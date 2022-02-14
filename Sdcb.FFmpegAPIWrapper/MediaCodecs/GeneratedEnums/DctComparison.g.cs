// This file was genereated from LINQPad scripts, DO NOT CHANGE DIRECTLY.

using System;
using Sdcb.FFmpegAPIWrapper.Common;
using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;

namespace Sdcb.FFmpegAPIWrapper.MediaCodecs
{
    /// <summary>See FF_CMP_* </summary>
    public enum DctComparison
    {
        /// <summary>
        /// <para>FF_CMP_SAD = 0x0.</para>
        /// <see cref="ffmpeg.FF_CMP_SAD" />
        /// </summary>
        Sad = 0,
        
        /// <summary>
        /// <para>FF_CMP_SSE = 0x1.</para>
        /// <see cref="ffmpeg.FF_CMP_SSE" />
        /// </summary>
        Sse = 1,
        
        /// <summary>
        /// <para>FF_CMP_SATD = 0x2.</para>
        /// <see cref="ffmpeg.FF_CMP_SATD" />
        /// </summary>
        Satd = 2,
        
        /// <summary>
        /// <para>FF_CMP_DCT = 0x3.</para>
        /// <see cref="ffmpeg.FF_CMP_DCT" />
        /// </summary>
        Dct = 3,
        
        /// <summary>
        /// <para>FF_CMP_PSNR = 0x4.</para>
        /// <see cref="ffmpeg.FF_CMP_PSNR" />
        /// </summary>
        Psnr = 4,
        
        /// <summary>
        /// <para>FF_CMP_BIT = 0x5.</para>
        /// <see cref="ffmpeg.FF_CMP_BIT" />
        /// </summary>
        Bit = 5,
        
        /// <summary>
        /// <para>FF_CMP_RD = 0x6.</para>
        /// <see cref="ffmpeg.FF_CMP_RD" />
        /// </summary>
        Rd = 6,
        
        /// <summary>
        /// <para>FF_CMP_ZERO = 0x7.</para>
        /// <see cref="ffmpeg.FF_CMP_ZERO" />
        /// </summary>
        Zero = 7,
        
        /// <summary>
        /// <para>FF_CMP_VSAD = 0x8.</para>
        /// <see cref="ffmpeg.FF_CMP_VSAD" />
        /// </summary>
        Vsad = 8,
        
        /// <summary>
        /// <para>FF_CMP_VSSE = 0x9.</para>
        /// <see cref="ffmpeg.FF_CMP_VSSE" />
        /// </summary>
        Vsse = 9,
        
        /// <summary>
        /// <para>FF_CMP_NSSE = 0xa.</para>
        /// <see cref="ffmpeg.FF_CMP_NSSE" />
        /// </summary>
        Nsse = 10,
        
        /// <summary>
        /// <para>FF_CMP_W53 = 0xb.</para>
        /// <see cref="ffmpeg.FF_CMP_W53" />
        /// </summary>
        W53 = 11,
        
        /// <summary>
        /// <para>FF_CMP_W97 = 0xc.</para>
        /// <see cref="ffmpeg.FF_CMP_W97" />
        /// </summary>
        W97 = 12,
        
        /// <summary>
        /// <para>FF_CMP_DCTMAX = 0xd.</para>
        /// <see cref="ffmpeg.FF_CMP_DCTMAX" />
        /// </summary>
        Dctmax = 13,
        
        /// <summary>
        /// <para>FF_CMP_DCT264 = 0xe.</para>
        /// <see cref="ffmpeg.FF_CMP_DCT264" />
        /// </summary>
        Dct264 = 14,
        
        /// <summary>
        /// <para>FF_CMP_MEDIAN_SAD = 0xf.</para>
        /// <see cref="ffmpeg.FF_CMP_MEDIAN_SAD" />
        /// </summary>
        MedianSad = 15,
        
        /// <summary>
        /// <para>FF_CMP_CHROMA = 0x100.</para>
        /// <see cref="ffmpeg.FF_CMP_CHROMA" />
        /// </summary>
        Chroma = 256,
        
    }
}
