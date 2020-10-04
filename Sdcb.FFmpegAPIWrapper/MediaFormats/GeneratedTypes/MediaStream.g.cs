// This file was genereated from LINQPad scripts, DO NOT CHANGE DIRECTLY.

using System;
using Sdcb.FFmpegAPIWrapper.Common;
using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;
using Sdcb.FFmpegAPIWrapper.MediaCodecs;

namespace Sdcb.FFmpegAPIWrapper.MediaFormats
{
    /// <summary>
    /// <para>Stream structure.</para>
    /// <para> New fields can be added to the end with minor version bumps.</para>
    /// <para> Removal, reordering and changes to existing fields require a major version bump.</para>
    /// <para> sizeof(AVStream) must not be used outside libav*.</para>
    /// <see cref="AVStream" />
    /// </summary>
    public unsafe partial struct MediaStream
    {
        private AVStream* _ptr;
        
        public static implicit operator AVStream*(MediaStream? data)
            => data.HasValue ? (AVStream*)data.Value._ptr : null;
        
        private MediaStream(AVStream* ptr)
        {
            if (ptr == null)
            {
                throw new ArgumentNullException(nameof(ptr));
            }
            _ptr = ptr;
        }
        
        public static MediaStream FromNative(AVStream* ptr) => new MediaStream(ptr);
        public static MediaStream FromNative(IntPtr ptr) => new MediaStream((AVStream*)ptr);
        internal static MediaStream? FromNativeOrNull(AVStream* ptr)
            => ptr != null ? new MediaStream?(new MediaStream(ptr)) : null;
        
        /// <summary>
        /// <para>stream index in AVFormatContext.</para>
        /// <see cref="AVStream.index" />
        /// </summary>
        public int Index
        {
            get => _ptr->index;
            set => _ptr->index = value;
        }
        
        /// <summary>
        /// <para>Format-specific stream ID.</para>
        /// <para> decoding: set by libavformat encoding: set by the user, replaced by libavformat if left unset.</para>
        /// <see cref="AVStream.id" />
        /// </summary>
        public int Id
        {
            get => _ptr->id;
            set => _ptr->id = value;
        }
        
        /// <summary>
        /// <see cref="AVStream.priv_data" />
        /// </summary>
        public IntPtr PrivateData
        {
            get => (IntPtr)_ptr->priv_data;
            set => _ptr->priv_data = (void*)value;
        }
        
        /// <summary>
        /// <para>This is the fundamental unit of time (in seconds) in terms of which frame timestamps are represented.</para>
        /// <see cref="AVStream.time_base" />
        /// </summary>
        public MediaRational TimeBase
        {
            get => _ptr->time_base;
            set => _ptr->time_base = value;
        }
        
        /// <summary>
        /// <para>Decoding: pts of the first frame of the stream in presentation order, in stream time base.</para>
        /// <para> Only set this if you are absolutely 100% sure that the value you set it to really is the pts of the first frame.</para>
        /// <para> This may be undefined (AV_NOPTS_VALUE).</para>
        /// <see cref="AVStream.start_time" />
        /// </summary>
        public long StartTime
        {
            get => _ptr->start_time;
            set => _ptr->start_time = value;
        }
        
        /// <summary>
        /// <para>Decoding: duration of the stream, in stream time base.</para>
        /// <para> If a source file does not specify a duration, but does specify a bitrate, this value will be estimated from bitrate and file size.</para>
        /// <see cref="AVStream.duration" />
        /// </summary>
        public long Duration
        {
            get => _ptr->duration;
            set => _ptr->duration = value;
        }
        
        /// <summary>
        /// <para>number of frames in this stream if known or 0.</para>
        /// <see cref="AVStream.nb_frames" />
        /// </summary>
        public long NbFrames
        {
            get => _ptr->nb_frames;
            set => _ptr->nb_frames = value;
        }
        
        /// <summary>
        /// <para>AV_DISPOSITION_* bit field.</para>
        /// <see cref="AVStream.disposition" />
        /// </summary>
        public int Disposition
        {
            get => _ptr->disposition;
            set => _ptr->disposition = value;
        }
        
        /// <summary>
        /// <para>Selects which packets can be discarded at will and do not need to be demuxed.</para>
        /// <see cref="AVStream.discard" />
        /// </summary>
        public MediaDiscard Discard
        {
            get => (MediaDiscard)_ptr->discard;
            set => _ptr->discard = (AVDiscard)value;
        }
        
        /// <summary>
        /// <para>sample aspect ratio (0 if unknown) - encoding: Set by user.</para>
        /// <para> - decoding: Set by libavformat.</para>
        /// <see cref="AVStream.sample_aspect_ratio" />
        /// </summary>
        public MediaRational SampleAspectRatio
        {
            get => _ptr->sample_aspect_ratio;
            set => _ptr->sample_aspect_ratio = value;
        }
        
        /// <summary>
        /// <see cref="AVStream.metadata" />
        /// </summary>
        public MediaDictionary Metadata
        {
            get => MediaDictionary.FromNative(_ptr->metadata, isOwner: false);
            set => _ptr->metadata = value;
        }
        
        /// <summary>
        /// <para>Average framerate.</para>
        /// <see cref="AVStream.avg_frame_rate" />
        /// </summary>
        public MediaRational AvgFrameRate
        {
            get => _ptr->avg_frame_rate;
            set => _ptr->avg_frame_rate = value;
        }
        
        /// <summary>
        /// <para>For streams with AV_DISPOSITION_ATTACHED_PIC disposition, this packet will contain the attached picture.</para>
        /// <see cref="AVStream.attached_pic" />
        /// </summary>
        public AVPacket AttachedPic
        {
            get => _ptr->attached_pic;
            set => _ptr->attached_pic = value;
        }
        
        /// <summary>
        /// <para>An array of side data that applies to the whole stream (i.</para>
        /// <para>e.</para>
        /// <para> the container does not allow it to change between packets).</para>
        /// <see cref="AVStream.side_data" />
        /// </summary>
        public AVPacketSideData* SideData
        {
            get => _ptr->side_data;
            set => _ptr->side_data = value;
        }
        
        /// <summary>
        /// <para>The number of elements in the AVStream.</para>
        /// <para>side_data array.</para>
        /// <see cref="AVStream.nb_side_data" />
        /// </summary>
        public int NbSideData
        {
            get => _ptr->nb_side_data;
            set => _ptr->nb_side_data = value;
        }
        
        /// <summary>
        /// <para>Flags for the user to detect events happening on the stream.</para>
        /// <para> Flags must be cleared by the user once the event has been handled.</para>
        /// <para> A combination of AVSTREAM_EVENT_FLAG_*.</para>
        /// <see cref="AVStream.event_flags" />
        /// </summary>
        public int EventFlags
        {
            get => _ptr->event_flags;
            set => _ptr->event_flags = value;
        }
        
        /// <summary>
        /// <para>Real base framerate of the stream.</para>
        /// <para> This is the lowest framerate with which all timestamps can be represented accurately (it is the least common multiple of all framerates in the stream).</para>
        /// <para> Note, this value is just a guess! For example, if the time base is 1/90000 and all frames have either approximately 3600 or 1800 timer ticks, then r_frame_rate will be 50/1.</para>
        /// <see cref="AVStream.r_frame_rate" />
        /// </summary>
        public MediaRational RFrameRate
        {
            get => _ptr->r_frame_rate;
            set => _ptr->r_frame_rate = value;
        }
        
        /// <summary>
        /// <para>Codec parameters associated with this stream.</para>
        /// <para> Allocated and freed by libavformat in avformat_new_stream() and avformat_free_context() respectively.</para>
        /// <see cref="AVStream.codecpar" />
        /// </summary>
        public CodecParameters Codecpar
        {
            get => CodecParameters.FromNative(_ptr->codecpar, isOwner: false);
            set => _ptr->codecpar = value;
        }
        
        /// <summary>
        /// <see cref="AVStream.info" />
        /// </summary>
        public AVStream_info* Info
        {
            get => _ptr->info;
            set => _ptr->info = value;
        }
        
        /// <summary>
        /// <para>number of bits in pts (used for wrapping control).</para>
        /// <see cref="AVStream.pts_wrap_bits" />
        /// </summary>
        public int PtsWrapBits
        {
            get => _ptr->pts_wrap_bits;
            set => _ptr->pts_wrap_bits = value;
        }
        
        /// <summary>
        /// <para>Timestamp corresponding to the last dts sync point.</para>
        /// <see cref="AVStream.first_dts" />
        /// </summary>
        public long FirstDts
        {
            get => _ptr->first_dts;
            set => _ptr->first_dts = value;
        }
        
        /// <summary>
        /// <see cref="AVStream.cur_dts" />
        /// </summary>
        public long CurDts
        {
            get => _ptr->cur_dts;
            set => _ptr->cur_dts = value;
        }
        
        /// <summary>
        /// <see cref="AVStream.last_IP_pts" />
        /// </summary>
        public long LastIpPts
        {
            get => _ptr->last_IP_pts;
            set => _ptr->last_IP_pts = value;
        }
        
        /// <summary>
        /// <see cref="AVStream.last_IP_duration" />
        /// </summary>
        public int LastIpDuration
        {
            get => _ptr->last_IP_duration;
            set => _ptr->last_IP_duration = value;
        }
        
        /// <summary>
        /// <para>Number of packets to buffer for codec probing.</para>
        /// <see cref="AVStream.probe_packets" />
        /// </summary>
        public int ProbePackets
        {
            get => _ptr->probe_packets;
            set => _ptr->probe_packets = value;
        }
        
        /// <summary>
        /// <para>Number of frames that have been demuxed during avformat_find_stream_info().</para>
        /// <see cref="AVStream.codec_info_nb_frames" />
        /// </summary>
        public int CodecInfoNbFrames
        {
            get => _ptr->codec_info_nb_frames;
            set => _ptr->codec_info_nb_frames = value;
        }
        
        /// <summary>
        /// <see cref="AVStream.need_parsing" />
        /// </summary>
        public StreamParseType NeedParsing
        {
            get => (StreamParseType)_ptr->need_parsing;
            set => _ptr->need_parsing = (AVStreamParseType)value;
        }
        
        /// <summary>
        /// <see cref="AVStream.parser" />
        /// </summary>
        public CodecParserContext Parser
        {
            get => CodecParserContext.FromNative(_ptr->parser, isOwner: false);
            set => _ptr->parser = value;
        }
        
        /// <summary>
        /// <para>last packet in packet_buffer for this stream when muxing.</para>
        /// <see cref="AVStream.last_in_packet_buffer" />
        /// </summary>
        public AVPacketList* LastInPacketBuffer
        {
            get => _ptr->last_in_packet_buffer;
            set => _ptr->last_in_packet_buffer = value;
        }
        
        /// <summary>
        /// <see cref="AVStream.probe_data" />
        /// </summary>
        public AVProbeData ProbeData
        {
            get => _ptr->probe_data;
            set => _ptr->probe_data = value;
        }
        
        /// <summary>
        /// <see cref="AVStream.pts_buffer" />
        /// </summary>
        public long_array17 PtsBuffer
        {
            get => _ptr->pts_buffer;
            set => _ptr->pts_buffer = value;
        }
        
        /// <summary>
        /// <para>Only used if the format does not support seeking natively.</para>
        /// <see cref="AVStream.index_entries" />
        /// </summary>
        public AVIndexEntry* IndexEntries
        {
            get => _ptr->index_entries;
            set => _ptr->index_entries = value;
        }
        
        /// <summary>
        /// <see cref="AVStream.nb_index_entries" />
        /// </summary>
        public int NbIndexEntries
        {
            get => _ptr->nb_index_entries;
            set => _ptr->nb_index_entries = value;
        }
        
        /// <summary>
        /// <see cref="AVStream.index_entries_allocated_size" />
        /// </summary>
        public uint IndexEntriesAllocatedSize
        {
            get => _ptr->index_entries_allocated_size;
            set => _ptr->index_entries_allocated_size = value;
        }
        
        /// <summary>
        /// <para>Stream Identifier This is the MPEG-TS stream identifier +1 0 means unknown.</para>
        /// <see cref="AVStream.stream_identifier" />
        /// </summary>
        public int StreamIdentifier
        {
            get => _ptr->stream_identifier;
            set => _ptr->stream_identifier = value;
        }
        
        /// <summary>
        /// <para>Details of the MPEG-TS program which created this stream.</para>
        /// <see cref="AVStream.program_num" />
        /// </summary>
        public int ProgramNum
        {
            get => _ptr->program_num;
            set => _ptr->program_num = value;
        }
        
        /// <summary>
        /// <see cref="AVStream.pmt_version" />
        /// </summary>
        public int PmtVersion
        {
            get => _ptr->pmt_version;
            set => _ptr->pmt_version = value;
        }
        
        /// <summary>
        /// <see cref="AVStream.pmt_stream_idx" />
        /// </summary>
        public int PmtStreamIdx
        {
            get => _ptr->pmt_stream_idx;
            set => _ptr->pmt_stream_idx = value;
        }
        
        /// <summary>
        /// <see cref="AVStream.interleaver_chunk_size" />
        /// </summary>
        public long InterleaverChunkSize
        {
            get => _ptr->interleaver_chunk_size;
            set => _ptr->interleaver_chunk_size = value;
        }
        
        /// <summary>
        /// <see cref="AVStream.interleaver_chunk_duration" />
        /// </summary>
        public long InterleaverChunkDuration
        {
            get => _ptr->interleaver_chunk_duration;
            set => _ptr->interleaver_chunk_duration = value;
        }
        
        /// <summary>
        /// <para>stream probing state -1 -&gt; probing finished 0 -&gt; no probing requested rest -&gt; perform probing with request_probe being the minimum score to accept.</para>
        /// <see cref="AVStream.request_probe" />
        /// </summary>
        public int RequestProbe
        {
            get => _ptr->request_probe;
            set => _ptr->request_probe = value;
        }
        
        /// <summary>
        /// <para>Indicates that everything up to the next keyframe should be discarded.</para>
        /// <see cref="AVStream.skip_to_keyframe" />
        /// </summary>
        public int SkipToKeyframe
        {
            get => _ptr->skip_to_keyframe;
            set => _ptr->skip_to_keyframe = value;
        }
        
        /// <summary>
        /// <para>Number of samples to skip at the start of the frame decoded from the next packet.</para>
        /// <see cref="AVStream.skip_samples" />
        /// </summary>
        public int SkipSamples
        {
            get => _ptr->skip_samples;
            set => _ptr->skip_samples = value;
        }
        
        /// <summary>
        /// <para>If not 0, the number of samples that should be skipped from the start of the stream (the samples are removed from packets with pts==0, which also assumes negative timestamps do not happen).</para>
        /// <para> Intended for use with formats such as mp3 with ad-hoc gapless audio support.</para>
        /// <see cref="AVStream.start_skip_samples" />
        /// </summary>
        public long StartSkipSamples
        {
            get => _ptr->start_skip_samples;
            set => _ptr->start_skip_samples = value;
        }
        
        /// <summary>
        /// <para>If not 0, the first audio sample that should be discarded from the stream.</para>
        /// <para> This is broken by design (needs global sample count), but can&#39;t be avoided for broken by design formats such as mp3 with ad-hoc gapless audio support.</para>
        /// <see cref="AVStream.first_discard_sample" />
        /// </summary>
        public long FirstDiscardSample
        {
            get => _ptr->first_discard_sample;
            set => _ptr->first_discard_sample = value;
        }
        
        /// <summary>
        /// <para>The sample after last sample that is intended to be discarded after first_discard_sample.</para>
        /// <para> Works on frame boundaries only.</para>
        /// <para> Used to prevent early EOF if the gapless info is broken (considered concatenated mp3s).</para>
        /// <see cref="AVStream.last_discard_sample" />
        /// </summary>
        public long LastDiscardSample
        {
            get => _ptr->last_discard_sample;
            set => _ptr->last_discard_sample = value;
        }
        
        /// <summary>
        /// <para>Number of internally decoded frames, used internally in libavformat, do not access its lifetime differs from info which is why it is not in that structure.</para>
        /// <see cref="AVStream.nb_decoded_frames" />
        /// </summary>
        public int NbDecodedFrames
        {
            get => _ptr->nb_decoded_frames;
            set => _ptr->nb_decoded_frames = value;
        }
        
        /// <summary>
        /// <para>Timestamp offset added to timestamps before muxing.</para>
        /// <see cref="AVStream.mux_ts_offset" />
        /// </summary>
        public long MuxTsOffset
        {
            get => _ptr->mux_ts_offset;
            set => _ptr->mux_ts_offset = value;
        }
        
        /// <summary>
        /// <para>Internal data to check for wrapping of the time stamp.</para>
        /// <see cref="AVStream.pts_wrap_reference" />
        /// </summary>
        public long PtsWrapReference
        {
            get => _ptr->pts_wrap_reference;
            set => _ptr->pts_wrap_reference = value;
        }
        
        /// <summary>
        /// <para>Options for behavior, when a wrap is detected.</para>
        /// <see cref="AVStream.pts_wrap_behavior" />
        /// </summary>
        public int PtsWrapBehavior
        {
            get => _ptr->pts_wrap_behavior;
            set => _ptr->pts_wrap_behavior = value;
        }
        
        /// <summary>
        /// <para>Internal data to prevent doing update_initial_durations() twice.</para>
        /// <see cref="AVStream.update_initial_durations_done" />
        /// </summary>
        public int UpdateInitialDurationsDone
        {
            get => _ptr->update_initial_durations_done;
            set => _ptr->update_initial_durations_done = value;
        }
        
        /// <summary>
        /// <para>Internal data to generate dts from pts.</para>
        /// <see cref="AVStream.pts_reorder_error" />
        /// </summary>
        public long_array17 PtsReorderError
        {
            get => _ptr->pts_reorder_error;
            set => _ptr->pts_reorder_error = value;
        }
        
        /// <summary>
        /// <see cref="AVStream.pts_reorder_error_count" />
        /// </summary>
        public byte_array17 PtsReorderErrorCount
        {
            get => _ptr->pts_reorder_error_count;
            set => _ptr->pts_reorder_error_count = value;
        }
        
        /// <summary>
        /// <para>Internal data to analyze DTS and detect faulty mpeg streams.</para>
        /// <see cref="AVStream.last_dts_for_order_check" />
        /// </summary>
        public long LastDtsForOrderCheck
        {
            get => _ptr->last_dts_for_order_check;
            set => _ptr->last_dts_for_order_check = value;
        }
        
        /// <summary>
        /// <see cref="AVStream.dts_ordered" />
        /// </summary>
        public byte DtsOrdered
        {
            get => _ptr->dts_ordered;
            set => _ptr->dts_ordered = value;
        }
        
        /// <summary>
        /// <see cref="AVStream.dts_misordered" />
        /// </summary>
        public byte DtsMisordered
        {
            get => _ptr->dts_misordered;
            set => _ptr->dts_misordered = value;
        }
        
        /// <summary>
        /// <para>Internal data to inject global side data.</para>
        /// <see cref="AVStream.inject_global_side_data" />
        /// </summary>
        public int InjectGlobalSideData
        {
            get => _ptr->inject_global_side_data;
            set => _ptr->inject_global_side_data = value;
        }
        
        /// <summary>
        /// <para>display aspect ratio (0 if unknown) - encoding: unused - decoding: Set by libavformat to calculate sample_aspect_ratio internally.</para>
        /// <see cref="AVStream.display_aspect_ratio" />
        /// </summary>
        public MediaRational DisplayAspectRatio
        {
            get => _ptr->display_aspect_ratio;
            set => _ptr->display_aspect_ratio = value;
        }
        
        /// <summary>
        /// <para>An opaque field for libavformat internal usage.</para>
        /// <para> Must not be accessed in any way by callers.</para>
        /// <see cref="AVStream.internal" />
        /// </summary>
        public AVStreamInternal* Internal
        {
            get => _ptr->@internal;
            set => _ptr->@internal = value;
        }
    }
}
