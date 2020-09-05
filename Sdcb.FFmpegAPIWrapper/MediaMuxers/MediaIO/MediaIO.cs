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

        public static unsafe implicit operator AVIOContext*(MediaIO data) => (AVIOContext*)data._handle;

        public static unsafe explicit operator MediaIO(AVIOContext* ptr) => new MediaIO(ptr);

        /// <summary>
        /// <see cref="avio_find_protocol_name(string)"/>
        /// </summary>
        public static string GetUrlProtocol(string url) => avio_find_protocol_name(url);

        /// <summary>
        /// <see cref="avpriv_io_move(string, string)"/>
        /// </summary>
        public static void Move(string source, string destination) => avpriv_io_move(source, destination);

        /// <summary>
        /// <see cref="avpriv_io_delete(string)"/>
        /// </summary>
        public static void Delete(string source) => avpriv_io_delete(source);

        /// <summary>
        /// <see cref="avio_check(string, int)"/>
        /// </summary>
        public static MediaIOFlags Check(string url, MediaIOFlags flags) => (MediaIOFlags)avio_check(url, (int)flags).ThrowIfError();

        /// <summary>
        /// <see cref="avio_open2(AVIOContext**, string, int, AVIOInterruptCB*, AVDictionary**)"/>
        /// </summary>
        public static unsafe MediaIO Create(string url, MediaIOFlags flags = MediaIOFlags.Read)
        {
            AVIOContext* cts = null;
            avio_open2(&cts, url, (int)flags, null, null).ThrowIfError();
            return new MediaIO(cts);
        }

        /// <summary>
        /// <see cref="avio_write(AVIOContext*, byte*, int)"/>
        /// </summary>
        public unsafe void Write(ReadOnlySpan<byte> data)
        {
            fixed(byte* pin = data)
            {
                avio_write(this, pin, data.Length);
            }
        }

        /// <summary>
        /// <see cref="avio_write(AVIOContext*, byte*, int)"/>
        /// </summary>
        public unsafe void Write(ReadOnlyMemory<byte> data)
        {
            MemoryHandle pin = data.Pin();
            avio_write(this, (byte*)pin.Pointer, data.Length);
        }

        /// <summary>
        /// <see cref="avio_read(AVIOContext*, byte*, int)"/>
        /// </summary>
        public unsafe int Read(Span<byte> data)
        {
            fixed(byte* pin = data)
            {
                return avio_read(this, pin, data.Length);
            }
        }

        /// <summary>
        /// <see cref="avio_read(AVIOContext*, byte*, int)"/>
        /// </summary>
        public unsafe int Read(Memory<byte> data)
        {
            MemoryHandle pin = data.Pin();
            return avio_read(this, (byte*)pin.Pointer, data.Length);
        }

        /// <summary>
        /// <see cref="avio_r8(AVIOContext*)"/>
        /// </summary>
        /// <returns>return 0 if EOF, so you cannot use it if EOF handling is necessary</returns>
        public unsafe byte ReadByte() => (byte)avio_r8(this);

        /// <summary>
        /// <see cref="avio_rl16(AVIOContext*)"/>
        /// </summary>
        /// <returns>return 0 if EOF, so you cannot use it if EOF handling is necessary</returns>
        public unsafe ushort ReadUInt16LittleEndian() => (ushort)avio_rl16(this);

        /// <summary>
        /// <see cref="avio_rl24(AVIOContext*)"/>
        /// </summary>
        /// <returns>return 0 if EOF, so you cannot use it if EOF handling is necessary</returns>
        public unsafe uint ReadUInt24LittleEndian() => avio_rl24(this);

        /// <summary>
        /// <see cref="avio_rl32(AVIOContext*)"/>
        /// </summary>
        /// <returns>return 0 if EOF, so you cannot use it if EOF handling is necessary</returns>
        public unsafe uint ReadUInt32LittleEndian() => avio_rl32(this);

        /// <summary>
        /// <see cref="avio_rl64(AVIOContext*)"/>
        /// </summary>
        /// <returns>return 0 if EOF, so you cannot use it if EOF handling is necessary</returns>
        public unsafe ulong ReadUInt64LittleEndian() => avio_rl64(this);

        /// <summary>
        /// <see cref="avio_rb16(AVIOContext*)"/>
        /// </summary>
        /// <returns>return 0 if EOF, so you cannot use it if EOF handling is necessary</returns>
        public unsafe ushort ReadUInt16BigEndian() => (ushort)avio_rb16(this);

        /// <summary>
        /// <see cref="avio_rb24(AVIOContext*)"/>
        /// </summary>
        /// <returns>return 0 if EOF, so you cannot use it if EOF handling is necessary</returns>
        public unsafe uint ReadUInt24BigEndian() => avio_rb24(this);

        /// <summary>
        /// <see cref="avio_rb32(AVIOContext*)"/>
        /// </summary>
        /// <returns>return 0 if EOF, so you cannot use it if EOF handling is necessary</returns>
        public unsafe uint ReadUInt32BigEndian() => avio_rb32(this);

        /// <summary>
        /// <see cref="avio_rb64(AVIOContext*)"/>
        /// </summary>
        /// <returns>return 0 if EOF, so you cannot use it if EOF handling is necessary</returns>
        public unsafe ulong ReadUInt64BigEndian() => avio_rb64(this);

        /// <summary>
        /// <see cref="avio_close(AVIOContext*)"/>
        /// </summary>
        protected unsafe override void Close()
        {
            avio_close((AVIOContext*)_handle).ThrowIfError();
        }
    }
}
