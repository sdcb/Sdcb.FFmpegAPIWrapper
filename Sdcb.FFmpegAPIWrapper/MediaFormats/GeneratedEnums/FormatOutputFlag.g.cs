// This file was genereated from LINQPad scripts, DO NOT CHANGE DIRECTLY.

using System;
using Sdcb.FFmpegAPIWrapper.Common;
using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;

namespace Sdcb.FFmpegAPIWrapper.MediaFormats
{
    /// <summary>See AVFMT_* </summary>
    [Flags]
    public enum FormatOutputFlag
    {
        /// <summary>
        /// <para>AVFMT_NOFILE = 0x0001.</para>
        /// <see cref="ffmpeg.AVFMT_NOFILE" />
        /// </summary>
        Nofile = 1,
        
        /// <summary>
        /// <para>AVFMT_NEEDNUMBER = 0x0002.</para>
        /// <see cref="ffmpeg.AVFMT_NEEDNUMBER" />
        /// </summary>
        Neednumber = 2,
        
        /// <summary>
        /// <para>AVFMT_GLOBALHEADER = 0x0040.</para>
        /// <see cref="ffmpeg.AVFMT_GLOBALHEADER" />
        /// </summary>
        Globalheader = 64,
        
        /// <summary>
        /// <para>AVFMT_NOTIMESTAMPS = 0x0080.</para>
        /// <see cref="ffmpeg.AVFMT_NOTIMESTAMPS" />
        /// </summary>
        Notimestamps = 128,
        
        /// <summary>
        /// <para>AVFMT_VARIABLE_FPS = 0x0400.</para>
        /// <see cref="ffmpeg.AVFMT_VARIABLE_FPS" />
        /// </summary>
        VariableFps = 1024,
        
        /// <summary>
        /// <para>AVFMT_NODIMENSIONS = 0x0800.</para>
        /// <see cref="ffmpeg.AVFMT_NODIMENSIONS" />
        /// </summary>
        Nodimensions = 2048,
        
        /// <summary>
        /// <para>AVFMT_NOSTREAMS = 0x1000.</para>
        /// <see cref="ffmpeg.AVFMT_NOSTREAMS" />
        /// </summary>
        Nostreams = 4096,
        
        /// <summary>
        /// <para>AVFMT_ALLOW_FLUSH = 0x10000.</para>
        /// <see cref="ffmpeg.AVFMT_ALLOW_FLUSH" />
        /// </summary>
        AllowFlush = 65536,
        
        /// <summary>
        /// <para>AVFMT_TS_NONSTRICT = 0x20000.</para>
        /// <see cref="ffmpeg.AVFMT_TS_NONSTRICT" />
        /// </summary>
        TsNonstrict = 131072,
        
        /// <summary>
        /// <para>AVFMT_TS_NEGATIVE = 0x40000.</para>
        /// <see cref="ffmpeg.AVFMT_TS_NEGATIVE" />
        /// </summary>
        TsNegative = 262144,
        
    }
}
