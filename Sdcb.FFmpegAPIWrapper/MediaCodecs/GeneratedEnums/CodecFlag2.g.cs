// This file was genereated from LINQPad scripts, DO NOT CHANGE DIRECTLY.

using System;
using Sdcb.FFmpegAPIWrapper.Common;
using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;

namespace Sdcb.FFmpegAPIWrapper.MediaCodecs
{
    /// <summary>See AV_CODEC_FLAG2_* </summary>
    [Flags]
    public enum CodecFlag2
    {
        None = 0,
        
        /// <summary>
        /// <para>AV_CODEC_FLAG2_FAST = 0x1 &lt;&lt; 0x0.</para>
        /// <see cref="ffmpeg.AV_CODEC_FLAG2_FAST" />
        /// </summary>
        Fast = 1,
        
        /// <summary>
        /// <para>AV_CODEC_FLAG2_NO_OUTPUT = 0x1 &lt;&lt; 0x2.</para>
        /// <see cref="ffmpeg.AV_CODEC_FLAG2_NO_OUTPUT" />
        /// </summary>
        NoOutput = 4,
        
        /// <summary>
        /// <para>AV_CODEC_FLAG2_LOCAL_HEADER = 0x1 &lt;&lt; 0x3.</para>
        /// <see cref="ffmpeg.AV_CODEC_FLAG2_LOCAL_HEADER" />
        /// </summary>
        LocalHeader = 8,
        
        /// <summary>
        /// <para>AV_CODEC_FLAG2_DROP_FRAME_TIMECODE = 0x1 &lt;&lt; 0xd.</para>
        /// <see cref="ffmpeg.AV_CODEC_FLAG2_DROP_FRAME_TIMECODE" />
        /// </summary>
        DropFrameTimecode = 8192,
        
        /// <summary>
        /// <para>AV_CODEC_FLAG2_CHUNKS = 0x1 &lt;&lt; 0xf.</para>
        /// <see cref="ffmpeg.AV_CODEC_FLAG2_CHUNKS" />
        /// </summary>
        Chunks = 32768,
        
        /// <summary>
        /// <para>AV_CODEC_FLAG2_IGNORE_CROP = 0x1 &lt;&lt; 0x10.</para>
        /// <see cref="ffmpeg.AV_CODEC_FLAG2_IGNORE_CROP" />
        /// </summary>
        IgnoreCrop = 65536,
        
        /// <summary>
        /// <para>AV_CODEC_FLAG2_SHOW_ALL = 0x1 &lt;&lt; 0x16.</para>
        /// <see cref="ffmpeg.AV_CODEC_FLAG2_SHOW_ALL" />
        /// </summary>
        ShowAll = 4194304,
        
        /// <summary>
        /// <para>AV_CODEC_FLAG2_EXPORT_MVS = 0x1 &lt;&lt; 0x1c.</para>
        /// <see cref="ffmpeg.AV_CODEC_FLAG2_EXPORT_MVS" />
        /// </summary>
        ExportMvs = 268435456,
        
        /// <summary>
        /// <para>AV_CODEC_FLAG2_SKIP_MANUAL = 0x1 &lt;&lt; 0x1d.</para>
        /// <see cref="ffmpeg.AV_CODEC_FLAG2_SKIP_MANUAL" />
        /// </summary>
        SkipManual = 536870912,
        
        /// <summary>
        /// <para>AV_CODEC_FLAG2_RO_FLUSH_NOOP = 0x1 &lt;&lt; 0x1e.</para>
        /// <see cref="ffmpeg.AV_CODEC_FLAG2_RO_FLUSH_NOOP" />
        /// </summary>
        RoFlushNoop = 1073741824,
        
    }
}
