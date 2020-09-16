using Sdcb.FFmpegAPIWrapper.Common;
using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;
using System;

namespace Sdcb.FFmpegAPIWrapper.MediaCodecs
{
    public unsafe partial class CodecContext
    {
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
    }
}
