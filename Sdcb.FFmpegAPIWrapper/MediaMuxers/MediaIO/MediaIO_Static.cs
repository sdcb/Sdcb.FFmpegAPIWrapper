using static FFmpeg.AutoGen.ffmpeg;
using Sdcb.FFmpegAPIWrapper.Common;
using FFmpeg.AutoGen;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.IO;

namespace Sdcb.FFmpegAPIWrapper.MediaMuxers
{
    public partial class MediaIO 
    {
        /// <summary>
        /// <see cref="avio_open2(AVIOContext**, string, int, AVIOInterruptCB*, AVDictionary**)"/>
        /// </summary>
        public static unsafe MediaIO Open(string url, MediaIOFlags flags = MediaIOFlags.Read)
        {
            AVIOContext* ctx = null;
            avio_open2(&ctx, url, (int)flags, null, null).ThrowIfError();
            return new MediaIO(ctx);
        }

        /// <summary>
        /// <see cref="avio_open_dyn_buf(AVIOContext**)"/>
        /// </summary>
        public static unsafe DynamicMediaIO OpenDynamic()
        {
            AVIOContext* ctx = null;
            avio_open_dyn_buf(&ctx).ThrowIfError();
            return new DynamicMediaIO(ctx);
        }

        /// <summary>
        /// <see cref="avio_alloc_context(byte*, int, int, void*, avio_alloc_context_read_packet_func, avio_alloc_context_write_packet_func, avio_alloc_context_seek_func)"/>
        /// </summary>
        public static unsafe MediaIO FromStream(Stream stream, MediaIOFlags flags = MediaIOFlags.Read | MediaIOFlags.Write, int bufferSize = 32768)
        {
            void* buffer = av_malloc((ulong)bufferSize);
            AVIOContext* ctx = avio_alloc_context((byte*)buffer, bufferSize, (int)flags,
                opaque: null, 
                read_packet: new avio_alloc_context_read_packet(Read), 
                write_packet: new avio_alloc_context_write_packet(Write), 
                seek: new avio_alloc_context_seek(Seek));
            if (ctx == null)
            {
                throw FFmpegException.FromErrorCode(AVERROR(ENOMEM), "Failed to alloc AVIOContext");
            }
            return new MediaIO(ctx);

            int Read(void* opaque, byte* buffer, int length) => stream.Read(new Span<byte>(buffer, length));
            int Write(void* opaque, byte* buffer, int length)
            {
                stream.Write(new Span<byte>(buffer, length));
                return length;
            }
            long Seek(void* opaque, long position, int origin) => (MediaIOSeek)origin switch
            {
                MediaIOSeek.Begin => stream.Seek(position, SeekOrigin.Begin), 
                MediaIOSeek.Current => stream.Seek(position, SeekOrigin.Current), 
                MediaIOSeek.End => stream.Seek(position, SeekOrigin.End), 
                MediaIOSeek.Size => stream.Length, 
                _ => throw new NotSupportedException(), 
            };
        }

        /// <summary>
        /// <see cref="avio_alloc_context(byte*, int, int, void*, avio_alloc_context_read_packet_func, avio_alloc_context_write_packet_func, avio_alloc_context_seek_func)"/>
        /// </summary>
        public static unsafe MediaIO FromBuffer(byte* buffer, int bufferSize, MediaIOFlags flags = MediaIOFlags.Read | MediaIOFlags.Write)
        {
            AVIOContext* ctx = avio_alloc_context(buffer, bufferSize, (int)flags,
                opaque: null,
                read_packet: null,
                write_packet: null,
                seek: null);
            if (ctx == null)
            {
                throw FFmpegException.FromErrorCode(AVERROR(ENOMEM), "Failed to alloc AVIOContext");
            }
            return FromNative(ctx);
        }

        public static unsafe MediaIO FromNative(AVIOContext* p) => new MediaIO(p);

        public static unsafe implicit operator AVIOContext*(MediaIO data) => (AVIOContext*)data._handle;

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
        /// <see cref="avio_enum_protocols(void**, int)"/>
        /// </summary>
        public static IEnumerable<string> InputProtocols => EnumerateProtocols(output: 0);

        /// <summary>
        /// <see cref="avio_enum_protocols(void**, int)"/>
        /// </summary>
        public static IEnumerable<string> OutputProtocols => EnumerateProtocols(output: 1);

        private static IEnumerable<string> EnumerateProtocols(int output)
        {
            IntPtr opaque = AllocOpaque();
            try
            {
                while (true)
                {
                    string result = avio_enum_protocols_internal(opaque, output);
                    if (result == null) break;
                    yield return result;
                }
            }
            finally
            {
                Marshal.FreeHGlobal(opaque);
            }

            unsafe static IntPtr AllocOpaque()
            {
                IntPtr address = Marshal.AllocHGlobal(IntPtr.Size);
                (*(IntPtr*)(address)) = new IntPtr(0);
                return address;
            }

            unsafe static string avio_enum_protocols_internal(IntPtr opaque, int output)
            {
                return avio_enum_protocols((void**)opaque, output);
            }
        }

        public static unsafe FFmpegClass GetProtocolClass(string protocol) => FFmpegClass.FromNative(avio_protocol_get_class(protocol));
    }
}
