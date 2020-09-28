using Sdcb.FFmpegAPIWrapper.Common;
using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;
using System;
using System.Runtime.CompilerServices;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace Sdcb.FFmpegAPIWrapper.MediaCodecs
{
    public unsafe partial class CodecContext : FFmpegSafeObject
    {
        public const int CompressionDefault = FF_COMPRESSION_DEFAULT;

        public FFmpegOptions Options => new FFmpegOptions(Pointer->priv_data);

        /// <summary>
        /// <see cref="avcodec_alloc_context3(AVCodec*)"/>
        /// </summary>
        public CodecContext(Codec codec)
        {
            AVCodecContext* ptr = avcodec_alloc_context3(codec);
            if (ptr == null)
            {
                throw new FFmpegException($"Failed to create {nameof(AVCodecContext)} from codec {codec.Id}");
            }

            _nativePointer = (IntPtr)ptr;
            _isOwner = true;
        }

        /// <summary>
        /// <see cref="avcodec_get_class"/>
        /// </summary>
        public static FFmpegClass FFmpegClass => FFmpegClass.FromNative(avcodec_get_class())!;

        /// <summary>
        /// <see cref="avcodec_parameters_to_context(AVCodecContext*, AVCodecParameters*)"/>
        /// </summary>
        public void FillParameters(CodecParameters parameters)
        {
            avcodec_parameters_to_context(this, parameters).ThrowIfError();
        }

        /// <summary>
        /// <see cref="avcodec_open2(AVCodecContext*, AVCodec*, AVDictionary**)"/>
        /// </summary>
        public void Open(Codec codec, MediaDictionary? options = null)
        {
            options = options ?? MediaDictionary.CreateEmpty();
            AVDictionary* ptrDict = options;
            avcodec_open2(this, codec, &ptrDict).ThrowIfError();
            options.Reset(ptrDict);
        }

        /// <summary>
        /// <see cref="avcodec_send_packet(AVCodecContext*, AVPacket*)"/>
        /// </summary>
        public void SendPacket(Packet? packet) => avcodec_send_packet(this, packet).ThrowIfError("Error sending a packet for decoding");

        /// <summary>
        /// <see cref="avcodec_receive_packet(AVCodecContext*, AVPacket*)"/>
        /// </summary>
        public CodecResult ReceivePacket(Packet packet) => ToCodecResult(avcodec_receive_packet(this, packet));

        /// <summary>
        /// <see cref="avcodec_send_frame(AVCodecContext*, AVFrame*)"/>
        /// </summary>
        public void SendFrame(Frame? frame) => avcodec_send_frame(this, frame).ThrowIfError("Error sending a frame for encoding");

        /// <summary>
        /// <see cref="avcodec_receive_frame(AVCodecContext*, AVFrame*)"/>
        /// </summary>
        public CodecResult ReceiveFrame(Frame frame) => ToCodecResult(avcodec_receive_frame(this, frame));

        private CodecResult ToCodecResult(int result, [CallerMemberName]string? callerMember = null) => result switch
        {
            0 => CodecResult.Success,
            var x when x == AVERROR_EOF => CodecResult.EOF,
            var x when x == AVERROR(EAGAIN) => CodecResult.Again,
            var x when x < 0 => throw FFmpegException.FromErrorCode(x, $"{callerMember} failed."),
            _ => throw new FFmpegException($"Unknown {nameof(callerMember)} status: {result}"),
        };

        /// <summary>
        /// 1 frame -> 0..N packet
        /// </summary>
        public IEnumerable<Packet> EncodeFrame(Frame? frame, Packet packet)
        {
            SendFrame(frame);
            while (true)
            {
                CodecResult s = ReceivePacket(packet);
                if (s == CodecResult.Again || s == CodecResult.EOF) yield break;
                try
                {
                    yield return packet;
                }
                finally
                {
                    packet.Unreference();
                }
            }
        }

        /// <summary>
        /// frames -> packets
        /// </summary>
        public IEnumerable<Packet> EncodeFrames(IEnumerable<Frame> frames)
        {
            using var packet = new Packet();
            
            foreach (Frame frame in frames)
                foreach (var _ in EncodeFrame(frame, packet)) 
                    yield return packet;

            foreach (var _ in EncodeFrame(null, packet)) 
                yield return packet;
        }

        /// <summary>
        /// packets -> frames
        /// </summary>
        public IEnumerable<Frame> DecodePackets(IEnumerable<Packet> packets)
        {
            using var frame = new Frame();

            foreach (Packet packet in packets)
                foreach (var _ in DecodePacket(packet, frame)) 
                    yield return frame;

            foreach (var _ in DecodePacket(null, frame)) 
                yield return frame;
        }

        /// <summary>
        /// 1 packet -> 0..N frame
        /// </summary>
        public IEnumerable<Frame> DecodePacket(Packet? packet, Frame frame)
        {
            SendPacket(packet);
            while (true)
            {
                CodecResult s = ReceiveFrame(frame);
                if (s == CodecResult.Again || s == CodecResult.EOF) yield break;
                yield return frame;
            }
        }

        /// <summary>
        /// <see cref="avcodec_free_context(AVCodecContext**)"/>
        /// </summary>
        public void Free()
        {
            AVCodecContext* ptr = this;
            avcodec_free_context(&ptr);
            _nativePointer = (IntPtr)ptr;
        }

        protected override void DisposeNative() => Free();
    }
}
