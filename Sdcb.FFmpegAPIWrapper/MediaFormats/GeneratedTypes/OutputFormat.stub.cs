using System;
using Sdcb.FFmpegAPIWrapper.Common;
using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;
using System.Collections.Generic;
using System.Linq;

namespace Sdcb.FFmpegAPIWrapper.MediaFormats
{
    public unsafe partial struct OutputFormat
    {
        /// <summary>
        /// <see cref="av_guess_format(string, string, string)"/>
        /// </summary>
        public static OutputFormat? Guess(string? shortName = null, string? fileName = null, string? mimeType = null)
            => FromNativeOrNull(av_guess_format(shortName, fileName, mimeType));

        /// <summary>
        /// <see cref="av_muxer_iterate(void**)"/>
        /// </summary>
        public static IEnumerable<OutputFormat> All => NativeUtils
            .EnumeratePtrIterator(ptr => (IntPtr)av_muxer_iterate((void**)ptr))
            .Select(x => FromNative((AVOutputFormat*)x));
    }
}
