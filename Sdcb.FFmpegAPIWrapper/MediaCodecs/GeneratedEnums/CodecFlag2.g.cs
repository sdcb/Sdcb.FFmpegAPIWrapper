using System;
using Sdcb.FFmpegAPIWrapper.Common;
using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;

namespace Sdcb.FFmpegAPIWrapper.MediaCodecs
{
    public enum CodecFlag2
    {
        /// <summary>
        /// <para>AV_CODEC_FLAG2_FAST = (1 &lt;&lt;  0).</para>
        /// <see cref="ffmpeg.AV_CODEC_FLAG2_FAST" />
        /// </summary>
        Fast = 1,
        
        /// <summary>
        /// <para>AV_CODEC_FLAG2_NO_OUTPUT = (1 &lt;&lt;  2).</para>
        /// <see cref="ffmpeg.AV_CODEC_FLAG2_NO_OUTPUT" />
        /// </summary>
        NoOutput = 4,
        
        /// <summary>
        /// <para>AV_CODEC_FLAG2_LOCAL_HEADER = (1 &lt;&lt;  3).</para>
        /// <see cref="ffmpeg.AV_CODEC_FLAG2_LOCAL_HEADER" />
        /// </summary>
        LocalHeader = 8,
        
        /// <summary>
        /// <para>AV_CODEC_FLAG2_DROP_FRAME_TIMECODE = (1 &lt;&lt; 13).</para>
        /// <see cref="ffmpeg.AV_CODEC_FLAG2_DROP_FRAME_TIMECODE" />
        /// </summary>
        DropFrameTimecode = 8192,
        
        /// <summary>
        /// <para>AV_CODEC_FLAG2_CHUNKS = (1 &lt;&lt; 15).</para>
        /// <see cref="ffmpeg.AV_CODEC_FLAG2_CHUNKS" />
        /// </summary>
        Chunks = 32768,
        
        /// <summary>
        /// <para>AV_CODEC_FLAG2_IGNORE_CROP = (1 &lt;&lt; 16).</para>
        /// <see cref="ffmpeg.AV_CODEC_FLAG2_IGNORE_CROP" />
        /// </summary>
        IgnoreCrop = 65536,
        
        /// <summary>
        /// <para>AV_CODEC_FLAG2_SHOW_ALL = (1 &lt;&lt; 22).</para>
        /// <see cref="ffmpeg.AV_CODEC_FLAG2_SHOW_ALL" />
        /// </summary>
        ShowAll = 4194304,
        
        /// <summary>
        /// <para>AV_CODEC_FLAG2_EXPORT_MVS = (1 &lt;&lt; 28).</para>
        /// <see cref="ffmpeg.AV_CODEC_FLAG2_EXPORT_MVS" />
        /// </summary>
        ExportMvs = 268435456,
        
        /// <summary>
        /// <para>AV_CODEC_FLAG2_SKIP_MANUAL = (1 &lt;&lt; 29).</para>
        /// <see cref="ffmpeg.AV_CODEC_FLAG2_SKIP_MANUAL" />
        /// </summary>
        SkipManual = 536870912,
        
        /// <summary>
        /// <para>AV_CODEC_FLAG2_RO_FLUSH_NOOP = (1 &lt;&lt; 30).</para>
        /// <see cref="ffmpeg.AV_CODEC_FLAG2_RO_FLUSH_NOOP" />
        /// </summary>
        RoFlushNoop = 1073741824,
        
    }
}
