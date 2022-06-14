using System;
using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;

namespace Sdcb.FFmpegAPIWrapper.Common
{
    public unsafe partial class BufferReference : FFmpegSafeObject
    {
        /// <summary>
        /// <see cref="av_buffer_alloc(int)"/>
        /// <see cref="av_buffer_allocz(int)"/>
        /// </summary>
        /// <returns></returns>
        public BufferReference Alloc(long size, bool zeroInitialized = true) => FromNative(
            zeroInitialized ? av_buffer_alloc((ulong)size) : av_buffer_allocz((ulong)size),
            isOwner: true);

        public BufferReference Create(Span<byte> data, Action<IntPtr, IntPtr> free, IntPtr opaque, int flags)
        {
            if (data.Length == 0) throw new ArgumentOutOfRangeException(nameof(data));
            fixed (byte* ptr = data)
            {
                AVBufferRef* res = av_buffer_create(ptr, (ulong)data.Length, new av_buffer_create_free((o, d) => free((IntPtr)o, (IntPtr)d)), (void*)opaque, flags);
                if (res == null) throw FFmpegException.NoMemory("falied to allocate AVBufferRef");
                return FromNative(res, isOwner: true);
            }
        }

        /// <summary>
        /// <see cref="av_buffer_get_opaque(AVBufferRef*)"/>
        /// </summary>
        public IntPtr Opaque => (IntPtr)av_buffer_get_opaque(this);

        /// <summary>
        /// <see cref="av_buffer_get_ref_count(AVBufferRef*)"/>
        /// </summary>
        public int ReferenceCount => av_buffer_get_ref_count(this);

        /// <summary>
        /// <see cref="av_buffer_ref(AVBufferRef*)"/>
        /// </summary>
        public BufferReference Reference() => FromNative(av_buffer_ref(this), isOwner: true);

        public void Unreference()
        {
            AVBufferRef* ptr;
            av_buffer_unref(&ptr);
            _nativePointer = (IntPtr)ptr;
        }

        /// <summary>
        /// <see cref="av_buffer_make_writable(AVBufferRef**)"/>
        /// </summary>
        public void MakeWritable()
        {
            AVBufferRef* ptr = this;
            av_buffer_make_writable(&ptr).ThrowIfError();
            _nativePointer = (IntPtr)ptr;
        }

        /// <summary>
        /// <see cref="av_buffer_realloc(AVBufferRef**, int)"/>
        /// </summary>
        /// <param name="size"></param>
        public void Realloc(ulong size)
        {
            AVBufferRef* ptr = this;
            av_buffer_realloc(&ptr, size);
            _nativePointer = (IntPtr)ptr;
        }

        protected override void DisposeNative() => Unreference();
    }
}
