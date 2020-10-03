using System;
using Sdcb.FFmpegAPIWrapper.Common;
using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;
using Sdcb.FFmpegAPIWrapper.MediaCodecs;

namespace Sdcb.FFmpegAPIWrapper.MediaFormats
{
    public unsafe partial class FormatContext : FFmpegSafeObject
    {
        /// <summary>
        /// <see cref="avformat_free_context(AVFormatContext*)"/>
        /// </summary>
        public void Free()
        {
            avformat_free_context(this);
            _nativePointer = IntPtr.Zero;
        }

        protected override void DisposeNative() => Free();
    }
}
