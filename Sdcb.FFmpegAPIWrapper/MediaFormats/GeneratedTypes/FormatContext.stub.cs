using System;
using Sdcb.FFmpegAPIWrapper.Common;
using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;
using Sdcb.FFmpegAPIWrapper.MediaCodecs;
using System.Linq;
using System.Collections.Generic;

namespace Sdcb.FFmpegAPIWrapper.MediaFormats
{
    public unsafe partial class FormatContext
    {
        /// <summary>
        /// <see cref="avformat_alloc_context"/>
        /// </summary>
        public FormatContext() : base(NativeUtils.NotNull((IntPtr)avformat_alloc_context()), isOwner: true)
        {
        }

        public FFmpegOptions Options => new FFmpegOptions(this);

        /// <summary>
        /// <see cref="avformat_alloc_output_context2(AVFormatContext**, AVOutputFormat*, string, string)"/>
        /// </summary>
        public static FormatContext AllocOutput(OutputFormat? format = null, string? formatName = null, string? fileName = null)
        {
            AVFormatContext* ptr;
            avformat_alloc_output_context2(
                &ptr,
                format ?? null,
                formatName,
                fileName).ThrowIfError();
            return FromNative(ptr, isOwner: true);
        }

        /// <summary>
        /// <see cref="avformat_open_input(AVFormatContext**, string, AVInputFormat*, AVDictionary**)"/>
        /// </summary>
        public static FormatContext OpenInput(string? url, InputFormat? format = null, MediaDictionary? options = null)
        {
            AVFormatContext* resultPtr;
            AVDictionary* dictPtr = options;
            avformat_open_input(&resultPtr, url, format, &dictPtr).ThrowIfError();
            options.Reset(dictPtr);
            return new InputFormatContext(resultPtr, isOwner: true);
        }

        /// <summary>
        /// <see cref="av_format_inject_global_side_data(AVFormatContext*)"/>
        /// </summary>
        public void InjectGlobalSideData() => av_format_inject_global_side_data(this);

        /// <summary>
        /// <see cref="avformat_new_stream(AVFormatContext*, AVCodec*)"/>
        /// </summary>
        public MediaStream NewStream(Codec? codec = null) => new MediaStream(this, codec);

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
            return MediaStream.FromNative(Pointer->streams[streamId]);
        }

        /// <summary>
        /// <see cref="av_read_frame(AVFormatContext*, AVPacket*)"/>
        /// </summary>
        public CodecResult ReadFrame(Packet packet) => CodecContext.ToCodecResult(av_read_frame(this, packet));

        public IEnumerable<Packet> ReadPackets()
        {
            using var packet = new Packet();
            while (true)
            {
                CodecResult result = ReadFrame(packet);
                if (result == CodecResult.EOF) break;
                System.Diagnostics.Debug.Assert(result == CodecResult.Success);
                try
                {
                    yield return packet;
                }
                finally
                {
                    packet.Unreference();
                }
            }
        }

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
        public void WritePacket(Packet packet) => av_write_frame(this, packet).ThrowIfError();

        /// <summary>
        /// <see cref="av_interleaved_write_frame(AVFormatContext*, AVPacket*)"/>
        /// </summary>
        public void InterleavedWritePacket(Packet packet) => av_interleaved_write_frame(this, packet).ThrowIfError();

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

        public IReadOnlyList<MediaStream> Streams => new MediaStreamPtrArray(Pointer->streams, (int)Pointer->nb_streams);

        public MediaStream GetVideoStream() => FindBestStream(MediaType.Video);
        public MediaStream GetAudioStream() => FindBestStream(MediaType.Audio);
        public MediaStream GetSubtitleStream() => FindBestStream(MediaType.Subtitle);

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
        /// <see cref="avformat_get_class"/>
        /// </summary>
        public static FFmpegClass TypeClass => FFmpegClass.FromNative(avformat_get_class());
    }
}
