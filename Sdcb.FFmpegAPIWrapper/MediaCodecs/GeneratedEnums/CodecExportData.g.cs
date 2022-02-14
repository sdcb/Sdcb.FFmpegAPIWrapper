// This file was genereated from LINQPad scripts, DO NOT CHANGE DIRECTLY.

using System;
using Sdcb.FFmpegAPIWrapper.Common;
using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;

namespace Sdcb.FFmpegAPIWrapper.MediaCodecs
{
    /// <summary>See AV_CODEC_EXPORT_DATA_* </summary>
    public enum CodecExportData
    {
        None = 0,
        
        /// <summary>
        /// <para>AV_CODEC_EXPORT_DATA_MVS = 0x1 &lt;&lt; 0x0.</para>
        /// <see cref="ffmpeg.AV_CODEC_EXPORT_DATA_MVS" />
        /// </summary>
        Mvs = 1,
        
        /// <summary>
        /// <para>AV_CODEC_EXPORT_DATA_PRFT = 0x1 &lt;&lt; 0x1.</para>
        /// <see cref="ffmpeg.AV_CODEC_EXPORT_DATA_PRFT" />
        /// </summary>
        Prft = 2,
        
        /// <summary>
        /// <para>AV_CODEC_EXPORT_DATA_VIDEO_ENC_PARAMS = 0x1 &lt;&lt; 0x2.</para>
        /// <see cref="ffmpeg.AV_CODEC_EXPORT_DATA_VIDEO_ENC_PARAMS" />
        /// </summary>
        VideoEncParams = 4,
        
        /// <summary>
        /// <para>AV_CODEC_EXPORT_DATA_FILM_GRAIN = 0x1 &lt;&lt; 0x3.</para>
        /// <see cref="ffmpeg.AV_CODEC_EXPORT_DATA_FILM_GRAIN" />
        /// </summary>
        FilmGrain = 8,
        
    }
}
