using System;
using Sdcb.FFmpegAPIWrapper.Common;
using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;

namespace Sdcb.FFmpegAPIWrapper.MediaCodecs
{
    public enum MBDecisions
    {
        /// <summary>
        /// <para>FF_MB_DECISION_BITS = 1.</para>
        /// <see cref="ffmpeg.FF_MB_DECISION_BITS" />
        /// </summary>
        Bits = 0x1,
        
        /// <summary>
        /// <para>FF_MB_DECISION_RD = 2.</para>
        /// <see cref="ffmpeg.FF_MB_DECISION_RD" />
        /// </summary>
        Rd = 0x2,
        
        /// <summary>
        /// <para>FF_MB_DECISION_SIMPLE = 0.</para>
        /// <see cref="ffmpeg.FF_MB_DECISION_SIMPLE" />
        /// </summary>
        Simple = 0x0,
    }
}
