using Sdcb.FFmpegAPIWrapper.Common;
using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;
using System;

namespace Sdcb.FFmpegAPIWrapper.MediaCodecs
{
    /// <summary>
    /// <see cref="AVCodecContext"/>
    /// </summary>
    public unsafe partial class MediaCodecContext : FFmpegHandle
    {
        public MediaCodecContext(AVCodecContext* ptr) : base((IntPtr)ptr) 
        {
            if (ptr == null)
            {
                throw new ArgumentNullException(nameof(ptr));
            }
        }

        /// <summary>
        /// <see cref="AVCodecContext.av_class"/>
        /// </summary>
        public FFmpegClass FFmpegClass => FFmpegClass.FromNative(Pointer->av_class);

        /// <summary>
        /// <see cref="AVCodecContext.log_level_offset"/>
        /// </summary>
        public int LogLevelOffset
        {
            get => Pointer->log_level_offset;
            set => Pointer->log_level_offset = value;
        }

        /// <summary>
        /// <see cref="AVCodecContext.codec_type"/>
        /// </summary>
        public MediaType CodecType
        {
            get => (MediaType)Pointer->codec_type;
            set => Pointer->codec_type = (AVMediaType)value;
        }

        /// <summary>
        /// <see cref="AVCodecContext.codec"/>
        /// </summary>
        public MediaCodec Codec => MediaCodec.FromNative(Pointer->codec);

        /// <summary>
        /// <see cref="AVCodecContext.codec_id"/>
        /// </summary>
        public AVCodecID CodecId
        {
            get => Pointer->codec_id;
            set => Pointer->codec_id = value;
        }

        /// <summary>
        /// <see cref="AVCodecContext.codec_tag"/>
        /// </summary>
        public uint CodecTag
        {
            get => Pointer->codec_tag;
            set => Pointer->codec_tag = value;
        }

        /// <summary>
        /// <see cref="AVCodecContext.priv_data"/>
        /// </summary>
        public IntPtr PrivateData
        {
            get => (IntPtr)Pointer->priv_data;
            set => Pointer->priv_data = (void*)value;
        }

        /// <summary>
        /// <see cref="AVCodecContext.@internal"/>
        /// </summary>
        public AVCodecInternal* Internal
        {
            get => Pointer->@internal;
            set => Pointer->@internal = value;
        }

        /// <summary>
        /// <see cref="AVCodecContext.opaque"/>
        /// </summary>
        public IntPtr Opaque
        {
            get => (IntPtr)Pointer->opaque;
            set => Pointer->opaque = (void*)value;
        }

        /// <summary>
        /// <see cref="AVCodecContext.bit_rate"/>
        /// </summary>
        public long BitRate
        {
            get => Pointer->bit_rate;
            set => Pointer->bit_rate = value;
        }

        /// <summary>
        /// <see cref="AVCodecContext.bit_rate_tolerance"/>
        /// </summary>
        public int BitRateTolerance
        {
            get => Pointer->bit_rate_tolerance;
            set => Pointer->bit_rate_tolerance = value;
        }

        /// <summary>
        /// <see cref="AVCodecContext.global_quality"/>
        /// </summary>
        public int GlobalQuality
        {
            get => Pointer->global_quality;
            set => Pointer->global_quality = value;
        }

        /// <summary>
        /// <see cref="AVCodecContext.compression_level"/>
        /// </summary>
        public int CompressionLevel
        {
            get => Pointer->compression_level;
            set => Pointer->compression_level = value;
        }

        /// <summary>
        /// <see cref="FF_COMPRESSION_DEFAULT"/>
        /// </summary>
        public const int DefaultCompressionLevel = FF_COMPRESSION_DEFAULT;

        /// <summary>
        /// <see cref="AVCodecContext.flags"/>
        /// </summary>
        public MediaCodecFlags Flags
        {
            get => (MediaCodecFlags)Pointer->flags;
            set => Pointer->flags = (int)value;
        }

        /// <summary>
        /// <see cref="AVCodecContext.flags2"/>
        /// </summary>
        public MediaCodecFlags2 Flags2
        {
            get => (MediaCodecFlags2)Pointer->flags2;
            set => Pointer->flags2 = (int)value;
        }

        /// <summary>
        /// <see cref="AVCodecContext.extradata"/>
        /// <see cref="AVCodecContext.extradata_size"/>
        /// </summary>
        public Span<byte> ExtraData
        {
            get => new Span<byte>(Pointer->extradata, Pointer->extradata_size);
            set
            {
                if (Pointer->extradata != null)
                {
                    av_free(Pointer->extradata);
                }

                if (value.Length > 0)
                {
                    fixed (byte* p = value)
                    {
                        void* mem = av_malloc((ulong)value.Length);
                        if (mem == null)
                        {
                            throw FFmpegException.FromErrorCode(AVERROR(ENOMEM), $"Failed to call av_malloc to store {nameof(ExtraData)}");
                        }
                        value.CopyTo(new Span<byte>(mem, value.Length));
                    }
                }
                else
                {
                    Pointer->extradata = null;
                    Pointer->extradata_size = 0;
                }
            }
        }

        private AVCodecContext* Pointer => this;

        protected override void Close()
        {
            AVCodecContext* ptr = this;
            avcodec_free_context(&ptr);
            _handle = (IntPtr)ptr;
        }
    }
}
