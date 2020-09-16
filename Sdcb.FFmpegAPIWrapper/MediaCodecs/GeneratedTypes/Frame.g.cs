// This file was genereated from LINQPad scripts, DO NOT CHANGE DIRECTLY.

using System;
using Sdcb.FFmpegAPIWrapper.Common;
using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;

namespace Sdcb.FFmpegAPIWrapper.MediaCodecs
{
    /// <summary>
    /// <para>This structure describes decoded (raw) audio or video data.</para>
    /// <see cref="AVFrame" />
    /// </summary>
    public unsafe partial class Frame: FFmpegHandle
    {
        protected AVFrame* Pointer => this;
        
        public static implicit operator AVFrame*(Frame data) => (AVFrame*)data._handle;
        
        protected Frame(AVFrame* ptr, bool isOwner): base((IntPtr)ptr, isOwner)
        {
            if (ptr == null)
            {
                throw new ArgumentNullException(nameof(ptr));
            }
        }
        
        public static Frame FromNative(AVFrame* ptr, bool isOwner) => new Frame(ptr, isOwner);
        
        /// <summary>
        /// <para>pointer to the picture/channel planes.</para>
        /// <para> This might be different from the first allocated byte.</para>
        /// <see cref="AVFrame.data" />
        /// </summary>
        public byte_ptrArray8 Data
        {
            get => Pointer->data;
            set => Pointer->data = value;
        }
        
        /// <summary>
        /// <para>For video, size in bytes of each picture line.</para>
        /// <para> For audio, size in bytes of each plane.</para>
        /// <see cref="AVFrame.linesize" />
        /// </summary>
        public int_array8 Linesize
        {
            get => Pointer->linesize;
            set => Pointer->linesize = value;
        }
        
        /// <summary>
        /// <para>pointers to the data planes/channels.</para>
        /// <see cref="AVFrame.extended_data" />
        /// </summary>
        public byte** ExtendedData
        {
            get => Pointer->extended_data;
            set => Pointer->extended_data = value;
        }
        
        /// <summary>
        /// <para>Video frames only.</para>
        /// <para> The coded dimensions (in pixels) of the video frame, i.</para>
        /// <para>e.</para>
        /// <para> the size of the rectangle that contains some well-defined values.</para>
        /// <see cref="AVFrame.width" />
        /// </summary>
        public int Width
        {
            get => Pointer->width;
            set => Pointer->width = value;
        }
        
        /// <summary>
        /// <para>Video frames only.</para>
        /// <para> The coded dimensions (in pixels) of the video frame, i.</para>
        /// <para>e.</para>
        /// <para> the size of the rectangle that contains some well-defined values.</para>
        /// <see cref="AVFrame.height" />
        /// </summary>
        public int Height
        {
            get => Pointer->height;
            set => Pointer->height = value;
        }
        
        /// <summary>
        /// <para>number of audio samples (per channel) described by this frame.</para>
        /// <see cref="AVFrame.nb_samples" />
        /// </summary>
        public int NbSamples
        {
            get => Pointer->nb_samples;
            set => Pointer->nb_samples = value;
        }
        
        /// <summary>
        /// <para>format of the frame, -1 if unknown or unset Values correspond to enum AVPixelFormat for video frames, enum AVSampleFormat for audio).</para>
        /// <see cref="AVFrame.format" />
        /// </summary>
        public int Format
        {
            get => Pointer->format;
            set => Pointer->format = value;
        }
        
        /// <summary>
        /// <para>1 -&gt; keyframe, 0-&gt; not.</para>
        /// <see cref="AVFrame.key_frame" />
        /// </summary>
        public int KeyFrame
        {
            get => Pointer->key_frame;
            set => Pointer->key_frame = value;
        }
        
        /// <summary>
        /// <para>Picture type of the frame.</para>
        /// <see cref="AVFrame.pict_type" />
        /// </summary>
        public PictureType PictureType
        {
            get => (PictureType)Pointer->pict_type;
            set => Pointer->pict_type = (AVPictureType)value;
        }
        
        /// <summary>
        /// <para>Sample aspect ratio for the video frame, 0/1 if unknown/unspecified.</para>
        /// <see cref="AVFrame.sample_aspect_ratio" />
        /// </summary>
        public MediaRational SampleAspectRatio
        {
            get => Pointer->sample_aspect_ratio;
            set => Pointer->sample_aspect_ratio = value;
        }
        
        /// <summary>
        /// <para>Presentation timestamp in time_base units (time when frame should be shown to user).</para>
        /// <see cref="AVFrame.pts" />
        /// </summary>
        public long Pts
        {
            get => Pointer->pts;
            set => Pointer->pts = value;
        }
        
        /// <summary>
        /// <para>PTS copied from the AVPacket that was decoded to produce this frame.</para>
        /// <see cref="AVFrame.pkt_pts" />
        /// </summary>
        public long PacketPts
        {
            get => Pointer->pkt_pts;
            set => Pointer->pkt_pts = value;
        }
        
        /// <summary>
        /// <para>DTS copied from the AVPacket that triggered returning this frame.</para>
        /// <para> (if frame threading isn&#39;t used) This is also the Presentation time of this AVFrame calculated from only AVPacket.</para>
        /// <para>dts values without pts values.</para>
        /// <see cref="AVFrame.pkt_dts" />
        /// </summary>
        public long PacketDts
        {
            get => Pointer->pkt_dts;
            set => Pointer->pkt_dts = value;
        }
        
        /// <summary>
        /// <para>picture number in bitstream order.</para>
        /// <see cref="AVFrame.coded_picture_number" />
        /// </summary>
        public int CodedPictureNumber
        {
            get => Pointer->coded_picture_number;
            set => Pointer->coded_picture_number = value;
        }
        
        /// <summary>
        /// <para>picture number in display order.</para>
        /// <see cref="AVFrame.display_picture_number" />
        /// </summary>
        public int DisplayPictureNumber
        {
            get => Pointer->display_picture_number;
            set => Pointer->display_picture_number = value;
        }
        
        /// <summary>
        /// <para>quality (between 1 (good) and FF_LAMBDA_MAX (bad)).</para>
        /// <see cref="AVFrame.quality" />
        /// </summary>
        public int Quality
        {
            get => Pointer->quality;
            set => Pointer->quality = value;
        }
        
        /// <summary>
        /// <para>for some private data of the user.</para>
        /// <see cref="AVFrame.opaque" />
        /// </summary>
        public IntPtr Opaque
        {
            get => (IntPtr)Pointer->opaque;
            set => Pointer->opaque = (void*)value;
        }
        
        /// <summary>
        /// <see cref="AVFrame.error" />
        /// </summary>
        public ulong_array8 Error
        {
            get => Pointer->error;
            set => Pointer->error = value;
        }
        
        /// <summary>
        /// <para>When decoding, this signals how much the picture must be delayed.</para>
        /// <para> extra_delay = repeat_pict / (2*fps).</para>
        /// <see cref="AVFrame.repeat_pict" />
        /// </summary>
        public int RepeatPict
        {
            get => Pointer->repeat_pict;
            set => Pointer->repeat_pict = value;
        }
        
        /// <summary>
        /// <para>The content of the picture is interlaced.</para>
        /// <see cref="AVFrame.interlaced_frame" />
        /// </summary>
        public int InterlacedFrame
        {
            get => Pointer->interlaced_frame;
            set => Pointer->interlaced_frame = value;
        }
        
        /// <summary>
        /// <para>If the content is interlaced, is top field displayed first.</para>
        /// <see cref="AVFrame.top_field_first" />
        /// </summary>
        public int TopFieldFirst
        {
            get => Pointer->top_field_first;
            set => Pointer->top_field_first = value;
        }
        
        /// <summary>
        /// <para>Tell user application that palette has changed from previous frame.</para>
        /// <see cref="AVFrame.palette_has_changed" />
        /// </summary>
        public int PaletteHasChanged
        {
            get => Pointer->palette_has_changed;
            set => Pointer->palette_has_changed = value;
        }
        
        /// <summary>
        /// <para>reordered opaque 64 bits (generally an integer or a double precision float PTS but can be anything).</para>
        /// <para> The user sets AVCodecContext.</para>
        /// <para>reordered_opaque to represent the input at that time, the decoder reorders values as needed and sets AVFrame.</para>
        /// <para>reordered_opaque to exactly one of the values provided by the user through AVCodecContext.</para>
        /// <para>reordered_opaque.</para>
        /// <see cref="AVFrame.reordered_opaque" />
        /// </summary>
        public long ReorderedOpaque
        {
            get => Pointer->reordered_opaque;
            set => Pointer->reordered_opaque = value;
        }
        
        /// <summary>
        /// <para>Sample rate of the audio data.</para>
        /// <see cref="AVFrame.sample_rate" />
        /// </summary>
        public int SampleRate
        {
            get => Pointer->sample_rate;
            set => Pointer->sample_rate = value;
        }
        
        /// <summary>
        /// <para>Channel layout of the audio data.</para>
        /// <see cref="AVFrame.channel_layout" />
        /// </summary>
        public ulong ChannelLayout
        {
            get => Pointer->channel_layout;
            set => Pointer->channel_layout = value;
        }
        
        /// <summary>
        /// <para>AVBuffer references backing the data for this frame.</para>
        /// <para> If all elements of this array are NULL, then this frame is not reference counted.</para>
        /// <para> This array must be filled contiguously -- if buf[i] is non-NULL then buf[j] must also be non-NULL for all j &lt; i.</para>
        /// <see cref="AVFrame.buf" />
        /// </summary>
        public AVBufferRef_ptrArray8 Buf
        {
            get => Pointer->buf;
            set => Pointer->buf = value;
        }
        
        /// <summary>
        /// <para>For planar audio which requires more than AV_NUM_DATA_POINTERS AVBufferRef pointers, this array will hold all the references which cannot fit into AVFrame.</para>
        /// <para>buf.</para>
        /// <see cref="AVFrame.extended_buf" />
        /// </summary>
        public AVBufferRef** ExtendedBuf
        {
            get => Pointer->extended_buf;
            set => Pointer->extended_buf = value;
        }
        
        /// <summary>
        /// <para>Number of elements in extended_buf.</para>
        /// <see cref="AVFrame.nb_extended_buf" />
        /// </summary>
        public int NbExtendedBuf
        {
            get => Pointer->nb_extended_buf;
            set => Pointer->nb_extended_buf = value;
        }
        
        /// <summary>
        /// <see cref="AVFrame.side_data" />
        /// </summary>
        public AVFrameSideData** SideData
        {
            get => Pointer->side_data;
            set => Pointer->side_data = value;
        }
        
        /// <summary>
        /// <see cref="AVFrame.nb_side_data" />
        /// </summary>
        public int NbSideData
        {
            get => Pointer->nb_side_data;
            set => Pointer->nb_side_data = value;
        }
        
        /// <summary>
        /// <para>Frame flags, a combination of.</para>
        /// <see cref="AVFrame.flags" />
        /// </summary>
        public int Flags
        {
            get => Pointer->flags;
            set => Pointer->flags = value;
        }
        
        /// <summary>
        /// <para>MPEG vs JPEG YUV range.</para>
        /// <para> - encoding: Set by user - decoding: Set by libavcodec.</para>
        /// <see cref="AVFrame.color_range" />
        /// </summary>
        public ColorRange ColorRange
        {
            get => (ColorRange)Pointer->color_range;
            set => Pointer->color_range = (AVColorRange)value;
        }
        
        /// <summary>
        /// <see cref="AVFrame.color_primaries" />
        /// </summary>
        public ColorPrimaries ColorPrimaries
        {
            get => (ColorPrimaries)Pointer->color_primaries;
            set => Pointer->color_primaries = (AVColorPrimaries)value;
        }
        
        /// <summary>
        /// <see cref="AVFrame.color_trc" />
        /// </summary>
        public ColorTransferCharacteristic ColorTrc
        {
            get => (ColorTransferCharacteristic)Pointer->color_trc;
            set => Pointer->color_trc = (AVColorTransferCharacteristic)value;
        }
        
        /// <summary>
        /// <para>YUV colorspace type.</para>
        /// <para> - encoding: Set by user - decoding: Set by libavcodec.</para>
        /// <see cref="AVFrame.colorspace" />
        /// </summary>
        public ColorSpace Colorspace
        {
            get => (ColorSpace)Pointer->colorspace;
            set => Pointer->colorspace = (AVColorSpace)value;
        }
        
        /// <summary>
        /// <see cref="AVFrame.chroma_location" />
        /// </summary>
        public ChromaLocation ChromaLocation
        {
            get => (ChromaLocation)Pointer->chroma_location;
            set => Pointer->chroma_location = (AVChromaLocation)value;
        }
        
        /// <summary>
        /// <para>frame timestamp estimated using various heuristics, in stream time base - encoding: unused - decoding: set by libavcodec, read by user.</para>
        /// <see cref="AVFrame.best_effort_timestamp" />
        /// </summary>
        public long BestEffortTimestamp
        {
            get => Pointer->best_effort_timestamp;
            set => Pointer->best_effort_timestamp = value;
        }
        
        /// <summary>
        /// <para>reordered pos from the last AVPacket that has been input into the decoder - encoding: unused - decoding: Read by user.</para>
        /// <see cref="AVFrame.pkt_pos" />
        /// </summary>
        public long PacketPos
        {
            get => Pointer->pkt_pos;
            set => Pointer->pkt_pos = value;
        }
        
        /// <summary>
        /// <para>duration of the corresponding packet, expressed in AVStream-&gt;time_base units, 0 if unknown.</para>
        /// <para> - encoding: unused - decoding: Read by user.</para>
        /// <see cref="AVFrame.pkt_duration" />
        /// </summary>
        public long PacketDuration
        {
            get => Pointer->pkt_duration;
            set => Pointer->pkt_duration = value;
        }
        
        /// <summary>
        /// <para>metadata.</para>
        /// <para> - encoding: Set by user.</para>
        /// <para> - decoding: Set by libavcodec.</para>
        /// <see cref="AVFrame.metadata" />
        /// </summary>
        public AVDictionary* Metadata
        {
            get => Pointer->metadata;
            set => Pointer->metadata = value;
        }
        
        /// <summary>
        /// <para>decode error flags of the frame, set to a combination of FF_DECODE_ERROR_xxx flags if the decoder produced a frame, but there were errors during the decoding.</para>
        /// <para> - encoding: unused - decoding: set by libavcodec, read by user.</para>
        /// <see cref="AVFrame.decode_error_flags" />
        /// </summary>
        public int DecodeErrorFlags
        {
            get => Pointer->decode_error_flags;
            set => Pointer->decode_error_flags = value;
        }
        
        /// <summary>
        /// <para>number of audio channels, only used for audio.</para>
        /// <para> - encoding: unused - decoding: Read by user.</para>
        /// <see cref="AVFrame.channels" />
        /// </summary>
        public int Channels
        {
            get => Pointer->channels;
            set => Pointer->channels = value;
        }
        
        /// <summary>
        /// <para>size of the corresponding packet containing the compressed frame.</para>
        /// <para> It is set to a negative value if unknown.</para>
        /// <para> - encoding: unused - decoding: set by libavcodec, read by user.</para>
        /// <see cref="AVFrame.pkt_size" />
        /// </summary>
        public int PacketSize
        {
            get => Pointer->pkt_size;
            set => Pointer->pkt_size = value;
        }
        
        /// <summary>
        /// <para>QP table.</para>
        /// <see cref="AVFrame.qscale_table" />
        /// </summary>
        public sbyte* QscaleTable
        {
            get => Pointer->qscale_table;
            set => Pointer->qscale_table = value;
        }
        
        /// <summary>
        /// <para>QP store stride.</para>
        /// <see cref="AVFrame.qstride" />
        /// </summary>
        public int Qstride
        {
            get => Pointer->qstride;
            set => Pointer->qstride = value;
        }
        
        /// <summary>
        /// <see cref="AVFrame.qscale_type" />
        /// </summary>
        public int QscaleType
        {
            get => Pointer->qscale_type;
            set => Pointer->qscale_type = value;
        }
        
        /// <summary>
        /// <see cref="AVFrame.qp_table_buf" />
        /// </summary>
        public AVBufferRef* QpTableBuf
        {
            get => Pointer->qp_table_buf;
            set => Pointer->qp_table_buf = value;
        }
        
        /// <summary>
        /// <para>For hwaccel-format frames, this should be a reference to the AVHWFramesContext describing the frame.</para>
        /// <see cref="AVFrame.hw_frames_ctx" />
        /// </summary>
        public AVBufferRef* HwFramesContext
        {
            get => Pointer->hw_frames_ctx;
            set => Pointer->hw_frames_ctx = value;
        }
        
        /// <summary>
        /// <para>AVBufferRef for free use by the API user.</para>
        /// <para> FFmpeg will never check the contents of the buffer ref.</para>
        /// <para> FFmpeg calls av_buffer_unref() on it when the frame is unreferenced.</para>
        /// <para> av_frame_copy_props() calls create a new reference with av_buffer_ref() for the target frame&#39;s opaque_ref field.</para>
        /// <see cref="AVFrame.opaque_ref" />
        /// </summary>
        public AVBufferRef* OpaqueRef
        {
            get => Pointer->opaque_ref;
            set => Pointer->opaque_ref = value;
        }
        
        /// <summary>
        /// <para>cropping Video frames only.</para>
        /// <para> The number of pixels to discard from the the top/bottom/left/right border of the frame to obtain the sub-rectangle of the frame intended for presentation.</para>
        /// <para> @{.</para>
        /// <see cref="AVFrame.crop_top" />
        /// </summary>
        public ulong CropTop
        {
            get => Pointer->crop_top;
            set => Pointer->crop_top = value;
        }
        
        /// <summary>
        /// <see cref="AVFrame.crop_bottom" />
        /// </summary>
        public ulong CropBottom
        {
            get => Pointer->crop_bottom;
            set => Pointer->crop_bottom = value;
        }
        
        /// <summary>
        /// <see cref="AVFrame.crop_left" />
        /// </summary>
        public ulong CropLeft
        {
            get => Pointer->crop_left;
            set => Pointer->crop_left = value;
        }
        
        /// <summary>
        /// <see cref="AVFrame.crop_right" />
        /// </summary>
        public ulong CropRight
        {
            get => Pointer->crop_right;
            set => Pointer->crop_right = value;
        }
        
        /// <summary>
        /// <para>AVBufferRef for internal use by a single libav* library.</para>
        /// <para> Must not be used to transfer data between libraries.</para>
        /// <para> Has to be NULL when ownership of the frame leaves the respective library.</para>
        /// <see cref="AVFrame.private_ref" />
        /// </summary>
        public AVBufferRef* PrivateRef
        {
            get => Pointer->private_ref;
            set => Pointer->private_ref = value;
        }
    }
}
