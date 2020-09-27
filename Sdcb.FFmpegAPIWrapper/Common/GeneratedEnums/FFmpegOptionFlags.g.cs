// This file was genereated from LINQPad scripts, DO NOT CHANGE DIRECTLY.

using System;
using Sdcb.FFmpegAPIWrapper.Common;
using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;

namespace Sdcb.FFmpegAPIWrapper.Common
{
    [Flags]
    public enum FFmpegOptionFlags
    {
        None = 0,
        
        /// <summary>
        /// <para>AV_OPT_FLAG_ENCODING_PARAM = 1.</para>
        /// <see cref="ffmpeg.AV_OPT_FLAG_ENCODING_PARAM" />
        /// </summary>
        EncodingParam = 1,
        
        /// <summary>
        /// <para>AV_OPT_FLAG_DECODING_PARAM = 2.</para>
        /// <see cref="ffmpeg.AV_OPT_FLAG_DECODING_PARAM" />
        /// </summary>
        DecodingParam = 2,
        
        /// <summary>
        /// <para>AV_OPT_FLAG_AUDIO_PARAM = 8.</para>
        /// <see cref="ffmpeg.AV_OPT_FLAG_AUDIO_PARAM" />
        /// </summary>
        AudioParam = 8,
        
        /// <summary>
        /// <para>AV_OPT_FLAG_VIDEO_PARAM = 16.</para>
        /// <see cref="ffmpeg.AV_OPT_FLAG_VIDEO_PARAM" />
        /// </summary>
        VideoParam = 16,
        
        /// <summary>
        /// <para>AV_OPT_FLAG_SUBTITLE_PARAM = 32.</para>
        /// <see cref="ffmpeg.AV_OPT_FLAG_SUBTITLE_PARAM" />
        /// </summary>
        SubtitleParam = 32,
        
        /// <summary>
        /// <para>AV_OPT_FLAG_EXPORT = 64.</para>
        /// <see cref="ffmpeg.AV_OPT_FLAG_EXPORT" />
        /// </summary>
        Export = 64,
        
        /// <summary>
        /// <para>AV_OPT_FLAG_READONLY = 128.</para>
        /// <see cref="ffmpeg.AV_OPT_FLAG_READONLY" />
        /// </summary>
        Readonly = 128,
        
        /// <summary>
        /// <para>AV_OPT_FLAG_BSF_PARAM = (1&lt;&lt;8).</para>
        /// <see cref="ffmpeg.AV_OPT_FLAG_BSF_PARAM" />
        /// </summary>
        BsfParam = 256,
        
        /// <summary>
        /// <para>AV_OPT_FLAG_RUNTIME_PARAM = (1&lt;&lt;15).</para>
        /// <see cref="ffmpeg.AV_OPT_FLAG_RUNTIME_PARAM" />
        /// </summary>
        RuntimeParam = 32768,
        
        /// <summary>
        /// <para>AV_OPT_FLAG_FILTERING_PARAM = (1&lt;&lt;16).</para>
        /// <see cref="ffmpeg.AV_OPT_FLAG_FILTERING_PARAM" />
        /// </summary>
        FilteringParam = 65536,
        
        /// <summary>
        /// <para>AV_OPT_FLAG_DEPRECATED = (1&lt;&lt;17).</para>
        /// <see cref="ffmpeg.AV_OPT_FLAG_DEPRECATED" />
        /// </summary>
        Deprecated = 131072,
        
        /// <summary>
        /// <para>AV_OPT_FLAG_CHILD_CONSTS = (1&lt;&lt;18).</para>
        /// <see cref="ffmpeg.AV_OPT_FLAG_CHILD_CONSTS" />
        /// </summary>
        ChildConsts = 262144,
        
    }
}
