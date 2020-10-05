using System;
using Sdcb.FFmpegAPIWrapper.Common;
using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;

namespace Sdcb.FFmpegAPIWrapper.MediaFormats
{
    public unsafe partial struct InputFormat
    {
        /// <summary>
        /// <see cref="av_find_input_format(string)"/>
        /// </summary>
        public InputFormat(string shortName)
        {
            AVInputFormat* ptr = av_find_input_format(shortName);
            if (ptr == null)
            {
                throw new ArgumentOutOfRangeException(nameof(shortName), $"Cannot find InputFormat: {shortName}");
            }
            _ptr = ptr;
        }

        /// <summary>
        /// <see cref="av_probe_input_format(AVProbeData*, int)"/>
        /// </summary>
        public static InputFormat? ProbeInputFormat(AVProbeData* data, bool isOpened)
        {
            AVInputFormat* ptr = av_probe_input_format(data, isOpened ? 1 : 0);
            return ptr != null ? new InputFormat?(FromNative(ptr)) : null;
        }

        /// <summary>
        /// <see cref="av_probe_input_format2(AVProbeData*, int, int*)"/>
        /// </summary>
        public static InputFormat? ProbeInputFormat2(AVProbeData* data, bool isOpened, out int maxScore)
        {
            int maxScoreRet;
            AVInputFormat* ptr = av_probe_input_format2(data, isOpened ? 1 : 0, &maxScoreRet);
            maxScore = maxScoreRet;
            return ptr != null ? new InputFormat?(FromNative(ptr)) : null;
        }

        /// <summary>
        /// <see cref="av_probe_input_format3(AVProbeData*, int, int*)"/>
        /// </summary>
        public static InputFormat? ProbeInputFormat3(AVProbeData* data, bool isOpened, out int score)
        {
            int scoreRet;
            AVInputFormat* ptr = av_probe_input_format3(data, isOpened ? 1 : 0, &scoreRet);
            score = scoreRet;
            return ptr != null ? new InputFormat?(FromNative(ptr)) : null;
        }

        /// <summary>
        /// <see cref="av_probe_input_buffer2(AVIOContext*, AVInputFormat**, string, void*, uint, uint)"/>
        /// </summary>
        public static InputFormat ProbeInputBuffer(MediaIO io, string url, IntPtr logCtx, out int score, uint offset = 0, uint maxProbeSize = 0)
        {
            AVInputFormat* format;
            score = av_probe_input_buffer2(io, &format, url, (void*)logCtx, offset, maxProbeSize).ThrowIfError();
            return FromNative(format);
        }

        public static InputFormat DShow => new InputFormat("dshow");
        public static InputFormat GdiGrab => new InputFormat("gdigrab");
    }
}
