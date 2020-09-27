using Sdcb.FFmpegAPIWrapper.Common;
using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;
using System;
using System.Runtime.CompilerServices;

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
        public CodecResult SendPacket(Packet? packet) => ToCodecResult(avcodec_send_packet(this, packet));

        /// <summary>
        /// <see cref="avcodec_receive_packet(AVCodecContext*, AVPacket*)"/>
        /// </summary>
        public CodecResult ReceivePacket(Packet packet) => ToCodecResult(avcodec_receive_packet(this, packet));

        /// <summary>
        /// <see cref="avcodec_send_frame(AVCodecContext*, AVFrame*)"/>
        /// </summary>
        public CodecResult SendFrame(Frame? frame) => ToCodecResult(avcodec_send_frame(this, frame));

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
