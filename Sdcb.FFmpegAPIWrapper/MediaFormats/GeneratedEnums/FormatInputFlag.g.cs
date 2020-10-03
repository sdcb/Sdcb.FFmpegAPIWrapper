// This file was genereated from LINQPad scripts, DO NOT CHANGE DIRECTLY.

using System;
using Sdcb.FFmpegAPIWrapper.Common;
using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;

namespace Sdcb.FFmpegAPIWrapper.MediaFormats
{
    /// <summary>See AVFMT_* </summary>
    [Flags]
    public enum FormatInputFlag
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
        /// <para>AVFMT_SHOW_IDS = 0x0008.</para>
        /// <see cref="ffmpeg.AVFMT_SHOW_IDS" />
        /// </summary>
        ShowIds = 8,
        
        /// <summary>
        /// <para>AVFMT_NOTIMESTAMPS = 0x0080.</para>
        /// <see cref="ffmpeg.AVFMT_NOTIMESTAMPS" />
        /// </summary>
        Notimestamps = 128,
        
        /// <summary>
        /// <para>AVFMT_GENERIC_INDEX = 0x0100.</para>
        /// <see cref="ffmpeg.AVFMT_GENERIC_INDEX" />
        /// </summary>
        GenericIndex = 256,
        
        /// <summary>
        /// <para>AVFMT_TS_DISCONT = 0x0200.</para>
        /// <see cref="ffmpeg.AVFMT_TS_DISCONT" />
        /// </summary>
        TsDiscont = 512,
        
        /// <summary>
        /// <para>AVFMT_NOBINSEARCH = 0x2000.</para>
        /// <see cref="ffmpeg.AVFMT_NOBINSEARCH" />
        /// </summary>
        Nobinsearch = 8192,
        
        /// <summary>
        /// <para>AVFMT_NOGENSEARCH = 0x4000.</para>
        /// <see cref="ffmpeg.AVFMT_NOGENSEARCH" />
        /// </summary>
        Nogensearch = 16384,
        
        /// <summary>
        /// <para>AVFMT_NO_BYTE_SEEK = 0x8000.</para>
        /// <see cref="ffmpeg.AVFMT_NO_BYTE_SEEK" />
        /// </summary>
        NoByteSeek = 32768,
        
        /// <summary>
        /// <para>AVFMT_SEEK_TO_PTS = 0x4000000.</para>
        /// <see cref="ffmpeg.AVFMT_SEEK_TO_PTS" />
        /// </summary>
        SeekToPts = 67108864,
        
    }
}
