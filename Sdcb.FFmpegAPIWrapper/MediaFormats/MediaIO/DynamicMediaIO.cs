using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;
using System;
using Sdcb.FFmpegAPIWrapper.Common;

namespace Sdcb.FFmpegAPIWrapper.MediaFormats
{
    public class DynamicMediaIO : MediaIO
    {
        internal protected unsafe DynamicMediaIO(AVIOContext* ptr, bool isOwner) : base(ptr, isOwner)
        {
        }

        /// <summary>
        /// <see cref="avio_get_dyn_buf(AVIOContext*, byte**)"/>
        /// </summary>
        public unsafe Span<byte> GetBuffer()
        {
            byte* buffer = null;
            int length = avio_get_dyn_buf(this, &buffer).ThrowIfError();
            return new Span<byte>(buffer, length);
        }

        /// <summary>
        /// <see cref="avio_close_dyn_buf(AVIOContext*, byte**)"/>
        /// </summary>
        public unsafe DisposableDataPointer GetBufferAndClose()
        {
            byte* buffer = null;
            int length = avio_close_dyn_buf(this, &buffer);
            _nativePointer = IntPtr.Zero;
            return new DisposableDataPointer(buffer, length);
        }

        protected override void DisposeNative()
        {
            using var _ = GetBufferAndClose();
        }
    }
}
