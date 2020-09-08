using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Sdcb.FFmpegAPIWrapper.MediaCodecs
{
    /// <summary>
    /// <see cref="AVCodec"/>
    /// </summary>
    public unsafe class MediaCodec
    {
        AVCodec* _p;

        public MediaCodec(AVCodec* ptr)
        {
            if (ptr == null) throw new ArgumentNullException(nameof(ptr));

            _p = ptr;
        }

        public static implicit operator AVCodec*(MediaCodec data) => data._p;

		public AVCodecID Id => _p->id;

		public string Name => Marshal.PtrToStringUTF8((IntPtr)_p->name);

		public string LongName => Marshal.PtrToStringUTF8((IntPtr)_p->long_name);

		public MediaType Type => (MediaType)_p->type;

		public string WrapperName => Marshal.PtrToStringUTF8((IntPtr)_p->wrapper_name);

		public int PrivateSize => _p->priv_data_size;

		public IEnumerable<AVRational> SupportedFrameRates => throw new NotImplementedException();

		public IEnumerable<AVPixelFormat> PixelFormats => throw new NotImplementedException();

		public IEnumerable<int> SupportedSampleRates => throw new NotImplementedException();

		public IEnumerable<AVSampleFormat> SampleFormats => throw new NotImplementedException();

		public CodecCompabilities Capabilities => (CodecCompabilities)_p->capabilities;

		public IEnumerable<ChannelLayouts> ChannelLayouts => throw new NotImplementedException();

		public byte MaxLowres => _p->max_lowres;

		public IEnumerable<MediaProfile> Profiles => throw new NotImplementedException();

		public Dictionary<string, string> Defaults => throw new NotImplementedException();


		public unsafe static MediaCodec FromNative(IntPtr p) => FromNative((AVCodec*)p);

		public unsafe static MediaCodec FromNative(AVCodec* p) => new MediaCodec(p);

		public unsafe struct AvCodecDefaultDef
		{
			public byte* key;
			public byte* value;
		};
	}

	public unsafe struct MediaProfile
	{
		private AVProfile* _p;

		public int Profile => _p->profile;
		public string Name => Marshal.PtrToStringAnsi((IntPtr)_p->name);
		public unsafe static MediaProfile FromNative(AVProfile* p) => new MediaProfile { _p = p };
	}
}
