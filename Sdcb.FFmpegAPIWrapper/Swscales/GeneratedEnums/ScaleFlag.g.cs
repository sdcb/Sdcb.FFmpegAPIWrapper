// This file was genereated from LINQPad scripts, DO NOT CHANGE DIRECTLY.

using System;
using Sdcb.FFmpegAPIWrapper.Common;
using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;

namespace Sdcb.FFmpegAPIWrapper.Swscales
{
    /// <summary>See SWS_* </summary>
    [Flags]
    public enum ScaleFlag
    {
        None = 0,
        
        /// <summary>
        /// <para>SWS_FAST_BILINEAR = 0x1.</para>
        /// <see cref="ffmpeg.SWS_FAST_BILINEAR" />
        /// </summary>
        FastBilinear = 1,
        
        /// <summary>
        /// <para>SWS_BILINEAR = 0x2.</para>
        /// <see cref="ffmpeg.SWS_BILINEAR" />
        /// </summary>
        Bilinear = 2,
        
        /// <summary>
        /// <para>SWS_BICUBIC = 0x4.</para>
        /// <see cref="ffmpeg.SWS_BICUBIC" />
        /// </summary>
        Bicubic = 4,
        
        /// <summary>
        /// <para>SWS_X = 0x8.</para>
        /// <see cref="ffmpeg.SWS_X" />
        /// </summary>
        X = 8,
        
        /// <summary>
        /// <para>SWS_POINT = 0x10.</para>
        /// <see cref="ffmpeg.SWS_POINT" />
        /// </summary>
        Point = 16,
        
        /// <summary>
        /// <para>SWS_SRC_V_CHR_DROP_SHIFT = 0x10.</para>
        /// <see cref="ffmpeg.SWS_SRC_V_CHR_DROP_SHIFT" />
        /// </summary>
        SrcVChrDropShift = 16,
        
        /// <summary>
        /// <para>SWS_AREA = 0x20.</para>
        /// <see cref="ffmpeg.SWS_AREA" />
        /// </summary>
        Area = 32,
        
        /// <summary>
        /// <para>SWS_BICUBLIN = 0x40.</para>
        /// <see cref="ffmpeg.SWS_BICUBLIN" />
        /// </summary>
        Bicublin = 64,
        
        /// <summary>
        /// <para>SWS_GAUSS = 0x80.</para>
        /// <see cref="ffmpeg.SWS_GAUSS" />
        /// </summary>
        Gauss = 128,
        
        /// <summary>
        /// <para>SWS_SINC = 0x100.</para>
        /// <see cref="ffmpeg.SWS_SINC" />
        /// </summary>
        Sinc = 256,
        
        /// <summary>
        /// <para>SWS_LANCZOS = 0x200.</para>
        /// <see cref="ffmpeg.SWS_LANCZOS" />
        /// </summary>
        Lanczos = 512,
        
        /// <summary>
        /// <para>SWS_SPLINE = 0x400.</para>
        /// <see cref="ffmpeg.SWS_SPLINE" />
        /// </summary>
        Spline = 1024,
        
        /// <summary>
        /// <para>SWS_PRINT_INFO = 0x1000.</para>
        /// <see cref="ffmpeg.SWS_PRINT_INFO" />
        /// </summary>
        PrintInfo = 4096,
        
        /// <summary>
        /// <para>SWS_FULL_CHR_H_INT = 0x2000.</para>
        /// <see cref="ffmpeg.SWS_FULL_CHR_H_INT" />
        /// </summary>
        FullChrHInt = 8192,
        
        /// <summary>
        /// <para>SWS_FULL_CHR_H_INP = 0x4000.</para>
        /// <see cref="ffmpeg.SWS_FULL_CHR_H_INP" />
        /// </summary>
        FullChrHInp = 16384,
        
        /// <summary>
        /// <para>SWS_DIRECT_BGR = 0x8000.</para>
        /// <see cref="ffmpeg.SWS_DIRECT_BGR" />
        /// </summary>
        DirectBgr = 32768,
        
        /// <summary>
        /// <para>SWS_PARAM_DEFAULT = 0x1e240.</para>
        /// <see cref="ffmpeg.SWS_PARAM_DEFAULT" />
        /// </summary>
        ParamDefault = 123456,
        
        /// <summary>
        /// <para>SWS_SRC_V_CHR_DROP_MASK = 0x30000.</para>
        /// <see cref="ffmpeg.SWS_SRC_V_CHR_DROP_MASK" />
        /// </summary>
        SrcVChrDropMask = 196608,
        
        /// <summary>
        /// <para>SWS_ACCURATE_RND = 0x40000.</para>
        /// <see cref="ffmpeg.SWS_ACCURATE_RND" />
        /// </summary>
        AccurateRnd = 262144,
        
        /// <summary>
        /// <para>SWS_BITEXACT = 0x80000.</para>
        /// <see cref="ffmpeg.SWS_BITEXACT" />
        /// </summary>
        Bitexact = 524288,
        
        /// <summary>
        /// <para>SWS_ERROR_DIFFUSION = 0x800000.</para>
        /// <see cref="ffmpeg.SWS_ERROR_DIFFUSION" />
        /// </summary>
        ErrorDiffusion = 8388608,
        
    }
}
