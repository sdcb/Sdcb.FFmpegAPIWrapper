using System;
using static FFmpeg.AutoGen.ffmpeg;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace Sdcb.FFmpegAPIWrapper.Common
{
    public struct DataPointer
    {
        public IntPtr Pointer { get; }
        public int Length { get; }

        public DataPointer(IntPtr pointer, int length)
        {
            Pointer = pointer;
            Length = length;
        }

        public unsafe DataPointer(byte* pointer, int length) : this((IntPtr)pointer, length)
        {
        }

        public DataPointer Slice(int start, int end)
        {
            if (start > Length) throw new ArgumentOutOfRangeException(nameof(start));
            if (end < 0) throw new ArgumentOutOfRangeException(nameof(end));
            return new DataPointer(Pointer + start, end);
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
        public IntPtr Pointer { get; private set; }
        public int Length { get; private set; }

        public DisposableDataPointer(IntPtr pointer, int length)
        {
            Pointer = pointer;
            Length = length;
        }

        public unsafe DisposableDataPointer(byte* pointer, int length) : this((IntPtr)pointer, length)
        {
        }

        public unsafe DisposableDataPointer(int allocSize) : this(NativeUtils.NotNull((IntPtr)av_malloc((ulong)allocSize)), allocSize)
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

        public DataPointer Slice(int start, int end)
        {
            if (start > Length) throw new ArgumentOutOfRangeException(nameof(start));
            if (end < 0) throw new ArgumentOutOfRangeException(nameof(end));
            return new DataPointer(Pointer + start, end);
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
            if (pointer == IntPtr.Zero)
            {
                throw FFmpegException.NoMemory($"pointer = 0 in {nameof(DisposableNativeString)}.");
            }
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
            return Marshal.PtrToStringUTF8(Pointer)!;
        }
    }
}
