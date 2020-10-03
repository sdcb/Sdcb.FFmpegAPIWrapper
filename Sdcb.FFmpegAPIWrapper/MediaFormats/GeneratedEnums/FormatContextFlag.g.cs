// This file was genereated from LINQPad scripts, DO NOT CHANGE DIRECTLY.

using System;
using Sdcb.FFmpegAPIWrapper.Common;
using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;

namespace Sdcb.FFmpegAPIWrapper.MediaFormats
{
    /// <summary>See AVFMTCTX_* </summary>
    [Flags]
    public enum FormatContextFlag
    {
        None = 0,
        
        /// <summary>
        /// <para>AVFMTCTX_NOHEADER = 0x0001.</para>
        /// <see cref="ffmpeg.AVFMTCTX_NOHEADER" />
        /// </summary>
        Noheader = 1,
        
        /// <summary>
        /// <para>AVFMTCTX_UNSEEKABLE = 0x0002.</para>
        /// <see cref="ffmpeg.AVFMTCTX_UNSEEKABLE" />
        /// </summary>
        Unseekable = 2,
        
    }
}
