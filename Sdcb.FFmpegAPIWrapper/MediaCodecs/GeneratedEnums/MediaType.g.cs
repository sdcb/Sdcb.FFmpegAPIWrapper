// This file was genereated from LINQPad scripts, DO NOT CHANGE DIRECTLY.

using System;
using Sdcb.FFmpegAPIWrapper.Common;
using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;

namespace Sdcb.FFmpegAPIWrapper.MediaCodecs
{
    /// <summary>
    /// <para>Media Type.</para>
    /// <see cref="AVMediaType" />
    /// </summary>
    public enum MediaType
    {
        /// <summary>
        /// <see cref="AVMediaType.AVMEDIA_TYPE_VIDEO" />
        /// </summary>
        Video = 0,
        
        /// <summary>
        /// <see cref="AVMediaType.AVMEDIA_TYPE_AUDIO" />
        /// </summary>
        Audio = 1,
        
        /// <summary>
        /// <para>Opaque data information usually continuous.</para>
        /// <see cref="AVMediaType.AVMEDIA_TYPE_DATA" />
        /// </summary>
        Data = 2,
        
        /// <summary>
        /// <see cref="AVMediaType.AVMEDIA_TYPE_SUBTITLE" />
        /// </summary>
        Subtitle = 3,
        
        /// <summary>
        /// <para>Opaque data information usually sparse.</para>
        /// <see cref="AVMediaType.AVMEDIA_TYPE_ATTACHMENT" />
        /// </summary>
        Attachment = 4,
        
        /// <summary>
        /// <see cref="AVMediaType.AVMEDIA_TYPE_NB" />
        /// </summary>
        Nb = 5,
        
        /// <summary>
        /// <para>Usually treated as AVMEDIA_TYPE_DATA.</para>
        /// <see cref="AVMediaType.AVMEDIA_TYPE_UNKNOWN" />
        /// </summary>
        Unknown = -1,
    }
}
