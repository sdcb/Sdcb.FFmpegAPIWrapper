using Sdcb.FFmpegAPIWrapper.Common;
using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;
using System;

namespace Sdcb.FFmpegAPIWrapper.MediaCodecs
{
    public unsafe partial class MediaCodecContext : FFmpegHandle
    {
        public const int CompressionDefault = FF_COMPRESSION_DEFAULT;

        protected override void Close()
        {
            AVCodecContext* ptr = this;
            avcodec_free_context(&ptr);
            _handle = (IntPtr)ptr;
        }
    }
}
