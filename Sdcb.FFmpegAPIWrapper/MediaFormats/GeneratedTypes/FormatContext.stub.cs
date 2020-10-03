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
        /// <see cref="avformat_find_stream_info(AVFormatContext*, AVDictionary**)"/>
        /// </summary>
        public MediaDictionary FindStreamInfo()
        {
            AVDictionary* dict;
            avformat_find_stream_info(this, &dict);
            return MediaDictionary.FromNative(dict, isOwner: true);
        }

        /// <summary>
        /// <see cref="av_find_program_from_stream(AVFormatContext*, AVProgram*, int)"/>
        /// </summary>
        public MediaProgram? FindProgramFromStream(MediaProgram? last, int index)
            => MediaProgram.FromNativeOrNull(av_find_program_from_stream(this, last, index));

        /// <summary>
        /// <see cref="av_find_best_stream(AVFormatContext*, AVMediaType, int, int, AVCodec**, int)"/>
        /// </summary>
        public (int streamId, Codec codec)? FindBestStreamId(MediaType type, int wantedStreamId = -1, int relatedStream = -1)
        {
            AVCodec* ptr;
            int id = av_find_best_stream(this, (AVMediaType)type, wantedStreamId, relatedStream, &ptr, flags: 0);
            if (id == AVERROR_DECODER_NOT_FOUND) return null;

            id.ThrowIfError();

            return (id, Codec.FromNative(ptr));
        }

        /// <summary>
        /// <see cref="av_find_best_stream(AVFormatContext*, AVMediaType, int, int, AVCodec**, int)"/>
        /// </summary>
        public MediaStream FindBestStream(MediaType type, int wantedStreamId = -1, int relatedStream = -1)
        {
            int streamId = av_find_best_stream(this, (AVMediaType)type, wantedStreamId, relatedStream, decoder_ret: null, flags: 0).ThrowIfError();
            return MediaStream.FromNative(Streams[streamId]);
        }

        /// <summary>
        /// <see cref="av_read_frame(AVFormatContext*, AVPacket*)"/>
        /// </summary>
        public CodecResult ReadFrame(Packet packet) => CodecContext.ToCodecResult(av_read_frame(this, packet));

        /// <summary>
        /// <see cref="av_seek_frame(AVFormatContext*, int, long, int)"/>
        /// </summary>
        public void SeekFrame(long timestamp, int streamIndex = -1, MediaSeek flags = MediaSeek.Backward) => av_seek_frame(this, streamIndex, timestamp, (int)flags).ThrowIfError();

        /// <summary>
        /// <see cref="avformat_flush(AVFormatContext*)"/>
        /// </summary>
        public void Flush() => avformat_flush(this).ThrowIfError();

        /// <summary>
        /// <see cref="av_read_play(AVFormatContext*)"/>
        /// </summary>
        public void ReadPlay() => av_read_play(this).ThrowIfError();

        /// <summary>
        /// <see cref="av_read_pause(AVFormatContext*)"/>
        /// </summary>
        public void ReadPause() => av_read_pause(this).ThrowIfError();

        /// <summary>
        /// <see cref="avformat_close_input(AVFormatContext**)"/>
        /// </summary>
        public void CloseInput()
        {
            AVFormatContext* ptr = this;
            avformat_close_input(&ptr);
            _nativePointer = (IntPtr)ptr;
        }

        /// <summary>
        /// <see cref="avformat_write_header(AVFormatContext*, AVDictionary**)"/>
        /// </summary>
        public StreamInitIn WriteHeader(MediaDictionary? options = null)
        {
            AVDictionary* dictPtr = options;
            int ret = avformat_write_header(this, &dictPtr).ThrowIfError();
            options.Reset(dictPtr);
            return (StreamInitIn)ret;
        }

        /// <summary>
        /// <see cref="avformat_init_output(AVFormatContext*, AVDictionary**)"/>
        /// </summary>
        public StreamInitIn InitOutput(MediaDictionary? options = null)
        {
            AVDictionary* dictPtr = options;
            int ret = avformat_init_output(this, &dictPtr).ThrowIfError();
            options.Reset(dictPtr);
            return (StreamInitIn)ret;
        }

        /// <summary>
        /// <see cref="av_write_frame(AVFormatContext*, AVPacket*)"/>
        /// </summary>
        public void WriteFrame(Packet packet) => av_write_frame(this, packet).ThrowIfError();

        /// <summary>
        /// <see cref="av_interleaved_write_frame(AVFormatContext*, AVPacket*)"/>
        /// </summary>
        public void InterleavedWriteFrame(Packet packet) => av_interleaved_write_frame(this, packet).ThrowIfError();

        /// <summary>
        /// <see cref="av_write_uncoded_frame(AVFormatContext*, int, AVFrame*)"/>
        /// </summary>
        public void WriteUncodedFrame(int streamIndex, Frame frame) => av_write_uncoded_frame(this, streamIndex, frame).ThrowIfError();

        /// <summary>
        /// <see cref="av_interleaved_write_uncoded_frame(AVFormatContext*, int, AVFrame*)"/>
        /// </summary>
        public void InterleavedWriteUncodedFrame(int streamIndex, Frame frame)
            => av_interleaved_write_uncoded_frame(this, streamIndex, frame);

        /// <summary>
        /// <see cref="av_write_uncoded_frame_query(AVFormatContext*, int)"/>
        /// </summary>
        /// <param name="streamIndex"></param>
        /// <returns></returns>
        public bool SupportWriteUncodedFrame(int streamIndex) => av_write_uncoded_frame_query(this, streamIndex) switch
        {
            >= 0 => true,
            < 0 => false
        };

        /// <summary>
        /// <see cref="av_write_trailer(AVFormatContext*)"/>
        /// </summary>
        public void WriteTrailer() => av_write_trailer(this).ThrowIfError();

        public (long dts, long wall) GetOutputTimestamp(int streamIndex)
        {
            long dts, wall;
            av_get_output_timestamp(this, streamIndex, &dts, &wall).ThrowIfError();
            return (dts, wall);
        }

        /// <summary>
        /// <see cref="DefaultStreamIndex"/>
        /// </summary>
        public int DefaultStreamIndex => av_find_default_stream_index(this);

        /// <summary>
        /// <see cref="av_dump_format(AVFormatContext*, int, string, int)"/>
        /// </summary>
        public void DumpFormat(int streamIndex, string? url, bool isOutput) => av_dump_format(this, streamIndex, url, isOutput ? 1 : 0);

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
        public static InputFormat ProbeInputBuffer(MediaIO io, string url, IntPtr logCtx, out int score, uint offset = 0, uint maxProbeSize = 0)
        {
            AVInputFormat* format;
            score = av_probe_input_buffer2(io, &format, url, (void*)logCtx, offset, maxProbeSize).ThrowIfError();
            return InputFormat.FromNative(format);
        }

        /// <summary>
        /// <see cref="avformat_get_class"/>
        /// </summary>
        public static FFmpegClass ContextClass => FFmpegClass.FromNative(avformat_get_class());
    }
}
