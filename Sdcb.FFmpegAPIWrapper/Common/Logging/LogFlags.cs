using FFmpeg.AutoGen;
using System;

namespace Sdcb.FFmpegAPIWrapper.Common
{
    /// <summary>
    /// AV_LOG_
    /// </summary>
    [Flags]
    public enum LogFlags : int
    {
        None = 0,
        /// <summary>
        /// <see cref="ffmpeg.AV_LOG_SKIP_REPEATED"/>
        /// </summary>
        SkipRepeated = ffmpeg.AV_LOG_SKIP_REPEATED,
        /// <summary>
        /// <see cref="ffmpeg.AV_LOG_PRINT_LEVEL"/>
        /// </summary>
        PrintLevel = ffmpeg.AV_LOG_PRINT_LEVEL,
    }
}