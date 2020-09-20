using System;
using System.Collections.Generic;
using System.Text;

namespace Sdcb.FFmpegAPIWrapper.Common
{
    public struct DataPointer
    {
        public readonly IntPtr Pointer;
        public readonly int Length;

        public DataPointer(IntPtr pointer, int length)
        {
            Pointer = pointer;
            Length = length;
        }

        public unsafe DataPointer(byte* pointer, int length) : this((IntPtr)pointer, length)
        {
        }

        public unsafe DataPointer(Span<byte> data)
        {
            fixed(byte* ptr = data)
            {
                Pointer = (IntPtr)ptr;
                Length = data.Length;
            }
        }

        public unsafe Span<byte> AsSpan() => new Span<byte>((byte*)Pointer, Length);
    }
}
