using FFmpeg.AutoGen;
using System;
using System.Runtime.InteropServices;

namespace Sdcb.FFmpegAPIWrapper.Common
{
    public unsafe struct FFmpegOption
    {
        private readonly AVOptionBugFixed* _p;

        public FFmpegOption(AVOptionBugFixed* p)
        {
            if (p == null) throw new ArgumentNullException(nameof(p));
            _p = p; 
        }

        public static implicit operator AVOptionBugFixed* (FFmpegOption data) => data._p;

        public string Name => Marshal.PtrToStringAnsi((IntPtr)_p->name);

        public string Help => Marshal.PtrToStringAnsi((IntPtr)_p->help);

        public int Offset => _p->offset;

        public FFmpegOptionType Type => (FFmpegOptionType)_p->type;

        public IntPtr DefaultValue => _p->default_val.ptr;

        public double Min => _p->min;

        public double Max => _p->max;

        public FFmpegOptionFlags Flags => (FFmpegOptionFlags)_p->flags;

        public string Unit => Marshal.PtrToStringAnsi((IntPtr)_p->unit);
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct AVOptionBugFixed
    {
        public byte* name;
        public byte* help;
        public int offset;
        public AVOptionType type;
        public AVOptionDefaultBugFixed default_val;
        public double min;
        public double max;
        public int flags;
        public byte* unit;
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe struct AVOptionDefaultBugFixed
    {
        [FieldOffset(0)]
        public long i64;

        [FieldOffset(0)]
        public double dbl;

        [FieldOffset(0)]
        public IntPtr ptr;

        [FieldOffset(0)]
        public AVRational q;
    }
}
