using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;
using System;
using Sdcb.FFmpegAPIWrapper.Common;

namespace Sdcb.FFmpegAPIWrapper.MediaMuxers
{
    public class DynamicMediaIO : MediaIO
    {
        internal protected unsafe DynamicMediaIO(AVIOContext* ptr) : base(ptr)
        {
        }

        public unsafe Span<byte> GetBuffer()
        {
            byte* buffer = null;
            int length = avio_get_dyn_buf(this, &buffer).ThrowIfError();
            return new Span<byte>(buffer, length);
        }

        public unsafe DynamicMediaIOMemory GetBufferAndClose()
        {
            byte* buffer = null;
            int length = avio_close_dyn_buf(this, &buffer);
            _handle = IntPtr.Zero;
            return new DynamicMediaIOMemory
            {
                Buffer = buffer, 
                Length = length, 
            };
        }

        protected override void Close()
        {
            using var _ = GetBufferAndClose();
        }
    }

    public ref struct DynamicMediaIOMemory
    {
        public unsafe byte* Buffer;
        public int Length;

        public unsafe Span<byte> AsSpan() => new Span<byte>(Buffer, Length);

        public unsafe void Dispose()
        {
            av_free(Buffer);
            Buffer = null;
            Length = 0;
        }
    }
}
