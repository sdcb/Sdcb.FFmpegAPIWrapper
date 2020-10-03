// This file was genereated from LINQPad scripts, DO NOT CHANGE DIRECTLY.

using System;
using Sdcb.FFmpegAPIWrapper.Common;
using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;

namespace Sdcb.FFmpegAPIWrapper.MediaFormats
{
    /// <summary>
    /// <para>The duration of a video can be estimated through various ways, and this enum can be used to know how the duration was estimated.</para>
    /// <see cref="AVDurationEstimationMethod" />
    /// </summary>
    public enum DurationEstimationMethod
    {
        /// <summary>
        /// <para>Duration accurately estimated from PTSes.</para>
        /// <see cref="AVDurationEstimationMethod.AVFMT_DURATION_FROM_PTS" />
        /// </summary>
        Pts = 0,
        
        /// <summary>
        /// <para>Duration estimated from a stream with a known duration.</para>
        /// <see cref="AVDurationEstimationMethod.AVFMT_DURATION_FROM_STREAM" />
        /// </summary>
        Stream = 1,
        
        /// <summary>
        /// <para>Duration estimated from bitrate (less accurate).</para>
        /// <see cref="AVDurationEstimationMethod.AVFMT_DURATION_FROM_BITRATE" />
        /// </summary>
        Bitrate = 2,
    }
}
