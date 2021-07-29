using FFmpeg.AutoGen;
using System;
using System.Runtime.InteropServices;

namespace Sdcb.FFmpegAPIWrapper.MediaCodecs
{
    /// <summary>
    /// <see cref="AVProfile"/>
    /// </summary>
    public unsafe struct MediaProfile
	{
		private AVProfile* _p;

		public int Profile => _p->profile;
		public string Name => Marshal.PtrToStringAnsi((IntPtr)_p->name)!;
		public unsafe static MediaProfile FromNative(AVProfile* p) => new MediaProfile { _p = p };
	}
}
