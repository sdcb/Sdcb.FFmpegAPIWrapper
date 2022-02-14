// This file was genereated from LINQPad scripts, DO NOT CHANGE DIRECTLY.

using System;
using Sdcb.FFmpegAPIWrapper.Common;
using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;

namespace Sdcb.FFmpegAPIWrapper.Common
{
    /// <summary>
    /// <para>A reference to a data buffer.</para>
    /// <see cref="AVBufferRef" />
    /// </summary>
    public unsafe partial class BufferReference : FFmpegSafeObject
    {
        protected AVBufferRef* Pointer => this;
        
        public static implicit operator AVBufferRef*(BufferReference data) => data != null ? (AVBufferRef*)data._nativePointer : null;
        
        protected BufferReference(AVBufferRef* ptr, bool isOwner): base(NativeUtils.NotNull((IntPtr)ptr), isOwner)
        {
        }
        
        public static BufferReference FromNative(AVBufferRef* ptr, bool isOwner) => new BufferReference(ptr, isOwner);
        
        /// <summary>
        /// <see cref="AVBufferRef.buffer" />
        /// </summary>
        public AVBuffer* Buffer
        {
            get => Pointer->buffer;
            set => Pointer->buffer = value;
        }
        
        /// <summary>
        /// <para>The data buffer.</para>
        /// <para> It is considered writable if and only if this is the only reference to the buffer, in which case av_buffer_is_writable() returns 1.</para>
        /// <see cref="AVBufferRef.data" />
        /// </summary>
        public IntPtr Data
        {
            get => (IntPtr)Pointer->data;
            set => Pointer->data = (byte*)value;
        }
        
        /// <summary>
        /// <para>Size of data in bytes.</para>
        /// <see cref="AVBufferRef.size" />
        /// </summary>
        public ulong Size
        {
            get => Pointer->size;
            set => Pointer->size = value;
        }
    }
}
