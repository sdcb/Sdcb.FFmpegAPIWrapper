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

        /// <summary>
        /// <see cref="AVCodecContext.time_base"/>
        /// </summary>
        public MediaRational Timebase
        {
            get => Pointer->time_base;
            set => Pointer->time_base = value;
        }

        /// <summary>
        /// <see cref="AVCodecContext.ticks_per_frame"/>
        /// </summary>
        public int TicksPerFrame
        {
            get => Pointer->ticks_per_frame;
            set => Pointer->ticks_per_frame = value;
        }

        /// <summary>
        /// <see cref="AVCodecContext.delay"/>
        /// </summary>
        public int Delay
        {
            get => Pointer->delay;
            set => Pointer->delay = value;
        }

        /// <summary>
        /// <see cref="AVCodecContext.width"/>
        /// </summary>
        public int Width
        {
            get => Pointer->width;
            set => Pointer->width = value;
        }

        /// <summary>
        /// <see cref="AVCodecContext.height"/>
        /// </summary>
        public int Height
        {
            get => Pointer->height;
            set => Pointer->height = value;
        }

        /// <summary>
        /// <see cref="AVCodecContext.coded_width"/>
        /// </summary>
        public int CodedWidth
        {
            get => Pointer->coded_width;
            set => Pointer->coded_width = value;
        }

        /// <summary>
        /// <see cref="AVCodecContext.coded_height"/>
        /// </summary>
        public int CodedHeight
        {
            get => Pointer->coded_height;
            set => Pointer->coded_height = value;
        }

        /// <summary>
        /// <see cref="AVCodecContext.gop_size"/>
        /// </summary>
        public int GopSize
        {
            get => Pointer->gop_size;
            set => Pointer->gop_size = value;
        }

        /// <summary>
        /// <see cref="AVCodecContext.pix_fmt"/>
        /// </summary>
        public AVPixelFormat PixelFormat
        {
            get => Pointer->pix_fmt;
            set => Pointer->pix_fmt = value;
        }

        /// <summary>
        /// <see cref="AVCodecContext.max_b_frames"/>
        /// </summary>
        public int MaxBFrames
        {
            get => Pointer->max_b_frames;
            set => Pointer->max_b_frames = value;
        }

        /// <summary>
        /// <see cref="AVCodecContext.b_quant_factor"/>
        /// </summary>
        public float BQuantFactor
        {
            get => Pointer->b_quant_factor;
            set => Pointer->b_quant_factor = value;
        }

        /// <summary>
        /// <see cref="AVCodecContext.b_frame_strategy"/>
        /// </summary>
        [Obsolete("use encoder private options instead")]
        public int BFrameStrategy
        {
            get => Pointer->b_frame_strategy;
            set => Pointer->b_frame_strategy = value;
        }

        /// <summary>
        /// <see cref="AVCodecContext.b_quant_offset"/>
        /// </summary>
        public float BQuantOffset
        {
            get => Pointer->b_quant_offset;
            set => Pointer->b_quant_offset = value;
        }

        /// <summary>
        /// <see cref="AVCodecContext.has_b_frames"/>
        /// </summary>
        public int HasBFrames
        {
            get => Pointer->has_b_frames;
            set => Pointer->has_b_frames = value;
        }

        /// <summary>
        /// <see cref="AVCodecContext.i_quant_factor"/>
        /// </summary>
        public float IQuantFactor
        {
            get => Pointer->i_quant_factor;
            set => Pointer->i_quant_factor = value;
        }

        /// <summary>
        /// <see cref="AVCodecContext.i_quant_offset"/>
        /// </summary>
        public float IQuantOffset
        {
            get => Pointer->i_quant_offset;
            set => Pointer->i_quant_offset = value;
        }

        /// <summary>
        /// <see cref="AVCodecContext.lumi_masking"/>
        /// </summary>
        public float LuminanceMasking
        {
            get => Pointer->lumi_masking;
            set => Pointer->lumi_masking = value;
        }

        /// <summary>
        /// <see cref="AVCodecContext.temporal_cplx_masking"/>
        /// </summary>
        public float TemporaryComplexityMasking
        {
            get => Pointer->temporal_cplx_masking;
            set => Pointer->temporal_cplx_masking = value;
        }

        /// <summary>
        /// <see cref="AVCodecContext.spatial_cplx_masking"/>
        /// </summary>
        public float SpatialComplexityMasking
        {
            get => Pointer->spatial_cplx_masking;
            set => Pointer->spatial_cplx_masking = value;
        }

        /// <summary>
        /// <see cref="AVCodecContext.p_masking"/>
        /// </summary>
        public float PMasking
        {
            get => Pointer->p_masking;
            set => Pointer->p_masking = value;
        }

        /// <summary>
        /// <see cref="AVCodecContext.dark_masking"/>
        /// </summary>
        public float DarkMasking
        {
            get => Pointer->dark_masking;
            set => Pointer->dark_masking = value;
        }

        /// <summary>
        /// <see cref="AVCodecContext.slice_count"/>
        /// </summary>
        public int SliceCount
        {
            get => Pointer->slice_count;
            set => Pointer->slice_count = value;
        }

        /// <summary>
        /// <see cref="AVCodecContext.prediction_method"/>
        /// </summary>
        [Obsolete("use encoder private options instead")]
        public int PredictionMethod
        {
            get => Pointer->prediction_method;
            set => Pointer->prediction_method = value;
        }

        /// <summary>
        /// <see cref="AVCodecContext.slice_offset"/>
        /// </summary>
        public IntPtr SliceOffset
        {
            get => (IntPtr)Pointer->slice_offset;
            set => Pointer->slice_offset = (int*)value;
        }

        /// <summary>
        /// <see cref="AVCodecContext.sample_aspect_ratio"/>
        /// </summary>
        public MediaRational SampleAspectRatio
        {
            get => Pointer->sample_aspect_ratio;
            set => Pointer->sample_aspect_ratio = value;
        }

        /// <summary>
        /// <see cref="AVCodecContext.me_cmp"/>
        /// </summary>
        public int MEComparison
        {
            get => Pointer->me_cmp;
            set => Pointer->me_cmp = value;
        }

        /// <summary>
        /// <see cref="AVCodecContext.me_sub_cmp"/>
        /// </summary>
        public int SubpixelMEComparison
        {
            get => Pointer->me_sub_cmp;
            set => Pointer->me_sub_cmp = value;
        }

        /// <summary>
        /// <see cref="AVCodecContext.mb_cmp"/>
        /// </summary>
        public int MacroblockComparison
        {
            get => Pointer->mb_cmp;
            set => Pointer->mb_cmp = value;
        }

        /// <summary>
        /// <see cref="AVCodecContext.ildct_cmp"/>
        /// </summary>
        public InterlacedDctComparison InterlacedDctComparison
        {
            get => (InterlacedDctComparison)Pointer->ildct_cmp;
            set => Pointer->ildct_cmp = (int)value;
        }

        /// <summary>
        /// <see cref="AVCodecContext.dia_size"/>
        /// </summary>
        public int DiamondSize
        {
            get => Pointer->dia_size;
            set => Pointer->dia_size = value;
        }

        /// <summary>
        /// <see cref="AVCodecContext.last_predictor_count"/>
        /// </summary>
        public int LastPredicatorCount
        {
            get => Pointer->last_predictor_count;
            set => Pointer->last_predictor_count = value;
        }

        /// <summary>
        /// <see cref="AVCodecContext.pre_me"/>
        /// </summary>
        [Obsolete("use encoder private options instead")]
        public int PreME
        {
            get => Pointer->pre_me;
            set => Pointer->pre_me = value;
        }

        /// <summary>
        /// <see cref="AVCodecContext.me_pre_cmp"/>
        /// </summary>
        public int MEPrepassComparison
        {
            get => Pointer->me_pre_cmp;
            set => Pointer->me_pre_cmp = value;
        }

        /// <summary>
        /// <see cref="AVCodecContext.pre_dia_size"/>
        /// </summary>
        public int PrepassDiamondSize
        {
            get => Pointer->pre_dia_size;
            set => Pointer->pre_dia_size = value;
        }

        /// <summary>
        /// <see cref="AVCodecContext.me_subpel_quality"/>
        /// </summary>
        public int MESubpelQuality
        {
            get => Pointer->me_subpel_quality;
            set => Pointer->me_subpel_quality = value;
        }

        /// <summary>
        /// <see cref="AVCodecContext.me_range"/>
        /// </summary>
        public int MERange
        {
            get => Pointer->me_range;
            set => Pointer->me_range = value;
        }

        /// <summary>
        /// <see cref="AVCodecContext.slice_flags"/>
        /// </summary>
        public SliceFlags SliceFlag
        {
            get => (SliceFlags)Pointer->slice_flags;
            set => Pointer->slice_flags = (int)value;
        }

        /// <summary>
        /// <see cref="AVCodecContext.mb_decision"/>
        /// </summary>
        public MacroblockDecisions MacroblockDecision
        {
            get => (MacroblockDecisions)Pointer->mb_decision;
            set => Pointer->mb_decision = (int)value;
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
