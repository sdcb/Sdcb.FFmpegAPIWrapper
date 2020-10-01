using FFmpeg.AutoGen;
using System;

namespace Sdcb.FFmpegAPIWrapper.Common
{
    public unsafe struct Ptr8
    {
        public static readonly int Size = 8;
        public IntPtr _0, _1, _2, _3, _4, _5, _6, _7;

        public Ptr8(IntPtr v0, IntPtr v1, IntPtr v2, IntPtr v3, IntPtr v4, IntPtr v5, IntPtr v6, IntPtr v7)
        {
            _0 = v0;
            _1 = v1;
            _2 = v2;
            _3 = v3;
            _4 = v4;
            _5 = v5;
            _6 = v6;
            _7 = v7;
        }

        public IntPtr[] ToArray() => new[] { _0, _1, _2, _3, _4, _5, _6, _7 };

        public static implicit operator Ptr8(byte_ptrArray8 s) => *(Ptr8*)&s;

        public static implicit operator byte_ptrArray8(Ptr8 s) => *(byte_ptrArray8*)&s;

        public static explicit operator Ptr4(Ptr8 s) => new Ptr4(s._0, s._1, s._2, s._3);

        public static explicit operator Ptr8(Ptr4 s) => new Ptr8(s._0, s._1, s._2, s._3, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero);
    }
}
