using System;
using static FFmpeg.AutoGen.ffmpeg;

namespace Sdcb.FFmpegAPIWrapper.MediaMuxers
{
    [Flags]
    public enum MediaIOSeek
    {
        /// <summary>
        /// SEEK_SET
        /// </summary>
        Begin = 0,

        /// <summary>
        /// SEEK_CUR
        /// </summary>
        Current = 1,

        /// <summary>
        /// SEEK_END
        /// </summary>
        End = 2,

        /// <summary>
        /// <see cref="AVSEEK_SIZE"/>
        /// </summary>
        Size = AVSEEK_SIZE, 

        /// <summary>
        /// <see cref="AVSEEK_FORCE"/>
        /// </summary>
        Force = AVSEEK_FORCE, 
    }
}
