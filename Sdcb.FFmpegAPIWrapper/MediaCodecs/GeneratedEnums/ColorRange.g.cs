// This file was genereated from LINQPad scripts, DO NOT CHANGE DIRECTLY.

using System;
using Sdcb.FFmpegAPIWrapper.Common;
using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;

namespace Sdcb.FFmpegAPIWrapper.MediaCodecs
{
    /// <summary>
    /// <para>MPEG vs JPEG YUV range.</para>
    /// <see cref="AVColorRange" />
    /// </summary>
    public enum ColorRange
    {
        /// <summary>
        /// <see cref="AVColorRange.AVCOL_RANGE_UNSPECIFIED" />
        /// </summary>
        Unspecified = 0,
        
        /// <summary>
        /// <para>the normal 219*2^(n-8) &quot;MPEG&quot; YUV ranges.</para>
        /// <see cref="AVColorRange.AVCOL_RANGE_MPEG" />
        /// </summary>
        Mpeg = 1,
        
        /// <summary>
        /// <para>the normal 2^n-1 &quot;JPEG&quot; YUV ranges.</para>
        /// <see cref="AVColorRange.AVCOL_RANGE_JPEG" />
        /// </summary>
        Jpeg = 2,
        
        /// <summary>
        /// <para>Not part of ABI.</para>
        /// <see cref="AVColorRange.AVCOL_RANGE_NB" />
        /// </summary>
        Nb = 3,
    }
}
