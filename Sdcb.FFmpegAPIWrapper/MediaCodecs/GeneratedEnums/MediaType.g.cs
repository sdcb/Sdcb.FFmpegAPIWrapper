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
        Video = 0x00000000,
        
        /// <summary>
        /// <see cref="AVMediaType.AVMEDIA_TYPE_AUDIO" />
        /// </summary>
        Audio = 0x00000001,
        
        /// <summary>
        /// <para>Opaque data information usually continuous.</para>
        /// <see cref="AVMediaType.AVMEDIA_TYPE_DATA" />
        /// </summary>
        Data = 0x00000002,
        
        /// <summary>
        /// <see cref="AVMediaType.AVMEDIA_TYPE_SUBTITLE" />
        /// </summary>
        Subtitle = 0x00000003,
        
        /// <summary>
        /// <para>Opaque data information usually sparse.</para>
        /// <see cref="AVMediaType.AVMEDIA_TYPE_ATTACHMENT" />
        /// </summary>
        Attachment = 0x00000004,
        
        /// <summary>
        /// <see cref="AVMediaType.AVMEDIA_TYPE_NB" />
        /// </summary>
        Nb = 0x00000005,
        
        /// <summary>
        /// <para>Usually treated as AVMEDIA_TYPE_DATA.</para>
        /// <see cref="AVMediaType.AVMEDIA_TYPE_UNKNOWN" />
        /// </summary>
        Unknown = 0xFFFFFFFF,
    }
}
