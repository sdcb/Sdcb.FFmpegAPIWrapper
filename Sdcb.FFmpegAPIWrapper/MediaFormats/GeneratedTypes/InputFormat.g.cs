// This file was genereated from LINQPad scripts, DO NOT CHANGE DIRECTLY.

using System;
using Sdcb.FFmpegAPIWrapper.Common;
using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;

namespace Sdcb.FFmpegAPIWrapper.MediaFormats
{
    /// <summary>
    /// <para>@{.</para>
    /// <see cref="AVInputFormat" />
    /// </summary>
    public unsafe partial struct InputFormat
    {
        private AVInputFormat* _ptr;
        
        public static implicit operator AVInputFormat*(InputFormat data) => (AVInputFormat*)data._ptr;
        
        private InputFormat(AVInputFormat* ptr)
        {
            if (ptr == null)
            {
                throw new ArgumentNullException(nameof(ptr));
            }
            _ptr = ptr;
        }
        
        public static InputFormat FromNative(AVInputFormat* ptr) => new InputFormat(ptr);
        
        /// <summary>
        /// <para>A comma separated list of short names for the format.</para>
        /// <para> New names may be appended with a minor bump.</para>
        /// <see cref="AVInputFormat.name" />
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
        /// <see cref="AVInputFormat.long_name" />
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
        /// <para>Can use flags: AVFMT_NOFILE, AVFMT_NEEDNUMBER, AVFMT_SHOW_IDS, AVFMT_NOTIMESTAMPS, AVFMT_GENERIC_INDEX, AVFMT_TS_DISCONT, AVFMT_NOBINSEARCH, AVFMT_NOGENSEARCH, AVFMT_NO_BYTE_SEEK, AVFMT_SEEK_TO_PTS.</para>
        /// <see cref="AVInputFormat.flags" />
        /// </summary>
        public int Flags
        {
            get => _ptr->flags;
            set => _ptr->flags = value;
        }
        
        /// <summary>
        /// <para>If extensions are defined, then no probe is done.</para>
        /// <para> You should usually not use extension format guessing because it is not reliable enough.</para>
        /// <see cref="AVInputFormat.extensions" />
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
        /// <see cref="AVInputFormat.codec_tag" />
        /// </summary>
        public AVCodecTag** CodecTag
        {
            get => _ptr->codec_tag;
            set => _ptr->codec_tag = value;
        }
        
        /// <summary>
        /// <para>AVClass for the private context.</para>
        /// <see cref="AVInputFormat.priv_class" />
        /// </summary>
        public FFmpegClass PrivateClass
        {
            get => FFmpegClass.FromNative(_ptr->priv_class);
            set => _ptr->priv_class = value;
        }
        
        /// <summary>
        /// <para>Comma-separated list of mime types.</para>
        /// <para> It is used check for matching mime types while probing.</para>
        /// <see cref="AVInputFormat.mime_type" />
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
        /// <para>*************************************************************** No fields below this line are part of the public API.</para>
        /// <para> They may not be used outside of libavformat and can be changed and removed at will.</para>
        /// <para> New public fields should be added right above.</para>
        /// <para> ****************************************************************.</para>
        /// <see cref="AVInputFormat.next" />
        /// </summary>
        public InputFormat Next
        {
            get => InputFormat.FromNative(_ptr->next);
            set => _ptr->next = value;
        }
        
        /// <summary>
        /// <para>Raw demuxers store their codec ID here.</para>
        /// <see cref="AVInputFormat.raw_codec_id" />
        /// </summary>
        public int RawCodecId
        {
            get => _ptr->raw_codec_id;
            set => _ptr->raw_codec_id = value;
        }
        
        /// <summary>
        /// <para>Size of private data so that it can be allocated in the wrapper.</para>
        /// <see cref="AVInputFormat.priv_data_size" />
        /// </summary>
        public int PrivateDataSize
        {
            get => _ptr->priv_data_size;
            set => _ptr->priv_data_size = value;
        }
        
        /// <summary>
        /// <para>Tell if a given file has a chance of being parsed as this format.</para>
        /// <para> The buffer provided is guaranteed to be AVPROBE_PADDING_SIZE bytes big so you do not have to check for that unless you need more.</para>
        /// <see cref="AVInputFormat.read_probe" />
        /// </summary>
        internal AVInputFormat_read_probe_func ReadProbe
        {
            get => _ptr->read_probe;
            set => _ptr->read_probe = value;
        }
        
        /// <summary>
        /// <para>Read the format header and initialize the AVFormatContext structure.</para>
        /// <para> Return 0 if OK.</para>
        /// <para> &#39;avformat_new_stream&#39; should be called to create new streams.</para>
        /// <see cref="AVInputFormat.read_header" />
        /// </summary>
        internal AVInputFormat_read_header_func ReadHeader
        {
            get => _ptr->read_header;
            set => _ptr->read_header = value;
        }
        
        /// <summary>
        /// <para>Read one packet and put it in &#39;pkt&#39;.</para>
        /// <para> pts and flags are also set.</para>
        /// <para> &#39;avformat_new_stream&#39; can be called only if the flag AVFMTCTX_NOHEADER is used and only in the calling thread (not in a background thread).</para>
        /// <see cref="AVInputFormat.read_packet" />
        /// </summary>
        internal AVInputFormat_read_packet_func ReadPacket
        {
            get => _ptr->read_packet;
            set => _ptr->read_packet = value;
        }
        
        /// <summary>
        /// <para>Close the stream.</para>
        /// <para> The AVFormatContext and AVStreams are not freed by this function.</para>
        /// <see cref="AVInputFormat.read_close" />
        /// </summary>
        internal AVInputFormat_read_close_func ReadClose
        {
            get => _ptr->read_close;
            set => _ptr->read_close = value;
        }
        
        /// <summary>
        /// <para>Seek to a given timestamp relative to the frames in stream component stream_index.</para>
        /// <see cref="AVInputFormat.read_seek" />
        /// </summary>
        internal AVInputFormat_read_seek_func ReadSeek
        {
            get => _ptr->read_seek;
            set => _ptr->read_seek = value;
        }
        
        /// <summary>
        /// <para>Get the next timestamp in stream[stream_index].</para>
        /// <para>time_base units.</para>
        /// <see cref="AVInputFormat.read_timestamp" />
        /// </summary>
        internal AVInputFormat_read_timestamp_func ReadTimestamp
        {
            get => _ptr->read_timestamp;
            set => _ptr->read_timestamp = value;
        }
        
        /// <summary>
        /// <para>Start/resume playing - only meaningful if using a network-based format (RTSP).</para>
        /// <see cref="AVInputFormat.read_play" />
        /// </summary>
        internal AVInputFormat_read_play_func ReadPlay
        {
            get => _ptr->read_play;
            set => _ptr->read_play = value;
        }
        
        /// <summary>
        /// <para>Pause playing - only meaningful if using a network-based format (RTSP).</para>
        /// <see cref="AVInputFormat.read_pause" />
        /// </summary>
        internal AVInputFormat_read_pause_func ReadPause
        {
            get => _ptr->read_pause;
            set => _ptr->read_pause = value;
        }
        
        /// <summary>
        /// <para>Seek to timestamp ts.</para>
        /// <para> Seeking will be done so that the point from which all active streams can be presented successfully will be closest to ts and within min/max_ts.</para>
        /// <para> Active streams are all streams that have AVStream.</para>
        /// <para>discard &lt; AVDISCARD_ALL.</para>
        /// <see cref="AVInputFormat.read_seek2" />
        /// </summary>
        internal AVInputFormat_read_seek2_func ReadSeek2
        {
            get => _ptr->read_seek2;
            set => _ptr->read_seek2 = value;
        }
        
        /// <summary>
        /// <para>Returns device list with it properties.</para>
        /// <see cref="AVInputFormat.get_device_list" />
        /// </summary>
        internal AVInputFormat_get_device_list_func GetDeviceList
        {
            get => _ptr->get_device_list;
            set => _ptr->get_device_list = value;
        }
        
        /// <summary>
        /// <para>Initialize device capabilities submodule.</para>
        /// <see cref="AVInputFormat.create_device_capabilities" />
        /// </summary>
        internal AVInputFormat_create_device_capabilities_func CreateDeviceCapabilities
        {
            get => _ptr->create_device_capabilities;
            set => _ptr->create_device_capabilities = value;
        }
        
        /// <summary>
        /// <para>Free device capabilities submodule.</para>
        /// <see cref="AVInputFormat.free_device_capabilities" />
        /// </summary>
        internal AVInputFormat_free_device_capabilities_func FreeDeviceCapabilities
        {
            get => _ptr->free_device_capabilities;
            set => _ptr->free_device_capabilities = value;
        }
    }
}
