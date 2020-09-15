using System;
using Sdcb.FFmpegAPIWrapper.Common;
using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;

namespace Sdcb.FFmpegAPIWrapper.MediaCodecs
{
    public enum DctComparison
    {
        /// <summary>
        /// <para>FF_CMP_BIT = 5.</para>
        /// <see cref="ffmpeg.FF_CMP_BIT" />
        /// </summary>
        Bit = 0x5,
        
        /// <summary>
        /// <para>FF_CMP_CHROMA = 256.</para>
        /// <see cref="ffmpeg.FF_CMP_CHROMA" />
        /// </summary>
        Chroma = 0x100,
        
        /// <summary>
        /// <para>FF_CMP_DCT = 3.</para>
        /// <see cref="ffmpeg.FF_CMP_DCT" />
        /// </summary>
        Dct = 0x3,
        
        /// <summary>
        /// <para>FF_CMP_DCT264 = 14.</para>
        /// <see cref="ffmpeg.FF_CMP_DCT264" />
        /// </summary>
        Dct264 = 0xE,
        
        /// <summary>
        /// <para>FF_CMP_DCTMAX = 13.</para>
        /// <see cref="ffmpeg.FF_CMP_DCTMAX" />
        /// </summary>
        Dctmax = 0xD,
        
        /// <summary>
        /// <para>FF_CMP_MEDIAN_SAD = 15.</para>
        /// <see cref="ffmpeg.FF_CMP_MEDIAN_SAD" />
        /// </summary>
        MedianSad = 0xF,
        
        /// <summary>
        /// <para>FF_CMP_NSSE = 10.</para>
        /// <see cref="ffmpeg.FF_CMP_NSSE" />
        /// </summary>
        Nsse = 0xA,
        
        /// <summary>
        /// <para>FF_CMP_PSNR = 4.</para>
        /// <see cref="ffmpeg.FF_CMP_PSNR" />
        /// </summary>
        Psnr = 0x4,
        
        /// <summary>
        /// <para>FF_CMP_RD = 6.</para>
        /// <see cref="ffmpeg.FF_CMP_RD" />
        /// </summary>
        Rd = 0x6,
        
        /// <summary>
        /// <para>FF_CMP_SAD = 0.</para>
        /// <see cref="ffmpeg.FF_CMP_SAD" />
        /// </summary>
        Sad = 0x0,
        
        /// <summary>
        /// <para>FF_CMP_SATD = 2.</para>
        /// <see cref="ffmpeg.FF_CMP_SATD" />
        /// </summary>
        Satd = 0x2,
        
        /// <summary>
        /// <para>FF_CMP_SSE = 1.</para>
        /// <see cref="ffmpeg.FF_CMP_SSE" />
        /// </summary>
        Sse = 0x1,
        
        /// <summary>
        /// <para>FF_CMP_VSAD = 8.</para>
        /// <see cref="ffmpeg.FF_CMP_VSAD" />
        /// </summary>
        Vsad = 0x8,
        
        /// <summary>
        /// <para>FF_CMP_VSSE = 9.</para>
        /// <see cref="ffmpeg.FF_CMP_VSSE" />
        /// </summary>
        Vsse = 0x9,
        
        /// <summary>
        /// <para>FF_CMP_W53 = 11.</para>
        /// <see cref="ffmpeg.FF_CMP_W53" />
        /// </summary>
        W53 = 0xB,
        
        /// <summary>
        /// <para>FF_CMP_W97 = 12.</para>
        /// <see cref="ffmpeg.FF_CMP_W97" />
        /// </summary>
        W97 = 0xC,
        
        /// <summary>
        /// <para>FF_CMP_ZERO = 7.</para>
        /// <see cref="ffmpeg.FF_CMP_ZERO" />
        /// </summary>
        Zero = 0x7,
    }
}
