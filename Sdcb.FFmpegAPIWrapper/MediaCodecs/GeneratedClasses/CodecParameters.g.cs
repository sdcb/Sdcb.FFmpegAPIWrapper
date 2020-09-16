using System;
using Sdcb.FFmpegAPIWrapper.Common;
using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;

namespace Sdcb.FFmpegAPIWrapper.MediaCodecs
{
    public unsafe partial struct CodecParameters
    {
        private AVCodecParameters* _ptr;
        
        public static implicit operator AVCodecParameters*(CodecParameters data) => (AVCodecParameters*)data._handle;
        
        public CodecParameters(AVCodecParameters* ptr)
        {
            if (ptr == null)
            {
                throw new ArgumentNullException(nameof(ptr));
            }
            _ptr = ptr;
        }
        
        /// <summary>
        /// <para>General type of the encoded data.</para>
        /// <see cref="AVCodecParameters.codec_type" />
        /// </summary>
        public MediaType CodecType
        {
            get => (MediaType)_ptr->codec_type;
            set => _ptr->codec_type = (AVMediaType)value;
        }
        
        /// <summary>
        /// <para>Specific type of the encoded data (the codec used).</para>
        /// <see cref="AVCodecParameters.codec_id" />
        /// </summary>
        public CodecID CodecId
        {
            get => (CodecID)_ptr->codec_id;
            set => _ptr->codec_id = (AVCodecID)value;
        }
        
        /// <summary>
        /// <para>Additional information about the codec (corresponds to the AVI FOURCC).</para>
        /// <see cref="AVCodecParameters.codec_tag" />
        /// </summary>
        public uint CodecTag
        {
            get => _ptr->codec_tag;
            set => _ptr->codec_tag = value;
        }
        
        /// <summary>
        /// <para>Extra binary data needed for initializing the decoder, codec-dependent.</para>
        /// <see cref="AVCodecParameters.extradata" />
        /// </summary>
        public byte* Extradata
        {
            get => _ptr->extradata;
            set => _ptr->extradata = value;
        }
        
        /// <summary>
        /// <para>Size of the extradata content in bytes.</para>
        /// <see cref="AVCodecParameters.extradata_size" />
        /// </summary>
        public int ExtradataSize
        {
            get => _ptr->extradata_size;
            set => _ptr->extradata_size = value;
        }
        
        /// <summary>
        /// <para>- video: the pixel format, the value corresponds to enum AVPixelFormat.</para>
        /// <para> - audio: the sample format, the value corresponds to enum AVSampleFormat.</para>
        /// <see cref="AVCodecParameters.format" />
        /// </summary>
        public int Format
        {
            get => _ptr->format;
            set => _ptr->format = value;
        }
        
        /// <summary>
        /// <para>The average bitrate of the encoded data (in bits per second).</para>
        /// <see cref="AVCodecParameters.bit_rate" />
        /// </summary>
        public long BitRate
        {
            get => _ptr->bit_rate;
            set => _ptr->bit_rate = value;
        }
        
        /// <summary>
        /// <para>The number of bits per sample in the codedwords.</para>
        /// <see cref="AVCodecParameters.bits_per_coded_sample" />
        /// </summary>
        public int BitsPerCodedSample
        {
            get => _ptr->bits_per_coded_sample;
            set => _ptr->bits_per_coded_sample = value;
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
            get => _ptr->bits_per_raw_sample;
            set => _ptr->bits_per_raw_sample = value;
        }
        
        /// <summary>
        /// <para>Codec-specific bitstream restrictions that the stream conforms to.</para>
        /// <see cref="AVCodecParameters.profile" />
        /// </summary>
        public int Profile
        {
            get => _ptr->profile;
            set => _ptr->profile = value;
        }
        
        /// <summary>
        /// <see cref="AVCodecParameters.level" />
        /// </summary>
        public int Level
        {
            get => _ptr->level;
            set => _ptr->level = value;
        }
        
        /// <summary>
        /// <para>Video only.</para>
        /// <para> The dimensions of the video frame in pixels.</para>
        /// <see cref="AVCodecParameters.width" />
        /// </summary>
        public int Width
        {
            get => _ptr->width;
            set => _ptr->width = value;
        }
        
        /// <summary>
        /// <see cref="AVCodecParameters.height" />
        /// </summary>
        public int Height
        {
            get => _ptr->height;
            set => _ptr->height = value;
        }
        
        /// <summary>
        /// <para>Video only.</para>
        /// <para> The aspect ratio (width / height) which a single pixel should have when displayed.</para>
        /// <see cref="AVCodecParameters.sample_aspect_ratio" />
        /// </summary>
        public MediaRational SampleAspectRatio
        {
            get => _ptr->sample_aspect_ratio;
            set => _ptr->sample_aspect_ratio = value;
        }
        
        /// <summary>
        /// <para>Video only.</para>
        /// <para> The order of the fields in interlaced video.</para>
        /// <see cref="AVCodecParameters.field_order" />
        /// </summary>
        public AVFieldOrder FieldOrder
        {
            get => _ptr->field_order;
            set => _ptr->field_order = value;
        }
        
        /// <summary>
        /// <para>Video only.</para>
        /// <para> Additional colorspace characteristics.</para>
        /// <see cref="AVCodecParameters.color_range" />
        /// </summary>
        public AVColorRange ColorRange
        {
            get => _ptr->color_range;
            set => _ptr->color_range = value;
        }
        
        /// <summary>
        /// <see cref="AVCodecParameters.color_primaries" />
        /// </summary>
        public AVColorPrimaries ColorPrimaries
        {
            get => _ptr->color_primaries;
            set => _ptr->color_primaries = value;
        }
        
        /// <summary>
        /// <see cref="AVCodecParameters.color_trc" />
        /// </summary>
        public AVColorTransferCharacteristic ColorTrc
        {
            get => _ptr->color_trc;
            set => _ptr->color_trc = value;
        }
        
        /// <summary>
        /// <see cref="AVCodecParameters.color_space" />
        /// </summary>
        public AVColorSpace ColorSpace
        {
            get => _ptr->color_space;
            set => _ptr->color_space = value;
        }
        
        /// <summary>
        /// <see cref="AVCodecParameters.chroma_location" />
        /// </summary>
        public AVChromaLocation ChromaLocation
        {
            get => _ptr->chroma_location;
            set => _ptr->chroma_location = value;
        }
        
        /// <summary>
        /// <para>Video only.</para>
        /// <para> Number of delayed frames.</para>
        /// <see cref="AVCodecParameters.video_delay" />
        /// </summary>
        public int VideoDelay
        {
            get => _ptr->video_delay;
            set => _ptr->video_delay = value;
        }
        
        /// <summary>
        /// <para>Audio only.</para>
        /// <para> The channel layout bitmask.</para>
        /// <para> May be 0 if the channel layout is unknown or unspecified, otherwise the number of bits set must be equal to the channels field.</para>
        /// <see cref="AVCodecParameters.channel_layout" />
        /// </summary>
        public ulong ChannelLayout
        {
            get => _ptr->channel_layout;
            set => _ptr->channel_layout = value;
        }
        
        /// <summary>
        /// <para>Audio only.</para>
        /// <para> The number of audio channels.</para>
        /// <see cref="AVCodecParameters.channels" />
        /// </summary>
        public int Channels
        {
            get => _ptr->channels;
            set => _ptr->channels = value;
        }
        
        /// <summary>
        /// <para>Audio only.</para>
        /// <para> The number of audio samples per second.</para>
        /// <see cref="AVCodecParameters.sample_rate" />
        /// </summary>
        public int SampleRate
        {
            get => _ptr->sample_rate;
            set => _ptr->sample_rate = value;
        }
        
        /// <summary>
        /// <para>Audio only.</para>
        /// <para> The number of bytes per coded audio frame, required by some formats.</para>
        /// <see cref="AVCodecParameters.block_align" />
        /// </summary>
        public int BlockAlign
        {
            get => _ptr->block_align;
            set => _ptr->block_align = value;
        }
        
        /// <summary>
        /// <para>Audio only.</para>
        /// <para> Audio frame size, if known.</para>
        /// <para> Required by some formats to be static.</para>
        /// <see cref="AVCodecParameters.frame_size" />
        /// </summary>
        public int FrameSize
        {
            get => _ptr->frame_size;
            set => _ptr->frame_size = value;
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
            get => _ptr->initial_padding;
            set => _ptr->initial_padding = value;
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
            get => _ptr->trailing_padding;
            set => _ptr->trailing_padding = value;
        }
        
        /// <summary>
        /// <para>Audio only.</para>
        /// <para> Number of samples to skip after a discontinuity.</para>
        /// <see cref="AVCodecParameters.seek_preroll" />
        /// </summary>
        public int SeekPreroll
        {
            get => _ptr->seek_preroll;
            set => _ptr->seek_preroll = value;
        }
    }
}
