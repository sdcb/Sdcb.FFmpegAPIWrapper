// This file was genereated from LINQPad scripts, DO NOT CHANGE DIRECTLY.

using System;
using Sdcb.FFmpegAPIWrapper.Common;
using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;

namespace Sdcb.FFmpegAPIWrapper.MediaCodecs
{
    /// <summary>
    /// <para>Visual content value range.</para>
    /// <see cref="AVColorRange" />
    /// </summary>
    public enum ColorRange
    {
        /// <summary>
        /// <see cref="AVColorRange.AVCOL_RANGE_UNSPECIFIED" />
        /// </summary>
        Unspecified = 0,
        
        /// <summary>
        /// <para>Narrow or limited range content.</para>
        /// <see cref="AVColorRange.AVCOL_RANGE_MPEG" />
        /// </summary>
        Mpeg = 1,
        
        /// <summary>
        /// <para>Full range content.</para>
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
