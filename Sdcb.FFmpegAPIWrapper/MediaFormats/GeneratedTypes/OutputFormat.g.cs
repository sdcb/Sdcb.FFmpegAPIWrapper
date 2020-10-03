// This file was genereated from LINQPad scripts, DO NOT CHANGE DIRECTLY.

using System;
using Sdcb.FFmpegAPIWrapper.Common;
using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;
using Sdcb.FFmpegAPIWrapper.MediaCodecs;

namespace Sdcb.FFmpegAPIWrapper.MediaFormats
{
    /// <summary>
    /// <para>@{.</para>
    /// <see cref="AVOutputFormat" />
    /// </summary>
    public unsafe partial class OutputFormat : FFmpegSafeObject
    {
        protected AVOutputFormat* Pointer => this;
        
        public static implicit operator AVOutputFormat*(OutputFormat data) => data != null ? (AVOutputFormat*)data._nativePointer : null;
        
        protected OutputFormat(AVOutputFormat* ptr, bool isOwner): base(NativeUtils.NotNull((IntPtr)ptr), isOwner)
        {
        }
        
        public static OutputFormat FromNative(AVOutputFormat* ptr, bool isOwner) => new OutputFormat(ptr, isOwner);
        
        /// <summary>
        /// <see cref="AVOutputFormat.name" />
        /// </summary>
        public string Name
        {
            get => System.Runtime.InteropServices.Marshal.PtrToStringUTF8((IntPtr)Pointer->name);
            set
            {
                if (Pointer->name != null)
                {
                    av_free(Pointer->name);
                    Pointer->name = null;
                }
        
                if (value != null)
                {
                    Pointer->name = av_strdup(value);
                }
            }
        }
        
        
        /// <summary>
        /// <para>Descriptive name for the format, meant to be more human-readable than name.</para>
        /// <para> You should use the NULL_IF_CONFIG_SMALL() macro to define it.</para>
        /// <see cref="AVOutputFormat.long_name" />
        /// </summary>
        public string LongName
        {
            get => System.Runtime.InteropServices.Marshal.PtrToStringUTF8((IntPtr)Pointer->long_name);
            set
            {
                if (Pointer->long_name != null)
                {
                    av_free(Pointer->long_name);
                    Pointer->long_name = null;
                }
        
                if (value != null)
                {
                    Pointer->long_name = av_strdup(value);
                }
            }
        }
        
        
        /// <summary>
        /// <see cref="AVOutputFormat.mime_type" />
        /// </summary>
        public string MimeType
        {
            get => System.Runtime.InteropServices.Marshal.PtrToStringUTF8((IntPtr)Pointer->mime_type);
            set
            {
                if (Pointer->mime_type != null)
                {
                    av_free(Pointer->mime_type);
                    Pointer->mime_type = null;
                }
        
                if (value != null)
                {
                    Pointer->mime_type = av_strdup(value);
                }
            }
        }
        
        
        /// <summary>
        /// <para>comma-separated filename extensions.</para>
        /// <see cref="AVOutputFormat.extensions" />
        /// </summary>
        public IntPtr Extensions
        {
            get => (IntPtr)Pointer->extensions;
            set => Pointer->extensions = (byte*)value;
        }
        
        /// <summary>
        /// <para>default audio codec.</para>
        /// <see cref="AVOutputFormat.audio_codec" />
        /// </summary>
        public CodecID AudioCodec
        {
            get => (CodecID)Pointer->audio_codec;
            set => Pointer->audio_codec = (AVCodecID)value;
        }
        
        /// <summary>
        /// <para>default video codec.</para>
        /// <see cref="AVOutputFormat.video_codec" />
        /// </summary>
        public CodecID VideoCodec
        {
            get => (CodecID)Pointer->video_codec;
            set => Pointer->video_codec = (AVCodecID)value;
        }
        
        /// <summary>
        /// <para>default subtitle codec.</para>
        /// <see cref="AVOutputFormat.subtitle_codec" />
        /// </summary>
        public CodecID SubtitleCodec
        {
            get => (CodecID)Pointer->subtitle_codec;
            set => Pointer->subtitle_codec = (AVCodecID)value;
        }
        
        /// <summary>
        /// <para>can use flags: AVFMT_NOFILE, AVFMT_NEEDNUMBER, AVFMT_GLOBALHEADER, AVFMT_NOTIMESTAMPS, AVFMT_VARIABLE_FPS, AVFMT_NODIMENSIONS, AVFMT_NOSTREAMS, AVFMT_ALLOW_FLUSH, AVFMT_TS_NONSTRICT, AVFMT_TS_NEGATIVE.</para>
        /// <see cref="AVOutputFormat.flags" />
        /// </summary>
        public int Flags
        {
            get => Pointer->flags;
            set => Pointer->flags = value;
        }
        
        /// <summary>
        /// <para>List of supported codec_id-codec_tag pairs, ordered by &quot;better choice first&quot;.</para>
        /// <para> The arrays are all terminated by AV_CODEC_ID_NONE.</para>
        /// <see cref="AVOutputFormat.codec_tag" />
        /// </summary>
        public AVCodecTag** CodecTag
        {
            get => Pointer->codec_tag;
            set => Pointer->codec_tag = value;
        }
        
        /// <summary>
        /// <para>AVClass for the private context.</para>
        /// <see cref="AVOutputFormat.priv_class" />
        /// </summary>
        public FFmpegClass PrivateClass
        {
            get => FFmpegClass.FromNative(Pointer->priv_class);
            set => Pointer->priv_class = value;
        }
        
        /// <summary>
        /// <see cref="AVOutputFormat.next" />
        /// </summary>
        public OutputFormat Next
        {
            get => OutputFormat.FromNative(Pointer->next, isOwner: false);
            set => Pointer->next = value;
        }
        
        /// <summary>
        /// <para>size of private data so that it can be allocated in the wrapper.</para>
        /// <see cref="AVOutputFormat.priv_data_size" />
        /// </summary>
        public int PrivateDataSize
        {
            get => Pointer->priv_data_size;
            set => Pointer->priv_data_size = value;
        }
        
        /// <summary>
        /// <see cref="AVOutputFormat.write_header" />
        /// </summary>
        internal AVOutputFormat_write_header_func WriteHeader
        {
            get => Pointer->write_header;
            set => Pointer->write_header = value;
        }
        
        /// <summary>
        /// <para>Write a packet.</para>
        /// <para> If AVFMT_ALLOW_FLUSH is set in flags, pkt can be NULL in order to flush data buffered in the muxer.</para>
        /// <para> When flushing, return 0 if there still is more data to flush, or 1 if everything was flushed and there is no more buffered data.</para>
        /// <see cref="AVOutputFormat.write_packet" />
        /// </summary>
        internal AVOutputFormat_write_packet_func WritePacket
        {
            get => Pointer->write_packet;
            set => Pointer->write_packet = value;
        }
        
        /// <summary>
        /// <see cref="AVOutputFormat.write_trailer" />
        /// </summary>
        internal AVOutputFormat_write_trailer_func WriteTrailer
        {
            get => Pointer->write_trailer;
            set => Pointer->write_trailer = value;
        }
        
        /// <summary>
        /// <para>A format-specific function for interleavement.</para>
        /// <para> If unset, packets will be interleaved by dts.</para>
        /// <see cref="AVOutputFormat.interleave_packet" />
        /// </summary>
        internal AVOutputFormat_interleave_packet_func InterleavePacket
        {
            get => Pointer->interleave_packet;
            set => Pointer->interleave_packet = value;
        }
        
        /// <summary>
        /// <para>Test if the given codec can be stored in this container.</para>
        /// <see cref="AVOutputFormat.query_codec" />
        /// </summary>
        internal AVOutputFormat_query_codec_func QueryCodec
        {
            get => Pointer->query_codec;
            set => Pointer->query_codec = value;
        }
        
        /// <summary>
        /// <see cref="AVOutputFormat.get_output_timestamp" />
        /// </summary>
        internal AVOutputFormat_get_output_timestamp_func GetOutputTimestamp
        {
            get => Pointer->get_output_timestamp;
            set => Pointer->get_output_timestamp = value;
        }
        
        /// <summary>
        /// <para>Allows sending messages from application to device.</para>
        /// <see cref="AVOutputFormat.control_message" />
        /// </summary>
        internal AVOutputFormat_control_message_func ControlMessage
        {
            get => Pointer->control_message;
            set => Pointer->control_message = value;
        }
        
        /// <summary>
        /// <para>Write an uncoded AVFrame.</para>
        /// <see cref="AVOutputFormat.write_uncoded_frame" />
        /// </summary>
        internal AVOutputFormat_write_uncoded_frame_func WriteUncodedFrame
        {
            get => Pointer->write_uncoded_frame;
            set => Pointer->write_uncoded_frame = value;
        }
        
        /// <summary>
        /// <para>Returns device list with it properties.</para>
        /// <see cref="AVOutputFormat.get_device_list" />
        /// </summary>
        internal AVOutputFormat_get_device_list_func GetDeviceList
        {
            get => Pointer->get_device_list;
            set => Pointer->get_device_list = value;
        }
        
        /// <summary>
        /// <para>Initialize device capabilities submodule.</para>
        /// <see cref="AVOutputFormat.create_device_capabilities" />
        /// </summary>
        internal AVOutputFormat_create_device_capabilities_func CreateDeviceCapabilities
        {
            get => Pointer->create_device_capabilities;
            set => Pointer->create_device_capabilities = value;
        }
        
        /// <summary>
        /// <para>Free device capabilities submodule.</para>
        /// <see cref="AVOutputFormat.free_device_capabilities" />
        /// </summary>
        internal AVOutputFormat_free_device_capabilities_func FreeDeviceCapabilities
        {
            get => Pointer->free_device_capabilities;
            set => Pointer->free_device_capabilities = value;
        }
        
        /// <summary>
        /// <para>default data codec.</para>
        /// <see cref="AVOutputFormat.data_codec" />
        /// </summary>
        public CodecID DataCodec
        {
            get => (CodecID)Pointer->data_codec;
            set => Pointer->data_codec = (AVCodecID)value;
        }
        
        /// <summary>
        /// <para>Initialize format.</para>
        /// <para> May allocate data here, and set any AVFormatContext or AVStream parameters that need to be set before packets are sent.</para>
        /// <para> This method must not write output.</para>
        /// <see cref="AVOutputFormat.init" />
        /// </summary>
        internal AVOutputFormat_init_func Init
        {
            get => Pointer->init;
            set => Pointer->init = value;
        }
        
        /// <summary>
        /// <para>Deinitialize format.</para>
        /// <para> If present, this is called whenever the muxer is being destroyed, regardless of whether or not the header has been written.</para>
        /// <see cref="AVOutputFormat.deinit" />
        /// </summary>
        internal AVOutputFormat_deinit_func Deinit
        {
            get => Pointer->deinit;
            set => Pointer->deinit = value;
        }
        
        /// <summary>
        /// <para>Set up any necessary bitstream filtering and extract any extra data needed for the global header.</para>
        /// <para> Return 0 if more packets from this stream must be checked; 1 if not.</para>
        /// <see cref="AVOutputFormat.check_bitstream" />
        /// </summary>
        internal AVOutputFormat_check_bitstream_func CheckBitstream
        {
            get => Pointer->check_bitstream;
            set => Pointer->check_bitstream = value;
        }
    }
}
