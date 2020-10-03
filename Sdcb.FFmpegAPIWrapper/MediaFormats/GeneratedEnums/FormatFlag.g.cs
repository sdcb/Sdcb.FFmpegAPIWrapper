// This file was genereated from LINQPad scripts, DO NOT CHANGE DIRECTLY.

using System;
using Sdcb.FFmpegAPIWrapper.Common;
using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;

namespace Sdcb.FFmpegAPIWrapper.MediaFormats
{
    /// <summary>See AVFMT_FLAG_* </summary>
    [Flags]
    public enum FormatFlag
    {
        None = 0,
        
        /// <summary>
        /// <para>AVFMT_FLAG_GENPTS = 0x0001.</para>
        /// <see cref="ffmpeg.AVFMT_FLAG_GENPTS" />
        /// </summary>
        Genpts = 1,
        
        /// <summary>
        /// <para>AVFMT_FLAG_IGNIDX = 0x0002.</para>
        /// <see cref="ffmpeg.AVFMT_FLAG_IGNIDX" />
        /// </summary>
        Ignidx = 2,
        
        /// <summary>
        /// <para>AVFMT_FLAG_NONBLOCK = 0x0004.</para>
        /// <see cref="ffmpeg.AVFMT_FLAG_NONBLOCK" />
        /// </summary>
        Nonblock = 4,
        
        /// <summary>
        /// <para>AVFMT_FLAG_IGNDTS = 0x0008.</para>
        /// <see cref="ffmpeg.AVFMT_FLAG_IGNDTS" />
        /// </summary>
        Igndts = 8,
        
        /// <summary>
        /// <para>AVFMT_FLAG_NOFILLIN = 0x0010.</para>
        /// <see cref="ffmpeg.AVFMT_FLAG_NOFILLIN" />
        /// </summary>
        Nofillin = 16,
        
        /// <summary>
        /// <para>AVFMT_FLAG_NOPARSE = 0x0020.</para>
        /// <see cref="ffmpeg.AVFMT_FLAG_NOPARSE" />
        /// </summary>
        Noparse = 32,
        
        /// <summary>
        /// <para>AVFMT_FLAG_NOBUFFER = 0x0040.</para>
        /// <see cref="ffmpeg.AVFMT_FLAG_NOBUFFER" />
        /// </summary>
        Nobuffer = 64,
        
        /// <summary>
        /// <para>AVFMT_FLAG_CUSTOM_IO = 0x0080.</para>
        /// <see cref="ffmpeg.AVFMT_FLAG_CUSTOM_IO" />
        /// </summary>
        CustomIo = 128,
        
        /// <summary>
        /// <para>AVFMT_FLAG_DISCARD_CORRUPT = 0x0100.</para>
        /// <see cref="ffmpeg.AVFMT_FLAG_DISCARD_CORRUPT" />
        /// </summary>
        DiscardCorrupt = 256,
        
        /// <summary>
        /// <para>AVFMT_FLAG_FLUSH_PACKETS = 0x0200.</para>
        /// <see cref="ffmpeg.AVFMT_FLAG_FLUSH_PACKETS" />
        /// </summary>
        FlushPackets = 512,
        
        /// <summary>
        /// <para>AVFMT_FLAG_BITEXACT = 0x0400.</para>
        /// <see cref="ffmpeg.AVFMT_FLAG_BITEXACT" />
        /// </summary>
        Bitexact = 1024,
        
        /// <summary>
        /// <para>AVFMT_FLAG_MP4A_LATM = 0x8000.</para>
        /// <see cref="ffmpeg.AVFMT_FLAG_MP4A_LATM" />
        /// </summary>
        Mp4aLatm = 32768,
        
        /// <summary>
        /// <para>AVFMT_FLAG_SORT_DTS = 0x10000.</para>
        /// <see cref="ffmpeg.AVFMT_FLAG_SORT_DTS" />
        /// </summary>
        SortDts = 65536,
        
        /// <summary>
        /// <para>AVFMT_FLAG_PRIV_OPT = 0x20000.</para>
        /// <see cref="ffmpeg.AVFMT_FLAG_PRIV_OPT" />
        /// </summary>
        PrivOpt = 131072,
        
        /// <summary>
        /// <para>AVFMT_FLAG_KEEP_SIDE_DATA = 0x40000.</para>
        /// <see cref="ffmpeg.AVFMT_FLAG_KEEP_SIDE_DATA" />
        /// </summary>
        KeepSideData = 262144,
        
        /// <summary>
        /// <para>AVFMT_FLAG_FAST_SEEK = 0x80000.</para>
        /// <see cref="ffmpeg.AVFMT_FLAG_FAST_SEEK" />
        /// </summary>
        FastSeek = 524288,
        
        /// <summary>
        /// <para>AVFMT_FLAG_SHORTEST = 0x100000.</para>
        /// <see cref="ffmpeg.AVFMT_FLAG_SHORTEST" />
        /// </summary>
        Shortest = 1048576,
        
        /// <summary>
        /// <para>AVFMT_FLAG_AUTO_BSF = 0x200000.</para>
        /// <see cref="ffmpeg.AVFMT_FLAG_AUTO_BSF" />
        /// </summary>
        AutoBsf = 2097152,
        
    }
}
