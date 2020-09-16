using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Sdcb.FFmpegAPIWrapper.Common;
using System.Linq;

namespace Sdcb.FFmpegAPIWrapper.MediaCodecs
{
    /// <summary>
    /// <see cref="AVCodec"/>
    /// </summary>
    public unsafe partial struct Codec
    {
        AVCodec* _p;

        public Codec(AVCodec* ptr)
        {
            if (ptr == null) throw new ArgumentNullException(nameof(ptr));

            _p = ptr;
        }

		/// <summary>
		/// <see cref="AVCodec.name"/>
		/// </summary>
		public string Name => Marshal.PtrToStringUTF8((IntPtr)_p->name);

		/// <summary>
		/// <see cref="AVCodec.long_name"/>
		/// </summary>
		public string LongName => Marshal.PtrToStringUTF8((IntPtr)_p->long_name);

		/// <summary>
		/// <see cref="AVCodec.type"/>
		/// </summary>
		public MediaType Type => (MediaType)_p->type;

		/// <summary>
		/// <see cref="AVCodec.id"/>
		/// </summary>
		public AVCodecID Id => _p->id;

		/// <summary>
		/// <see cref="AVCodec.capabilities"/>
		/// </summary>
		public CodecCompability Capabilities => (CodecCompability)_p->capabilities;

		/// <summary>
		/// <see cref="AVCodec.supported_framerates"/>
		/// </summary>
		public IEnumerable<AVRational> SupportedFrameRates => NativeUtils.ReadSequence(
			p: (IntPtr)_p->supported_framerates,
			unitSize: sizeof(AVRational),
			exitCondition: p => ((AVRational*)p)->num == 0,
            valGetter: p => *((AVRational*)p));

		/// <summary>
		/// <see cref="AVCodec.pix_fmts"/>
		/// </summary>
		public IEnumerable<AVPixelFormat> PixelFormats => NativeUtils.ReadSequence(
			p: (IntPtr)_p->pix_fmts, 
			unitSize: sizeof(AVPixelFormat), 
			exitCondition: p => *((AVPixelFormat*)p) == AVPixelFormat.AV_PIX_FMT_NONE, 
			valGetter: p => *((AVPixelFormat*)p));

		/// <summary>
		/// <see cref="AVCodec.supported_samplerates"/>
		/// </summary>
		public IEnumerable<int> SupportedSampleRates => NativeUtils.ReadSequence(
			p: (IntPtr)_p->supported_samplerates, 
			unitSize: sizeof(int), 
			exitCondition: p => *((int*)p) == 0, 
			valGetter: p => *((int*)p));

		/// <summary>
		/// <see cref="AVCodec.sample_fmts"/>
		/// </summary>
		public IEnumerable<AVSampleFormat> SampleFormats => NativeUtils.ReadSequence(
			p: (IntPtr)_p->sample_fmts,
			unitSize: sizeof(AVSampleFormat),
			exitCondition: p => *((AVSampleFormat*)p) == AVSampleFormat.AV_SAMPLE_FMT_NONE,
			valGetter: p => *((AVSampleFormat*)p));

		/// <summary>
		/// <see cref="AVCodec.channel_layouts"/>
		/// </summary>
		public IEnumerable<ChannelLayout> ChannelLayouts => NativeUtils.ReadSequence(
			p: (IntPtr)_p->channel_layouts,
			unitSize: sizeof(ChannelLayout),
			exitCondition: p => *((ChannelLayout*)p) == 0,
			valGetter: p => *((ChannelLayout*)p));

		/// <summary>
		/// <see cref="AVCodec.max_lowres"/>
		/// </summary>
		public byte MaxLowres => _p->max_lowres;

		/// <summary>
		/// <see cref="AVCodec.priv_class"/>
		/// </summary>
		public FFmpegClass PrivateClass => FFmpegClass.FromNative(_p->priv_class);

		/// <summary>
		/// <see cref="AVCodec.profiles"/>
		/// </summary>
		public IEnumerable<MediaProfile> Profiles => NativeUtils.ReadSequence(
			p: (IntPtr)_p->profiles, 
			unitSize: sizeof(AVProfile), 
			exitCondition: p => ((AVProfile*)p)->profile == FF_PROFILE_UNKNOWN, 
			valGetter: p => MediaProfile.FromNative((AVProfile*)p));

		/// <summary>
		/// <see cref="AVCodec.wrapper_name"/>
		/// </summary>
		public string WrapperName => Marshal.PtrToStringUTF8((IntPtr)_p->wrapper_name);

		/// <summary>
		/// <see cref=""/>
		/// </summary>
		public int PrivateSize => _p->priv_data_size;

		/// <summary>
		/// <see cref="av_codec_is_encoder(AVCodec*)"/>
		/// </summary>
		public bool IsEncoder => av_codec_is_encoder(this) != 0;

		/// <summary>
		/// <see cref="av_codec_is_decoder(AVCodec*)"/>
		/// </summary>
		public bool IsDecoder => av_codec_is_decoder(this) != 0;


		public Dictionary<string, string> Defaults => NativeUtils.ReadSequence(
				p: (IntPtr)_p->defaults, 
				unitSize: sizeof(AvCodecDefaultDef), 
				exitCondition: p => ((AvCodecDefaultDef*)p)->key == IntPtr.Zero, 
				valGetter: p => *((AvCodecDefaultDef*)p)
			)
			.ToDictionary(k => Marshal.PtrToStringAnsi(k.key), v => Marshal.PtrToStringAnsi(v.value));

		private unsafe struct AvCodecDefaultDef
		{
#pragma warning disable CS0649 // never need to assign the values
			public IntPtr key;
			public IntPtr value;
#pragma warning restore CS0649
		};
	}
}
