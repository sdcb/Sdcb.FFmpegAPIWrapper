// This file was genereated from LINQPad scripts, DO NOT CHANGE DIRECTLY.

using System;
using Sdcb.FFmpegAPIWrapper.Common;
using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;

namespace Sdcb.FFmpegAPIWrapper.MediaFormats
{
    /// <summary>
    /// <para>@}.</para>
    /// <see cref="AVStreamParseType" />
    /// </summary>
    public enum StreamParseType
    {
        /// <summary>
        /// <see cref="AVStreamParseType.AVSTREAM_PARSE_NONE" />
        /// </summary>
        None = 0,
        
        /// <summary>
        /// <para>full parsing and repack.</para>
        /// <see cref="AVStreamParseType.AVSTREAM_PARSE_FULL" />
        /// </summary>
        Full = 1,
        
        /// <summary>
        /// <para>Only parse headers, do not repack.</para>
        /// <see cref="AVStreamParseType.AVSTREAM_PARSE_HEADERS" />
        /// </summary>
        Headers = 2,
        
        /// <summary>
        /// <para>full parsing and interpolation of timestamps for frames not starting on a packet boundary.</para>
        /// <see cref="AVStreamParseType.AVSTREAM_PARSE_TIMESTAMPS" />
        /// </summary>
        Timestamps = 3,
        
        /// <summary>
        /// <para>full parsing and repack of the first frame only, only implemented for H.</para>
        /// <para>264 currently.</para>
        /// <see cref="AVStreamParseType.AVSTREAM_PARSE_FULL_ONCE" />
        /// </summary>
        FullOnce = 4,
        
        /// <summary>
        /// <para>full parsing and repack with timestamp and position generation by parser for raw this assumes that each packet in the file contains no demuxer level headers and just codec level data, otherwise position generation would fail.</para>
        /// <see cref="AVStreamParseType.AVSTREAM_PARSE_FULL_RAW" />
        /// </summary>
        FullRaw = 5,
    }
}
