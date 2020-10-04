using Sdcb.FFmpegAPIWrapper.MediaCodecs;
using static FFmpeg.AutoGen.ffmpeg;
using System;
using System.Collections.Generic;
using System.Text;
using FFmpeg.AutoGen;

namespace Sdcb.FFmpegAPIWrapper.MediaUtils
{
    public static class PixelUtils
    {
        /// <summary>
        /// <see cref="av_get_pix_fmt_name(AVPixelFormat)"/>
        /// </summary>
        public static string GetPixelFormatName(PixelFormat pixelFormat) => av_get_pix_fmt_name((AVPixelFormat)pixelFormat);

        /// <summary>
        /// <see cref="av_get_pix_fmt(string)"/>
        /// </summary>
        public static PixelFormat ToPixelFormat(string name) => (PixelFormat)av_get_pix_fmt(name);
    }
}
