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
    public unsafe partial struct OutputFormat
    {
        private AVOutputFormat* _ptr;
        
        public static implicit operator AVOutputFormat*(OutputFormat data) => (AVOutputFormat*)data._ptr;
        
        private OutputFormat(AVOutputFormat* ptr)
        {
            if (ptr == null)
            {
                throw new ArgumentNullException(nameof(ptr));
            }
            _ptr = ptr;
        }
        
        public static OutputFormat FromNative(AVOutputFormat* ptr) => new OutputFormat(ptr);
        
        /// <summary>
        /// <see cref="AVOutputFormat.name" />
        /// </summary>
        public string Name
        {
            get => System.Runtime.InteropServices.Marshal.PtrToStringUTF8((IntPtr)_ptr->name);
            set
            {
                if (_ptr->name != null)
                {
                    av_free(_ptr->name);
                    _ptr->name = null;
                }
        
                if (value != null)
                {
                    _ptr->name = av_strdup(value);
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
            get => System.Runtime.InteropServices.Marshal.PtrToStringUTF8((IntPtr)_ptr->long_name);
            set
            {
                if (_ptr->long_name != null)
                {
                    av_free(_ptr->long_name);
                    _ptr->long_name = null;
                }
        
                if (value != null)
                {
                    _ptr->long_name = av_strdup(value);
                }
            }
        }
        
        
        /// <summary>
        /// <see cref="AVOutputFormat.mime_type" />
        /// </summary>
        public string MimeType
        {
            get => System.Runtime.InteropServices.Marshal.PtrToStringUTF8((IntPtr)_ptr->mime_type);
            set
            {
                if (_ptr->mime_type != null)
                {
                    av_free(_ptr->mime_type);
                    _ptr->mime_type = null;
                }
        
                if (value != null)
                {
                    _ptr->mime_type = av_strdup(value);
                }
            }
        }
        
        
        /// <summary>
        /// <para>comma-separated filename extensions.</para>
        /// <see cref="AVOutputFormat.extensions" />
        /// </summary>
        public string Extensions
        {
            get => System.Runtime.InteropServices.Marshal.PtrToStringUTF8((IntPtr)_ptr->extensions);
            set
            {
                if (_ptr->extensions != null)
                {
                    av_free(_ptr->extensions);
                    _ptr->extensions = null;
                }
        
                if (value != null)
                {
                    _ptr->extensions = av_strdup(value);
                }
            }
        }
        
        
        /// <summary>
        /// <para>default audio codec.</para>
        /// <see cref="AVOutputFormat.audio_codec" />
        /// </summary>
        public CodecID AudioCodec
        {
            get => (CodecID)_ptr->audio_codec;
            set => _ptr->audio_codec = (AVCodecID)value;
        }
        
        /// <summary>
        /// <para>default video codec.</para>
        /// <see cref="AVOutputFormat.video_codec" />
        /// </summary>
        public CodecID VideoCodec
        {
            get => (CodecID)_ptr->video_codec;
            set => _ptr->video_codec = (AVCodecID)value;
        }
        
        /// <summary>
        /// <para>default subtitle codec.</para>
        /// <see cref="AVOutputFormat.subtitle_codec" />
        /// </summary>
        public CodecID SubtitleCodec
        {
            get => (CodecID)_ptr->subtitle_codec;
            set => _ptr->subtitle_codec = (AVCodecID)value;
        }
        
        /// <summary>
        /// <para>can use flags: AVFMT_NOFILE, AVFMT_NEEDNUMBER, AVFMT_GLOBALHEADER, AVFMT_NOTIMESTAMPS, AVFMT_VARIABLE_FPS, AVFMT_NODIMENSIONS, AVFMT_NOSTREAMS, AVFMT_ALLOW_FLUSH, AVFMT_TS_NONSTRICT, AVFMT_TS_NEGATIVE.</para>
        /// <see cref="AVOutputFormat.flags" />
        /// </summary>
        public int Flags
        {
            get => _ptr->flags;
            set => _ptr->flags = value;
        }
        
        /// <summary>
        /// <para>List of supported codec_id-codec_tag pairs, ordered by &quot;better choice first&quot;.</para>
        /// <para> The arrays are all terminated by AV_CODEC_ID_NONE.</para>
        /// <see cref="AVOutputFormat.codec_tag" />
        /// </summary>
        public AVCodecTag** CodecTag
        {
            get => _ptr->codec_tag;
            set => _ptr->codec_tag = value;
        }
        
        /// <summary>
        /// <para>AVClass for the private context.</para>
        /// <see cref="AVOutputFormat.priv_class" />
        /// </summary>
        public FFmpegClass PrivateClass
        {
            get => FFmpegClass.FromNative(_ptr->priv_class);
            set => _ptr->priv_class = value;
        }
        
        /// <summary>
        /// <see cref="AVOutputFormat.next" />
        /// </summary>
        public OutputFormat Next
        {
            get => OutputFormat.FromNative(_ptr->next);
            set => _ptr->next = value;
        }
        
        /// <summary>
        /// <para>size of private data so that it can be allocated in the wrapper.</para>
        /// <see cref="AVOutputFormat.priv_data_size" />
        /// </summary>
        public int PrivateDataSize
        {
            get => _ptr->priv_data_size;
            set => _ptr->priv_data_size = value;
        }
        
        /// <summary>
        /// <see cref="AVOutputFormat.write_header" />
        /// </summary>
        internal AVOutputFormat_write_header_func WriteHeader
        {
            get => _ptr->write_header;
            set => _ptr->write_header = value;
        }
        
        /// <summary>
        /// <para>Write a packet.</para>
        /// <para> If AVFMT_ALLOW_FLUSH is set in flags, pkt can be NULL in order to flush data buffered in the muxer.</para>
        /// <para> When flushing, return 0 if there still is more data to flush, or 1 if everything was flushed and there is no more buffered data.</para>
        /// <see cref="AVOutputFormat.write_packet" />
        /// </summary>
        internal AVOutputFormat_write_packet_func WritePacket
        {
            get => _ptr->write_packet;
            set => _ptr->write_packet = value;
        }
        
        /// <summary>
        /// <see cref="AVOutputFormat.write_trailer" />
        /// </summary>
        internal AVOutputFormat_write_trailer_func WriteTrailer
        {
            get => _ptr->write_trailer;
            set => _ptr->write_trailer = value;
        }
        
        /// <summary>
        /// <para>A format-specific function for interleavement.</para>
        /// <para> If unset, packets will be interleaved by dts.</para>
        /// <see cref="AVOutputFormat.interleave_packet" />
        /// </summary>
        internal AVOutputFormat_interleave_packet_func InterleavePacket
        {
            get => _ptr->interleave_packet;
            set => _ptr->interleave_packet = value;
        }
        
        /// <summary>
        /// <para>Test if the given codec can be stored in this container.</para>
        /// <see cref="AVOutputFormat.query_codec" />
        /// </summary>
        internal AVOutputFormat_query_codec_func QueryCodec
        {
            get => _ptr->query_codec;
            set => _ptr->query_codec = value;
        }
        
        /// <summary>
        /// <see cref="AVOutputFormat.get_output_timestamp" />
        /// </summary>
        internal AVOutputFormat_get_output_timestamp_func GetOutputTimestamp
        {
            get => _ptr->get_output_timestamp;
            set => _ptr->get_output_timestamp = value;
        }
        
        /// <summary>
        /// <para>Allows sending messages from application to device.</para>
        /// <see cref="AVOutputFormat.control_message" />
        /// </summary>
        internal AVOutputFormat_control_message_func ControlMessage
        {
            get => _ptr->control_message;
            set => _ptr->control_message = value;
        }
        
        /// <summary>
        /// <para>Write an uncoded AVFrame.</para>
        /// <see cref="AVOutputFormat.write_uncoded_frame" />
        /// </summary>
        internal AVOutputFormat_write_uncoded_frame_func WriteUncodedFrame
        {
            get => _ptr->write_uncoded_frame;
            set => _ptr->write_uncoded_frame = value;
        }
        
        /// <summary>
        /// <para>Returns device list with it properties.</para>
        /// <see cref="AVOutputFormat.get_device_list" />
        /// </summary>
        internal AVOutputFormat_get_device_list_func GetDeviceList
        {
            get => _ptr->get_device_list;
            set => _ptr->get_device_list = value;
        }
        
        /// <summary>
        /// <para>Initialize device capabilities submodule.</para>
        /// <see cref="AVOutputFormat.create_device_capabilities" />
        /// </summary>
        internal AVOutputFormat_create_device_capabilities_func CreateDeviceCapabilities
        {
            get => _ptr->create_device_capabilities;
            set => _ptr->create_device_capabilities = value;
        }
        
        /// <summary>
        /// <para>Free device capabilities submodule.</para>
        /// <see cref="AVOutputFormat.free_device_capabilities" />
        /// </summary>
        internal AVOutputFormat_free_device_capabilities_func FreeDeviceCapabilities
        {
            get => _ptr->free_device_capabilities;
            set => _ptr->free_device_capabilities = value;
        }
        
        /// <summary>
        /// <para>default data codec.</para>
        /// <see cref="AVOutputFormat.data_codec" />
        /// </summary>
        public CodecID DataCodec
        {
            get => (CodecID)_ptr->data_codec;
            set => _ptr->data_codec = (AVCodecID)value;
        }
        
        /// <summary>
        /// <para>Initialize format.</para>
        /// <para> May allocate data here, and set any AVFormatContext or AVStream parameters that need to be set before packets are sent.</para>
        /// <para> This method must not write output.</para>
        /// <see cref="AVOutputFormat.init" />
        /// </summary>
        internal AVOutputFormat_init_func Init
        {
            get => _ptr->init;
            set => _ptr->init = value;
        }
        
        /// <summary>
        /// <para>Deinitialize format.</para>
        /// <para> If present, this is called whenever the muxer is being destroyed, regardless of whether or not the header has been written.</para>
        /// <see cref="AVOutputFormat.deinit" />
        /// </summary>
        internal AVOutputFormat_deinit_func Deinit
        {
            get => _ptr->deinit;
            set => _ptr->deinit = value;
        }
        
        /// <summary>
        /// <para>Set up any necessary bitstream filtering and extract any extra data needed for the global header.</para>
        /// <para> Return 0 if more packets from this stream must be checked; 1 if not.</para>
        /// <see cref="AVOutputFormat.check_bitstream" />
        /// </summary>
        internal AVOutputFormat_check_bitstream_func CheckBitstream
        {
            get => _ptr->check_bitstream;
            set => _ptr->check_bitstream = value;
        }
    }
}
