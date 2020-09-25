using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;
using System;
using System.Runtime.InteropServices;

namespace Sdcb.FFmpegAPIWrapper.Common
{
    public unsafe struct FFmpegOption
    {
        private readonly AVOption* _p;

        public FFmpegOption(AVOption* p)
        {
            if (p == null) throw new ArgumentNullException(nameof(p));
            _p = p;
        }

        public FFmpegOption(IntPtr p)
        {
            if (p == IntPtr.Zero) throw new ArgumentNullException(nameof(p));
            _p = (AVOption*)p;
        }

        public static implicit operator AVOption*(FFmpegOption data) => data._p;

        public string Name => Marshal.PtrToStringAnsi((IntPtr)_p->name);

        public string Help => Marshal.PtrToStringAnsi((IntPtr)_p->help);

        public int Offset => _p->offset;

        public FFmpegOptionType Type => (FFmpegOptionType)_p->type;

        public object DefaultValue => Type switch
        {
            FFmpegOptionType.String => Marshal.PtrToStringUTF8((IntPtr)_p->default_val.str), 
            FFmpegOptionType.Rational => (MediaRational) _p->default_val.q, 
            _ => (IntPtr)_p->default_val.str
        };

        public double Min => _p->min;

        public double Max => _p->max;

        public FFmpegOptionFlags Flags => (FFmpegOptionFlags)_p->flags;

        public string Unit => Marshal.PtrToStringAnsi((IntPtr)_p->unit);
    }
}
