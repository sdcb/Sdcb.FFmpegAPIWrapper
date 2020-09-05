using static FFmpeg.AutoGen.ffmpeg;
using Sdcb.FFmpegAPIWrapper.Common;
using FFmpeg.AutoGen;
using System;

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
            AVIOContext* ctx = null;
            avio_open2(&ctx, url, (int)flags, null, null).ThrowIfError();
            return new MediaIO(ctx);
        }

        public static unsafe DynamicMediaIO CreateDynamic()
        {
            AVIOContext* ctx = null;
            avio_open_dyn_buf(&ctx).ThrowIfError();
            return new DynamicMediaIO(ctx);
        }

        /// <summary>
        /// <see cref="avio_read(AVIOContext*, byte*, int)"/>
        /// </summary>
        public unsafe int Read(Span<byte> data)
        {
            fixed(byte* pin = data)
            {
                return avio_read(this, pin, data.Length).ThrowIfError();
            }
        }

        /// <summary>
        /// <see cref="avio_read_partial(AVIOContext*, byte*, int)"/>
        /// </summary>
        public unsafe int ReadPartial(Span<byte> data)
        {
            fixed(byte* p = data)
            {
                return avio_read_partial(this, p, data.Length).ThrowIfError();
            }
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
        /// <see cref="avio_get_str(AVIOContext*, int, byte*, int)"/>
        /// </summary>
        public unsafe int ReadString(Span<byte> data, int maxLength)
        {
            fixed(byte* p = data)
            {
                return avio_get_str(this, maxLength, p, data.Length).ThrowIfError();
            }
        }

        /// <summary>
        /// <para>Read a UTF-16 string and convert it to UTF-8.</para>
        /// <see cref="avio_get_str16le(AVIOContext*, int, byte*, int)"/>
        /// </summary>
        public unsafe int ReadStringUtf16LE(Span<byte> data, int maxLength)
        {
            fixed(byte* p = data)
            {
                return avio_get_str16le(this, maxLength, p, data.Length).ThrowIfError();
            }
        }

        /// <summary>
        /// <para>Read a UTF-16 string and convert it to UTF-8.</para>
        /// <see cref="avio_get_str16le(AVIOContext*, int, byte*, int)"/>
        /// </summary>
        public unsafe int ReadStringUtf16BE(Span<byte> data, int maxLength)
        {
            fixed(byte* p = data)
            {
                return avio_get_str16be(this, maxLength, p, data.Length).ThrowIfError();
            }
        }

        /// <summary>
        /// <see cref="avio_write(AVIOContext*, byte*, int)"/>
        /// </summary>
        public unsafe void Write(ReadOnlySpan<byte> data)
        {
            fixed (byte* pin = data)
            {
                avio_write(this, pin, data.Length);
            }
        }

        /// <summary>
        /// <see cref="avio_put_str(AVIOContext*, string)"/>
        /// </summary>
        /// <param name="text">NULL-terminated string.</param>
        /// <returns>number of bytes written.</returns>
        public unsafe int WriteString(string text) => avio_put_str(this, text);

        /// <summary>
        /// Convert an string to UTF-16LE and write it.
        /// <see cref="avio_put_str16le(AVIOContext*, string)"/>
        /// </summary>
        /// <param name="text">NULL-terminated UTF-8 string</param>
        /// <returns>number of bytes written.</returns>
        public unsafe int WriteStringUtf16LE(string text) => avio_put_str16le(this, text);

        /// <summary>
        /// Convert an string to UTF-16BE and write it.
        /// <see cref="avio_put_str16be(AVIOContext*, string)"/>
        /// </summary>
        /// <param name="text">NULL-terminated UTF-8 string</param>
        /// <returns>number of bytes written.</returns>
        public unsafe int WriteStringUtf16BE(string text) => avio_put_str16be(this, text);

        /// <summary>
        /// Mark the written bytestream as a specific type.
        /// <para>Zero-length ranges are omitted from the output.</para>
        /// <see cref="avio_write_marker(AVIOContext*, long, AVIODataMarkerType)"/>
        /// </summary>
        /// <param name="time">the stream time the current bytestream pos corresponds to 
        /// (in AV_TIME_BASE units), or AV_NOPTS_VALUE if unknown or not applicable</param>
        /// <param name="type">the kind of data written starting at the current pos</param>
        public unsafe void WriteMarker(long time, DataMarkerTypes type) => avio_write_marker(this, time, (AVIODataMarkerType)type);

        /// <summary>
        /// <see cref="avio_flush(AVIOContext*)"/>
        /// </summary>
        public unsafe void Flush() => avio_flush(this);

        /// <summary>
        /// <see cref="avio_seek(AVIOContext*, long, int)"/>
        /// </summary>
        public unsafe long Seek(long offset, MediaIOSeek origin)
        {
            return avio_seek(this, offset, (int)origin).ThrowIfError();
        }

        /// <summary>
        /// <para>Similar to feof() but also returns nonzero on read errors.</para>
        /// <para>@return non zero if and only if at end of file or a read error happened when reading.</para>
        /// <see cref="avio_feof(AVIOContext*)"/>
        /// </summary>
        public unsafe int EOF => avio_feof(this);

        /// <summary>
        /// <see cref="avio_size(AVIOContext*)"/>
        /// </summary>
        public unsafe long Size => avio_size(this).ThrowIfError();

        /// <summary>
        /// <see cref="avio_close(AVIOContext*)"/>
        /// </summary>
        protected unsafe override void Close()
        {
            avio_close((AVIOContext*)_handle).ThrowIfError();
        }
    }
}
