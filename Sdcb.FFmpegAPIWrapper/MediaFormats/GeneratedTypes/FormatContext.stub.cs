using System;
using Sdcb.FFmpegAPIWrapper.Common;
using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;
using Sdcb.FFmpegAPIWrapper.MediaCodecs;
using System.Linq;
using System.Collections.Generic;

namespace Sdcb.FFmpegAPIWrapper.MediaFormats
{
    public unsafe partial class FormatContext : FFmpegSafeObject
    {
        /// <summary>
        /// <see cref="avformat_alloc_context"/>
        /// </summary>
        public FormatContext() : base(NativeUtils.NotNull((IntPtr)avformat_alloc_context()), isOwner: true)
        {
        }

        /// <summary>
        /// <see cref="avformat_alloc_output_context2(AVFormatContext**, AVOutputFormat*, string, string)"/>
        /// </summary>
        public static FormatContext AllocOutput(OutputFormat? format, string formatName, string fileName)
        {
            AVFormatContext* ptr;
            avformat_alloc_output_context2(
                &ptr, 
                format.HasValue ? (AVOutputFormat*)format.Value : null, 
                formatName, 
                fileName).ThrowIfError();
            return FromNative(ptr, isOwner: true);
        }

        /// <summary>
        /// <see cref="avformat_open_input(AVFormatContext**, string, AVInputFormat*, AVDictionary**)"/>
        /// </summary>
        public static FormatContext OpenInput(string? url, InputFormat? format, MediaDictionary? options = null)
        {
            AVFormatContext* resultPtr;
            AVDictionary* dictPtr = options;
            avformat_open_input(&resultPtr, url, format, &dictPtr).ThrowIfError();
            options.Reset(dictPtr);
            return FromNative(resultPtr, isOwner: true);
        }

        /// <summary>
        /// <see cref="av_format_inject_global_side_data(AVFormatContext*)"/>
        /// </summary>
        public void InjectGlobalSideData() => av_format_inject_global_side_data(this);

        /// <summary>
        /// <see cref="avformat_new_stream(AVFormatContext*, AVCodec*)"/>
        /// </summary>
        public MediaStream NewStream(Codec codec) => MediaStream.FromNative(avformat_new_stream(this, codec));

        /// <summary>
        /// <see cref="av_new_program(AVFormatContext*, int)"/>
        /// </summary>
        public MediaProgram NewProgram(int id) => MediaProgram.FromNative(av_new_program(this, id));

        /// <summary>
        /// <see cref="avformat_free_context(AVFormatContext*)"/>
        /// </summary>
        public void Free()
        {
            avformat_free_context(this);
            _nativePointer = IntPtr.Zero;
        }

        protected override void DisposeNative() => Free();

        /// <summary>
        /// <see cref="avformat_version"/>
        /// </summary>
        public static string Version => avformat_version().ToFourCC();

        /// <summary>
        /// <see cref="avformat_configuration"/>
        /// </summary>
        public static HashSet<string> Configuration => avformat_configuration()
            .Split(' ')
            .ToHashSet();

        /// <summary>
        /// <see cref="avformat_license"/>
        /// </summary>
        /// <returns></returns>
        public static string License() => avformat_license();

        /// <summary>
        /// <see cref="av_muxer_iterate(void**)"/>
        /// </summary>
        public static IEnumerable<OutputFormat> Muxers => NativeUtils
            .EnumeratePtrIterator(ptr => (IntPtr)av_muxer_iterate((void**)ptr))
            .Select(x => OutputFormat.FromNative((AVOutputFormat*)x));

        /// <summary>
        /// <see cref="av_demuxer_iterate(void**)"/>
        /// </summary>
        public static IEnumerable<InputFormat> Demuxers => NativeUtils
            .EnumeratePtrIterator(ptr => (IntPtr)av_demuxer_iterate((void**)ptr))
            .Select(x => InputFormat.FromNative((AVInputFormat*)x));

        /// <summary>
        /// <see cref="av_find_input_format(string)"/>
        /// </summary>
        public static InputFormat? FindInputFormat(string shortName)
        {
            AVInputFormat* ptr = av_find_input_format(shortName);
            return ptr != null ? new InputFormat?(InputFormat.FromNative(ptr)) : null;
        }

        /// <summary>
        /// <see cref="av_probe_input_format(AVProbeData*, int)"/>
        /// </summary>
        public static InputFormat? ProbeInputFormat(AVProbeData* data, bool isOpened)
        {
            AVInputFormat* ptr = av_probe_input_format(data, isOpened ? 1 : 0);
            return ptr != null ? new InputFormat?(InputFormat.FromNative(ptr)) : null;
        }

        /// <summary>
        /// <see cref="av_probe_input_format2(AVProbeData*, int, int*)"/>
        /// </summary>
        public static InputFormat? ProbeInputFormat2(AVProbeData* data, bool isOpened, out int maxScore)
        {
            int maxScoreRet;
            AVInputFormat* ptr = av_probe_input_format2(data, isOpened ? 1 : 0, &maxScoreRet);
            maxScore = maxScoreRet;
            return ptr != null ? new InputFormat?(InputFormat.FromNative(ptr)) : null;
        }

        /// <summary>
        /// <see cref="av_probe_input_format3(AVProbeData*, int, int*)"/>
        /// </summary>
        public static InputFormat? ProbeInputFormat3(AVProbeData* data, bool isOpened, out int score)
        {
            int scoreRet;
            AVInputFormat* ptr = av_probe_input_format3(data, isOpened ? 1 : 0, &scoreRet);
            score = scoreRet;
            return ptr != null ? new InputFormat?(InputFormat.FromNative(ptr)) : null;
        }

        /// <summary>
        /// <see cref="av_probe_input_buffer2(AVIOContext*, AVInputFormat**, string, void*, uint, uint)"/>
        /// </summary>
        public static InputFormat ProbeInputBuffer(MediaIO io, string url, IntPtr logCtx, out int score, uint offset = 0 , uint maxProbeSize = 0)
        {
            AVInputFormat* format;
            score = av_probe_input_buffer2(io, &format, url, (void*)logCtx, offset, maxProbeSize).ThrowIfError();
            return InputFormat.FromNative(format);
        }

        /// <summary>
        /// <see cref="avformat_get_class"/>
        /// </summary>
        public static FFmpegClass FFmpegClass => FFmpegClass.FromNative(avformat_get_class());
    }
}
