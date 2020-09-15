using System;
using Sdcb.FFmpegAPIWrapper.Common;
using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;

namespace Sdcb.FFmpegAPIWrapper.MediaCodecs
{
    /// <summary>
    /// <para>Audio sample formats.</para>
    /// <see cref="AVSampleFormat" />
    /// </summary>
    public enum MediaSampleFormat
    {
        /// <summary>
        /// <para>unsigned 8 bits.</para>
        /// <see cref="AVSampleFormat.AV_SAMPLE_FMT_U8" />
        /// </summary>
        U8 = 0x00000000,
        
        /// <summary>
        /// <para>signed 16 bits.</para>
        /// <see cref="AVSampleFormat.AV_SAMPLE_FMT_S16" />
        /// </summary>
        S16 = 0x00000001,
        
        /// <summary>
        /// <para>signed 32 bits.</para>
        /// <see cref="AVSampleFormat.AV_SAMPLE_FMT_S32" />
        /// </summary>
        S32 = 0x00000002,
        
        /// <summary>
        /// <para>float.</para>
        /// <see cref="AVSampleFormat.AV_SAMPLE_FMT_FLT" />
        /// </summary>
        Flt = 0x00000003,
        
        /// <summary>
        /// <para>double.</para>
        /// <see cref="AVSampleFormat.AV_SAMPLE_FMT_DBL" />
        /// </summary>
        Dbl = 0x00000004,
        
        /// <summary>
        /// <para>unsigned 8 bits, planar.</para>
        /// <see cref="AVSampleFormat.AV_SAMPLE_FMT_U8P" />
        /// </summary>
        U8p = 0x00000005,
        
        /// <summary>
        /// <para>signed 16 bits, planar.</para>
        /// <see cref="AVSampleFormat.AV_SAMPLE_FMT_S16P" />
        /// </summary>
        S16p = 0x00000006,
        
        /// <summary>
        /// <para>signed 32 bits, planar.</para>
        /// <see cref="AVSampleFormat.AV_SAMPLE_FMT_S32P" />
        /// </summary>
        S32p = 0x00000007,
        
        /// <summary>
        /// <para>float, planar.</para>
        /// <see cref="AVSampleFormat.AV_SAMPLE_FMT_FLTP" />
        /// </summary>
        Fltp = 0x00000008,
        
        /// <summary>
        /// <para>double, planar.</para>
        /// <see cref="AVSampleFormat.AV_SAMPLE_FMT_DBLP" />
        /// </summary>
        Dblp = 0x00000009,
        
        /// <summary>
        /// <para>signed 64 bits.</para>
        /// <see cref="AVSampleFormat.AV_SAMPLE_FMT_S64" />
        /// </summary>
        S64 = 0x0000000A,
        
        /// <summary>
        /// <para>signed 64 bits, planar.</para>
        /// <see cref="AVSampleFormat.AV_SAMPLE_FMT_S64P" />
        /// </summary>
        S64p = 0x0000000B,
        
        /// <summary>
        /// <para>Number of sample formats.</para>
        /// <para> DO NOT USE if linking dynamically.</para>
        /// <see cref="AVSampleFormat.AV_SAMPLE_FMT_NB" />
        /// </summary>
        Nb = 0x0000000C,
        
        /// <summary>
        /// <see cref="AVSampleFormat.AV_SAMPLE_FMT_NONE" />
        /// </summary>
        None = 0xFFFFFFFF,
    }
}
