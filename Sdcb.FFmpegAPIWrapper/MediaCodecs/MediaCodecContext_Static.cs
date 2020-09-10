using Sdcb.FFmpegAPIWrapper.Common;
using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;
using System;

namespace Sdcb.FFmpegAPIWrapper.MediaCodecs
{
    public unsafe partial class MediaCodecContext
    {
        public static implicit operator AVCodecContext*(MediaCodecContext data) => (AVCodecContext*)data._handle;

        public static MediaCodecContext FromNative(AVCodecContext* ptr) => new MediaCodecContext(ptr);

        public static MediaCodecContext FromCodec(MediaCodec codec)
        {
            AVCodecContext* ptr = avcodec_alloc_context3(codec);
            if (ptr == null)
            {
                throw new FFmpegException($"Failed to create {nameof(AVCodecContext)} from codec {codec.Id}");
            }
            return FromNative(ptr);
        }
    }
}
