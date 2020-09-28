// This file was genereated from LINQPad scripts, DO NOT CHANGE DIRECTLY.

using System;
using Sdcb.FFmpegAPIWrapper.Common;
using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;

namespace Sdcb.FFmpegAPIWrapper.MediaCodecs
{
    /// <summary>See AV_CODEC_CAP_* </summary>
    [Flags]
    public enum CodecCompability : uint
    {
        None = 0x0U,
        
        /// <summary>
        /// <para>AV_CODEC_CAP_DRAW_HORIZ_BAND = (1 &lt;&lt;  0).</para>
        /// <see cref="ffmpeg.AV_CODEC_CAP_DRAW_HORIZ_BAND" />
        /// </summary>
        DrawHorizBand = 0x1U,
        
        /// <summary>
        /// <para>AV_CODEC_CAP_DR1 = (1 &lt;&lt;  1).</para>
        /// <see cref="ffmpeg.AV_CODEC_CAP_DR1" />
        /// </summary>
        Dr1 = 0x2U,
        
        /// <summary>
        /// <para>AV_CODEC_CAP_TRUNCATED = (1 &lt;&lt;  3).</para>
        /// <see cref="ffmpeg.AV_CODEC_CAP_TRUNCATED" />
        /// </summary>
        Truncated = 0x8U,
        
        /// <summary>
        /// <para>AV_CODEC_CAP_DELAY = (1 &lt;&lt;  5).</para>
        /// <see cref="ffmpeg.AV_CODEC_CAP_DELAY" />
        /// </summary>
        Delay = 0x20U,
        
        /// <summary>
        /// <para>AV_CODEC_CAP_SMALL_LAST_FRAME = (1 &lt;&lt;  6).</para>
        /// <see cref="ffmpeg.AV_CODEC_CAP_SMALL_LAST_FRAME" />
        /// </summary>
        SmallLastFrame = 0x40U,
        
        /// <summary>
        /// <para>AV_CODEC_CAP_SUBFRAMES = (1 &lt;&lt;  8).</para>
        /// <see cref="ffmpeg.AV_CODEC_CAP_SUBFRAMES" />
        /// </summary>
        Subframes = 0x100U,
        
        /// <summary>
        /// <para>AV_CODEC_CAP_EXPERIMENTAL = (1 &lt;&lt;  9).</para>
        /// <see cref="ffmpeg.AV_CODEC_CAP_EXPERIMENTAL" />
        /// </summary>
        Experimental = 0x200U,
        
        /// <summary>
        /// <para>AV_CODEC_CAP_CHANNEL_CONF = (1 &lt;&lt; 10).</para>
        /// <see cref="ffmpeg.AV_CODEC_CAP_CHANNEL_CONF" />
        /// </summary>
        ChannelConf = 0x400U,
        
        /// <summary>
        /// <para>AV_CODEC_CAP_FRAME_THREADS = (1 &lt;&lt; 12).</para>
        /// <see cref="ffmpeg.AV_CODEC_CAP_FRAME_THREADS" />
        /// </summary>
        FrameThreads = 0x1000U,
        
        /// <summary>
        /// <para>AV_CODEC_CAP_SLICE_THREADS = (1 &lt;&lt; 13).</para>
        /// <see cref="ffmpeg.AV_CODEC_CAP_SLICE_THREADS" />
        /// </summary>
        SliceThreads = 0x2000U,
        
        /// <summary>
        /// <para>AV_CODEC_CAP_PARAM_CHANGE = (1 &lt;&lt; 14).</para>
        /// <see cref="ffmpeg.AV_CODEC_CAP_PARAM_CHANGE" />
        /// </summary>
        ParamChange = 0x4000U,
        
        /// <summary>
        /// <para>AV_CODEC_CAP_AUTO_THREADS = (1 &lt;&lt; 15).</para>
        /// <see cref="ffmpeg.AV_CODEC_CAP_AUTO_THREADS" />
        /// </summary>
        AutoThreads = 0x8000U,
        
        /// <summary>
        /// <para>AV_CODEC_CAP_VARIABLE_FRAME_SIZE = (1 &lt;&lt; 16).</para>
        /// <see cref="ffmpeg.AV_CODEC_CAP_VARIABLE_FRAME_SIZE" />
        /// </summary>
        VariableFrameSize = 0x10000U,
        
        /// <summary>
        /// <para>AV_CODEC_CAP_AVOID_PROBING = (1 &lt;&lt; 17).</para>
        /// <see cref="ffmpeg.AV_CODEC_CAP_AVOID_PROBING" />
        /// </summary>
        AvoidProbing = 0x20000U,
        
        /// <summary>
        /// <para>AV_CODEC_CAP_HARDWARE = (1 &lt;&lt; 18).</para>
        /// <see cref="ffmpeg.AV_CODEC_CAP_HARDWARE" />
        /// </summary>
        Hardware = 0x40000U,
        
        /// <summary>
        /// <para>AV_CODEC_CAP_HYBRID = (1 &lt;&lt; 19).</para>
        /// <see cref="ffmpeg.AV_CODEC_CAP_HYBRID" />
        /// </summary>
        Hybrid = 0x80000U,
        
        /// <summary>
        /// <para>AV_CODEC_CAP_ENCODER_REORDERED_OPAQUE = (1 &lt;&lt; 20).</para>
        /// <see cref="ffmpeg.AV_CODEC_CAP_ENCODER_REORDERED_OPAQUE" />
        /// </summary>
        EncoderReorderedOpaque = 0x100000U,
        
        /// <summary>
        /// <para>AV_CODEC_CAP_ENCODER_FLUSH = (1 &lt;&lt; 21).</para>
        /// <see cref="ffmpeg.AV_CODEC_CAP_ENCODER_FLUSH" />
        /// </summary>
        EncoderFlush = 0x200000U,
        
        /// <summary>
        /// <para>AV_CODEC_CAP_INTRA_ONLY = 0x40000000.</para>
        /// <see cref="ffmpeg.AV_CODEC_CAP_INTRA_ONLY" />
        /// </summary>
        IntraOnly = 0x40000000U,
        
        /// <summary>
        /// <para>AV_CODEC_CAP_LOSSLESS = 0x80000000.</para>
        /// <see cref="ffmpeg.AV_CODEC_CAP_LOSSLESS" />
        /// </summary>
        Lossless = 0x80000000U,
        
    }
}
