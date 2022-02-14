// This file was genereated from LINQPad scripts, DO NOT CHANGE DIRECTLY.

using System;
using Sdcb.FFmpegAPIWrapper.Common;
using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;

namespace Sdcb.FFmpegAPIWrapper.MediaCodecs
{
    /// <summary>See AV_CODEC_FLAG_* </summary>
    [Flags]
    public enum CodecFlag : uint
    {
        None = 0x0U,
        
        /// <summary>
        /// <para>AV_CODEC_FLAG_UNALIGNED = 0x1 &lt;&lt; 0x0.</para>
        /// <see cref="ffmpeg.AV_CODEC_FLAG_UNALIGNED" />
        /// </summary>
        Unaligned = 0x1U,
        
        /// <summary>
        /// <para>AV_CODEC_FLAG_QSCALE = 0x1 &lt;&lt; 0x1.</para>
        /// <see cref="ffmpeg.AV_CODEC_FLAG_QSCALE" />
        /// </summary>
        Qscale = 0x2U,
        
        /// <summary>
        /// <para>AV_CODEC_FLAG_4MV = 0x1 &lt;&lt; 0x2.</para>
        /// <see cref="ffmpeg.AV_CODEC_FLAG_4MV" />
        /// </summary>
        _4mv = 0x4U,
        
        /// <summary>
        /// <para>AV_CODEC_FLAG_OUTPUT_CORRUPT = 0x1 &lt;&lt; 0x3.</para>
        /// <see cref="ffmpeg.AV_CODEC_FLAG_OUTPUT_CORRUPT" />
        /// </summary>
        OutputCorrupt = 0x8U,
        
        /// <summary>
        /// <para>AV_CODEC_FLAG_QPEL = 0x1 &lt;&lt; 0x4.</para>
        /// <see cref="ffmpeg.AV_CODEC_FLAG_QPEL" />
        /// </summary>
        Qpel = 0x10U,
        
        /// <summary>
        /// <para>AV_CODEC_FLAG_DROPCHANGED = 0x1 &lt;&lt; 0x5.</para>
        /// <see cref="ffmpeg.AV_CODEC_FLAG_DROPCHANGED" />
        /// </summary>
        Dropchanged = 0x20U,
        
        /// <summary>
        /// <para>AV_CODEC_FLAG_PASS1 = 0x1 &lt;&lt; 0x9.</para>
        /// <see cref="ffmpeg.AV_CODEC_FLAG_PASS1" />
        /// </summary>
        Pass1 = 0x200U,
        
        /// <summary>
        /// <para>AV_CODEC_FLAG_PASS2 = 0x1 &lt;&lt; 0xa.</para>
        /// <see cref="ffmpeg.AV_CODEC_FLAG_PASS2" />
        /// </summary>
        Pass2 = 0x400U,
        
        /// <summary>
        /// <para>AV_CODEC_FLAG_LOOP_FILTER = 0x1 &lt;&lt; 0xb.</para>
        /// <see cref="ffmpeg.AV_CODEC_FLAG_LOOP_FILTER" />
        /// </summary>
        LoopFilter = 0x800U,
        
        /// <summary>
        /// <para>AV_CODEC_FLAG_GRAY = 0x1 &lt;&lt; 0xd.</para>
        /// <see cref="ffmpeg.AV_CODEC_FLAG_GRAY" />
        /// </summary>
        Gray = 0x2000U,
        
        /// <summary>
        /// <para>AV_CODEC_FLAG_PSNR = 0x1 &lt;&lt; 0xf.</para>
        /// <see cref="ffmpeg.AV_CODEC_FLAG_PSNR" />
        /// </summary>
        Psnr = 0x8000U,
        
        /// <summary>
        /// <para>AV_CODEC_FLAG_TRUNCATED = 0x1 &lt;&lt; 0x10.</para>
        /// <see cref="ffmpeg.AV_CODEC_FLAG_TRUNCATED" />
        /// </summary>
        Truncated = 0x10000U,
        
        /// <summary>
        /// <para>AV_CODEC_FLAG_INTERLACED_DCT = 0x1 &lt;&lt; 0x12.</para>
        /// <see cref="ffmpeg.AV_CODEC_FLAG_INTERLACED_DCT" />
        /// </summary>
        InterlacedDct = 0x40000U,
        
        /// <summary>
        /// <para>AV_CODEC_FLAG_LOW_DELAY = 0x1 &lt;&lt; 0x13.</para>
        /// <see cref="ffmpeg.AV_CODEC_FLAG_LOW_DELAY" />
        /// </summary>
        LowDelay = 0x80000U,
        
        /// <summary>
        /// <para>AV_CODEC_FLAG_GLOBAL_HEADER = 0x1 &lt;&lt; 0x16.</para>
        /// <see cref="ffmpeg.AV_CODEC_FLAG_GLOBAL_HEADER" />
        /// </summary>
        GlobalHeader = 0x400000U,
        
        /// <summary>
        /// <para>AV_CODEC_FLAG_BITEXACT = 0x1 &lt;&lt; 0x17.</para>
        /// <see cref="ffmpeg.AV_CODEC_FLAG_BITEXACT" />
        /// </summary>
        Bitexact = 0x800000U,
        
        /// <summary>
        /// <para>AV_CODEC_FLAG_AC_PRED = 0x1 &lt;&lt; 0x18.</para>
        /// <see cref="ffmpeg.AV_CODEC_FLAG_AC_PRED" />
        /// </summary>
        AcPred = 0x1000000U,
        
        /// <summary>
        /// <para>AV_CODEC_FLAG_INTERLACED_ME = 0x1 &lt;&lt; 0x1d.</para>
        /// <see cref="ffmpeg.AV_CODEC_FLAG_INTERLACED_ME" />
        /// </summary>
        InterlacedMe = 0x20000000U,
        
        /// <summary>
        /// <para>AV_CODEC_FLAG_CLOSED_GOP = 0x1U &lt;&lt; 0x1f.</para>
        /// <see cref="ffmpeg.AV_CODEC_FLAG_CLOSED_GOP" />
        /// </summary>
        ClosedGop = 0x80000000U,
        
    }
}
