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
        
        public static implicit operator AVOutputFormat*(OutputFormat? data)
            => data.HasValue ? (AVOutputFormat*)data.Value._ptr : null;
        
        private OutputFormat(AVOutputFormat* ptr)
        {
            if (ptr == null)
            {
                throw new ArgumentNullException(nameof(ptr));
            }
            _ptr = ptr;
        }
        
        public static OutputFormat FromNative(AVOutputFormat* ptr) => new OutputFormat(ptr);
        internal static OutputFormat? FromNativeOrNull(AVOutputFormat* ptr)
            => ptr != null ? new OutputFormat?(new OutputFormat(ptr)) : null;
        
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
    }
}
