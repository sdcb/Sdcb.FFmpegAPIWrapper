using FFmpeg.AutoGen;
using System;

namespace Sdcb.FFmpegAPIWrapper.MediaFormats
{
    /// <summary>
    /// AVIO_FLAG_
    /// </summary>
    [Flags]
    public enum MediaIOFlags
    {
        /// <summary>
        /// <see cref="ffmpeg.AVIO_FLAG_READ"/>
        /// </summary>
        Read = ffmpeg.AVIO_FLAG_READ,

        /// <summary>
        /// <see cref="ffmpeg.AVIO_FLAG_WRITE"/>
        /// </summary>
        Write = ffmpeg.AVIO_FLAG_WRITE,

        /// <summary>
        /// <see cref="ffmpeg.AVIO_FLAG_READ_WRITE"/>
        /// </summary>
        ReadWrite = ffmpeg.AVIO_FLAG_READ_WRITE,

        /// <summary>
        /// <see cref="ffmpeg.AVIO_FLAG_NONBLOCK"/>
        /// </summary>
        NonBlock = ffmpeg.AVIO_FLAG_NONBLOCK,

        /// <summary>
        /// <see cref="ffmpeg.AVIO_FLAG_DIRECT"/>
        /// </summary>
        Direct = ffmpeg.AVIO_FLAG_DIRECT,
    }
}
