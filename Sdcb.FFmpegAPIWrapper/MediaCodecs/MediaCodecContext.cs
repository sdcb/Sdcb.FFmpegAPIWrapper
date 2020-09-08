using Sdcb.FFmpegAPIWrapper.Common;
using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;
using System;

namespace Sdcb.FFmpegAPIWrapper.MediaCodecs
{
    /// <summary>
    /// <see cref="AVCodecContext"/>
    /// </summary>
    public unsafe class MediaCodecContext : FFmpegHandle
    {
        public MediaCodecContext(AVCodecContext* ptr) : base((IntPtr)ptr) { }

        public static implicit operator AVCodecContext*(MediaCodecContext data) => (AVCodecContext*)data._handle;

        protected override void Close()
        {
            AVCodecContext* ptr = this;
            avcodec_free_context(&ptr);
            _handle = (IntPtr)ptr;
        }
    }
}
