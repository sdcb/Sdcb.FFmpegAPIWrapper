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
    public enum SampleFormat
    {
        /// <summary>
        /// <para>unsigned 8 bits.</para>
        /// <see cref="AVSampleFormat.AV_SAMPLE_FMT_U8" />
        /// </summary>
        U8 = 0,
        
        /// <summary>
        /// <para>signed 16 bits.</para>
        /// <see cref="AVSampleFormat.AV_SAMPLE_FMT_S16" />
        /// </summary>
        S16 = 1,
        
        /// <summary>
        /// <para>signed 32 bits.</para>
        /// <see cref="AVSampleFormat.AV_SAMPLE_FMT_S32" />
        /// </summary>
        S32 = 2,
        
        /// <summary>
        /// <para>float.</para>
        /// <see cref="AVSampleFormat.AV_SAMPLE_FMT_FLT" />
        /// </summary>
        Flt = 3,
        
        /// <summary>
        /// <para>double.</para>
        /// <see cref="AVSampleFormat.AV_SAMPLE_FMT_DBL" />
        /// </summary>
        Dbl = 4,
        
        /// <summary>
        /// <para>unsigned 8 bits, planar.</para>
        /// <see cref="AVSampleFormat.AV_SAMPLE_FMT_U8P" />
        /// </summary>
        U8p = 5,
        
        /// <summary>
        /// <para>signed 16 bits, planar.</para>
        /// <see cref="AVSampleFormat.AV_SAMPLE_FMT_S16P" />
        /// </summary>
        S16p = 6,
        
        /// <summary>
        /// <para>signed 32 bits, planar.</para>
        /// <see cref="AVSampleFormat.AV_SAMPLE_FMT_S32P" />
        /// </summary>
        S32p = 7,
        
        /// <summary>
        /// <para>float, planar.</para>
        /// <see cref="AVSampleFormat.AV_SAMPLE_FMT_FLTP" />
        /// </summary>
        Fltp = 8,
        
        /// <summary>
        /// <para>double, planar.</para>
        /// <see cref="AVSampleFormat.AV_SAMPLE_FMT_DBLP" />
        /// </summary>
        Dblp = 9,
        
        /// <summary>
        /// <para>signed 64 bits.</para>
        /// <see cref="AVSampleFormat.AV_SAMPLE_FMT_S64" />
        /// </summary>
        S64 = 10,
        
        /// <summary>
        /// <para>signed 64 bits, planar.</para>
        /// <see cref="AVSampleFormat.AV_SAMPLE_FMT_S64P" />
        /// </summary>
        S64p = 11,
        
        /// <summary>
        /// <para>Number of sample formats.</para>
        /// <para> DO NOT USE if linking dynamically.</para>
        /// <see cref="AVSampleFormat.AV_SAMPLE_FMT_NB" />
        /// </summary>
        Nb = 12,
        
        /// <summary>
        /// <see cref="AVSampleFormat.AV_SAMPLE_FMT_NONE" />
        /// </summary>
        None = -1,
    }
}
