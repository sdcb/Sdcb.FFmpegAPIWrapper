// This file was genereated from LINQPad scripts, DO NOT CHANGE DIRECTLY.

using System;
using Sdcb.FFmpegAPIWrapper.Common;
using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;

namespace Sdcb.FFmpegAPIWrapper.MediaFormats
{
    /// <summary>See AVFMT_EVENT_FLAG_* </summary>
    [Flags]
    public enum EventFlag
    {
        None = 0,
        
        /// <summary>
        /// <para>AVFMT_EVENT_FLAG_METADATA_UPDATED = 0x0001.</para>
        /// <see cref="ffmpeg.AVFMT_EVENT_FLAG_METADATA_UPDATED" />
        /// </summary>
        MetadataUpdated = 1,
        
    }
}
