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
        /// <para>Stream disposition - a combination of AV_DISPOSITION_* flags.</para>
        /// <para> - demuxing: set by libavformat when creating the stream or in avformat_find_stream_info().</para>
        /// <para> - muxing: may be set by the caller before avformat_write_header().</para>
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
        /// <para>Number of bits in timestamps.</para>
        /// <para> Used for wrapping control.</para>
        /// <see cref="AVStream.pts_wrap_bits" />
        /// </summary>
        public int PtsWrapBits
        {
            get => _ptr->pts_wrap_bits;
            set => _ptr->pts_wrap_bits = value;
        }
    }
}
