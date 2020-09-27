// This file was genereated from LINQPad scripts, DO NOT CHANGE DIRECTLY.

using System;
using Sdcb.FFmpegAPIWrapper.Common;
using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;

namespace Sdcb.FFmpegAPIWrapper.MediaCodecs
{
    /// <summary>
    /// <para>This struct describes the properties of an encoded stream.</para>
    /// <see cref="AVCodecParameters" />
    /// </summary>
    public unsafe partial class CodecParameters : FFmpegSafeObject
    {
        protected AVCodecParameters* Pointer => this;
        
        public static implicit operator AVCodecParameters*(CodecParameters data) => data != null ? (AVCodecParameters*)data._nativePointer : null;
        
        protected CodecParameters(AVCodecParameters* ptr, bool isOwner): base(NativeUtils.NotNull((IntPtr)ptr), isOwner)
        {
        }
        
        public static CodecParameters FromNative(AVCodecParameters* ptr, bool isOwner) => new CodecParameters(ptr, isOwner);
        
        /// <summary>
        /// <para>General type of the encoded data.</para>
        /// <see cref="AVCodecParameters.codec_type" />
        /// </summary>
        public MediaType CodecType
        {
            get => (MediaType)Pointer->codec_type;
            set => Pointer->codec_type = (AVMediaType)value;
        }
        
        /// <summary>
        /// <para>Specific type of the encoded data (the codec used).</para>
        /// <see cref="AVCodecParameters.codec_id" />
        /// </summary>
        public CodecID CodecId
        {
            get => (CodecID)Pointer->codec_id;
            set => Pointer->codec_id = (AVCodecID)value;
        }
        
        /// <summary>
        /// <para>Additional information about the codec (corresponds to the AVI FOURCC).</para>
        /// <see cref="AVCodecParameters.codec_tag" />
        /// </summary>
        public uint CodecTag
        {
            get => Pointer->codec_tag;
            set => Pointer->codec_tag = value;
        }
        
        /// <summary>
        /// <para>Extra binary data needed for initializing the decoder, codec-dependent.</para>
        /// <see cref="AVCodecParameters.extradata" />
        /// </summary>
        public IntPtr Extradata
        {
            get => (IntPtr)Pointer->extradata;
            set => Pointer->extradata = (byte*)value;
        }
        
        /// <summary>
        /// <para>Size of the extradata content in bytes.</para>
        /// <see cref="AVCodecParameters.extradata_size" />
        /// </summary>
        public int ExtradataSize
        {
            get => Pointer->extradata_size;
            set => Pointer->extradata_size = value;
        }
        
        /// <summary>
        /// <para>- video: the pixel format, the value corresponds to enum AVPixelFormat.</para>
        /// <para> - audio: the sample format, the value corresponds to enum AVSampleFormat.</para>
        /// <see cref="AVCodecParameters.format" />
        /// </summary>
        public int Format
        {
            get => Pointer->format;
            set => Pointer->format = value;
        }
        
        /// <summary>
        /// <para>The average bitrate of the encoded data (in bits per second).</para>
        /// <see cref="AVCodecParameters.bit_rate" />
        /// </summary>
        public long BitRate
        {
            get => Pointer->bit_rate;
            set => Pointer->bit_rate = value;
        }
        
        /// <summary>
        /// <para>The number of bits per sample in the codedwords.</para>
        /// <see cref="AVCodecParameters.bits_per_coded_sample" />
        /// </summary>
        public int BitsPerCodedSample
        {
            get => Pointer->bits_per_coded_sample;
            set => Pointer->bits_per_coded_sample = value;
        }
        
        /// <summary>
        /// <para>This is the number of valid bits in each output sample.</para>
        /// <para> If the sample format has more bits, the least significant bits are additional padding bits, which are always 0.</para>
        /// <para> Use right shifts to reduce the sample to its actual size.</para>
        /// <para> For example, audio formats with 24 bit samples will have bits_per_raw_sample set to 24, and format set to AV_SAMPLE_FMT_S32.</para>
        /// <para> To get the original sample use &quot;(int32_t)sample &gt;&gt; 8&quot;.</para>
        /// <para>&quot;.</para>
        /// <see cref="AVCodecParameters.bits_per_raw_sample" />
        /// </summary>
        public int BitsPerRawSample
        {
            get => Pointer->bits_per_raw_sample;
            set => Pointer->bits_per_raw_sample = value;
        }
        
        /// <summary>
        /// <para>Codec-specific bitstream restrictions that the stream conforms to.</para>
        /// <see cref="AVCodecParameters.profile" />
        /// </summary>
        public int Profile
        {
            get => Pointer->profile;
            set => Pointer->profile = value;
        }
        
        /// <summary>
        /// <see cref="AVCodecParameters.level" />
        /// </summary>
        public int Level
        {
            get => Pointer->level;
            set => Pointer->level = value;
        }
        
        /// <summary>
        /// <para>Video only.</para>
        /// <para> The dimensions of the video frame in pixels.</para>
        /// <see cref="AVCodecParameters.width" />
        /// </summary>
        public int Width
        {
            get => Pointer->width;
            set => Pointer->width = value;
        }
        
        /// <summary>
        /// <see cref="AVCodecParameters.height" />
        /// </summary>
        public int Height
        {
            get => Pointer->height;
            set => Pointer->height = value;
        }
        
        /// <summary>
        /// <para>Video only.</para>
        /// <para> The aspect ratio (width / height) which a single pixel should have when displayed.</para>
        /// <see cref="AVCodecParameters.sample_aspect_ratio" />
        /// </summary>
        public MediaRational SampleAspectRatio
        {
            get => Pointer->sample_aspect_ratio;
            set => Pointer->sample_aspect_ratio = value;
        }
        
        /// <summary>
        /// <para>Video only.</para>
        /// <para> The order of the fields in interlaced video.</para>
        /// <see cref="AVCodecParameters.field_order" />
        /// </summary>
        public FieldOrder FieldOrder
        {
            get => (FieldOrder)Pointer->field_order;
            set => Pointer->field_order = (AVFieldOrder)value;
        }
        
        /// <summary>
        /// <para>Video only.</para>
        /// <para> Additional colorspace characteristics.</para>
        /// <see cref="AVCodecParameters.color_range" />
        /// </summary>
        public ColorRange ColorRange
        {
            get => (ColorRange)Pointer->color_range;
            set => Pointer->color_range = (AVColorRange)value;
        }
        
        /// <summary>
        /// <see cref="AVCodecParameters.color_primaries" />
        /// </summary>
        public ColorPrimaries ColorPrimaries
        {
            get => (ColorPrimaries)Pointer->color_primaries;
            set => Pointer->color_primaries = (AVColorPrimaries)value;
        }
        
        /// <summary>
        /// <see cref="AVCodecParameters.color_trc" />
        /// </summary>
        public ColorTransferCharacteristic ColorTrc
        {
            get => (ColorTransferCharacteristic)Pointer->color_trc;
            set => Pointer->color_trc = (AVColorTransferCharacteristic)value;
        }
        
        /// <summary>
        /// <see cref="AVCodecParameters.color_space" />
        /// </summary>
        public ColorSpace ColorSpace
        {
            get => (ColorSpace)Pointer->color_space;
            set => Pointer->color_space = (AVColorSpace)value;
        }
        
        /// <summary>
        /// <see cref="AVCodecParameters.chroma_location" />
        /// </summary>
        public ChromaLocation ChromaLocation
        {
            get => (ChromaLocation)Pointer->chroma_location;
            set => Pointer->chroma_location = (AVChromaLocation)value;
        }
        
        /// <summary>
        /// <para>Video only.</para>
        /// <para> Number of delayed frames.</para>
        /// <see cref="AVCodecParameters.video_delay" />
        /// </summary>
        public int VideoDelay
        {
            get => Pointer->video_delay;
            set => Pointer->video_delay = value;
        }
        
        /// <summary>
        /// <para>Audio only.</para>
        /// <para> The channel layout bitmask.</para>
        /// <para> May be 0 if the channel layout is unknown or unspecified, otherwise the number of bits set must be equal to the channels field.</para>
        /// <see cref="AVCodecParameters.channel_layout" />
        /// </summary>
        public ulong ChannelLayout
        {
            get => Pointer->channel_layout;
            set => Pointer->channel_layout = value;
        }
        
        /// <summary>
        /// <para>Audio only.</para>
        /// <para> The number of audio channels.</para>
        /// <see cref="AVCodecParameters.channels" />
        /// </summary>
        public int Channels
        {
            get => Pointer->channels;
            set => Pointer->channels = value;
        }
        
        /// <summary>
        /// <para>Audio only.</para>
        /// <para> The number of audio samples per second.</para>
        /// <see cref="AVCodecParameters.sample_rate" />
        /// </summary>
        public int SampleRate
        {
            get => Pointer->sample_rate;
            set => Pointer->sample_rate = value;
        }
        
        /// <summary>
        /// <para>Audio only.</para>
        /// <para> The number of bytes per coded audio frame, required by some formats.</para>
        /// <see cref="AVCodecParameters.block_align" />
        /// </summary>
        public int BlockAlign
        {
            get => Pointer->block_align;
            set => Pointer->block_align = value;
        }
        
        /// <summary>
        /// <para>Audio only.</para>
        /// <para> Audio frame size, if known.</para>
        /// <para> Required by some formats to be static.</para>
        /// <see cref="AVCodecParameters.frame_size" />
        /// </summary>
        public int FrameSize
        {
            get => Pointer->frame_size;
            set => Pointer->frame_size = value;
        }
        
        /// <summary>
        /// <para>Audio only.</para>
        /// <para> The amount of padding (in samples) inserted by the encoder at the beginning of the audio.</para>
        /// <para> I.</para>
        /// <para>e.</para>
        /// <para> this number of leading decoded samples must be discarded by the caller to get the original audio without leading padding.</para>
        /// <see cref="AVCodecParameters.initial_padding" />
        /// </summary>
        public int InitialPadding
        {
            get => Pointer->initial_padding;
            set => Pointer->initial_padding = value;
        }
        
        /// <summary>
        /// <para>Audio only.</para>
        /// <para> The amount of padding (in samples) appended by the encoder to the end of the audio.</para>
        /// <para> I.</para>
        /// <para>e.</para>
        /// <para> this number of decoded samples must be discarded by the caller from the end of the stream to get the original audio without any trailing padding.</para>
        /// <see cref="AVCodecParameters.trailing_padding" />
        /// </summary>
        public int TrailingPadding
        {
            get => Pointer->trailing_padding;
            set => Pointer->trailing_padding = value;
        }
        
        /// <summary>
        /// <para>Audio only.</para>
        /// <para> Number of samples to skip after a discontinuity.</para>
        /// <see cref="AVCodecParameters.seek_preroll" />
        /// </summary>
        public int SeekPreroll
        {
            get => Pointer->seek_preroll;
            set => Pointer->seek_preroll = value;
        }
    }
}
