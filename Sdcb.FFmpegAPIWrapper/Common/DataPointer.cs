using System;
using static FFmpeg.AutoGen.ffmpeg;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

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

    public ref struct DisposableDataPointer
    {
        public IntPtr Pointer;
        public int Length;

        public DisposableDataPointer(IntPtr pointer, int length)
        {
            Pointer = pointer;
            Length = length;
        }

        public unsafe DisposableDataPointer(byte* pointer, int length) : this((IntPtr)pointer, length)
        {
        }

        public unsafe DisposableDataPointer(Span<byte> data)
        {
            fixed (byte* ptr = data)
            {
                Pointer = (IntPtr)ptr;
                Length = data.Length;
            }
        }

        public unsafe Span<byte> AsSpan() => new Span<byte>((byte*)Pointer, Length);

        public unsafe void Dispose()
        {
            av_free((void*)Pointer);
            Pointer = IntPtr.Zero;
            Length = 0;
        }
    }

    public ref struct DisposableNativeString
    {
        public IntPtr Pointer;

        public DisposableNativeString(IntPtr pointer)
        {
            Pointer = pointer;
        }

        public unsafe DisposableNativeString(byte* pointer) : this((IntPtr)pointer)
        {
        }

        public unsafe void Dispose()
        {
            av_free((void*)Pointer);
            Pointer = IntPtr.Zero;
        }

        public override string ToString()
        {
            return Marshal.PtrToStringUTF8(Pointer);
        }
    }
}
