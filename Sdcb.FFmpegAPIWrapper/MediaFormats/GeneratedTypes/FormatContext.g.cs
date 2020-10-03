// This file was genereated from LINQPad scripts, DO NOT CHANGE DIRECTLY.

using System;
using Sdcb.FFmpegAPIWrapper.Common;
using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;
using Sdcb.FFmpegAPIWrapper.MediaCodecs;

namespace Sdcb.FFmpegAPIWrapper.MediaFormats
{
    /// <summary>
    /// <para>Format I/O context.</para>
    /// <para> New fields can be added to the end with minor version bumps.</para>
    /// <para> Removal, reordering and changes to existing fields require a major version bump.</para>
    /// <para> sizeof(AVFormatContext) must not be used outside libav*, use avformat_alloc_context() to create an AVFormatContext.</para>
    /// <see cref="AVFormatContext" />
    /// </summary>
    public unsafe partial class FormatContext : FFmpegSafeObject
    {
        protected AVFormatContext* Pointer => this;
        
        public static implicit operator AVFormatContext*(FormatContext data) => data != null ? (AVFormatContext*)data._nativePointer : null;
        
        protected FormatContext(AVFormatContext* ptr, bool isOwner): base(NativeUtils.NotNull((IntPtr)ptr), isOwner)
        {
        }
        
        public static FormatContext FromNative(AVFormatContext* ptr, bool isOwner) => new FormatContext(ptr, isOwner);
        
        /// <summary>
        /// <para>A class for logging and Exports (de)muxer private options if they exist.</para>
        /// <see cref="AVFormatContext.av_class" />
        /// </summary>
        public FFmpegClass Class
        {
            get => FFmpegClass.FromNative(Pointer->av_class);
            set => Pointer->av_class = value;
        }
        
        /// <summary>
        /// <para>The input container format.</para>
        /// <see cref="AVFormatContext.iformat" />
        /// </summary>
        public InputFormat InputFormat
        {
            get => InputFormat.FromNative(Pointer->iformat);
            set => Pointer->iformat = value;
        }
        
        /// <summary>
        /// <para>The output container format.</para>
        /// <see cref="AVFormatContext.oformat" />
        /// </summary>
        public OutputFormat OutputFormat
        {
            get => OutputFormat.FromNative(Pointer->oformat);
            set => Pointer->oformat = value;
        }
        
        /// <summary>
        /// <para>Format private data.</para>
        /// <para> This is an AVOptions-enabled struct if and only if iformat/oformat.</para>
        /// <para>priv_class is not NULL.</para>
        /// <see cref="AVFormatContext.priv_data" />
        /// </summary>
        public IntPtr PrivateData
        {
            get => (IntPtr)Pointer->priv_data;
            set => Pointer->priv_data = (void*)value;
        }
        
        /// <summary>
        /// <para>I/O context.</para>
        /// <see cref="AVFormatContext.pb" />
        /// </summary>
        public MediaIO IO
        {
            get => MediaIO.FromNative(Pointer->pb, isOwner: false);
            set => Pointer->pb = value;
        }
        
        /// <summary>
        /// <para>Flags signalling stream properties.</para>
        /// <para> A combination of AVFMTCTX_*.</para>
        /// <para> Set by libavformat.</para>
        /// <see cref="AVFormatContext.ctx_flags" />
        /// </summary>
        public int ContextFlags
        {
            get => Pointer->ctx_flags;
            set => Pointer->ctx_flags = value;
        }
        
        /// <summary>
        /// <para>Number of elements in AVFormatContext.</para>
        /// <para>streams.</para>
        /// <see cref="AVFormatContext.nb_streams" />
        /// </summary>
        public uint NbStreams
        {
            get => Pointer->nb_streams;
            set => Pointer->nb_streams = value;
        }
        
        /// <summary>
        /// <para>A list of all streams in the file.</para>
        /// <para> New streams are created with avformat_new_stream().</para>
        /// <see cref="AVFormatContext.streams" />
        /// </summary>
        public AVStream** Streams
        {
            get => Pointer->streams;
            set => Pointer->streams = value;
        }
        
        /// <summary>
        /// <para>input or output URL.</para>
        /// <para> Unlike the old filename field, this field has no length restriction.</para>
        /// <see cref="AVFormatContext.url" />
        /// </summary>
        public string Url
        {
            get => System.Runtime.InteropServices.Marshal.PtrToStringUTF8((IntPtr)Pointer->url);
            set
            {
                if (Pointer->url != null)
                {
                    av_free(Pointer->url);
                    Pointer->url = null;
                }
        
                if (value != null)
                {
                    Pointer->url = av_strdup(value);
                }
            }
        }
        
        
        /// <summary>
        /// <para>Position of the first frame of the component, in AV_TIME_BASE fractional seconds.</para>
        /// <para> NEVER set this value directly: It is deduced from the AVStream values.</para>
        /// <see cref="AVFormatContext.start_time" />
        /// </summary>
        public long StartTime
        {
            get => Pointer->start_time;
            set => Pointer->start_time = value;
        }
        
        /// <summary>
        /// <para>Duration of the stream, in AV_TIME_BASE fractional seconds.</para>
        /// <para> Only set this value if you know none of the individual stream durations and also do not set any of them.</para>
        /// <para> This is deduced from the AVStream values if not set.</para>
        /// <see cref="AVFormatContext.duration" />
        /// </summary>
        public long Duration
        {
            get => Pointer->duration;
            set => Pointer->duration = value;
        }
        
        /// <summary>
        /// <para>Total stream bitrate in bit/s, 0 if not available.</para>
        /// <para> Never set it directly if the file_size and the duration are known as FFmpeg can compute it automatically.</para>
        /// <see cref="AVFormatContext.bit_rate" />
        /// </summary>
        public long BitRate
        {
            get => Pointer->bit_rate;
            set => Pointer->bit_rate = value;
        }
        
        /// <summary>
        /// <see cref="AVFormatContext.packet_size" />
        /// </summary>
        public uint PacketSize
        {
            get => Pointer->packet_size;
            set => Pointer->packet_size = value;
        }
        
        /// <summary>
        /// <see cref="AVFormatContext.max_delay" />
        /// </summary>
        public int MaxDelay
        {
            get => Pointer->max_delay;
            set => Pointer->max_delay = value;
        }
        
        /// <summary>
        /// <para>Flags modifying the (de)muxer behaviour.</para>
        /// <para> A combination of AVFMT_FLAG_*.</para>
        /// <para> Set by the user before avformat_open_input() / avformat_write_header().</para>
        /// <see cref="AVFormatContext.flags" />
        /// </summary>
        public FormatFlag Flags
        {
            get => (FormatFlag)Pointer->flags;
            set => Pointer->flags = (int)value;
        }
        
        /// <summary>
        /// <para>Maximum size of the data read from input for determining the input container format.</para>
        /// <para> Demuxing only, set by the caller before avformat_open_input().</para>
        /// <see cref="AVFormatContext.probesize" />
        /// </summary>
        public long Probesize
        {
            get => Pointer->probesize;
            set => Pointer->probesize = value;
        }
        
        /// <summary>
        /// <para>Maximum duration (in AV_TIME_BASE units) of the data read from input in avformat_find_stream_info().</para>
        /// <para> Demuxing only, set by the caller before avformat_find_stream_info().</para>
        /// <para> Can be set to 0 to let avformat choose using a heuristic.</para>
        /// <see cref="AVFormatContext.max_analyze_duration" />
        /// </summary>
        public long MaxAnalyzeDuration
        {
            get => Pointer->max_analyze_duration;
            set => Pointer->max_analyze_duration = value;
        }
        
        /// <summary>
        /// <see cref="AVFormatContext.key" />
        /// </summary>
        public IntPtr Key
        {
            get => (IntPtr)Pointer->key;
            set => Pointer->key = (byte*)value;
        }
        
        /// <summary>
        /// <see cref="AVFormatContext.keylen" />
        /// </summary>
        public int Keylen
        {
            get => Pointer->keylen;
            set => Pointer->keylen = value;
        }
        
        /// <summary>
        /// <see cref="AVFormatContext.nb_programs" />
        /// </summary>
        public uint NbPrograms
        {
            get => Pointer->nb_programs;
            set => Pointer->nb_programs = value;
        }
        
        /// <summary>
        /// <see cref="AVFormatContext.programs" />
        /// </summary>
        public AVProgram** Programs
        {
            get => Pointer->programs;
            set => Pointer->programs = value;
        }
        
        /// <summary>
        /// <para>Forced video codec_id.</para>
        /// <para> Demuxing: Set by user.</para>
        /// <see cref="AVFormatContext.video_codec_id" />
        /// </summary>
        public CodecID VideoCodecId
        {
            get => (CodecID)Pointer->video_codec_id;
            set => Pointer->video_codec_id = (AVCodecID)value;
        }
        
        /// <summary>
        /// <para>Forced audio codec_id.</para>
        /// <para> Demuxing: Set by user.</para>
        /// <see cref="AVFormatContext.audio_codec_id" />
        /// </summary>
        public CodecID AudioCodecId
        {
            get => (CodecID)Pointer->audio_codec_id;
            set => Pointer->audio_codec_id = (AVCodecID)value;
        }
        
        /// <summary>
        /// <para>Forced subtitle codec_id.</para>
        /// <para> Demuxing: Set by user.</para>
        /// <see cref="AVFormatContext.subtitle_codec_id" />
        /// </summary>
        public CodecID SubtitleCodecId
        {
            get => (CodecID)Pointer->subtitle_codec_id;
            set => Pointer->subtitle_codec_id = (AVCodecID)value;
        }
        
        /// <summary>
        /// <para>Maximum amount of memory in bytes to use for the index of each stream.</para>
        /// <para> If the index exceeds this size, entries will be discarded as needed to maintain a smaller size.</para>
        /// <para> This can lead to slower or less accurate seeking (depends on demuxer).</para>
        /// <para> Demuxers for which a full in-memory index is mandatory will ignore this.</para>
        /// <para> - muxing: unused - demuxing: set by user.</para>
        /// <see cref="AVFormatContext.max_index_size" />
        /// </summary>
        public uint MaxIndexSize
        {
            get => Pointer->max_index_size;
            set => Pointer->max_index_size = value;
        }
        
        /// <summary>
        /// <para>Maximum amount of memory in bytes to use for buffering frames obtained from realtime capture devices.</para>
        /// <see cref="AVFormatContext.max_picture_buffer" />
        /// </summary>
        public uint MaxPictureBuffer
        {
            get => Pointer->max_picture_buffer;
            set => Pointer->max_picture_buffer = value;
        }
        
        /// <summary>
        /// <para>Number of chapters in AVChapter array.</para>
        /// <para> When muxing, chapters are normally written in the file header, so nb_chapters should normally be initialized before write_header is called.</para>
        /// <para> Some muxers (e.</para>
        /// <para>g.</para>
        /// <para> mov and mkv) can also write chapters in the trailer.</para>
        /// <para> To write chapters in the trailer, nb_chapters must be zero when write_header is called and non-zero when write_trailer is called.</para>
        /// <para> - muxing: set by user - demuxing: set by libavformat.</para>
        /// <see cref="AVFormatContext.nb_chapters" />
        /// </summary>
        public uint NbChapters
        {
            get => Pointer->nb_chapters;
            set => Pointer->nb_chapters = value;
        }
        
        /// <summary>
        /// <see cref="AVFormatContext.chapters" />
        /// </summary>
        public AVChapter** Chapters
        {
            get => Pointer->chapters;
            set => Pointer->chapters = value;
        }
        
        /// <summary>
        /// <para>Metadata that applies to the whole file.</para>
        /// <see cref="AVFormatContext.metadata" />
        /// </summary>
        public MediaDictionary Metadata
        {
            get => MediaDictionary.FromNative(Pointer->metadata, isOwner: false);
            set => Pointer->metadata = value;
        }
        
        /// <summary>
        /// <para>Start time of the stream in real world time, in microseconds since the Unix epoch (00:00 1st January 1970).</para>
        /// <para> That is, pts=0 in the stream was captured at this real world time.</para>
        /// <para> - muxing: Set by the caller before avformat_write_header().</para>
        /// <para> If set to either 0 or AV_NOPTS_VALUE, then the current wall-time will be used.</para>
        /// <para> - demuxing: Set by libavformat.</para>
        /// <para> AV_NOPTS_VALUE if unknown.</para>
        /// <para> Note that the value may become known after some number of frames have been received.</para>
        /// <see cref="AVFormatContext.start_time_realtime" />
        /// </summary>
        public long StartTimeRealtime
        {
            get => Pointer->start_time_realtime;
            set => Pointer->start_time_realtime = value;
        }
        
        /// <summary>
        /// <para>The number of frames used for determining the framerate in avformat_find_stream_info().</para>
        /// <para> Demuxing only, set by the caller before avformat_find_stream_info().</para>
        /// <see cref="AVFormatContext.fps_probe_size" />
        /// </summary>
        public int FpsProbeSize
        {
            get => Pointer->fps_probe_size;
            set => Pointer->fps_probe_size = value;
        }
        
        /// <summary>
        /// <para>Error recognition; higher values will detect more errors but may misdetect some more or less valid parts as errors.</para>
        /// <para> Demuxing only, set by the caller before avformat_open_input().</para>
        /// <see cref="AVFormatContext.error_recognition" />
        /// </summary>
        public int ErrorRecognition
        {
            get => Pointer->error_recognition;
            set => Pointer->error_recognition = value;
        }
        
        /// <summary>
        /// <para>Custom interrupt callbacks for the I/O layer.</para>
        /// <see cref="AVFormatContext.interrupt_callback" />
        /// </summary>
        public AVIOInterruptCB InterruptCallback
        {
            get => Pointer->interrupt_callback;
            set => Pointer->interrupt_callback = value;
        }
        
        /// <summary>
        /// <para>Flags to enable debugging.</para>
        /// <see cref="AVFormatContext.debug" />
        /// </summary>
        public int Debug
        {
            get => Pointer->debug;
            set => Pointer->debug = value;
        }
        
        /// <summary>
        /// <para>Maximum buffering duration for interleaving.</para>
        /// <see cref="AVFormatContext.max_interleave_delta" />
        /// </summary>
        public long MaxInterleaveDelta
        {
            get => Pointer->max_interleave_delta;
            set => Pointer->max_interleave_delta = value;
        }
        
        /// <summary>
        /// <para>Allow non-standard and experimental extension.</para>
        /// <see cref="AVFormatContext.strict_std_compliance" />
        /// </summary>
        public int StrictStdCompliance
        {
            get => Pointer->strict_std_compliance;
            set => Pointer->strict_std_compliance = value;
        }
        
        /// <summary>
        /// <para>Flags for the user to detect events happening on the file.</para>
        /// <para> Flags must be cleared by the user once the event has been handled.</para>
        /// <para> A combination of AVFMT_EVENT_FLAG_*.</para>
        /// <see cref="AVFormatContext.event_flags" />
        /// </summary>
        public EventFlag EventFlags
        {
            get => (EventFlag)Pointer->event_flags;
            set => Pointer->event_flags = (int)value;
        }
        
        /// <summary>
        /// <para>Maximum number of packets to read while waiting for the first timestamp.</para>
        /// <para> Decoding only.</para>
        /// <see cref="AVFormatContext.max_ts_probe" />
        /// </summary>
        public int MaxTsProbe
        {
            get => Pointer->max_ts_probe;
            set => Pointer->max_ts_probe = value;
        }
        
        /// <summary>
        /// <para>Avoid negative timestamps during muxing.</para>
        /// <para> Any value of the AVFMT_AVOID_NEG_TS_* constants.</para>
        /// <para> Note, this only works when using av_interleaved_write_frame.</para>
        /// <para> (interleave_packet_per_dts is in use) - muxing: Set by user - demuxing: unused.</para>
        /// <see cref="AVFormatContext.avoid_negative_ts" />
        /// </summary>
        public int AvoidNegativeTs
        {
            get => Pointer->avoid_negative_ts;
            set => Pointer->avoid_negative_ts = value;
        }
        
        /// <summary>
        /// <para>Transport stream id.</para>
        /// <para> This will be moved into demuxer private options.</para>
        /// <para> Thus no API/ABI compatibility.</para>
        /// <see cref="AVFormatContext.ts_id" />
        /// </summary>
        public int TsId
        {
            get => Pointer->ts_id;
            set => Pointer->ts_id = value;
        }
        
        /// <summary>
        /// <para>Audio preload in microseconds.</para>
        /// <para> Note, not all formats support this and unpredictable things may happen if it is used when not supported.</para>
        /// <para> - encoding: Set by user - decoding: unused.</para>
        /// <see cref="AVFormatContext.audio_preload" />
        /// </summary>
        public int AudioPreload
        {
            get => Pointer->audio_preload;
            set => Pointer->audio_preload = value;
        }
        
        /// <summary>
        /// <para>Max chunk time in microseconds.</para>
        /// <para> Note, not all formats support this and unpredictable things may happen if it is used when not supported.</para>
        /// <para> - encoding: Set by user - decoding: unused.</para>
        /// <see cref="AVFormatContext.max_chunk_duration" />
        /// </summary>
        public int MaxChunkDuration
        {
            get => Pointer->max_chunk_duration;
            set => Pointer->max_chunk_duration = value;
        }
        
        /// <summary>
        /// <para>Max chunk size in bytes Note, not all formats support this and unpredictable things may happen if it is used when not supported.</para>
        /// <para> - encoding: Set by user - decoding: unused.</para>
        /// <see cref="AVFormatContext.max_chunk_size" />
        /// </summary>
        public int MaxChunkSize
        {
            get => Pointer->max_chunk_size;
            set => Pointer->max_chunk_size = value;
        }
        
        /// <summary>
        /// <para>forces the use of wallclock timestamps as pts/dts of packets This has undefined results in the presence of B frames.</para>
        /// <para> - encoding: unused - decoding: Set by user.</para>
        /// <see cref="AVFormatContext.use_wallclock_as_timestamps" />
        /// </summary>
        public int UseWallclockAsTimestamps
        {
            get => Pointer->use_wallclock_as_timestamps;
            set => Pointer->use_wallclock_as_timestamps = value;
        }
        
        /// <summary>
        /// <para>avio flags, used to force AVIO_FLAG_DIRECT.</para>
        /// <para> - encoding: unused - decoding: Set by user.</para>
        /// <see cref="AVFormatContext.avio_flags" />
        /// </summary>
        public MediaIOFlags AvioFlags
        {
            get => (MediaIOFlags)Pointer->avio_flags;
            set => Pointer->avio_flags = (int)value;
        }
        
        /// <summary>
        /// <para>The duration field can be estimated through various ways, and this field can be used to know how the duration was estimated.</para>
        /// <para> - encoding: unused - decoding: Read by user.</para>
        /// <see cref="AVFormatContext.duration_estimation_method" />
        /// </summary>
        public DurationEstimationMethod DurationEstimationMethod
        {
            get => (DurationEstimationMethod)Pointer->duration_estimation_method;
            set => Pointer->duration_estimation_method = (AVDurationEstimationMethod)value;
        }
        
        /// <summary>
        /// <para>Skip initial bytes when opening stream - encoding: unused - decoding: Set by user.</para>
        /// <see cref="AVFormatContext.skip_initial_bytes" />
        /// </summary>
        public long SkipInitialBytes
        {
            get => Pointer->skip_initial_bytes;
            set => Pointer->skip_initial_bytes = value;
        }
        
        /// <summary>
        /// <para>Correct single timestamp overflows - encoding: unused - decoding: Set by user.</para>
        /// <see cref="AVFormatContext.correct_ts_overflow" />
        /// </summary>
        public uint CorrectTsOverflow
        {
            get => Pointer->correct_ts_overflow;
            set => Pointer->correct_ts_overflow = value;
        }
        
        /// <summary>
        /// <para>Force seeking to any (also non key) frames.</para>
        /// <para> - encoding: unused - decoding: Set by user.</para>
        /// <see cref="AVFormatContext.seek2any" />
        /// </summary>
        public int Seek2any
        {
            get => Pointer->seek2any;
            set => Pointer->seek2any = value;
        }
        
        /// <summary>
        /// <para>Flush the I/O context after each packet.</para>
        /// <para> - encoding: Set by user - decoding: unused.</para>
        /// <see cref="AVFormatContext.flush_packets" />
        /// </summary>
        public int FlushPackets
        {
            get => Pointer->flush_packets;
            set => Pointer->flush_packets = value;
        }
        
        /// <summary>
        /// <para>format probing score.</para>
        /// <para> The maximal score is AVPROBE_SCORE_MAX, its set when the demuxer probes the format.</para>
        /// <para> - encoding: unused - decoding: set by avformat, read by user.</para>
        /// <see cref="AVFormatContext.probe_score" />
        /// </summary>
        public int ProbeScore
        {
            get => Pointer->probe_score;
            set => Pointer->probe_score = value;
        }
        
        /// <summary>
        /// <para>number of bytes to read maximally to identify format.</para>
        /// <para> - encoding: unused - decoding: set by user.</para>
        /// <see cref="AVFormatContext.format_probesize" />
        /// </summary>
        public int FormatProbesize
        {
            get => Pointer->format_probesize;
            set => Pointer->format_probesize = value;
        }
        
        /// <summary>
        /// <para>&#39;,&#39; separated list of allowed decoders.</para>
        /// <para> If NULL then all are allowed - encoding: unused - decoding: set by user.</para>
        /// <see cref="AVFormatContext.codec_whitelist" />
        /// </summary>
        public IntPtr CodecWhitelist
        {
            get => (IntPtr)Pointer->codec_whitelist;
            set => Pointer->codec_whitelist = (byte*)value;
        }
        
        /// <summary>
        /// <para>&#39;,&#39; separated list of allowed demuxers.</para>
        /// <para> If NULL then all are allowed - encoding: unused - decoding: set by user.</para>
        /// <see cref="AVFormatContext.format_whitelist" />
        /// </summary>
        public IntPtr FormatWhitelist
        {
            get => (IntPtr)Pointer->format_whitelist;
            set => Pointer->format_whitelist = (byte*)value;
        }
        
        /// <summary>
        /// <para>An opaque field for libavformat internal usage.</para>
        /// <para> Must not be accessed in any way by callers.</para>
        /// <see cref="AVFormatContext.internal" />
        /// </summary>
        public AVFormatInternal* Internal
        {
            get => Pointer->@internal;
            set => Pointer->@internal = value;
        }
        
        /// <summary>
        /// <para>IO repositioned flag.</para>
        /// <para> This is set by avformat when the underlaying IO context read pointer is repositioned, for example when doing byte based seeking.</para>
        /// <para> Demuxers can use the flag to detect such changes.</para>
        /// <see cref="AVFormatContext.io_repositioned" />
        /// </summary>
        public int IoRepositioned
        {
            get => Pointer->io_repositioned;
            set => Pointer->io_repositioned = value;
        }
        
        /// <summary>
        /// <para>Forced video codec.</para>
        /// <para> This allows forcing a specific decoder, even when there are multiple with the same codec_id.</para>
        /// <para> Demuxing: Set by user.</para>
        /// <see cref="AVFormatContext.video_codec" />
        /// </summary>
        public Codec VideoCodec
        {
            get => Codec.FromNative(Pointer->video_codec);
            set => Pointer->video_codec = value;
        }
        
        /// <summary>
        /// <para>Forced audio codec.</para>
        /// <para> This allows forcing a specific decoder, even when there are multiple with the same codec_id.</para>
        /// <para> Demuxing: Set by user.</para>
        /// <see cref="AVFormatContext.audio_codec" />
        /// </summary>
        public Codec AudioCodec
        {
            get => Codec.FromNative(Pointer->audio_codec);
            set => Pointer->audio_codec = value;
        }
        
        /// <summary>
        /// <para>Forced subtitle codec.</para>
        /// <para> This allows forcing a specific decoder, even when there are multiple with the same codec_id.</para>
        /// <para> Demuxing: Set by user.</para>
        /// <see cref="AVFormatContext.subtitle_codec" />
        /// </summary>
        public Codec SubtitleCodec
        {
            get => Codec.FromNative(Pointer->subtitle_codec);
            set => Pointer->subtitle_codec = value;
        }
        
        /// <summary>
        /// <para>Forced data codec.</para>
        /// <para> This allows forcing a specific decoder, even when there are multiple with the same codec_id.</para>
        /// <para> Demuxing: Set by user.</para>
        /// <see cref="AVFormatContext.data_codec" />
        /// </summary>
        public Codec DataCodec
        {
            get => Codec.FromNative(Pointer->data_codec);
            set => Pointer->data_codec = value;
        }
        
        /// <summary>
        /// <para>Number of bytes to be written as padding in a metadata header.</para>
        /// <para> Demuxing: Unused.</para>
        /// <para> Muxing: Set by user via av_format_set_metadata_header_padding.</para>
        /// <see cref="AVFormatContext.metadata_header_padding" />
        /// </summary>
        public int MetadataHeaderPadding
        {
            get => Pointer->metadata_header_padding;
            set => Pointer->metadata_header_padding = value;
        }
        
        /// <summary>
        /// <para>User data.</para>
        /// <para> This is a place for some private data of the user.</para>
        /// <see cref="AVFormatContext.opaque" />
        /// </summary>
        public IntPtr Opaque
        {
            get => (IntPtr)Pointer->opaque;
            set => Pointer->opaque = (void*)value;
        }
        
        /// <summary>
        /// <para>Output timestamp offset, in microseconds.</para>
        /// <para> Muxing: set by user.</para>
        /// <see cref="AVFormatContext.output_ts_offset" />
        /// </summary>
        public long OutputTsOffset
        {
            get => Pointer->output_ts_offset;
            set => Pointer->output_ts_offset = value;
        }
        
        /// <summary>
        /// <para>dump format separator.</para>
        /// <para> can be &quot;, &quot; or &quot; &quot; or anything else - muxing: Set by user.</para>
        /// <para> - demuxing: Set by user.</para>
        /// <see cref="AVFormatContext.dump_separator" />
        /// </summary>
        public IntPtr DumpSeparator
        {
            get => (IntPtr)Pointer->dump_separator;
            set => Pointer->dump_separator = (byte*)value;
        }
        
        /// <summary>
        /// <para>Forced Data codec_id.</para>
        /// <para> Demuxing: Set by user.</para>
        /// <see cref="AVFormatContext.data_codec_id" />
        /// </summary>
        public CodecID DataCodecId
        {
            get => (CodecID)Pointer->data_codec_id;
            set => Pointer->data_codec_id = (AVCodecID)value;
        }
        
        /// <summary>
        /// <para>&#39;,&#39; separated list of allowed protocols.</para>
        /// <para> - encoding: unused - decoding: set by user.</para>
        /// <see cref="AVFormatContext.protocol_whitelist" />
        /// </summary>
        public IntPtr ProtocolWhitelist
        {
            get => (IntPtr)Pointer->protocol_whitelist;
            set => Pointer->protocol_whitelist = (byte*)value;
        }
        
        /// <summary>
        /// <para>&#39;,&#39; separated list of disallowed protocols.</para>
        /// <para> - encoding: unused - decoding: set by user.</para>
        /// <see cref="AVFormatContext.protocol_blacklist" />
        /// </summary>
        public IntPtr ProtocolBlacklist
        {
            get => (IntPtr)Pointer->protocol_blacklist;
            set => Pointer->protocol_blacklist = (byte*)value;
        }
        
        /// <summary>
        /// <para>The maximum number of streams.</para>
        /// <para> - encoding: unused - decoding: set by user.</para>
        /// <see cref="AVFormatContext.max_streams" />
        /// </summary>
        public int MaxStreams
        {
            get => Pointer->max_streams;
            set => Pointer->max_streams = value;
        }
        
        /// <summary>
        /// <para>Skip duration calcuation in estimate_timings_from_pts.</para>
        /// <para> - encoding: unused - decoding: set by user.</para>
        /// <see cref="AVFormatContext.skip_estimate_duration_from_pts" />
        /// </summary>
        public int SkipEstimateDurationFromPts
        {
            get => Pointer->skip_estimate_duration_from_pts;
            set => Pointer->skip_estimate_duration_from_pts = value;
        }
        
        /// <summary>
        /// <para>Maximum number of packets that can be probed - encoding: unused - decoding: set by user.</para>
        /// <see cref="AVFormatContext.max_probe_packets" />
        /// </summary>
        public int MaxProbePackets
        {
            get => Pointer->max_probe_packets;
            set => Pointer->max_probe_packets = value;
        }
    }
}
