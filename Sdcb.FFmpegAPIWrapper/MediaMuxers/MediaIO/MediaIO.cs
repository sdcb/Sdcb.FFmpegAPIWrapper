using static FFmpeg.AutoGen.ffmpeg;
using Sdcb.FFmpegAPIWrapper.Common;
using FFmpeg.AutoGen;
using System;
using System.Buffers;

namespace Sdcb.FFmpegAPIWrapper.MediaMuxers
{
    public class MediaIO : FFmpegHandle
    {
        protected unsafe MediaIO(AVIOContext* ptr): base((IntPtr)ptr) { }

        public static unsafe explicit operator AVIOContext*(MediaIO data) => (AVIOContext*)data._handle;

        public static unsafe explicit operator MediaIO(AVIOContext* ptr) => new MediaIO(ptr);

        public static string GetUrlProtocol(string url) => avio_find_protocol_name(url);

        public static void Move(string source, string destination) => avpriv_io_move(source, destination);

        public static void Delete(string source) => avpriv_io_delete(source);

        public static MediaIOFlags Check(string url, MediaIOFlags flags) => (MediaIOFlags)avio_check(url, (int)flags).ThrowIfError();

        public static unsafe MediaIO Create(string url, MediaIOFlags flags = MediaIOFlags.Read)
        {
            AVIOContext* cts = null;
            avio_open2(&cts, url, (int)flags, null, null).ThrowIfError();
            return new MediaIO(cts);
        }

        public unsafe void Write(ReadOnlySpan<byte> data)
        {
            fixed(byte* pin = data)
            {
                avio_write((AVIOContext*)this, pin, data.Length);
            }
        }

        public unsafe void Write(ReadOnlyMemory<byte> data)
        {
            MemoryHandle pin = data.Pin();
            avio_write((AVIOContext*)this, (byte*)pin.Pointer, data.Length);
        }

        public unsafe int Read(Span<byte> data)
        {
            fixed(byte* pin = data)
            {
                return avio_read((AVIOContext*)this, pin, data.Length);
            }
        }

        public unsafe int Read(Memory<byte> data)
        {
            MemoryHandle pin = data.Pin();
            return avio_read((AVIOContext*)this, (byte*)pin.Pointer, data.Length);
        }

        protected unsafe override void Close()
        {
            avio_close((AVIOContext*)_handle).ThrowIfError();
        }
    }
}
