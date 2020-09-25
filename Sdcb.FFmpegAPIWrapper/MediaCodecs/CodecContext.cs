using Sdcb.FFmpegAPIWrapper.Common;
using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;
using System;

namespace Sdcb.FFmpegAPIWrapper.MediaCodecs
{
    public unsafe partial class CodecContext : FFmpegHandle
    {
        public const int CompressionDefault = FF_COMPRESSION_DEFAULT;

        public FFmpegOptions Options => new FFmpegOptions(Pointer->priv_data);

        /// <summary>
        /// <see cref="avcodec_alloc_context3(AVCodec*)"/>
        /// </summary>
        public static CodecContext FromCodec(Codec codec)
        {
            AVCodecContext* ptr = avcodec_alloc_context3(codec);
            if (ptr == null)
            {
                throw new FFmpegException($"Failed to create {nameof(AVCodecContext)} from codec {codec.Id}");
            }
            return FromNative(ptr, isOwner: true);
        }

        /// <summary>
        /// <see cref="avcodec_get_class"/>
        /// </summary>
        public static FFmpegClass FFmpegClass => FFmpegClass.FromNative(avcodec_get_class());

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
        public void Open(Codec codec, MediaDictionary options = null)
        {
            options = options ?? MediaDictionary.CreateEmpty();
            AVDictionary* ptrDict = options;
            avcodec_open2(this, codec, &ptrDict).ThrowIfError();
            options.Reset(ptrDict);
        }

        public override void Close()
        {
            AVCodecContext* ptr = this;
            avcodec_free_context(&ptr);
            _handle = (IntPtr)ptr;
        }
    }
}
