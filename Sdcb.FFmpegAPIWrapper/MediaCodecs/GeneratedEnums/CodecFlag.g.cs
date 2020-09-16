// This file was genereated from LINQPad scripts, DO NOT CHANGE DIRECTLY.

using System;
using Sdcb.FFmpegAPIWrapper.Common;
using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;

namespace Sdcb.FFmpegAPIWrapper.MediaCodecs
{
    [Flags]
    public enum CodecFlag : uint
    {
        /// <summary>
        /// <para>AV_CODEC_FLAG_UNALIGNED = (1 &lt;&lt;  0).</para>
        /// <see cref="ffmpeg.AV_CODEC_FLAG_UNALIGNED" />
        /// </summary>
        Unaligned = 0x1U,
        
        /// <summary>
        /// <para>AV_CODEC_FLAG_QSCALE = (1 &lt;&lt;  1).</para>
        /// <see cref="ffmpeg.AV_CODEC_FLAG_QSCALE" />
        /// </summary>
        Qscale = 0x2U,
        
        /// <summary>
        /// <para>AV_CODEC_FLAG_4MV = (1 &lt;&lt;  2).</para>
        /// <see cref="ffmpeg.AV_CODEC_FLAG_4MV" />
        /// </summary>
        _4mv = 0x4U,
        
        /// <summary>
        /// <para>AV_CODEC_FLAG_OUTPUT_CORRUPT = (1 &lt;&lt;  3).</para>
        /// <see cref="ffmpeg.AV_CODEC_FLAG_OUTPUT_CORRUPT" />
        /// </summary>
        OutputCorrupt = 0x8U,
        
        /// <summary>
        /// <para>AV_CODEC_FLAG_QPEL = (1 &lt;&lt;  4).</para>
        /// <see cref="ffmpeg.AV_CODEC_FLAG_QPEL" />
        /// </summary>
        Qpel = 0x10U,
        
        /// <summary>
        /// <para>AV_CODEC_FLAG_DROPCHANGED = (1 &lt;&lt;  5).</para>
        /// <see cref="ffmpeg.AV_CODEC_FLAG_DROPCHANGED" />
        /// </summary>
        Dropchanged = 0x20U,
        
        /// <summary>
        /// <para>AV_CODEC_FLAG_PASS1 = (1 &lt;&lt;  9).</para>
        /// <see cref="ffmpeg.AV_CODEC_FLAG_PASS1" />
        /// </summary>
        Pass1 = 0x200U,
        
        /// <summary>
        /// <para>AV_CODEC_FLAG_PASS2 = (1 &lt;&lt; 10).</para>
        /// <see cref="ffmpeg.AV_CODEC_FLAG_PASS2" />
        /// </summary>
        Pass2 = 0x400U,
        
        /// <summary>
        /// <para>AV_CODEC_FLAG_LOOP_FILTER = (1 &lt;&lt; 11).</para>
        /// <see cref="ffmpeg.AV_CODEC_FLAG_LOOP_FILTER" />
        /// </summary>
        LoopFilter = 0x800U,
        
        /// <summary>
        /// <para>AV_CODEC_FLAG_GRAY = (1 &lt;&lt; 13).</para>
        /// <see cref="ffmpeg.AV_CODEC_FLAG_GRAY" />
        /// </summary>
        Gray = 0x2000U,
        
        /// <summary>
        /// <para>AV_CODEC_FLAG_PSNR = (1 &lt;&lt; 15).</para>
        /// <see cref="ffmpeg.AV_CODEC_FLAG_PSNR" />
        /// </summary>
        Psnr = 0x8000U,
        
        /// <summary>
        /// <para>AV_CODEC_FLAG_TRUNCATED = (1 &lt;&lt; 16).</para>
        /// <see cref="ffmpeg.AV_CODEC_FLAG_TRUNCATED" />
        /// </summary>
        Truncated = 0x10000U,
        
        /// <summary>
        /// <para>AV_CODEC_FLAG_INTERLACED_DCT = (1 &lt;&lt; 18).</para>
        /// <see cref="ffmpeg.AV_CODEC_FLAG_INTERLACED_DCT" />
        /// </summary>
        InterlacedDct = 0x40000U,
        
        /// <summary>
        /// <para>AV_CODEC_FLAG_LOW_DELAY = (1 &lt;&lt; 19).</para>
        /// <see cref="ffmpeg.AV_CODEC_FLAG_LOW_DELAY" />
        /// </summary>
        LowDelay = 0x80000U,
        
        /// <summary>
        /// <para>AV_CODEC_FLAG_GLOBAL_HEADER = (1 &lt;&lt; 22).</para>
        /// <see cref="ffmpeg.AV_CODEC_FLAG_GLOBAL_HEADER" />
        /// </summary>
        GlobalHeader = 0x400000U,
        
        /// <summary>
        /// <para>AV_CODEC_FLAG_BITEXACT = (1 &lt;&lt; 23).</para>
        /// <see cref="ffmpeg.AV_CODEC_FLAG_BITEXACT" />
        /// </summary>
        Bitexact = 0x800000U,
        
        /// <summary>
        /// <para>AV_CODEC_FLAG_AC_PRED = (1 &lt;&lt; 24).</para>
        /// <see cref="ffmpeg.AV_CODEC_FLAG_AC_PRED" />
        /// </summary>
        AcPred = 0x1000000U,
        
        /// <summary>
        /// <para>AV_CODEC_FLAG_INTERLACED_ME = (1 &lt;&lt; 29).</para>
        /// <see cref="ffmpeg.AV_CODEC_FLAG_INTERLACED_ME" />
        /// </summary>
        InterlacedMe = 0x20000000U,
        
        /// <summary>
        /// <para>AV_CODEC_FLAG_CLOSED_GOP = (1U &lt;&lt; 31).</para>
        /// <see cref="ffmpeg.AV_CODEC_FLAG_CLOSED_GOP" />
        /// </summary>
        ClosedGop = 0x80000000U,
        
    }
}
