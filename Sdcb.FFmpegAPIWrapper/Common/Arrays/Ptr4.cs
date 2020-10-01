using FFmpeg.AutoGen;
using System;

namespace Sdcb.FFmpegAPIWrapper.Common
{
    public unsafe struct Ptr4
    {
        public static readonly int Size = 4;
        public IntPtr _0, _1, _2, _3;

        public Ptr4(IntPtr v0, IntPtr v1, IntPtr v2, IntPtr v3)
        {
            _0 = v0;
            _1 = v1;
            _2 = v2;
            _3 = v3;
        }

        public IntPtr[] ToArray() => new[] { _0, _1, _2, _3 };

        public static implicit operator Ptr4(byte_ptrArray4 s) => *(Ptr4*)&s;

        public static implicit operator byte_ptrArray4(Ptr4 s) => *(byte_ptrArray4*)&s;
    }
}
