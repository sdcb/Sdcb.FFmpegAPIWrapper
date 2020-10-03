using System;
using Sdcb.FFmpegAPIWrapper.Common;
using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;
using Sdcb.FFmpegAPIWrapper.MediaCodecs;

namespace Sdcb.FFmpegAPIWrapper.MediaFormats
{
    public unsafe partial struct OutputFormat
    {
        public static OutputFormat? Guess(string? shortName = null, string? fileName = null, string? mimeType = null)
            => FromNativeOrNull(av_guess_format(shortName, fileName, mimeType));
    }
}
