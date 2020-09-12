using System;
using Sdcb.FFmpegAPIWrapper.Common;
using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;

namespace Sdcb.FFmpegAPIWrapper.MediaCodecs
{
    public unsafe partial class MediaCodecContext : FFmpegHandle
    {
        private AVCodecContext* Pointer => this;
        
        public static implicit operator AVCodecContext*(MediaCodecContext data) => (AVCodecContext*)data._handle;
        
        public MediaCodecContext(AVCodecContext* ptr) : base((IntPtr)ptr) 
        {
            if (ptr == null)
            {
                throw new ArgumentNullException(nameof(ptr));
            }
        }
        
        /// <summary>information on struct for av_log - set by avcodec_alloc_context3</summary>
        public FFmpegClass AvClass
        {
            get => FFmpegClass.FromNative(Pointer->av_class);
            set => Pointer->av_class = value;
        }
        
        public int LogLevelOffset
        {
            get => Pointer->log_level_offset;
            set => Pointer->log_level_offset = value;
        }
        
        public AVMediaType CodecType
        {
            get => Pointer->codec_type;
            set => Pointer->codec_type = value;
        }
        
        public MediaCodec Codec
        {
            get => MediaCodec.FromNative(Pointer->codec);
            set => Pointer->codec = value;
        }
        
        public AVCodecID CodecId
        {
            get => Pointer->codec_id;
            set => Pointer->codec_id = value;
        }
        
        /// <summary>fourcc (LSB first, so "ABCD" -&gt; ('D'&lt;&lt;24) + ('C'&lt;&lt;16) + ('B'&lt;&lt;8) + 'A'). This is used to work around some encoder bugs. A demuxer should set this to what is stored in the field used to identify the codec. If there are multiple such fields in a container then the demuxer should choose the one which maximizes the information about the used codec. If the codec tag field in a container is larger than 32 bits then the demuxer should remap the longer ID to 32 bits with a table or other structure. Alternatively a new extra_codec_tag + size could be added but for this a clear advantage must be demonstrated first. - encoding: Set by user, if not then the default based on codec_id will be used. - decoding: Set by user, will be converted to uppercase by libavcodec during init.</summary>
        public uint CodecTag
        {
            get => Pointer->codec_tag;
            set => Pointer->codec_tag = value;
        }
        
        public IntPtr PrivData
        {
            get => (IntPtr)Pointer->priv_data;
            set => Pointer->priv_data = (void*)value;
        }
        
        public AVCodecInternal* @internal
        {
            get => Pointer->@internal;
            set => Pointer->@internal = value;
        }
        
        /// <summary>Private data of the user, can be used to carry app specific stuff. - encoding: Set by user. - decoding: Set by user.</summary>
        public IntPtr Opaque
        {
            get => (IntPtr)Pointer->opaque;
            set => Pointer->opaque = (void*)value;
        }
        
        /// <summary>the average bitrate - encoding: Set by user; unused for constant quantizer encoding. - decoding: Set by user, may be overwritten by libavcodec if this info is available in the stream</summary>
        public long BitRate
        {
            get => Pointer->bit_rate;
            set => Pointer->bit_rate = value;
        }
        
        /// <summary>number of bits the bitstream is allowed to diverge from the reference. the reference can be CBR (for CBR pass1) or VBR (for pass2) - encoding: Set by user; unused for constant quantizer encoding. - decoding: unused</summary>
        public int BitRateTolerance
        {
            get => Pointer->bit_rate_tolerance;
            set => Pointer->bit_rate_tolerance = value;
        }
        
        /// <summary>Global quality for codecs which cannot change it per frame. This should be proportional to MPEG-1/2/4 qscale. - encoding: Set by user. - decoding: unused</summary>
        public int GlobalQuality
        {
            get => Pointer->global_quality;
            set => Pointer->global_quality = value;
        }
        
        /// <summary>- encoding: Set by user. - decoding: unused</summary>
        public int CompressionLevel
        {
            get => Pointer->compression_level;
            set => Pointer->compression_level = value;
        }
        
        /// <summary>AV_CODEC_FLAG_*. - encoding: Set by user. - decoding: Set by user.</summary>
        public CodecFlags Flags
        {
            get => (CodecFlags)Pointer->flags;
            set => Pointer->flags = (int)value;
        }
        
        /// <summary>AV_CODEC_FLAG2_* - encoding: Set by user. - decoding: Set by user.</summary>
        public CodecFlags2 Flags2
        {
            get => (CodecFlags2)Pointer->flags2;
            set => Pointer->flags2 = (int)value;
        }
        
        /// <summary>some codecs need / can use extradata like Huffman tables. MJPEG: Huffman tables rv10: additional flags MPEG-4: global headers (they can be in the bitstream or here) The allocated memory should be AV_INPUT_BUFFER_PADDING_SIZE bytes larger than extradata_size to avoid problems if it is read with the bitstream reader. The bytewise contents of extradata must not depend on the architecture or CPU endianness. Must be allocated with the av_malloc() family of functions. - encoding: Set/allocated/freed by libavcodec. - decoding: Set/allocated/freed by user.</summary>
        public byte* Extradata
        {
            get => Pointer->extradata;
            set => Pointer->extradata = value;
        }
        
        public int ExtradataSize
        {
            get => Pointer->extradata_size;
            set => Pointer->extradata_size = value;
        }
        
        /// <summary>This is the fundamental unit of time (in seconds) in terms of which frame timestamps are represented. For fixed-fps content, timebase should be 1/framerate and timestamp increments should be identically 1. This often, but not always is the inverse of the frame rate or field rate for video. 1/time_base is not the average frame rate if the frame rate is not constant.</summary>
        public MediaRational TimeBase
        {
            get => Pointer->time_base;
            set => Pointer->time_base = value;
        }
        
        /// <summary>For some codecs, the time base is closer to the field rate than the frame rate. Most notably, H.264 and MPEG-2 specify time_base as half of frame duration if no telecine is used ...</summary>
        public int TicksPerFrame
        {
            get => Pointer->ticks_per_frame;
            set => Pointer->ticks_per_frame = value;
        }
        
        /// <summary>Codec delay.</summary>
        public int Delay
        {
            get => Pointer->delay;
            set => Pointer->delay = value;
        }
        
        /// <summary>picture width / height.</summary>
        public int Width
        {
            get => Pointer->width;
            set => Pointer->width = value;
        }
        
        /// <summary>picture width / height.</summary>
        public int Height
        {
            get => Pointer->height;
            set => Pointer->height = value;
        }
        
        /// <summary>Bitstream width / height, may be different from width/height e.g. when the decoded frame is cropped before being output or lowres is enabled.</summary>
        public int CodedWidth
        {
            get => Pointer->coded_width;
            set => Pointer->coded_width = value;
        }
        
        /// <summary>Bitstream width / height, may be different from width/height e.g. when the decoded frame is cropped before being output or lowres is enabled.</summary>
        public int CodedHeight
        {
            get => Pointer->coded_height;
            set => Pointer->coded_height = value;
        }
        
        /// <summary>the number of pictures in a group of pictures, or 0 for intra_only - encoding: Set by user. - decoding: unused</summary>
        public int GopSize
        {
            get => Pointer->gop_size;
            set => Pointer->gop_size = value;
        }
        
        /// <summary>Pixel format, see AV_PIX_FMT_xxx. May be set by the demuxer if known from headers. May be overridden by the decoder if it knows better.</summary>
        public AVPixelFormat PixFmt
        {
            get => Pointer->pix_fmt;
            set => Pointer->pix_fmt = value;
        }
        
        /// <summary>If non NULL, 'draw_horiz_band' is called by the libavcodec decoder to draw a horizontal band. It improves cache usage. Not all codecs can do that. You must check the codec capabilities beforehand. When multithreading is used, it may be called from multiple threads at the same time; threads might draw different parts of the same AVFrame, or multiple AVFrames, and there is no guarantee that slices will be drawn in order. The function is also used by hardware acceleration APIs. It is called at least once during frame decoding to pass the data needed for hardware render. In that mode instead of pixel data, AVFrame points to a structure specific to the acceleration API. The application reads the structure and can change some fields to indicate progress or mark state. - encoding: unused - decoding: Set by user.</summary>
        public AVCodecContext_draw_horiz_band_func DrawHorizBand
        {
            get => Pointer->draw_horiz_band;
            set => Pointer->draw_horiz_band = value;
        }
        
        /// <summary>callback to negotiate the pixelFormat</summary>
        public AVCodecContext_get_format_func GetFormat
        {
            get => Pointer->get_format;
            set => Pointer->get_format = value;
        }
        
        /// <summary>maximum number of B-frames between non-B-frames Note: The output will be delayed by max_b_frames+1 relative to the input. - encoding: Set by user. - decoding: unused</summary>
        public int MaxBFrames
        {
            get => Pointer->max_b_frames;
            set => Pointer->max_b_frames = value;
        }
        
        /// <summary>qscale factor between IP and B-frames If &gt; 0 then the last P-frame quantizer will be used (q= lastp_q*factor+offset). If &lt; 0 then normal ratecontrol will be done (q= -normal_q*factor+offset). - encoding: Set by user. - decoding: unused</summary>
        public float BQuantFactor
        {
            get => Pointer->b_quant_factor;
            set => Pointer->b_quant_factor = value;
        }
        
        public int BFrameStrategy
        {
            get => Pointer->b_frame_strategy;
            set => Pointer->b_frame_strategy = value;
        }
        
        /// <summary>qscale offset between IP and B-frames - encoding: Set by user. - decoding: unused</summary>
        public float BQuantOffset
        {
            get => Pointer->b_quant_offset;
            set => Pointer->b_quant_offset = value;
        }
        
        /// <summary>Size of the frame reordering buffer in the decoder. For MPEG-2 it is 1 IPB or 0 low delay IP. - encoding: Set by libavcodec. - decoding: Set by libavcodec.</summary>
        public int HasBFrames
        {
            get => Pointer->has_b_frames;
            set => Pointer->has_b_frames = value;
        }
        
        public int MpegQuant
        {
            get => Pointer->mpeg_quant;
            set => Pointer->mpeg_quant = value;
        }
        
        /// <summary>qscale factor between P- and I-frames If &gt; 0 then the last P-frame quantizer will be used (q = lastp_q * factor + offset). If &lt; 0 then normal ratecontrol will be done (q= -normal_q*factor+offset). - encoding: Set by user. - decoding: unused</summary>
        public float IQuantFactor
        {
            get => Pointer->i_quant_factor;
            set => Pointer->i_quant_factor = value;
        }
        
        /// <summary>qscale offset between P and I-frames - encoding: Set by user. - decoding: unused</summary>
        public float IQuantOffset
        {
            get => Pointer->i_quant_offset;
            set => Pointer->i_quant_offset = value;
        }
        
        /// <summary>luminance masking (0-&gt; disabled) - encoding: Set by user. - decoding: unused</summary>
        public float LumiMasking
        {
            get => Pointer->lumi_masking;
            set => Pointer->lumi_masking = value;
        }
        
        /// <summary>temporary complexity masking (0-&gt; disabled) - encoding: Set by user. - decoding: unused</summary>
        public float TemporalCplxMasking
        {
            get => Pointer->temporal_cplx_masking;
            set => Pointer->temporal_cplx_masking = value;
        }
        
        /// <summary>spatial complexity masking (0-&gt; disabled) - encoding: Set by user. - decoding: unused</summary>
        public float SpatialCplxMasking
        {
            get => Pointer->spatial_cplx_masking;
            set => Pointer->spatial_cplx_masking = value;
        }
        
        /// <summary>p block masking (0-&gt; disabled) - encoding: Set by user. - decoding: unused</summary>
        public float PMasking
        {
            get => Pointer->p_masking;
            set => Pointer->p_masking = value;
        }
        
        /// <summary>darkness masking (0-&gt; disabled) - encoding: Set by user. - decoding: unused</summary>
        public float DarkMasking
        {
            get => Pointer->dark_masking;
            set => Pointer->dark_masking = value;
        }
        
        /// <summary>slice count - encoding: Set by libavcodec. - decoding: Set by user (or 0).</summary>
        public int SliceCount
        {
            get => Pointer->slice_count;
            set => Pointer->slice_count = value;
        }
        
        public int PredictionMethod
        {
            get => Pointer->prediction_method;
            set => Pointer->prediction_method = value;
        }
        
        /// <summary>slice offsets in the frame in bytes - encoding: Set/allocated by libavcodec. - decoding: Set/allocated by user (or NULL).</summary>
        public int* SliceOffset
        {
            get => Pointer->slice_offset;
            set => Pointer->slice_offset = value;
        }
        
        /// <summary>sample aspect ratio (0 if unknown) That is the width of a pixel divided by the height of the pixel. Numerator and denominator must be relatively prime and smaller than 256 for some video standards. - encoding: Set by user. - decoding: Set by libavcodec.</summary>
        public MediaRational SampleAspectRatio
        {
            get => Pointer->sample_aspect_ratio;
            set => Pointer->sample_aspect_ratio = value;
        }
        
        /// <summary>motion estimation comparison function - encoding: Set by user. - decoding: unused</summary>
        public int MeCmp
        {
            get => Pointer->me_cmp;
            set => Pointer->me_cmp = value;
        }
        
        /// <summary>subpixel motion estimation comparison function - encoding: Set by user. - decoding: unused</summary>
        public int MeSubCmp
        {
            get => Pointer->me_sub_cmp;
            set => Pointer->me_sub_cmp = value;
        }
        
        /// <summary>macroblock comparison function (not supported yet) - encoding: Set by user. - decoding: unused</summary>
        public int MbCmp
        {
            get => Pointer->mb_cmp;
            set => Pointer->mb_cmp = value;
        }
        
        /// <summary>interlaced DCT comparison function - encoding: Set by user. - decoding: unused</summary>
        public int IldctCmp
        {
            get => Pointer->ildct_cmp;
            set => Pointer->ildct_cmp = value;
        }
        
        /// <summary>ME diamond size &amp; shape - encoding: Set by user. - decoding: unused</summary>
        public int DiaSize
        {
            get => Pointer->dia_size;
            set => Pointer->dia_size = value;
        }
        
        /// <summary>amount of previous MV predictors (2a+1 x 2a+1 square) - encoding: Set by user. - decoding: unused</summary>
        public int LastPredictorCount
        {
            get => Pointer->last_predictor_count;
            set => Pointer->last_predictor_count = value;
        }
        
        public int PreMe
        {
            get => Pointer->pre_me;
            set => Pointer->pre_me = value;
        }
        
        /// <summary>motion estimation prepass comparison function - encoding: Set by user. - decoding: unused</summary>
        public int MePreCmp
        {
            get => Pointer->me_pre_cmp;
            set => Pointer->me_pre_cmp = value;
        }
        
        /// <summary>ME prepass diamond size &amp; shape - encoding: Set by user. - decoding: unused</summary>
        public int PreDiaSize
        {
            get => Pointer->pre_dia_size;
            set => Pointer->pre_dia_size = value;
        }
        
        /// <summary>subpel ME quality - encoding: Set by user. - decoding: unused</summary>
        public int MeSubpelQuality
        {
            get => Pointer->me_subpel_quality;
            set => Pointer->me_subpel_quality = value;
        }
        
        /// <summary>maximum motion estimation search range in subpel units If 0 then no limit.</summary>
        public int MeRange
        {
            get => Pointer->me_range;
            set => Pointer->me_range = value;
        }
        
        /// <summary>slice flags - encoding: unused - decoding: Set by user.</summary>
        public int SliceFlags
        {
            get => Pointer->slice_flags;
            set => Pointer->slice_flags = value;
        }
        
        /// <summary>macroblock decision mode - encoding: Set by user. - decoding: unused</summary>
        public int MbDecision
        {
            get => Pointer->mb_decision;
            set => Pointer->mb_decision = value;
        }
        
        /// <summary>custom intra quantization matrix Must be allocated with the av_malloc() family of functions, and will be freed in avcodec_free_context(). - encoding: Set/allocated by user, freed by libavcodec. Can be NULL. - decoding: Set/allocated/freed by libavcodec.</summary>
        public ushort* IntraMatrix
        {
            get => Pointer->intra_matrix;
            set => Pointer->intra_matrix = value;
        }
        
        /// <summary>custom inter quantization matrix Must be allocated with the av_malloc() family of functions, and will be freed in avcodec_free_context(). - encoding: Set/allocated by user, freed by libavcodec. Can be NULL. - decoding: Set/allocated/freed by libavcodec.</summary>
        public ushort* InterMatrix
        {
            get => Pointer->inter_matrix;
            set => Pointer->inter_matrix = value;
        }
        
        public int ScenechangeThreshold
        {
            get => Pointer->scenechange_threshold;
            set => Pointer->scenechange_threshold = value;
        }
        
        public int NoiseReduction
        {
            get => Pointer->noise_reduction;
            set => Pointer->noise_reduction = value;
        }
        
        /// <summary>precision of the intra DC coefficient - 8 - encoding: Set by user. - decoding: Set by libavcodec</summary>
        public int IntraDcPrecision
        {
            get => Pointer->intra_dc_precision;
            set => Pointer->intra_dc_precision = value;
        }
        
        /// <summary>Number of macroblock rows at the top which are skipped. - encoding: unused - decoding: Set by user.</summary>
        public int SkipTop
        {
            get => Pointer->skip_top;
            set => Pointer->skip_top = value;
        }
        
        /// <summary>Number of macroblock rows at the bottom which are skipped. - encoding: unused - decoding: Set by user.</summary>
        public int SkipBottom
        {
            get => Pointer->skip_bottom;
            set => Pointer->skip_bottom = value;
        }
        
        /// <summary>minimum MB Lagrange multiplier - encoding: Set by user. - decoding: unused</summary>
        public int MbLmin
        {
            get => Pointer->mb_lmin;
            set => Pointer->mb_lmin = value;
        }
        
        /// <summary>maximum MB Lagrange multiplier - encoding: Set by user. - decoding: unused</summary>
        public int MbLmax
        {
            get => Pointer->mb_lmax;
            set => Pointer->mb_lmax = value;
        }
        
        public int MePenaltyCompensation
        {
            get => Pointer->me_penalty_compensation;
            set => Pointer->me_penalty_compensation = value;
        }
        
        /// <summary>- encoding: Set by user. - decoding: unused</summary>
        public int BidirRefine
        {
            get => Pointer->bidir_refine;
            set => Pointer->bidir_refine = value;
        }
        
        public int BrdScale
        {
            get => Pointer->brd_scale;
            set => Pointer->brd_scale = value;
        }
        
        /// <summary>minimum GOP size - encoding: Set by user. - decoding: unused</summary>
        public int KeyintMin
        {
            get => Pointer->keyint_min;
            set => Pointer->keyint_min = value;
        }
        
        /// <summary>number of reference frames - encoding: Set by user. - decoding: Set by lavc.</summary>
        public int Refs
        {
            get => Pointer->refs;
            set => Pointer->refs = value;
        }
        
        public int Chromaoffset
        {
            get => Pointer->chromaoffset;
            set => Pointer->chromaoffset = value;
        }
        
        /// <summary>Note: Value depends upon the compare function used for fullpel ME. - encoding: Set by user. - decoding: unused</summary>
        public int Mv0Threshold
        {
            get => Pointer->mv0_threshold;
            set => Pointer->mv0_threshold = value;
        }
        
        public int BSensitivity
        {
            get => Pointer->b_sensitivity;
            set => Pointer->b_sensitivity = value;
        }
        
        /// <summary>Chromaticity coordinates of the source primaries. - encoding: Set by user - decoding: Set by libavcodec</summary>
        public AVColorPrimaries ColorPrimaries
        {
            get => Pointer->color_primaries;
            set => Pointer->color_primaries = value;
        }
        
        /// <summary>Color Transfer Characteristic. - encoding: Set by user - decoding: Set by libavcodec</summary>
        public AVColorTransferCharacteristic ColorTrc
        {
            get => Pointer->color_trc;
            set => Pointer->color_trc = value;
        }
        
        /// <summary>YUV colorspace type. - encoding: Set by user - decoding: Set by libavcodec</summary>
        public AVColorSpace Colorspace
        {
            get => Pointer->colorspace;
            set => Pointer->colorspace = value;
        }
        
        /// <summary>MPEG vs JPEG YUV range. - encoding: Set by user - decoding: Set by libavcodec</summary>
        public AVColorRange ColorRange
        {
            get => Pointer->color_range;
            set => Pointer->color_range = value;
        }
        
        /// <summary>This defines the location of chroma samples. - encoding: Set by user - decoding: Set by libavcodec</summary>
        public AVChromaLocation ChromaSampleLocation
        {
            get => Pointer->chroma_sample_location;
            set => Pointer->chroma_sample_location = value;
        }
        
        /// <summary>Number of slices. Indicates number of picture subdivisions. Used for parallelized decoding. - encoding: Set by user - decoding: unused</summary>
        public int Slices
        {
            get => Pointer->slices;
            set => Pointer->slices = value;
        }
        
        /// <summary>Field order - encoding: set by libavcodec - decoding: Set by user.</summary>
        public AVFieldOrder FieldOrder
        {
            get => Pointer->field_order;
            set => Pointer->field_order = value;
        }
        
        /// <summary>samples per second</summary>
        public int SampleRate
        {
            get => Pointer->sample_rate;
            set => Pointer->sample_rate = value;
        }
        
        /// <summary>number of audio channels</summary>
        public int Channels
        {
            get => Pointer->channels;
            set => Pointer->channels = value;
        }
        
        /// <summary>sample format</summary>
        public AVSampleFormat SampleFmt
        {
            get => Pointer->sample_fmt;
            set => Pointer->sample_fmt = value;
        }
        
        /// <summary>Number of samples per channel in an audio frame.</summary>
        public int FrameSize
        {
            get => Pointer->frame_size;
            set => Pointer->frame_size = value;
        }
        
        /// <summary>Frame counter, set by libavcodec.</summary>
        public int FrameNumber
        {
            get => Pointer->frame_number;
            set => Pointer->frame_number = value;
        }
        
        /// <summary>number of bytes per packet if constant and known or 0 Used by some WAV based audio codecs.</summary>
        public int BlockAlign
        {
            get => Pointer->block_align;
            set => Pointer->block_align = value;
        }
        
        /// <summary>Audio cutoff bandwidth (0 means "automatic") - encoding: Set by user. - decoding: unused</summary>
        public int Cutoff
        {
            get => Pointer->cutoff;
            set => Pointer->cutoff = value;
        }
        
        /// <summary>Audio channel layout. - encoding: set by user. - decoding: set by user, may be overwritten by libavcodec.</summary>
        public ulong ChannelLayout
        {
            get => Pointer->channel_layout;
            set => Pointer->channel_layout = value;
        }
        
        /// <summary>Request decoder to use this channel layout if it can (0 for default) - encoding: unused - decoding: Set by user.</summary>
        public ulong RequestChannelLayout
        {
            get => Pointer->request_channel_layout;
            set => Pointer->request_channel_layout = value;
        }
        
        /// <summary>Type of service that the audio stream conveys. - encoding: Set by user. - decoding: Set by libavcodec.</summary>
        public AVAudioServiceType AudioServiceType
        {
            get => Pointer->audio_service_type;
            set => Pointer->audio_service_type = value;
        }
        
        /// <summary>desired sample format - encoding: Not used. - decoding: Set by user. Decoder will decode to this format if it can.</summary>
        public AVSampleFormat RequestSampleFmt
        {
            get => Pointer->request_sample_fmt;
            set => Pointer->request_sample_fmt = value;
        }
        
        /// <summary>This callback is called at the beginning of each frame to get data buffer(s) for it. There may be one contiguous buffer for all the data or there may be a buffer per each data plane or anything in between. What this means is, you may set however many entries in buf[] you feel necessary. Each buffer must be reference-counted using the AVBuffer API (see description of buf[] below).</summary>
        public AVCodecContext_get_buffer2_func GetBuffer2
        {
            get => Pointer->get_buffer2;
            set => Pointer->get_buffer2 = value;
        }
        
        /// <summary>If non-zero, the decoded audio and video frames returned from avcodec_decode_video2() and avcodec_decode_audio4() are reference-counted and are valid indefinitely. The caller must free them with av_frame_unref() when they are not needed anymore. Otherwise, the decoded frames must not be freed by the caller and are only valid until the next decode call.</summary>
        public int RefcountedFrames
        {
            get => Pointer->refcounted_frames;
            set => Pointer->refcounted_frames = value;
        }
        
        /// <summary>amount of qscale change between easy &amp; hard scenes (0.0-1.0)</summary>
        public float Qcompress
        {
            get => Pointer->qcompress;
            set => Pointer->qcompress = value;
        }
        
        /// <summary>amount of qscale smoothing over time (0.0-1.0)</summary>
        public float Qblur
        {
            get => Pointer->qblur;
            set => Pointer->qblur = value;
        }
        
        /// <summary>minimum quantizer - encoding: Set by user. - decoding: unused</summary>
        public int Qmin
        {
            get => Pointer->qmin;
            set => Pointer->qmin = value;
        }
        
        /// <summary>maximum quantizer - encoding: Set by user. - decoding: unused</summary>
        public int Qmax
        {
            get => Pointer->qmax;
            set => Pointer->qmax = value;
        }
        
        /// <summary>maximum quantizer difference between frames - encoding: Set by user. - decoding: unused</summary>
        public int MaxQdiff
        {
            get => Pointer->max_qdiff;
            set => Pointer->max_qdiff = value;
        }
        
        /// <summary>decoder bitstream buffer size - encoding: Set by user. - decoding: unused</summary>
        public int RcBufferSize
        {
            get => Pointer->rc_buffer_size;
            set => Pointer->rc_buffer_size = value;
        }
        
        /// <summary>ratecontrol override, see RcOverride - encoding: Allocated/set/freed by user. - decoding: unused</summary>
        public int RcOverrideCount
        {
            get => Pointer->rc_override_count;
            set => Pointer->rc_override_count = value;
        }
        
        public RcOverride* RcOverride
        {
            get => Pointer->rc_override;
            set => Pointer->rc_override = value;
        }
        
        /// <summary>maximum bitrate - encoding: Set by user. - decoding: Set by user, may be overwritten by libavcodec.</summary>
        public long RcMaxRate
        {
            get => Pointer->rc_max_rate;
            set => Pointer->rc_max_rate = value;
        }
        
        /// <summary>minimum bitrate - encoding: Set by user. - decoding: unused</summary>
        public long RcMinRate
        {
            get => Pointer->rc_min_rate;
            set => Pointer->rc_min_rate = value;
        }
        
        /// <summary>Ratecontrol attempt to use, at maximum, &lt;value&gt; of what can be used without an underflow. - encoding: Set by user. - decoding: unused.</summary>
        public float RcMaxAvailableVbvUse
        {
            get => Pointer->rc_max_available_vbv_use;
            set => Pointer->rc_max_available_vbv_use = value;
        }
        
        /// <summary>Ratecontrol attempt to use, at least, &lt;value&gt; times the amount needed to prevent a vbv overflow. - encoding: Set by user. - decoding: unused.</summary>
        public float RcMinVbvOverflowUse
        {
            get => Pointer->rc_min_vbv_overflow_use;
            set => Pointer->rc_min_vbv_overflow_use = value;
        }
        
        /// <summary>Number of bits which should be loaded into the rc buffer before decoding starts. - encoding: Set by user. - decoding: unused</summary>
        public int RcInitialBufferOccupancy
        {
            get => Pointer->rc_initial_buffer_occupancy;
            set => Pointer->rc_initial_buffer_occupancy = value;
        }
        
        public int CoderType
        {
            get => Pointer->coder_type;
            set => Pointer->coder_type = value;
        }
        
        public int ContextModel
        {
            get => Pointer->context_model;
            set => Pointer->context_model = value;
        }
        
        public int FrameSkipThreshold
        {
            get => Pointer->frame_skip_threshold;
            set => Pointer->frame_skip_threshold = value;
        }
        
        public int FrameSkipFactor
        {
            get => Pointer->frame_skip_factor;
            set => Pointer->frame_skip_factor = value;
        }
        
        public int FrameSkipExp
        {
            get => Pointer->frame_skip_exp;
            set => Pointer->frame_skip_exp = value;
        }
        
        public int FrameSkipCmp
        {
            get => Pointer->frame_skip_cmp;
            set => Pointer->frame_skip_cmp = value;
        }
        
        /// <summary>trellis RD quantization - encoding: Set by user. - decoding: unused</summary>
        public int Trellis
        {
            get => Pointer->trellis;
            set => Pointer->trellis = value;
        }
        
        public int MinPredictionOrder
        {
            get => Pointer->min_prediction_order;
            set => Pointer->min_prediction_order = value;
        }
        
        public int MaxPredictionOrder
        {
            get => Pointer->max_prediction_order;
            set => Pointer->max_prediction_order = value;
        }
        
        public long TimecodeFrameStart
        {
            get => Pointer->timecode_frame_start;
            set => Pointer->timecode_frame_start = value;
        }
        
        public AVCodecContext_rtp_callback_func RtpCallback
        {
            get => Pointer->rtp_callback;
            set => Pointer->rtp_callback = value;
        }
        
        public int RtpPayloadSize
        {
            get => Pointer->rtp_payload_size;
            set => Pointer->rtp_payload_size = value;
        }
        
        public int MvBits
        {
            get => Pointer->mv_bits;
            set => Pointer->mv_bits = value;
        }
        
        public int HeaderBits
        {
            get => Pointer->header_bits;
            set => Pointer->header_bits = value;
        }
        
        public int ITexBits
        {
            get => Pointer->i_tex_bits;
            set => Pointer->i_tex_bits = value;
        }
        
        public int PTexBits
        {
            get => Pointer->p_tex_bits;
            set => Pointer->p_tex_bits = value;
        }
        
        public int ICount
        {
            get => Pointer->i_count;
            set => Pointer->i_count = value;
        }
        
        public int PCount
        {
            get => Pointer->p_count;
            set => Pointer->p_count = value;
        }
        
        public int SkipCount
        {
            get => Pointer->skip_count;
            set => Pointer->skip_count = value;
        }
        
        public int MiscBits
        {
            get => Pointer->misc_bits;
            set => Pointer->misc_bits = value;
        }
        
        public int FrameBits
        {
            get => Pointer->frame_bits;
            set => Pointer->frame_bits = value;
        }
        
        /// <summary>pass1 encoding statistics output buffer - encoding: Set by libavcodec. - decoding: unused</summary>
        public byte* StatsOut
        {
            get => Pointer->stats_out;
            set => Pointer->stats_out = value;
        }
        
        /// <summary>pass2 encoding statistics input buffer Concatenated stuff from stats_out of pass1 should be placed here. - encoding: Allocated/set/freed by user. - decoding: unused</summary>
        public byte* StatsIn
        {
            get => Pointer->stats_in;
            set => Pointer->stats_in = value;
        }
        
        /// <summary>Work around bugs in encoders which sometimes cannot be detected automatically. - encoding: Set by user - decoding: Set by user</summary>
        public int WorkaroundBugs
        {
            get => Pointer->workaround_bugs;
            set => Pointer->workaround_bugs = value;
        }
        
        /// <summary>strictly follow the standard (MPEG-4, ...). - encoding: Set by user. - decoding: Set by user. Setting this to STRICT or higher means the encoder and decoder will generally do stupid things, whereas setting it to unofficial or lower will mean the encoder might produce output that is not supported by all spec-compliant decoders. Decoders don't differentiate between normal, unofficial and experimental (that is, they always try to decode things when they can) unless they are explicitly asked to behave stupidly (=strictly conform to the specs)</summary>
        public int StrictStdCompliance
        {
            get => Pointer->strict_std_compliance;
            set => Pointer->strict_std_compliance = value;
        }
        
        /// <summary>error concealment flags - encoding: unused - decoding: Set by user.</summary>
        public int ErrorConcealment
        {
            get => Pointer->error_concealment;
            set => Pointer->error_concealment = value;
        }
        
        /// <summary>debug - encoding: Set by user. - decoding: Set by user.</summary>
        public int Debug
        {
            get => Pointer->debug;
            set => Pointer->debug = value;
        }
        
        /// <summary>Error recognition; may misdetect some more or less valid parts as errors. - encoding: unused - decoding: Set by user.</summary>
        public int ErrRecognition
        {
            get => Pointer->err_recognition;
            set => Pointer->err_recognition = value;
        }
        
        /// <summary>opaque 64-bit number (generally a PTS) that will be reordered and output in AVFrame.reordered_opaque - encoding: Set by libavcodec to the reordered_opaque of the input frame corresponding to the last returned packet. Only supported by encoders with the AV_CODEC_CAP_ENCODER_REORDERED_OPAQUE capability. - decoding: Set by user.</summary>
        public long ReorderedOpaque
        {
            get => Pointer->reordered_opaque;
            set => Pointer->reordered_opaque = value;
        }
        
        /// <summary>Hardware accelerator in use - encoding: unused. - decoding: Set by libavcodec</summary>
        public AVHWAccel* Hwaccel
        {
            get => Pointer->hwaccel;
            set => Pointer->hwaccel = value;
        }
        
        /// <summary>Hardware accelerator context. For some hardware accelerators, a global context needs to be provided by the user. In that case, this holds display-dependent data FFmpeg cannot instantiate itself. Please refer to the FFmpeg HW accelerator documentation to know how to fill this is. e.g. for VA API, this is a struct vaapi_context. - encoding: unused - decoding: Set by user</summary>
        public IntPtr HwaccelContext
        {
            get => (IntPtr)Pointer->hwaccel_context;
            set => Pointer->hwaccel_context = (void*)value;
        }
        
        /// <summary>error - encoding: Set by libavcodec if flags &amp; AV_CODEC_FLAG_PSNR. - decoding: unused</summary>
        public ulong_array8 Error
        {
            get => Pointer->error;
            set => Pointer->error = value;
        }
        
        /// <summary>DCT algorithm, see FF_DCT_* below - encoding: Set by user. - decoding: unused</summary>
        public int DctAlgo
        {
            get => Pointer->dct_algo;
            set => Pointer->dct_algo = value;
        }
        
        /// <summary>IDCT algorithm, see FF_IDCT_* below. - encoding: Set by user. - decoding: Set by user.</summary>
        public int IdctAlgo
        {
            get => Pointer->idct_algo;
            set => Pointer->idct_algo = value;
        }
        
        /// <summary>bits per sample/pixel from the demuxer (needed for huffyuv). - encoding: Set by libavcodec. - decoding: Set by user.</summary>
        public int BitsPerCodedSample
        {
            get => Pointer->bits_per_coded_sample;
            set => Pointer->bits_per_coded_sample = value;
        }
        
        /// <summary>Bits per sample/pixel of internal libavcodec pixel/sample format. - encoding: set by user. - decoding: set by libavcodec.</summary>
        public int BitsPerRawSample
        {
            get => Pointer->bits_per_raw_sample;
            set => Pointer->bits_per_raw_sample = value;
        }
        
        /// <summary>low resolution decoding, 1-&gt; 1/2 size, 2-&gt;1/4 size - encoding: unused - decoding: Set by user.</summary>
        public int Lowres
        {
            get => Pointer->lowres;
            set => Pointer->lowres = value;
        }
        
        /// <summary>the picture in the bitstream - encoding: Set by libavcodec. - decoding: unused</summary>
        public AVFrame* CodedFrame
        {
            get => Pointer->coded_frame;
            set => Pointer->coded_frame = value;
        }
        
        /// <summary>thread count is used to decide how many independent tasks should be passed to execute() - encoding: Set by user. - decoding: Set by user.</summary>
        public int ThreadCount
        {
            get => Pointer->thread_count;
            set => Pointer->thread_count = value;
        }
        
        /// <summary>Which multithreading methods to use. Use of FF_THREAD_FRAME will increase decoding delay by one frame per thread, so clients which cannot provide future frames should not use it.</summary>
        public int ThreadType
        {
            get => Pointer->thread_type;
            set => Pointer->thread_type = value;
        }
        
        /// <summary>Which multithreading methods are in use by the codec. - encoding: Set by libavcodec. - decoding: Set by libavcodec.</summary>
        public int ActiveThreadType
        {
            get => Pointer->active_thread_type;
            set => Pointer->active_thread_type = value;
        }
        
        /// <summary>Set by the client if its custom get_buffer() callback can be called synchronously from another thread, which allows faster multithreaded decoding. draw_horiz_band() will be called from other threads regardless of this setting. Ignored if the default get_buffer() is used. - encoding: Set by user. - decoding: Set by user.</summary>
        public int ThreadSafeCallbacks
        {
            get => Pointer->thread_safe_callbacks;
            set => Pointer->thread_safe_callbacks = value;
        }
        
        /// <summary>The codec may call this to execute several independent things. It will return only after finishing all tasks. The user may replace this with some multithreaded implementation, the default implementation will execute the parts serially.</summary>
        public AVCodecContext_execute_func Execute
        {
            get => Pointer->execute;
            set => Pointer->execute = value;
        }
        
        /// <summary>The codec may call this to execute several independent things. It will return only after finishing all tasks. The user may replace this with some multithreaded implementation, the default implementation will execute the parts serially. Also see avcodec_thread_init and e.g. the --enable-pthread configure option.</summary>
        public AVCodecContext_execute2_func Execute2
        {
            get => Pointer->execute2;
            set => Pointer->execute2 = value;
        }
        
        /// <summary>noise vs. sse weight for the nsse comparison function - encoding: Set by user. - decoding: unused</summary>
        public int NsseWeight
        {
            get => Pointer->nsse_weight;
            set => Pointer->nsse_weight = value;
        }
        
        /// <summary>profile - encoding: Set by user. - decoding: Set by libavcodec.</summary>
        public int Profile
        {
            get => Pointer->profile;
            set => Pointer->profile = value;
        }
        
        /// <summary>level - encoding: Set by user. - decoding: Set by libavcodec.</summary>
        public int Level
        {
            get => Pointer->level;
            set => Pointer->level = value;
        }
        
        /// <summary>Skip loop filtering for selected frames. - encoding: unused - decoding: Set by user.</summary>
        public AVDiscard SkipLoopFilter
        {
            get => Pointer->skip_loop_filter;
            set => Pointer->skip_loop_filter = value;
        }
        
        /// <summary>Skip IDCT/dequantization for selected frames. - encoding: unused - decoding: Set by user.</summary>
        public AVDiscard SkipIdct
        {
            get => Pointer->skip_idct;
            set => Pointer->skip_idct = value;
        }
        
        /// <summary>Skip decoding for selected frames. - encoding: unused - decoding: Set by user.</summary>
        public AVDiscard SkipFrame
        {
            get => Pointer->skip_frame;
            set => Pointer->skip_frame = value;
        }
        
        /// <summary>Header containing style information for text subtitles. For SUBTITLE_ASS subtitle type, it should contain the whole ASS [Script Info] and [V4+ Styles] section, plus the [Events] line and the Format line following. It shouldn't include any Dialogue line. - encoding: Set/allocated/freed by user (before avcodec_open2()) - decoding: Set/allocated/freed by libavcodec (by avcodec_open2())</summary>
        public byte* SubtitleHeader
        {
            get => Pointer->subtitle_header;
            set => Pointer->subtitle_header = value;
        }
        
        public int SubtitleHeaderSize
        {
            get => Pointer->subtitle_header_size;
            set => Pointer->subtitle_header_size = value;
        }
        
        /// <summary>VBV delay coded in the last frame (in periods of a 27 MHz clock). Used for compliant TS muxing. - encoding: Set by libavcodec. - decoding: unused.</summary>
        public ulong VbvDelay
        {
            get => Pointer->vbv_delay;
            set => Pointer->vbv_delay = value;
        }
        
        /// <summary>Encoding only and set by default. Allow encoders to output packets that do not contain any encoded data, only side data.</summary>
        public int SideDataOnlyPackets
        {
            get => Pointer->side_data_only_packets;
            set => Pointer->side_data_only_packets = value;
        }
        
        /// <summary>Audio only. The number of "priming" samples (padding) inserted by the encoder at the beginning of the audio. I.e. this number of leading decoded samples must be discarded by the caller to get the original audio without leading padding.</summary>
        public int InitialPadding
        {
            get => Pointer->initial_padding;
            set => Pointer->initial_padding = value;
        }
        
        /// <summary>- decoding: For codecs that store a framerate value in the compressed bitstream, the decoder may export it here. { 0, 1} when unknown. - encoding: May be used to signal the framerate of CFR content to an encoder.</summary>
        public MediaRational Framerate
        {
            get => Pointer->framerate;
            set => Pointer->framerate = value;
        }
        
        /// <summary>Nominal unaccelerated pixel format, see AV_PIX_FMT_xxx. - encoding: unused. - decoding: Set by libavcodec before calling get_format()</summary>
        public AVPixelFormat SwPixFmt
        {
            get => Pointer->sw_pix_fmt;
            set => Pointer->sw_pix_fmt = value;
        }
        
        /// <summary>Timebase in which pkt_dts/pts and AVPacket.dts/pts are. - encoding unused. - decoding set by user.</summary>
        public MediaRational PktTimebase
        {
            get => Pointer->pkt_timebase;
            set => Pointer->pkt_timebase = value;
        }
        
        /// <summary>AVCodecDescriptor - encoding: unused. - decoding: set by libavcodec.</summary>
        public AVCodecDescriptor* CodecDescriptor
        {
            get => Pointer->codec_descriptor;
            set => Pointer->codec_descriptor = value;
        }
        
        /// <summary>Current statistics for PTS correction. - decoding: maintained and used by libavcodec, not intended to be used by user apps - encoding: unused</summary>
        public long PtsCorrectionNumFaultyPts
        {
            get => Pointer->pts_correction_num_faulty_pts;
            set => Pointer->pts_correction_num_faulty_pts = value;
        }
        
        /// <summary>Number of incorrect PTS values so far</summary>
        public long PtsCorrectionNumFaultyDts
        {
            get => Pointer->pts_correction_num_faulty_dts;
            set => Pointer->pts_correction_num_faulty_dts = value;
        }
        
        /// <summary>Number of incorrect DTS values so far</summary>
        public long PtsCorrectionLastPts
        {
            get => Pointer->pts_correction_last_pts;
            set => Pointer->pts_correction_last_pts = value;
        }
        
        /// <summary>PTS of the last frame</summary>
        public long PtsCorrectionLastDts
        {
            get => Pointer->pts_correction_last_dts;
            set => Pointer->pts_correction_last_dts = value;
        }
        
        /// <summary>Character encoding of the input subtitles file. - decoding: set by user - encoding: unused</summary>
        public byte* SubCharenc
        {
            get => Pointer->sub_charenc;
            set => Pointer->sub_charenc = value;
        }
        
        /// <summary>Subtitles character encoding mode. Formats or codecs might be adjusting this setting (if they are doing the conversion themselves for instance). - decoding: set by libavcodec - encoding: unused</summary>
        public int SubCharencMode
        {
            get => Pointer->sub_charenc_mode;
            set => Pointer->sub_charenc_mode = value;
        }
        
        /// <summary>Skip processing alpha if supported by codec. Note that if the format uses pre-multiplied alpha (common with VP6, and recommended due to better video quality/compression) the image will look as if alpha-blended onto a black background. However for formats that do not use pre-multiplied alpha there might be serious artefacts (though e.g. libswscale currently assumes pre-multiplied alpha anyway).</summary>
        public int SkipAlpha
        {
            get => Pointer->skip_alpha;
            set => Pointer->skip_alpha = value;
        }
        
        /// <summary>Number of samples to skip after a discontinuity - decoding: unused - encoding: set by libavcodec</summary>
        public int SeekPreroll
        {
            get => Pointer->seek_preroll;
            set => Pointer->seek_preroll = value;
        }
        
        /// <summary>debug motion vectors - encoding: Set by user. - decoding: Set by user.</summary>
        public int DebugMv
        {
            get => Pointer->debug_mv;
            set => Pointer->debug_mv = value;
        }
        
        /// <summary>custom intra quantization matrix - encoding: Set by user, can be NULL. - decoding: unused.</summary>
        public ushort* ChromaIntraMatrix
        {
            get => Pointer->chroma_intra_matrix;
            set => Pointer->chroma_intra_matrix = value;
        }
        
        /// <summary>dump format separator. can be ", " or " " or anything else - encoding: Set by user. - decoding: Set by user.</summary>
        public byte* DumpSeparator
        {
            get => Pointer->dump_separator;
            set => Pointer->dump_separator = value;
        }
        
        /// <summary>',' separated list of allowed decoders. If NULL then all are allowed - encoding: unused - decoding: set by user</summary>
        public byte* CodecWhitelist
        {
            get => Pointer->codec_whitelist;
            set => Pointer->codec_whitelist = value;
        }
        
        /// <summary>Properties of the stream that gets decoded - encoding: unused - decoding: set by libavcodec</summary>
        public uint Properties
        {
            get => Pointer->properties;
            set => Pointer->properties = value;
        }
        
        /// <summary>Additional data associated with the entire coded stream.</summary>
        public AVPacketSideData* CodedSideData
        {
            get => Pointer->coded_side_data;
            set => Pointer->coded_side_data = value;
        }
        
        public int NbCodedSideData
        {
            get => Pointer->nb_coded_side_data;
            set => Pointer->nb_coded_side_data = value;
        }
        
        /// <summary>A reference to the AVHWFramesContext describing the input (for encoding) or output (decoding) frames. The reference is set by the caller and afterwards owned (and freed) by libavcodec - it should never be read by the caller after being set.</summary>
        public AVBufferRef* HwFramesCtx
        {
            get => Pointer->hw_frames_ctx;
            set => Pointer->hw_frames_ctx = value;
        }
        
        /// <summary>Control the form of AVSubtitle.rects[N]-&gt;ass - decoding: set by user - encoding: unused</summary>
        public int SubTextFormat
        {
            get => Pointer->sub_text_format;
            set => Pointer->sub_text_format = value;
        }
        
        /// <summary>Audio only. The amount of padding (in samples) appended by the encoder to the end of the audio. I.e. this number of decoded samples must be discarded by the caller from the end of the stream to get the original audio without any trailing padding.</summary>
        public int TrailingPadding
        {
            get => Pointer->trailing_padding;
            set => Pointer->trailing_padding = value;
        }
        
        /// <summary>The number of pixels per image to maximally accept.</summary>
        public long MaxPixels
        {
            get => Pointer->max_pixels;
            set => Pointer->max_pixels = value;
        }
        
        /// <summary>A reference to the AVHWDeviceContext describing the device which will be used by a hardware encoder/decoder. The reference is set by the caller and afterwards owned (and freed) by libavcodec.</summary>
        public AVBufferRef* HwDeviceCtx
        {
            get => Pointer->hw_device_ctx;
            set => Pointer->hw_device_ctx = value;
        }
        
        /// <summary>Bit set of AV_HWACCEL_FLAG_* flags, which affect hardware accelerated decoding (if active). - encoding: unused - decoding: Set by user (either before avcodec_open2(), or in the AVCodecContext.get_format callback)</summary>
        public int HwaccelFlags
        {
            get => Pointer->hwaccel_flags;
            set => Pointer->hwaccel_flags = value;
        }
        
        /// <summary>Video decoding only. Certain video codecs support cropping, meaning that only a sub-rectangle of the decoded frame is intended for display. This option controls how cropping is handled by libavcodec.</summary>
        public int ApplyCropping
        {
            get => Pointer->apply_cropping;
            set => Pointer->apply_cropping = value;
        }
        
        public int ExtraHwFrames
        {
            get => Pointer->extra_hw_frames;
            set => Pointer->extra_hw_frames = value;
        }
        
        /// <summary>The percentage of damaged samples to discard a frame.</summary>
        public int DiscardDamagedPercentage
        {
            get => Pointer->discard_damaged_percentage;
            set => Pointer->discard_damaged_percentage = value;
        }
        
        /// <summary>The number of samples per frame to maximally accept.</summary>
        public long MaxSamples
        {
            get => Pointer->max_samples;
            set => Pointer->max_samples = value;
        }
        
        /// <summary>Bit set of AV_CODEC_EXPORT_DATA_* flags, which affects the kind of metadata exported in frame, packet, or coded stream side data by decoders and encoders.</summary>
        public int ExportSideData
        {
            get => Pointer->export_side_data;
            set => Pointer->export_side_data = value;
        }
    }
}
