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
        
    }
}
