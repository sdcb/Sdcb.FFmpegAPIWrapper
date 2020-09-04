using FFmpeg.AutoGen;

namespace Sdcb.FFmpegAPIWrapper.Common.Logging
{
    /// <summary>
    /// AV_LOG_
    /// </summary>
    public enum LogLevel : int
    {
        /// <summary>
        /// <see cref="ffmpeg.AV_LOG_TRACE"/>
        /// </summary>
        Trace = ffmpeg.AV_LOG_TRACE,
        /// <summary>
        /// <see cref="ffmpeg.AV_LOG_DEBUG"/>
        /// </summary>
        Debug = ffmpeg.AV_LOG_DEBUG,
        /// <summary>
        /// <see cref="ffmpeg.AV_LOG_VERBOSE"/>
        /// </summary>
        Verbose = ffmpeg.AV_LOG_VERBOSE,
        /// <summary>
        /// <see cref="ffmpeg.AV_LOG_INFO"/>
        /// </summary>
        Info = ffmpeg.AV_LOG_INFO,
        /// <summary>
        /// <see cref="ffmpeg.AV_LOG_WARNING"/>
        /// </summary>
        Warning = ffmpeg.AV_LOG_WARNING,
        /// <summary>
        /// <see cref="ffmpeg.AV_LOG_ERROR"/>
        /// </summary>
        Error = ffmpeg.AV_LOG_ERROR,
        /// <summary>
        /// <see cref="ffmpeg.AV_LOG_FATAL"/>
        /// </summary>
        Fatal = ffmpeg.AV_LOG_FATAL,
        /// <summary>
        /// <see cref="ffmpeg.AV_LOG_PANIC"/>
        /// </summary>
        Panic = ffmpeg.AV_LOG_PANIC,
        /// <summary>
        /// <see cref="ffmpeg.AV_LOG_QUIET"/>
        /// </summary>
        Quiet = ffmpeg.AV_LOG_QUIET,
    }
}
