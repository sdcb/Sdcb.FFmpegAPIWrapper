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
        /// <para>Flags indicating events happening on the stream, a combination of AVSTREAM_EVENT_FLAG_*.</para>
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
        public MediaRational RealFrameRate
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
        /// <see cref="AVStream.unused" />
        /// </summary>
        internal IntPtr Unused
        {
            get => (IntPtr)_ptr->unused;
            set => _ptr->unused = (void*)value;
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
        /// <see cref="AVStream.unused7" />
        /// </summary>
        internal IntPtr Unused7
        {
            get => (IntPtr)_ptr->unused7;
            set => _ptr->unused7 = (void*)value;
        }
        
        /// <summary>
        /// <see cref="AVStream.unused6" />
        /// </summary>
        internal AVProbeData Unused6
        {
            get => _ptr->unused6;
            set => _ptr->unused6 = value;
        }
        
        /// <summary>
        /// <see cref="AVStream.unused5" />
        /// </summary>
        internal long_array17 Unused5
        {
            get => _ptr->unused5;
            set => _ptr->unused5 = value;
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
        /// <see cref="AVStream.unused8" />
        /// </summary>
        internal int Unused8
        {
            get => _ptr->unused8;
            set => _ptr->unused8 = value;
        }
        
        /// <summary>
        /// <see cref="AVStream.unused9" />
        /// </summary>
        internal int Unused9
        {
            get => _ptr->unused9;
            set => _ptr->unused9 = value;
        }
        
        /// <summary>
        /// <see cref="AVStream.unused10" />
        /// </summary>
        internal int Unused10
        {
            get => _ptr->unused10;
            set => _ptr->unused10 = value;
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
