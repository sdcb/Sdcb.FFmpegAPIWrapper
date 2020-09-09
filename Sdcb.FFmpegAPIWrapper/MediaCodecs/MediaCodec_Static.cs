using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;
using Sdcb.FFmpegAPIWrapper.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Sdcb.FFmpegAPIWrapper.MediaCodecs
{
    public unsafe partial class MediaCodec
    {
        public static implicit operator AVCodec*(MediaCodec data) => data._p;

        /// <summary>
        /// <see cref="av_codec_iterate(void**)"/>
        /// </summary>
        public static IEnumerable<MediaCodec> MediaCodecs => NativeUtils
            .EnumeratePtrIterator(ptr => (IntPtr)(av_codec_iterate((void**)ptr)))
            .Select(FromNative);
    }
}
