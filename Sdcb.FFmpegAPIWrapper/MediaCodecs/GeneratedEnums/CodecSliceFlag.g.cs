// This file was genereated from LINQPad scripts, DO NOT CHANGE DIRECTLY.

using System;
using Sdcb.FFmpegAPIWrapper.Common;
using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;

namespace Sdcb.FFmpegAPIWrapper.MediaCodecs
{
    /// <summary>See SLICE_FLAG_* </summary>
    [Flags]
    public enum CodecSliceFlag
    {
        None = 0,
        
        /// <summary>
        /// <para>SLICE_FLAG_CODED_ORDER = 0x1.</para>
        /// <see cref="ffmpeg.SLICE_FLAG_CODED_ORDER" />
        /// </summary>
        CodedOrder = 1,
        
        /// <summary>
        /// <para>SLICE_FLAG_ALLOW_FIELD = 0x2.</para>
        /// <see cref="ffmpeg.SLICE_FLAG_ALLOW_FIELD" />
        /// </summary>
        AllowField = 2,
        
        /// <summary>
        /// <para>SLICE_FLAG_ALLOW_PLANE = 0x4.</para>
        /// <see cref="ffmpeg.SLICE_FLAG_ALLOW_PLANE" />
        /// </summary>
        AllowPlane = 4,
        
    }
}
