using Sdcb.FFmpegAPIWrapper.Common;
using Sdcb.FFmpegAPIWrapper.MediaCodecs;
using Sdcb.FFmpegAPIWrapper.Swscales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sdcb.FFmpegAPIWrapper.MediaFormats
{
    public unsafe static class FrameExtensions
    {
        public static void WriteImageTo(this Frame frame, string url, OutputFormat? format = null, string? formatName = null)
        {
            using FormatContext fc = FormatContext.AllocOutput(format, formatName, url);
            Codec codec = Codec.FindEncoder(fc.OutputFormat.VideoCodec);

            using var io = MediaIO.OpenWrite(url);
            fc.IO = io;

            var stream = new MediaStream(fc);
            using CodecContext codecContext = new CodecContext(codec)
            {
                PixelFormat = codec.PixelFormats.First(),
                Width = frame.Width,
                Height = frame.Height,
                TimeBase = new MediaRational(1, 25),
                Flags = ((fc.OutputFormat.Flags & FormatOutputFlag.Globalheader) != 0) ? CodecFlag.GlobalHeader : CodecFlag.None,
            };
            codecContext.Open(codec);
            stream.Codecpar.CopyFrom(codecContext);

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
                fc.WriteFrame(packet);
            }
            fc.WriteTrailer();
        }
    }
}
