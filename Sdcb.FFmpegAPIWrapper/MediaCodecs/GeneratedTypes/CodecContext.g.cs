// This file was genereated from LINQPad scripts, DO NOT CHANGE DIRECTLY.

using System;
using Sdcb.FFmpegAPIWrapper.Common;
using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;

namespace Sdcb.FFmpegAPIWrapper.MediaCodecs
{
    /// <summary>
    /// <para>main external API structure.</para>
    /// <para> New fields can be added to the end with minor version bumps.</para>
    /// <para> Removal, reordering and changes to existing fields require a major version bump.</para>
    /// <para> You can use AVOptions (av_opt* / av_set/get*()) to access these fields from user applications.</para>
    /// <para> The name string for AVOptions options matches the associated command line parameter name and can be found in libavcodec/options_table.</para>
    /// <para>h The AVOption/command line parameter names differ in some cases from the C structure field names for historic reasons or brevity.</para>
    /// <para> sizeof(AVCodecContext) must not be used outside libav*.</para>
    /// <see cref="AVCodecContext" />
    /// </summary>
    public unsafe partial class CodecContext : FFmpegSafeObject
    {
        protected AVCodecContext* Pointer => this;
        
        public static implicit operator AVCodecContext*(CodecContext data) => data != null ? (AVCodecContext*)data._nativePointer : null;
        
        protected CodecContext(AVCodecContext* ptr, bool isOwner): base(NativeUtils.NotNull((IntPtr)ptr), isOwner)
        {
        }
        
        public static CodecContext FromNative(AVCodecContext* ptr, bool isOwner) => new CodecContext(ptr, isOwner);
        
        /// <summary>
        /// <para>information on struct for av_log - set by avcodec_alloc_context3.</para>
        /// <see cref="AVCodecContext.av_class" />
        /// </summary>
        public FFmpegClass Class
        {
            get => FFmpegClass.FromNativeOrNull(Pointer->av_class);
            set => Pointer->av_class = value;
        }
        
        /// <summary>
        /// <see cref="AVCodecContext.log_level_offset" />
        /// </summary>
        public int LogLevelOffset
        {
            get => Pointer->log_level_offset;
            set => Pointer->log_level_offset = value;
        }
        
        /// <summary>
        /// <see cref="AVCodecContext.codec_type" />
        /// </summary>
        public MediaType CodecType
        {
            get => (MediaType)Pointer->codec_type;
            set => Pointer->codec_type = (AVMediaType)value;
        }
        
        /// <summary>
        /// <see cref="AVCodecContext.codec" />
        /// </summary>
        public Codec Codec
        {
            get => Codec.FromNative(Pointer->codec);
            set => Pointer->codec = value;
        }
        
        /// <summary>
        /// <see cref="AVCodecContext.codec_id" />
        /// </summary>
        public CodecID CodecId
        {
            get => (CodecID)Pointer->codec_id;
            set => Pointer->codec_id = (AVCodecID)value;
        }
        
        /// <summary>
        /// <para>fourcc (LSB first, so &quot;ABCD&quot; -&gt; (&#39;D&#39;&lt;&lt;24) + (&#39;C&#39;&lt;&lt;16) + (&#39;B&#39;&lt;&lt;8) + &#39;A&#39;).</para>
        /// <para> This is used to work around some encoder bugs.</para>
        /// <para> A demuxer should set this to what is stored in the field used to identify the codec.</para>
        /// <para> If there are multiple such fields in a container then the demuxer should choose the one which maximizes the information about the used codec.</para>
        /// <para> If the codec tag field in a container is larger than 32 bits then the demuxer should remap the longer ID to 32 bits with a table or other structure.</para>
        /// <para> Alternatively a new extra_codec_tag + size could be added but for this a clear advantage must be demonstrated first.</para>
        /// <para> - encoding: Set by user, if not then the default based on codec_id will be used.</para>
        /// <para> - decoding: Set by user, will be converted to uppercase by libavcodec during init.</para>
        /// <see cref="AVCodecContext.codec_tag" />
        /// </summary>
        public uint CodecTag
        {
            get => Pointer->codec_tag;
            set => Pointer->codec_tag = value;
        }
        
        /// <summary>
        /// <see cref="AVCodecContext.priv_data" />
        /// </summary>
        public IntPtr PrivateData
        {
            get => (IntPtr)Pointer->priv_data;
            set => Pointer->priv_data = (void*)value;
        }
        
        /// <summary>
        /// <para>Private context used for internal data.</para>
        /// <see cref="AVCodecContext.internal" />
        /// </summary>
        public AVCodecInternal* Internal
        {
            get => Pointer->@internal;
            set => Pointer->@internal = value;
        }
        
        /// <summary>
        /// <para>Private data of the user, can be used to carry app specific stuff.</para>
        /// <para> - encoding: Set by user.</para>
        /// <para> - decoding: Set by user.</para>
        /// <see cref="AVCodecContext.opaque" />
        /// </summary>
        public IntPtr Opaque
        {
            get => (IntPtr)Pointer->opaque;
            set => Pointer->opaque = (void*)value;
        }
        
        /// <summary>
        /// <para>the average bitrate - encoding: Set by user; unused for constant quantizer encoding.</para>
        /// <para> - decoding: Set by user, may be overwritten by libavcodec if this info is available in the stream.</para>
        /// <see cref="AVCodecContext.bit_rate" />
        /// </summary>
        public long BitRate
        {
            get => Pointer->bit_rate;
            set => Pointer->bit_rate = value;
        }
        
        /// <summary>
        /// <para>number of bits the bitstream is allowed to diverge from the reference.</para>
        /// <para> the reference can be CBR (for CBR pass1) or VBR (for pass2) - encoding: Set by user; unused for constant quantizer encoding.</para>
        /// <para> - decoding: unused.</para>
        /// <see cref="AVCodecContext.bit_rate_tolerance" />
        /// </summary>
        public int BitRateTolerance
        {
            get => Pointer->bit_rate_tolerance;
            set => Pointer->bit_rate_tolerance = value;
        }
        
        /// <summary>
        /// <para>Global quality for codecs which cannot change it per frame.</para>
        /// <para> This should be proportional to MPEG-1/2/4 qscale.</para>
        /// <para> - encoding: Set by user.</para>
        /// <para> - decoding: unused.</para>
        /// <see cref="AVCodecContext.global_quality" />
        /// </summary>
        public int GlobalQuality
        {
            get => Pointer->global_quality;
            set => Pointer->global_quality = value;
        }
        
        /// <summary>
        /// <para>- encoding: Set by user.</para>
        /// <para> - decoding: unused.</para>
        /// <see cref="AVCodecContext.compression_level" />
        /// </summary>
        public int CompressionLevel
        {
            get => Pointer->compression_level;
            set => Pointer->compression_level = value;
        }
        
        /// <summary>
        /// <para>AV_CODEC_FLAG_*.</para>
        /// <para> - encoding: Set by user.</para>
        /// <para> - decoding: Set by user.</para>
        /// <see cref="AVCodecContext.flags" />
        /// </summary>
        public CodecFlag Flags
        {
            get => (CodecFlag)Pointer->flags;
            set => Pointer->flags = (int)value;
        }
        
        /// <summary>
        /// <para>AV_CODEC_FLAG2_* - encoding: Set by user.</para>
        /// <para> - decoding: Set by user.</para>
        /// <see cref="AVCodecContext.flags2" />
        /// </summary>
        public CodecFlag2 Flags2
        {
            get => (CodecFlag2)Pointer->flags2;
            set => Pointer->flags2 = (int)value;
        }
        
        /// <summary>
        /// <para>some codecs need / can use extradata like Huffman tables.</para>
        /// <para> MJPEG: Huffman tables rv10: additional flags MPEG-4: global headers (they can be in the bitstream or here) The allocated memory should be AV_INPUT_BUFFER_PADDING_SIZE bytes larger than extradata_size to avoid problems if it is read with the bitstream reader.</para>
        /// <para> The bytewise contents of extradata must not depend on the architecture or CPU endianness.</para>
        /// <para> Must be allocated with the av_malloc() family of functions.</para>
        /// <para> - encoding: Set/allocated/freed by libavcodec.</para>
        /// <para> - decoding: Set/allocated/freed by user.</para>
        /// <see cref="AVCodecContext.extradata" />
        /// </summary>
        public IntPtr Extradata
        {
            get => (IntPtr)Pointer->extradata;
            set => Pointer->extradata = (byte*)value;
        }
        
        /// <summary>
        /// <see cref="AVCodecContext.extradata_size" />
        /// </summary>
        public int ExtradataSize
        {
            get => Pointer->extradata_size;
            set => Pointer->extradata_size = value;
        }
        
        /// <summary>
        /// <para>This is the fundamental unit of time (in seconds) in terms of which frame timestamps are represented.</para>
        /// <para> For fixed-fps content, timebase should be 1/framerate and timestamp increments should be identically 1.</para>
        /// <para> This often, but not always is the inverse of the frame rate or field rate for video.</para>
        /// <para> 1/time_base is not the average frame rate if the frame rate is not constant.</para>
        /// <see cref="AVCodecContext.time_base" />
        /// </summary>
        public MediaRational TimeBase
        {
            get => Pointer->time_base;
            set => Pointer->time_base = value;
        }
        
        /// <summary>
        /// <para>For some codecs, the time base is closer to the field rate than the frame rate.</para>
        /// <para> Most notably, H.</para>
        /// <para>264 and MPEG-2 specify time_base as half of frame duration if no telecine is used .</para>
        /// <see cref="AVCodecContext.ticks_per_frame" />
        /// </summary>
        public int TicksPerFrame
        {
            get => Pointer->ticks_per_frame;
            set => Pointer->ticks_per_frame = value;
        }
        
        /// <summary>
        /// <para>Codec delay.</para>
        /// <see cref="AVCodecContext.delay" />
        /// </summary>
        public int Delay
        {
            get => Pointer->delay;
            set => Pointer->delay = value;
        }
        
        /// <summary>
        /// <para>picture width / height.</para>
        /// <see cref="AVCodecContext.width" />
        /// </summary>
        public int Width
        {
            get => Pointer->width;
            set => Pointer->width = value;
        }
        
        /// <summary>
        /// <para>picture width / height.</para>
        /// <see cref="AVCodecContext.height" />
        /// </summary>
        public int Height
        {
            get => Pointer->height;
            set => Pointer->height = value;
        }
        
        /// <summary>
        /// <para>Bitstream width / height, may be different from width/height e.</para>
        /// <para>g.</para>
        /// <para> when the decoded frame is cropped before being output or lowres is enabled.</para>
        /// <see cref="AVCodecContext.coded_width" />
        /// </summary>
        public int CodedWidth
        {
            get => Pointer->coded_width;
            set => Pointer->coded_width = value;
        }
        
        /// <summary>
        /// <para>Bitstream width / height, may be different from width/height e.</para>
        /// <para>g.</para>
        /// <para> when the decoded frame is cropped before being output or lowres is enabled.</para>
        /// <see cref="AVCodecContext.coded_height" />
        /// </summary>
        public int CodedHeight
        {
            get => Pointer->coded_height;
            set => Pointer->coded_height = value;
        }
        
        /// <summary>
        /// <para>the number of pictures in a group of pictures, or 0 for intra_only - encoding: Set by user.</para>
        /// <para> - decoding: unused.</para>
        /// <see cref="AVCodecContext.gop_size" />
        /// </summary>
        public int GopSize
        {
            get => Pointer->gop_size;
            set => Pointer->gop_size = value;
        }
        
        /// <summary>
        /// <para>Pixel format, see AV_PIX_FMT_xxx.</para>
        /// <para> May be set by the demuxer if known from headers.</para>
        /// <para> May be overridden by the decoder if it knows better.</para>
        /// <see cref="AVCodecContext.pix_fmt" />
        /// </summary>
        public PixelFormat PixelFormat
        {
            get => (PixelFormat)Pointer->pix_fmt;
            set => Pointer->pix_fmt = (AVPixelFormat)value;
        }
        
        /// <summary>
        /// <para>maximum number of B-frames between non-B-frames Note: The output will be delayed by max_b_frames+1 relative to the input.</para>
        /// <para> - encoding: Set by user.</para>
        /// <para> - decoding: unused.</para>
        /// <see cref="AVCodecContext.max_b_frames" />
        /// </summary>
        public int MaxBFrames
        {
            get => Pointer->max_b_frames;
            set => Pointer->max_b_frames = value;
        }
        
        /// <summary>
        /// <para>qscale factor between IP and B-frames If &gt; 0 then the last P-frame quantizer will be used (q= lastp_q*factor+offset).</para>
        /// <para> If &lt; 0 then normal ratecontrol will be done (q= -normal_q*factor+offset).</para>
        /// <para> - encoding: Set by user.</para>
        /// <para> - decoding: unused.</para>
        /// <see cref="AVCodecContext.b_quant_factor" />
        /// </summary>
        public float BQuantFactor
        {
            get => Pointer->b_quant_factor;
            set => Pointer->b_quant_factor = value;
        }
        
        /// <summary>
        /// <para>qscale offset between IP and B-frames - encoding: Set by user.</para>
        /// <para> - decoding: unused.</para>
        /// <see cref="AVCodecContext.b_quant_offset" />
        /// </summary>
        public float BQuantOffset
        {
            get => Pointer->b_quant_offset;
            set => Pointer->b_quant_offset = value;
        }
        
        /// <summary>
        /// <para>Size of the frame reordering buffer in the decoder.</para>
        /// <para> For MPEG-2 it is 1 IPB or 0 low delay IP.</para>
        /// <para> - encoding: Set by libavcodec.</para>
        /// <para> - decoding: Set by libavcodec.</para>
        /// <see cref="AVCodecContext.has_b_frames" />
        /// </summary>
        public int HasBFrames
        {
            get => Pointer->has_b_frames;
            set => Pointer->has_b_frames = value;
        }
        
        /// <summary>
        /// <para>qscale factor between P- and I-frames If &gt; 0 then the last P-frame quantizer will be used (q = lastp_q * factor + offset).</para>
        /// <para> If &lt; 0 then normal ratecontrol will be done (q= -normal_q*factor+offset).</para>
        /// <para> - encoding: Set by user.</para>
        /// <para> - decoding: unused.</para>
        /// <see cref="AVCodecContext.i_quant_factor" />
        /// </summary>
        public float IQuantFactor
        {
            get => Pointer->i_quant_factor;
            set => Pointer->i_quant_factor = value;
        }
        
        /// <summary>
        /// <para>qscale offset between P and I-frames - encoding: Set by user.</para>
        /// <para> - decoding: unused.</para>
        /// <see cref="AVCodecContext.i_quant_offset" />
        /// </summary>
        public float IQuantOffset
        {
            get => Pointer->i_quant_offset;
            set => Pointer->i_quant_offset = value;
        }
        
        /// <summary>
        /// <para>luminance masking (0-&gt; disabled) - encoding: Set by user.</para>
        /// <para> - decoding: unused.</para>
        /// <see cref="AVCodecContext.lumi_masking" />
        /// </summary>
        public float LumiMasking
        {
            get => Pointer->lumi_masking;
            set => Pointer->lumi_masking = value;
        }
        
        /// <summary>
        /// <para>temporary complexity masking (0-&gt; disabled) - encoding: Set by user.</para>
        /// <para> - decoding: unused.</para>
        /// <see cref="AVCodecContext.temporal_cplx_masking" />
        /// </summary>
        public float TemporalCplxMasking
        {
            get => Pointer->temporal_cplx_masking;
            set => Pointer->temporal_cplx_masking = value;
        }
        
        /// <summary>
        /// <para>spatial complexity masking (0-&gt; disabled) - encoding: Set by user.</para>
        /// <para> - decoding: unused.</para>
        /// <see cref="AVCodecContext.spatial_cplx_masking" />
        /// </summary>
        public float SpatialCplxMasking
        {
            get => Pointer->spatial_cplx_masking;
            set => Pointer->spatial_cplx_masking = value;
        }
        
        /// <summary>
        /// <para>p block masking (0-&gt; disabled) - encoding: Set by user.</para>
        /// <para> - decoding: unused.</para>
        /// <see cref="AVCodecContext.p_masking" />
        /// </summary>
        public float PMasking
        {
            get => Pointer->p_masking;
            set => Pointer->p_masking = value;
        }
        
        /// <summary>
        /// <para>darkness masking (0-&gt; disabled) - encoding: Set by user.</para>
        /// <para> - decoding: unused.</para>
        /// <see cref="AVCodecContext.dark_masking" />
        /// </summary>
        public float DarkMasking
        {
            get => Pointer->dark_masking;
            set => Pointer->dark_masking = value;
        }
        
        /// <summary>
        /// <para>slice count - encoding: Set by libavcodec.</para>
        /// <para> - decoding: Set by user (or 0).</para>
        /// <see cref="AVCodecContext.slice_count" />
        /// </summary>
        public int SliceCount
        {
            get => Pointer->slice_count;
            set => Pointer->slice_count = value;
        }
        
        /// <summary>
        /// <para>slice offsets in the frame in bytes - encoding: Set/allocated by libavcodec.</para>
        /// <para> - decoding: Set/allocated by user (or NULL).</para>
        /// <see cref="AVCodecContext.slice_offset" />
        /// </summary>
        public int* SliceOffset
        {
            get => Pointer->slice_offset;
            set => Pointer->slice_offset = value;
        }
        
        /// <summary>
        /// <para>sample aspect ratio (0 if unknown) That is the width of a pixel divided by the height of the pixel.</para>
        /// <para> Numerator and denominator must be relatively prime and smaller than 256 for some video standards.</para>
        /// <para> - encoding: Set by user.</para>
        /// <para> - decoding: Set by libavcodec.</para>
        /// <see cref="AVCodecContext.sample_aspect_ratio" />
        /// </summary>
        public MediaRational SampleAspectRatio
        {
            get => Pointer->sample_aspect_ratio;
            set => Pointer->sample_aspect_ratio = value;
        }
        
        /// <summary>
        /// <para>motion estimation comparison function - encoding: Set by user.</para>
        /// <para> - decoding: unused.</para>
        /// <see cref="AVCodecContext.me_cmp" />
        /// </summary>
        public int MeCmp
        {
            get => Pointer->me_cmp;
            set => Pointer->me_cmp = value;
        }
        
        /// <summary>
        /// <para>subpixel motion estimation comparison function - encoding: Set by user.</para>
        /// <para> - decoding: unused.</para>
        /// <see cref="AVCodecContext.me_sub_cmp" />
        /// </summary>
        public int MeSubCmp
        {
            get => Pointer->me_sub_cmp;
            set => Pointer->me_sub_cmp = value;
        }
        
        /// <summary>
        /// <para>macroblock comparison function (not supported yet) - encoding: Set by user.</para>
        /// <para> - decoding: unused.</para>
        /// <see cref="AVCodecContext.mb_cmp" />
        /// </summary>
        public int MbCmp
        {
            get => Pointer->mb_cmp;
            set => Pointer->mb_cmp = value;
        }
        
        /// <summary>
        /// <para>interlaced DCT comparison function - encoding: Set by user.</para>
        /// <para> - decoding: unused.</para>
        /// <see cref="AVCodecContext.ildct_cmp" />
        /// </summary>
        public DctComparison IldctCmp
        {
            get => (DctComparison)Pointer->ildct_cmp;
            set => Pointer->ildct_cmp = (int)value;
        }
        
        /// <summary>
        /// <para>ME diamond size &amp; shape - encoding: Set by user.</para>
        /// <para> - decoding: unused.</para>
        /// <see cref="AVCodecContext.dia_size" />
        /// </summary>
        public int DiaSize
        {
            get => Pointer->dia_size;
            set => Pointer->dia_size = value;
        }
        
        /// <summary>
        /// <para>amount of previous MV predictors (2a+1 x 2a+1 square) - encoding: Set by user.</para>
        /// <para> - decoding: unused.</para>
        /// <see cref="AVCodecContext.last_predictor_count" />
        /// </summary>
        public int LastPredictorCount
        {
            get => Pointer->last_predictor_count;
            set => Pointer->last_predictor_count = value;
        }
        
        /// <summary>
        /// <para>motion estimation prepass comparison function - encoding: Set by user.</para>
        /// <para> - decoding: unused.</para>
        /// <see cref="AVCodecContext.me_pre_cmp" />
        /// </summary>
        public int MePreCmp
        {
            get => Pointer->me_pre_cmp;
            set => Pointer->me_pre_cmp = value;
        }
        
        /// <summary>
        /// <para>ME prepass diamond size &amp; shape - encoding: Set by user.</para>
        /// <para> - decoding: unused.</para>
        /// <see cref="AVCodecContext.pre_dia_size" />
        /// </summary>
        public int PreDiaSize
        {
            get => Pointer->pre_dia_size;
            set => Pointer->pre_dia_size = value;
        }
        
        /// <summary>
        /// <para>subpel ME quality - encoding: Set by user.</para>
        /// <para> - decoding: unused.</para>
        /// <see cref="AVCodecContext.me_subpel_quality" />
        /// </summary>
        public int MeSubpelQuality
        {
            get => Pointer->me_subpel_quality;
            set => Pointer->me_subpel_quality = value;
        }
        
        /// <summary>
        /// <para>maximum motion estimation search range in subpel units If 0 then no limit.</para>
        /// <see cref="AVCodecContext.me_range" />
        /// </summary>
        public int MeRange
        {
            get => Pointer->me_range;
            set => Pointer->me_range = value;
        }
        
        /// <summary>
        /// <para>slice flags - encoding: unused - decoding: Set by user.</para>
        /// <see cref="AVCodecContext.slice_flags" />
        /// </summary>
        public CodecSliceFlag SliceFlags
        {
            get => (CodecSliceFlag)Pointer->slice_flags;
            set => Pointer->slice_flags = (int)value;
        }
        
        /// <summary>
        /// <para>macroblock decision mode - encoding: Set by user.</para>
        /// <para> - decoding: unused.</para>
        /// <see cref="AVCodecContext.mb_decision" />
        /// </summary>
        public MacroblockDecision MbDecision
        {
            get => (MacroblockDecision)Pointer->mb_decision;
            set => Pointer->mb_decision = (int)value;
        }
        
        /// <summary>
        /// <para>custom intra quantization matrix Must be allocated with the av_malloc() family of functions, and will be freed in avcodec_free_context().</para>
        /// <para> - encoding: Set/allocated by user, freed by libavcodec.</para>
        /// <para> Can be NULL.</para>
        /// <para> - decoding: Set/allocated/freed by libavcodec.</para>
        /// <see cref="AVCodecContext.intra_matrix" />
        /// </summary>
        public ushort* IntraMatrix
        {
            get => Pointer->intra_matrix;
            set => Pointer->intra_matrix = value;
        }
        
        /// <summary>
        /// <para>custom inter quantization matrix Must be allocated with the av_malloc() family of functions, and will be freed in avcodec_free_context().</para>
        /// <para> - encoding: Set/allocated by user, freed by libavcodec.</para>
        /// <para> Can be NULL.</para>
        /// <para> - decoding: Set/allocated/freed by libavcodec.</para>
        /// <see cref="AVCodecContext.inter_matrix" />
        /// </summary>
        public ushort* InterMatrix
        {
            get => Pointer->inter_matrix;
            set => Pointer->inter_matrix = value;
        }
        
        /// <summary>
        /// <para>precision of the intra DC coefficient - 8 - encoding: Set by user.</para>
        /// <para> - decoding: Set by libavcodec.</para>
        /// <see cref="AVCodecContext.intra_dc_precision" />
        /// </summary>
        public int IntraDcPrecision
        {
            get => Pointer->intra_dc_precision;
            set => Pointer->intra_dc_precision = value;
        }
        
        /// <summary>
        /// <para>Number of macroblock rows at the top which are skipped.</para>
        /// <para> - encoding: unused - decoding: Set by user.</para>
        /// <see cref="AVCodecContext.skip_top" />
        /// </summary>
        public int SkipTop
        {
            get => Pointer->skip_top;
            set => Pointer->skip_top = value;
        }
        
        /// <summary>
        /// <para>Number of macroblock rows at the bottom which are skipped.</para>
        /// <para> - encoding: unused - decoding: Set by user.</para>
        /// <see cref="AVCodecContext.skip_bottom" />
        /// </summary>
        public int SkipBottom
        {
            get => Pointer->skip_bottom;
            set => Pointer->skip_bottom = value;
        }
        
        /// <summary>
        /// <para>minimum MB Lagrange multiplier - encoding: Set by user.</para>
        /// <para> - decoding: unused.</para>
        /// <see cref="AVCodecContext.mb_lmin" />
        /// </summary>
        public int MbLmin
        {
            get => Pointer->mb_lmin;
            set => Pointer->mb_lmin = value;
        }
        
        /// <summary>
        /// <para>maximum MB Lagrange multiplier - encoding: Set by user.</para>
        /// <para> - decoding: unused.</para>
        /// <see cref="AVCodecContext.mb_lmax" />
        /// </summary>
        public int MbLmax
        {
            get => Pointer->mb_lmax;
            set => Pointer->mb_lmax = value;
        }
        
        /// <summary>
        /// <para>- encoding: Set by user.</para>
        /// <para> - decoding: unused.</para>
        /// <see cref="AVCodecContext.bidir_refine" />
        /// </summary>
        public int BidirRefine
        {
            get => Pointer->bidir_refine;
            set => Pointer->bidir_refine = value;
        }
        
        /// <summary>
        /// <para>minimum GOP size - encoding: Set by user.</para>
        /// <para> - decoding: unused.</para>
        /// <see cref="AVCodecContext.keyint_min" />
        /// </summary>
        public int KeyintMin
        {
            get => Pointer->keyint_min;
            set => Pointer->keyint_min = value;
        }
        
        /// <summary>
        /// <para>number of reference frames - encoding: Set by user.</para>
        /// <para> - decoding: Set by lavc.</para>
        /// <see cref="AVCodecContext.refs" />
        /// </summary>
        public int Refs
        {
            get => Pointer->refs;
            set => Pointer->refs = value;
        }
        
        /// <summary>
        /// <para>Note: Value depends upon the compare function used for fullpel ME.</para>
        /// <para> - encoding: Set by user.</para>
        /// <para> - decoding: unused.</para>
        /// <see cref="AVCodecContext.mv0_threshold" />
        /// </summary>
        public int Mv0Threshold
        {
            get => Pointer->mv0_threshold;
            set => Pointer->mv0_threshold = value;
        }
        
        /// <summary>
        /// <para>Chromaticity coordinates of the source primaries.</para>
        /// <para> - encoding: Set by user - decoding: Set by libavcodec.</para>
        /// <see cref="AVCodecContext.color_primaries" />
        /// </summary>
        public ColorPrimaries ColorPrimaries
        {
            get => (ColorPrimaries)Pointer->color_primaries;
            set => Pointer->color_primaries = (AVColorPrimaries)value;
        }
        
        /// <summary>
        /// <para>Color Transfer Characteristic.</para>
        /// <para> - encoding: Set by user - decoding: Set by libavcodec.</para>
        /// <see cref="AVCodecContext.color_trc" />
        /// </summary>
        public ColorTransferCharacteristic ColorTrc
        {
            get => (ColorTransferCharacteristic)Pointer->color_trc;
            set => Pointer->color_trc = (AVColorTransferCharacteristic)value;
        }
        
        /// <summary>
        /// <para>YUV colorspace type.</para>
        /// <para> - encoding: Set by user - decoding: Set by libavcodec.</para>
        /// <see cref="AVCodecContext.colorspace" />
        /// </summary>
        public ColorSpace Colorspace
        {
            get => (ColorSpace)Pointer->colorspace;
            set => Pointer->colorspace = (AVColorSpace)value;
        }
        
        /// <summary>
        /// <para>MPEG vs JPEG YUV range.</para>
        /// <para> - encoding: Set by user - decoding: Set by libavcodec.</para>
        /// <see cref="AVCodecContext.color_range" />
        /// </summary>
        public ColorRange ColorRange
        {
            get => (ColorRange)Pointer->color_range;
            set => Pointer->color_range = (AVColorRange)value;
        }
        
        /// <summary>
        /// <para>This defines the location of chroma samples.</para>
        /// <para> - encoding: Set by user - decoding: Set by libavcodec.</para>
        /// <see cref="AVCodecContext.chroma_sample_location" />
        /// </summary>
        public ChromaLocation ChromaSampleLocation
        {
            get => (ChromaLocation)Pointer->chroma_sample_location;
            set => Pointer->chroma_sample_location = (AVChromaLocation)value;
        }
        
        /// <summary>
        /// <para>Number of slices.</para>
        /// <para> Indicates number of picture subdivisions.</para>
        /// <para> Used for parallelized decoding.</para>
        /// <para> - encoding: Set by user - decoding: unused.</para>
        /// <see cref="AVCodecContext.slices" />
        /// </summary>
        public int Slices
        {
            get => Pointer->slices;
            set => Pointer->slices = value;
        }
        
        /// <summary>
        /// <para>Field order - encoding: set by libavcodec - decoding: Set by user.</para>
        /// <see cref="AVCodecContext.field_order" />
        /// </summary>
        public FieldOrder FieldOrder
        {
            get => (FieldOrder)Pointer->field_order;
            set => Pointer->field_order = (AVFieldOrder)value;
        }
        
        /// <summary>
        /// <para>samples per second.</para>
        /// <see cref="AVCodecContext.sample_rate" />
        /// </summary>
        public int SampleRate
        {
            get => Pointer->sample_rate;
            set => Pointer->sample_rate = value;
        }
        
        /// <summary>
        /// <para>number of audio channels.</para>
        /// <see cref="AVCodecContext.channels" />
        /// </summary>
        public int Channels
        {
            get => Pointer->channels;
            set => Pointer->channels = value;
        }
        
        /// <summary>
        /// <para>sample format.</para>
        /// <see cref="AVCodecContext.sample_fmt" />
        /// </summary>
        public SampleFormat SampleFormat
        {
            get => (SampleFormat)Pointer->sample_fmt;
            set => Pointer->sample_fmt = (AVSampleFormat)value;
        }
        
        /// <summary>
        /// <para>Number of samples per channel in an audio frame.</para>
        /// <see cref="AVCodecContext.frame_size" />
        /// </summary>
        public int FrameSize
        {
            get => Pointer->frame_size;
            set => Pointer->frame_size = value;
        }
        
        /// <summary>
        /// <para>Frame counter, set by libavcodec.</para>
        /// <see cref="AVCodecContext.frame_number" />
        /// </summary>
        public int FrameNumber
        {
            get => Pointer->frame_number;
            set => Pointer->frame_number = value;
        }
        
        /// <summary>
        /// <para>number of bytes per packet if constant and known or 0 Used by some WAV based audio codecs.</para>
        /// <see cref="AVCodecContext.block_align" />
        /// </summary>
        public int BlockAlign
        {
            get => Pointer->block_align;
            set => Pointer->block_align = value;
        }
        
        /// <summary>
        /// <para>Audio cutoff bandwidth (0 means &quot;automatic&quot;) - encoding: Set by user.</para>
        /// <para> - decoding: unused.</para>
        /// <see cref="AVCodecContext.cutoff" />
        /// </summary>
        public int Cutoff
        {
            get => Pointer->cutoff;
            set => Pointer->cutoff = value;
        }
        
        /// <summary>
        /// <para>Audio channel layout.</para>
        /// <para> - encoding: set by user.</para>
        /// <para> - decoding: set by user, may be overwritten by libavcodec.</para>
        /// <see cref="AVCodecContext.channel_layout" />
        /// </summary>
        public ChannelLayout ChannelLayout
        {
            get => (ChannelLayout)Pointer->channel_layout;
            set => Pointer->channel_layout = (ulong)value;
        }
        
        /// <summary>
        /// <para>Request decoder to use this channel layout if it can (0 for default) - encoding: unused - decoding: Set by user.</para>
        /// <see cref="AVCodecContext.request_channel_layout" />
        /// </summary>
        public ulong RequestChannelLayout
        {
            get => Pointer->request_channel_layout;
            set => Pointer->request_channel_layout = value;
        }
        
        /// <summary>
        /// <para>Type of service that the audio stream conveys.</para>
        /// <para> - encoding: Set by user.</para>
        /// <para> - decoding: Set by libavcodec.</para>
        /// <see cref="AVCodecContext.audio_service_type" />
        /// </summary>
        public AVAudioServiceType AudioServiceType
        {
            get => Pointer->audio_service_type;
            set => Pointer->audio_service_type = value;
        }
        
        /// <summary>
        /// <para>desired sample format - encoding: Not used.</para>
        /// <para> - decoding: Set by user.</para>
        /// <para> Decoder will decode to this format if it can.</para>
        /// <see cref="AVCodecContext.request_sample_fmt" />
        /// </summary>
        public SampleFormat RequestSampleFormat
        {
            get => (SampleFormat)Pointer->request_sample_fmt;
            set => Pointer->request_sample_fmt = (AVSampleFormat)value;
        }
        
        /// <summary>
        /// <para>If non-zero, the decoded audio and video frames returned from avcodec_decode_video2() and avcodec_decode_audio4() are reference-counted and are valid indefinitely.</para>
        /// <para> The caller must free them with av_frame_unref() when they are not needed anymore.</para>
        /// <para> Otherwise, the decoded frames must not be freed by the caller and are only valid until the next decode call.</para>
        /// <see cref="AVCodecContext.refcounted_frames" />
        /// </summary>
        public int RefcountedFrames
        {
            get => Pointer->refcounted_frames;
            set => Pointer->refcounted_frames = value;
        }
        
        /// <summary>
        /// <para>amount of qscale change between easy &amp; hard scenes (0.</para>
        /// <para>0-1.</para>
        /// <para>0).</para>
        /// <see cref="AVCodecContext.qcompress" />
        /// </summary>
        public float Qcompress
        {
            get => Pointer->qcompress;
            set => Pointer->qcompress = value;
        }
        
        /// <summary>
        /// <para>amount of qscale smoothing over time (0.</para>
        /// <para>0-1.</para>
        /// <para>0).</para>
        /// <see cref="AVCodecContext.qblur" />
        /// </summary>
        public float Qblur
        {
            get => Pointer->qblur;
            set => Pointer->qblur = value;
        }
        
        /// <summary>
        /// <para>minimum quantizer - encoding: Set by user.</para>
        /// <para> - decoding: unused.</para>
        /// <see cref="AVCodecContext.qmin" />
        /// </summary>
        public int Qmin
        {
            get => Pointer->qmin;
            set => Pointer->qmin = value;
        }
        
        /// <summary>
        /// <para>maximum quantizer - encoding: Set by user.</para>
        /// <para> - decoding: unused.</para>
        /// <see cref="AVCodecContext.qmax" />
        /// </summary>
        public int Qmax
        {
            get => Pointer->qmax;
            set => Pointer->qmax = value;
        }
        
        /// <summary>
        /// <para>maximum quantizer difference between frames - encoding: Set by user.</para>
        /// <para> - decoding: unused.</para>
        /// <see cref="AVCodecContext.max_qdiff" />
        /// </summary>
        public int MaxQdiff
        {
            get => Pointer->max_qdiff;
            set => Pointer->max_qdiff = value;
        }
        
        /// <summary>
        /// <para>decoder bitstream buffer size - encoding: Set by user.</para>
        /// <para> - decoding: unused.</para>
        /// <see cref="AVCodecContext.rc_buffer_size" />
        /// </summary>
        public int RcBufferSize
        {
            get => Pointer->rc_buffer_size;
            set => Pointer->rc_buffer_size = value;
        }
        
        /// <summary>
        /// <para>ratecontrol override, see RcOverride - encoding: Allocated/set/freed by user.</para>
        /// <para> - decoding: unused.</para>
        /// <see cref="AVCodecContext.rc_override_count" />
        /// </summary>
        public int RcOverrideCount
        {
            get => Pointer->rc_override_count;
            set => Pointer->rc_override_count = value;
        }
        
        /// <summary>
        /// <see cref="AVCodecContext.rc_override" />
        /// </summary>
        public RcOverride* RcOverride
        {
            get => Pointer->rc_override;
            set => Pointer->rc_override = value;
        }
        
        /// <summary>
        /// <para>maximum bitrate - encoding: Set by user.</para>
        /// <para> - decoding: Set by user, may be overwritten by libavcodec.</para>
        /// <see cref="AVCodecContext.rc_max_rate" />
        /// </summary>
        public long RcMaxRate
        {
            get => Pointer->rc_max_rate;
            set => Pointer->rc_max_rate = value;
        }
        
        /// <summary>
        /// <para>minimum bitrate - encoding: Set by user.</para>
        /// <para> - decoding: unused.</para>
        /// <see cref="AVCodecContext.rc_min_rate" />
        /// </summary>
        public long RcMinRate
        {
            get => Pointer->rc_min_rate;
            set => Pointer->rc_min_rate = value;
        }
        
        /// <summary>
        /// <para>Ratecontrol attempt to use, at maximum, &lt;value&gt; of what can be used without an underflow.</para>
        /// <para> - encoding: Set by user.</para>
        /// <para> - decoding: unused.</para>
        /// <see cref="AVCodecContext.rc_max_available_vbv_use" />
        /// </summary>
        public float RcMaxAvailableVbvUse
        {
            get => Pointer->rc_max_available_vbv_use;
            set => Pointer->rc_max_available_vbv_use = value;
        }
        
        /// <summary>
        /// <para>Ratecontrol attempt to use, at least, &lt;value&gt; times the amount needed to prevent a vbv overflow.</para>
        /// <para> - encoding: Set by user.</para>
        /// <para> - decoding: unused.</para>
        /// <see cref="AVCodecContext.rc_min_vbv_overflow_use" />
        /// </summary>
        public float RcMinVbvOverflowUse
        {
            get => Pointer->rc_min_vbv_overflow_use;
            set => Pointer->rc_min_vbv_overflow_use = value;
        }
        
        /// <summary>
        /// <para>Number of bits which should be loaded into the rc buffer before decoding starts.</para>
        /// <para> - encoding: Set by user.</para>
        /// <para> - decoding: unused.</para>
        /// <see cref="AVCodecContext.rc_initial_buffer_occupancy" />
        /// </summary>
        public int RcInitialBufferOccupancy
        {
            get => Pointer->rc_initial_buffer_occupancy;
            set => Pointer->rc_initial_buffer_occupancy = value;
        }
        
        /// <summary>
        /// <para>trellis RD quantization - encoding: Set by user.</para>
        /// <para> - decoding: unused.</para>
        /// <see cref="AVCodecContext.trellis" />
        /// </summary>
        public int Trellis
        {
            get => Pointer->trellis;
            set => Pointer->trellis = value;
        }
        
        /// <summary>
        /// <see cref="AVCodecContext.mv_bits" />
        /// </summary>
        public int MvBits
        {
            get => Pointer->mv_bits;
            set => Pointer->mv_bits = value;
        }
        
        /// <summary>
        /// <see cref="AVCodecContext.header_bits" />
        /// </summary>
        public int HeaderBits
        {
            get => Pointer->header_bits;
            set => Pointer->header_bits = value;
        }
        
        /// <summary>
        /// <see cref="AVCodecContext.i_tex_bits" />
        /// </summary>
        public int ITexBits
        {
            get => Pointer->i_tex_bits;
            set => Pointer->i_tex_bits = value;
        }
        
        /// <summary>
        /// <see cref="AVCodecContext.p_tex_bits" />
        /// </summary>
        public int PTexBits
        {
            get => Pointer->p_tex_bits;
            set => Pointer->p_tex_bits = value;
        }
        
        /// <summary>
        /// <see cref="AVCodecContext.i_count" />
        /// </summary>
        public int ICount
        {
            get => Pointer->i_count;
            set => Pointer->i_count = value;
        }
        
        /// <summary>
        /// <see cref="AVCodecContext.p_count" />
        /// </summary>
        public int PCount
        {
            get => Pointer->p_count;
            set => Pointer->p_count = value;
        }
        
        /// <summary>
        /// <see cref="AVCodecContext.skip_count" />
        /// </summary>
        public int SkipCount
        {
            get => Pointer->skip_count;
            set => Pointer->skip_count = value;
        }
        
        /// <summary>
        /// <see cref="AVCodecContext.misc_bits" />
        /// </summary>
        public int MiscBits
        {
            get => Pointer->misc_bits;
            set => Pointer->misc_bits = value;
        }
        
        /// <summary>
        /// <para>pass1 encoding statistics output buffer - encoding: Set by libavcodec.</para>
        /// <para> - decoding: unused.</para>
        /// <see cref="AVCodecContext.stats_out" />
        /// </summary>
        public IntPtr StatsOut
        {
            get => (IntPtr)Pointer->stats_out;
            set => Pointer->stats_out = (byte*)value;
        }
        
        /// <summary>
        /// <para>pass2 encoding statistics input buffer Concatenated stuff from stats_out of pass1 should be placed here.</para>
        /// <para> - encoding: Allocated/set/freed by user.</para>
        /// <para> - decoding: unused.</para>
        /// <see cref="AVCodecContext.stats_in" />
        /// </summary>
        public IntPtr StatsIn
        {
            get => (IntPtr)Pointer->stats_in;
            set => Pointer->stats_in = (byte*)value;
        }
        
        /// <summary>
        /// <para>Work around bugs in encoders which sometimes cannot be detected automatically.</para>
        /// <para> - encoding: Set by user - decoding: Set by user.</para>
        /// <see cref="AVCodecContext.workaround_bugs" />
        /// </summary>
        public int WorkaroundBugs
        {
            get => Pointer->workaround_bugs;
            set => Pointer->workaround_bugs = value;
        }
        
        /// <summary>
        /// <para>strictly follow the standard (MPEG-4, .</para>
        /// <para>).</para>
        /// <para> - encoding: Set by user.</para>
        /// <para> - decoding: Set by user.</para>
        /// <para> Setting this to STRICT or higher means the encoder and decoder will generally do stupid things, whereas setting it to unofficial or lower will mean the encoder might produce output that is not supported by all spec-compliant decoders.</para>
        /// <para> Decoders don&#39;t differentiate between normal, unofficial and experimental (that is, they always try to decode things when they can) unless they are explicitly asked to behave stupidly (=strictly conform to the specs).</para>
        /// <see cref="AVCodecContext.strict_std_compliance" />
        /// </summary>
        public int StrictStdCompliance
        {
            get => Pointer->strict_std_compliance;
            set => Pointer->strict_std_compliance = value;
        }
        
        /// <summary>
        /// <para>error concealment flags - encoding: unused - decoding: Set by user.</para>
        /// <see cref="AVCodecContext.error_concealment" />
        /// </summary>
        public int ErrorConcealment
        {
            get => Pointer->error_concealment;
            set => Pointer->error_concealment = value;
        }
        
        /// <summary>
        /// <para>debug - encoding: Set by user.</para>
        /// <para> - decoding: Set by user.</para>
        /// <see cref="AVCodecContext.debug" />
        /// </summary>
        public int Debug
        {
            get => Pointer->debug;
            set => Pointer->debug = value;
        }
        
        /// <summary>
        /// <para>Error recognition; may misdetect some more or less valid parts as errors.</para>
        /// <para> - encoding: Set by user.</para>
        /// <para> - decoding: Set by user.</para>
        /// <see cref="AVCodecContext.err_recognition" />
        /// </summary>
        public int ErrRecognition
        {
            get => Pointer->err_recognition;
            set => Pointer->err_recognition = value;
        }
        
        /// <summary>
        /// <para>opaque 64-bit number (generally a PTS) that will be reordered and output in AVFrame.</para>
        /// <para>reordered_opaque - encoding: Set by libavcodec to the reordered_opaque of the input frame corresponding to the last returned packet.</para>
        /// <para> Only supported by encoders with the AV_CODEC_CAP_ENCODER_REORDERED_OPAQUE capability.</para>
        /// <para> - decoding: Set by user.</para>
        /// <see cref="AVCodecContext.reordered_opaque" />
        /// </summary>
        public long ReorderedOpaque
        {
            get => Pointer->reordered_opaque;
            set => Pointer->reordered_opaque = value;
        }
        
        /// <summary>
        /// <para>Hardware accelerator in use - encoding: unused.</para>
        /// <para> - decoding: Set by libavcodec.</para>
        /// <see cref="AVCodecContext.hwaccel" />
        /// </summary>
        public AVHWAccel* Hwaccel
        {
            get => Pointer->hwaccel;
            set => Pointer->hwaccel = value;
        }
        
        /// <summary>
        /// <para>Hardware accelerator context.</para>
        /// <para> For some hardware accelerators, a global context needs to be provided by the user.</para>
        /// <para> In that case, this holds display-dependent data FFmpeg cannot instantiate itself.</para>
        /// <para> Please refer to the FFmpeg HW accelerator documentation to know how to fill this is.</para>
        /// <para> e.</para>
        /// <para>g.</para>
        /// <para> for VA API, this is a struct vaapi_context.</para>
        /// <para> - encoding: unused - decoding: Set by user.</para>
        /// <see cref="AVCodecContext.hwaccel_context" />
        /// </summary>
        public IntPtr HwaccelContext
        {
            get => (IntPtr)Pointer->hwaccel_context;
            set => Pointer->hwaccel_context = (void*)value;
        }
        
        /// <summary>
        /// <para>error - encoding: Set by libavcodec if flags &amp; AV_CODEC_FLAG_PSNR.</para>
        /// <para> - decoding: unused.</para>
        /// <see cref="AVCodecContext.error" />
        /// </summary>
        public ulong_array8 Error
        {
            get => Pointer->error;
            set => Pointer->error = value;
        }
        
        /// <summary>
        /// <para>DCT algorithm, see FF_DCT_* below - encoding: Set by user.</para>
        /// <para> - decoding: unused.</para>
        /// <see cref="AVCodecContext.dct_algo" />
        /// </summary>
        public int DctAlgo
        {
            get => Pointer->dct_algo;
            set => Pointer->dct_algo = value;
        }
        
        /// <summary>
        /// <para>IDCT algorithm, see FF_IDCT_* below.</para>
        /// <para> - encoding: Set by user.</para>
        /// <para> - decoding: Set by user.</para>
        /// <see cref="AVCodecContext.idct_algo" />
        /// </summary>
        public int IdctAlgo
        {
            get => Pointer->idct_algo;
            set => Pointer->idct_algo = value;
        }
        
        /// <summary>
        /// <para>bits per sample/pixel from the demuxer (needed for huffyuv).</para>
        /// <para> - encoding: Set by libavcodec.</para>
        /// <para> - decoding: Set by user.</para>
        /// <see cref="AVCodecContext.bits_per_coded_sample" />
        /// </summary>
        public int BitsPerCodedSample
        {
            get => Pointer->bits_per_coded_sample;
            set => Pointer->bits_per_coded_sample = value;
        }
        
        /// <summary>
        /// <para>Bits per sample/pixel of internal libavcodec pixel/sample format.</para>
        /// <para> - encoding: set by user.</para>
        /// <para> - decoding: set by libavcodec.</para>
        /// <see cref="AVCodecContext.bits_per_raw_sample" />
        /// </summary>
        public int BitsPerRawSample
        {
            get => Pointer->bits_per_raw_sample;
            set => Pointer->bits_per_raw_sample = value;
        }
        
        /// <summary>
        /// <para>low resolution decoding, 1-&gt; 1/2 size, 2-&gt;1/4 size - encoding: unused - decoding: Set by user.</para>
        /// <see cref="AVCodecContext.lowres" />
        /// </summary>
        public int Lowres
        {
            get => Pointer->lowres;
            set => Pointer->lowres = value;
        }
        
        /// <summary>
        /// <para>thread count is used to decide how many independent tasks should be passed to execute() - encoding: Set by user.</para>
        /// <para> - decoding: Set by user.</para>
        /// <see cref="AVCodecContext.thread_count" />
        /// </summary>
        public int ThreadCount
        {
            get => Pointer->thread_count;
            set => Pointer->thread_count = value;
        }
        
        /// <summary>
        /// <para>Which multithreading methods to use.</para>
        /// <para> Use of FF_THREAD_FRAME will increase decoding delay by one frame per thread, so clients which cannot provide future frames should not use it.</para>
        /// <see cref="AVCodecContext.thread_type" />
        /// </summary>
        public int ThreadType
        {
            get => Pointer->thread_type;
            set => Pointer->thread_type = value;
        }
        
        /// <summary>
        /// <para>Which multithreading methods are in use by the codec.</para>
        /// <para> - encoding: Set by libavcodec.</para>
        /// <para> - decoding: Set by libavcodec.</para>
        /// <see cref="AVCodecContext.active_thread_type" />
        /// </summary>
        public int ActiveThreadType
        {
            get => Pointer->active_thread_type;
            set => Pointer->active_thread_type = value;
        }
        
        /// <summary>
        /// <para>noise vs.</para>
        /// <para> sse weight for the nsse comparison function - encoding: Set by user.</para>
        /// <para> - decoding: unused.</para>
        /// <see cref="AVCodecContext.nsse_weight" />
        /// </summary>
        public int NsseWeight
        {
            get => Pointer->nsse_weight;
            set => Pointer->nsse_weight = value;
        }
        
        /// <summary>
        /// <para>profile - encoding: Set by user.</para>
        /// <para> - decoding: Set by libavcodec.</para>
        /// <see cref="AVCodecContext.profile" />
        /// </summary>
        public int Profile
        {
            get => Pointer->profile;
            set => Pointer->profile = value;
        }
        
        /// <summary>
        /// <para>level - encoding: Set by user.</para>
        /// <para> - decoding: Set by libavcodec.</para>
        /// <see cref="AVCodecContext.level" />
        /// </summary>
        public int Level
        {
            get => Pointer->level;
            set => Pointer->level = value;
        }
        
        /// <summary>
        /// <para>Skip loop filtering for selected frames.</para>
        /// <para> - encoding: unused - decoding: Set by user.</para>
        /// <see cref="AVCodecContext.skip_loop_filter" />
        /// </summary>
        public MediaDiscard SkipLoopFilter
        {
            get => (MediaDiscard)Pointer->skip_loop_filter;
            set => Pointer->skip_loop_filter = (AVDiscard)value;
        }
        
        /// <summary>
        /// <para>Skip IDCT/dequantization for selected frames.</para>
        /// <para> - encoding: unused - decoding: Set by user.</para>
        /// <see cref="AVCodecContext.skip_idct" />
        /// </summary>
        public MediaDiscard SkipIdct
        {
            get => (MediaDiscard)Pointer->skip_idct;
            set => Pointer->skip_idct = (AVDiscard)value;
        }
        
        /// <summary>
        /// <para>Skip decoding for selected frames.</para>
        /// <para> - encoding: unused - decoding: Set by user.</para>
        /// <see cref="AVCodecContext.skip_frame" />
        /// </summary>
        public MediaDiscard SkipFrame
        {
            get => (MediaDiscard)Pointer->skip_frame;
            set => Pointer->skip_frame = (AVDiscard)value;
        }
        
        /// <summary>
        /// <para>Header containing style information for text subtitles.</para>
        /// <para> For SUBTITLE_ASS subtitle type, it should contain the whole ASS [Script Info] and [V4+ Styles] section, plus the [Events] line and the Format line following.</para>
        /// <para> It shouldn&#39;t include any Dialogue line.</para>
        /// <para> - encoding: Set/allocated/freed by user (before avcodec_open2()) - decoding: Set/allocated/freed by libavcodec (by avcodec_open2()).</para>
        /// <see cref="AVCodecContext.subtitle_header" />
        /// </summary>
        public IntPtr SubtitleHeader
        {
            get => (IntPtr)Pointer->subtitle_header;
            set => Pointer->subtitle_header = (byte*)value;
        }
        
        /// <summary>
        /// <see cref="AVCodecContext.subtitle_header_size" />
        /// </summary>
        public int SubtitleHeaderSize
        {
            get => Pointer->subtitle_header_size;
            set => Pointer->subtitle_header_size = value;
        }
        
        /// <summary>
        /// <para>Audio only.</para>
        /// <para> The number of &quot;priming&quot; samples (padding) inserted by the encoder at the beginning of the audio.</para>
        /// <para> I.</para>
        /// <para>e.</para>
        /// <para> this number of leading decoded samples must be discarded by the caller to get the original audio without leading padding.</para>
        /// <see cref="AVCodecContext.initial_padding" />
        /// </summary>
        public int InitialPadding
        {
            get => Pointer->initial_padding;
            set => Pointer->initial_padding = value;
        }
        
        /// <summary>
        /// <para>- decoding: For codecs that store a framerate value in the compressed bitstream, the decoder may export it here.</para>
        /// <para> { 0, 1} when unknown.</para>
        /// <para> - encoding: May be used to signal the framerate of CFR content to an encoder.</para>
        /// <see cref="AVCodecContext.framerate" />
        /// </summary>
        public MediaRational Framerate
        {
            get => Pointer->framerate;
            set => Pointer->framerate = value;
        }
        
        /// <summary>
        /// <para>Nominal unaccelerated pixel format, see AV_PIX_FMT_xxx.</para>
        /// <para> - encoding: unused.</para>
        /// <para> - decoding: Set by libavcodec before calling get_format().</para>
        /// <see cref="AVCodecContext.sw_pix_fmt" />
        /// </summary>
        public PixelFormat SwPixelFormat
        {
            get => (PixelFormat)Pointer->sw_pix_fmt;
            set => Pointer->sw_pix_fmt = (AVPixelFormat)value;
        }
        
        /// <summary>
        /// <para>Timebase in which pkt_dts/pts and AVPacket.</para>
        /// <para>dts/pts are.</para>
        /// <para> - encoding unused.</para>
        /// <para> - decoding set by user.</para>
        /// <see cref="AVCodecContext.pkt_timebase" />
        /// </summary>
        public MediaRational PacketTimebase
        {
            get => Pointer->pkt_timebase;
            set => Pointer->pkt_timebase = value;
        }
        
        /// <summary>
        /// <para>AVCodecDescriptor - encoding: unused.</para>
        /// <para> - decoding: set by libavcodec.</para>
        /// <see cref="AVCodecContext.codec_descriptor" />
        /// </summary>
        public AVCodecDescriptor* CodecDescriptor
        {
            get => Pointer->codec_descriptor;
            set => Pointer->codec_descriptor = value;
        }
        
        /// <summary>
        /// <para>Current statistics for PTS correction.</para>
        /// <para> - decoding: maintained and used by libavcodec, not intended to be used by user apps - encoding: unused.</para>
        /// <see cref="AVCodecContext.pts_correction_num_faulty_pts" />
        /// </summary>
        public long PtsCorrectionNumFaultyPts
        {
            get => Pointer->pts_correction_num_faulty_pts;
            set => Pointer->pts_correction_num_faulty_pts = value;
        }
        
        /// <summary>
        /// <para>Number of incorrect PTS values so far.</para>
        /// <see cref="AVCodecContext.pts_correction_num_faulty_dts" />
        /// </summary>
        public long PtsCorrectionNumFaultyDts
        {
            get => Pointer->pts_correction_num_faulty_dts;
            set => Pointer->pts_correction_num_faulty_dts = value;
        }
        
        /// <summary>
        /// <para>Number of incorrect DTS values so far.</para>
        /// <see cref="AVCodecContext.pts_correction_last_pts" />
        /// </summary>
        public long PtsCorrectionLastPts
        {
            get => Pointer->pts_correction_last_pts;
            set => Pointer->pts_correction_last_pts = value;
        }
        
        /// <summary>
        /// <para>PTS of the last frame.</para>
        /// <see cref="AVCodecContext.pts_correction_last_dts" />
        /// </summary>
        public long PtsCorrectionLastDts
        {
            get => Pointer->pts_correction_last_dts;
            set => Pointer->pts_correction_last_dts = value;
        }
        
        /// <summary>
        /// <para>Character encoding of the input subtitles file.</para>
        /// <para> - decoding: set by user - encoding: unused.</para>
        /// <see cref="AVCodecContext.sub_charenc" />
        /// </summary>
        public IntPtr SubCharenc
        {
            get => (IntPtr)Pointer->sub_charenc;
            set => Pointer->sub_charenc = (byte*)value;
        }
        
        /// <summary>
        /// <para>Subtitles character encoding mode.</para>
        /// <para> Formats or codecs might be adjusting this setting (if they are doing the conversion themselves for instance).</para>
        /// <para> - decoding: set by libavcodec - encoding: unused.</para>
        /// <see cref="AVCodecContext.sub_charenc_mode" />
        /// </summary>
        public int SubCharencMode
        {
            get => Pointer->sub_charenc_mode;
            set => Pointer->sub_charenc_mode = value;
        }
        
        /// <summary>
        /// <para>Skip processing alpha if supported by codec.</para>
        /// <para> Note that if the format uses pre-multiplied alpha (common with VP6, and recommended due to better video quality/compression) the image will look as if alpha-blended onto a black background.</para>
        /// <para> However for formats that do not use pre-multiplied alpha there might be serious artefacts (though e.</para>
        /// <para>g.</para>
        /// <para> libswscale currently assumes pre-multiplied alpha anyway).</para>
        /// <see cref="AVCodecContext.skip_alpha" />
        /// </summary>
        public int SkipAlpha
        {
            get => Pointer->skip_alpha;
            set => Pointer->skip_alpha = value;
        }
        
        /// <summary>
        /// <para>Number of samples to skip after a discontinuity - decoding: unused - encoding: set by libavcodec.</para>
        /// <see cref="AVCodecContext.seek_preroll" />
        /// </summary>
        public int SeekPreroll
        {
            get => Pointer->seek_preroll;
            set => Pointer->seek_preroll = value;
        }
        
        /// <summary>
        /// <para>custom intra quantization matrix - encoding: Set by user, can be NULL.</para>
        /// <para> - decoding: unused.</para>
        /// <see cref="AVCodecContext.chroma_intra_matrix" />
        /// </summary>
        public ushort* ChromaIntraMatrix
        {
            get => Pointer->chroma_intra_matrix;
            set => Pointer->chroma_intra_matrix = value;
        }
        
        /// <summary>
        /// <para>dump format separator.</para>
        /// <para> can be &quot;, &quot; or &quot; &quot; or anything else - encoding: Set by user.</para>
        /// <para> - decoding: Set by user.</para>
        /// <see cref="AVCodecContext.dump_separator" />
        /// </summary>
        public IntPtr DumpSeparator
        {
            get => (IntPtr)Pointer->dump_separator;
            set => Pointer->dump_separator = (byte*)value;
        }
        
        /// <summary>
        /// <para>&#39;,&#39; separated list of allowed decoders.</para>
        /// <para> If NULL then all are allowed - encoding: unused - decoding: set by user.</para>
        /// <see cref="AVCodecContext.codec_whitelist" />
        /// </summary>
        public IntPtr CodecWhitelist
        {
            get => (IntPtr)Pointer->codec_whitelist;
            set => Pointer->codec_whitelist = (byte*)value;
        }
        
        /// <summary>
        /// <para>Properties of the stream that gets decoded - encoding: unused - decoding: set by libavcodec.</para>
        /// <see cref="AVCodecContext.properties" />
        /// </summary>
        public uint Properties
        {
            get => Pointer->properties;
            set => Pointer->properties = value;
        }
        
        /// <summary>
        /// <para>Additional data associated with the entire coded stream.</para>
        /// <see cref="AVCodecContext.coded_side_data" />
        /// </summary>
        public AVPacketSideData* CodedSideData
        {
            get => Pointer->coded_side_data;
            set => Pointer->coded_side_data = value;
        }
        
        /// <summary>
        /// <see cref="AVCodecContext.nb_coded_side_data" />
        /// </summary>
        public int NbCodedSideData
        {
            get => Pointer->nb_coded_side_data;
            set => Pointer->nb_coded_side_data = value;
        }
        
        /// <summary>
        /// <para>A reference to the AVHWFramesContext describing the input (for encoding) or output (decoding) frames.</para>
        /// <para> The reference is set by the caller and afterwards owned (and freed) by libavcodec - it should never be read by the caller after being set.</para>
        /// <see cref="AVCodecContext.hw_frames_ctx" />
        /// </summary>
        public BufferReference HwFramesContext
        {
            get => BufferReference.FromNative(Pointer->hw_frames_ctx, isOwner: false);
            set => Pointer->hw_frames_ctx = value;
        }
        
        /// <summary>
        /// <para>Control the form of AVSubtitle.</para>
        /// <para>rects[N]-&gt;ass - decoding: set by user - encoding: unused.</para>
        /// <see cref="AVCodecContext.sub_text_format" />
        /// </summary>
        public int SubTextFormat
        {
            get => Pointer->sub_text_format;
            set => Pointer->sub_text_format = value;
        }
        
        /// <summary>
        /// <para>Audio only.</para>
        /// <para> The amount of padding (in samples) appended by the encoder to the end of the audio.</para>
        /// <para> I.</para>
        /// <para>e.</para>
        /// <para> this number of decoded samples must be discarded by the caller from the end of the stream to get the original audio without any trailing padding.</para>
        /// <see cref="AVCodecContext.trailing_padding" />
        /// </summary>
        public int TrailingPadding
        {
            get => Pointer->trailing_padding;
            set => Pointer->trailing_padding = value;
        }
        
        /// <summary>
        /// <para>The number of pixels per image to maximally accept.</para>
        /// <see cref="AVCodecContext.max_pixels" />
        /// </summary>
        public long MaxPixels
        {
            get => Pointer->max_pixels;
            set => Pointer->max_pixels = value;
        }
        
        /// <summary>
        /// <para>A reference to the AVHWDeviceContext describing the device which will be used by a hardware encoder/decoder.</para>
        /// <para> The reference is set by the caller and afterwards owned (and freed) by libavcodec.</para>
        /// <see cref="AVCodecContext.hw_device_ctx" />
        /// </summary>
        public BufferReference HwDeviceContext
        {
            get => BufferReference.FromNative(Pointer->hw_device_ctx, isOwner: false);
            set => Pointer->hw_device_ctx = value;
        }
        
        /// <summary>
        /// <para>Bit set of AV_HWACCEL_FLAG_* flags, which affect hardware accelerated decoding (if active).</para>
        /// <para> - encoding: unused - decoding: Set by user (either before avcodec_open2(), or in the AVCodecContext.</para>
        /// <para>get_format callback).</para>
        /// <see cref="AVCodecContext.hwaccel_flags" />
        /// </summary>
        public int HwaccelFlags
        {
            get => Pointer->hwaccel_flags;
            set => Pointer->hwaccel_flags = value;
        }
        
        /// <summary>
        /// <para>Video decoding only.</para>
        /// <para> Certain video codecs support cropping, meaning that only a sub-rectangle of the decoded frame is intended for display.</para>
        /// <para> This option controls how cropping is handled by libavcodec.</para>
        /// <see cref="AVCodecContext.apply_cropping" />
        /// </summary>
        public int ApplyCropping
        {
            get => Pointer->apply_cropping;
            set => Pointer->apply_cropping = value;
        }
        
        /// <summary>
        /// <see cref="AVCodecContext.extra_hw_frames" />
        /// </summary>
        public int ExtraHwFrames
        {
            get => Pointer->extra_hw_frames;
            set => Pointer->extra_hw_frames = value;
        }
        
        /// <summary>
        /// <para>The percentage of damaged samples to discard a frame.</para>
        /// <see cref="AVCodecContext.discard_damaged_percentage" />
        /// </summary>
        public int DiscardDamagedPercentage
        {
            get => Pointer->discard_damaged_percentage;
            set => Pointer->discard_damaged_percentage = value;
        }
        
        /// <summary>
        /// <para>The number of samples per frame to maximally accept.</para>
        /// <see cref="AVCodecContext.max_samples" />
        /// </summary>
        public long MaxSamples
        {
            get => Pointer->max_samples;
            set => Pointer->max_samples = value;
        }
        
        /// <summary>
        /// <para>Bit set of AV_CODEC_EXPORT_DATA_* flags, which affects the kind of metadata exported in frame, packet, or coded stream side data by decoders and encoders.</para>
        /// <see cref="AVCodecContext.export_side_data" />
        /// </summary>
        public CodecExportData ExportSideData
        {
            get => (CodecExportData)Pointer->export_side_data;
            set => Pointer->export_side_data = (int)value;
        }
    }
}
