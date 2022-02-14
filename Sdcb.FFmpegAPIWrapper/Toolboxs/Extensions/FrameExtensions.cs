﻿using Sdcb.FFmpegAPIWrapper.Common;
using Sdcb.FFmpegAPIWrapper.MediaCodecs;
using Sdcb.FFmpegAPIWrapper.MediaFormats;
using Sdcb.FFmpegAPIWrapper.Swscales;
using System.IO;
using System.Linq;

namespace Sdcb.FFmpegAPIWrapper.Toolboxs
{
    public unsafe static class FrameExtensions
    {
        public static void WriteImageTo(this Frame frame, string url, OutputFormat? format = null, string? formatName = null)
        {
            using FormatContext fc = FormatContext.AllocOutput(format, formatName, url);
            using MediaIO io = MediaIO.OpenWrite(url);
            fc.IO = io;

            WriteImageTo(frame, fc);
        }

        public static void WriteImageTo(this Frame frame, Stream stream, OutputFormat? format = null, string? formatName = null, bool leaveOpen = false)
        {
            using FormatContext fc = FormatContext.AllocOutput(format, formatName);
            using MediaIO io = MediaIO.WriteStream(stream);
            fc.IO = io;

            WriteImageTo(frame, fc);
            if (!leaveOpen)
            {
                stream.Close();
            }
        }

        public static DisposableDataPointer Encode(this Frame frame, OutputFormat? format = null, string? formatName = null)
        {
            using FormatContext fc = FormatContext.AllocOutput(format, formatName);
            using DynamicMediaIO io = MediaIO.OpenDynamic();
            fc.IO = io;
            WriteImageTo(frame, fc);

            return io.GetBufferAndClose();
        }

        public static byte[] EncodeToBytes(this Frame frame, OutputFormat? format = null, string? formatName = null)
        {
            using DisposableDataPointer data = frame.Encode(format, formatName);
            return data.AsSpan().ToArray();
        }

        private static void WriteImageTo(Frame frame, FormatContext fc)
        {
            Codec codec = Codec.FindEncoder(fc.OutputFormat.VideoCodec);
            var mediaStream = new MediaStream(fc);
            using CodecContext codecContext = new CodecContext(codec)
            {
                PixelFormat = codec.PixelFormats.First(),
                Width = frame.Width,
                Height = frame.Height,
                TimeBase = new MediaRational(1, 25),
                Flags = fc.OutputFormat.Flags.HasFlag(FormatOutputFlag.Globalheader) ? CodecFlag.GlobalHeader : CodecFlag.None,
            };
            codecContext.Open(codec);
            mediaStream.Codecpar.CopyFrom(codecContext);

            if ((PixelFormat)frame.Format == codecContext.PixelFormat)
            {
                WriteAction(frame, fc, codecContext);
            }
            else
            {
                using var tempFrame = Frame.CreateWritableVideo(frame.Width, frame.Height, codecContext.PixelFormat);
                using var frameConverter = new FrameConverter();
                frameConverter.ConvertFrame(frame, tempFrame);
                WriteAction(tempFrame, fc, codecContext);
            }
        }

        private static void WriteAction(Frame frame, FormatContext fc, CodecContext codecContext)
        {
            fc.WriteHeader();
            foreach (Packet packet in codecContext.EncodeFrames(new[] { frame }))
            {
                fc.WritePacket(packet);
            }
            fc.WriteTrailer();
        }
    }
}
