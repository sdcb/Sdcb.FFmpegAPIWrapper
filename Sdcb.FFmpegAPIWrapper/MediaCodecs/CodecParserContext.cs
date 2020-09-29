using Sdcb.FFmpegAPIWrapper.Common;
using System;
using System.Collections.Generic;
using System.IO;
using static FFmpeg.AutoGen.ffmpeg;

namespace Sdcb.FFmpegAPIWrapper.MediaCodecs
{
    public unsafe partial class CodecParserContext
    {
        private const long NoPts = long.MinValue;
        
        /// <summary>
        /// <see cref="av_parser_init(int)"/>
        /// </summary>
        public CodecParserContext(CodecID codecId) : base(NativeUtils.NotNull((IntPtr)av_parser_init((int)codecId)), isOwner: true)
        {
        }

        /// <summary>
        /// <see cref="av_parser_parse2(FFmpeg.AutoGen.AVCodecParserContext*, FFmpeg.AutoGen.AVCodecContext*, byte**, int*, byte*, int, long, long, long)"/>
        /// </summary>
        public int Parse(CodecContext codecContext, DataPointer data, out DataPointer result, long pts = NoPts, long dts = NoPts, long pos = 0)
        {
            byte* outBuffer;
            int outBufferSize;

            int offset = av_parser_parse2(this, codecContext, &outBuffer, &outBufferSize, (byte*)data.Pointer, data.Length, pts, dts, pos).ThrowIfError();
            result = new DataPointer(outBuffer, outBufferSize);
            return offset;
        }

        public IEnumerable<DataPointer> Parse(CodecContext codecContext, Stream sourceStream, int bufferSize = 4096, long pts = NoPts, long dts = NoPts, long pos = 0)
        {
            IntPtr buffer = AllocZero(bufferSize + AV_INPUT_BUFFER_PADDING_SIZE);
            try
            {
                while (true)
                {
                    int thisBufferLength = sourceStream.Read(ToSpan(buffer, bufferSize));
                    if (thisBufferLength == 0) break;

                    DataPointer thisBuffer = new DataPointer(buffer, thisBufferLength);
                    while (thisBuffer.Length > 0)
                    {
                        int offset = Parse(codecContext, thisBuffer, out DataPointer dataPointer, pts, dts, pos);
                        if (dataPointer.Length > 0) yield return dataPointer;
                        thisBuffer = thisBuffer[offset..];
                    }
                }
            }
            finally
            {
                Free(buffer);
            }

            static Span<byte> ToSpan(IntPtr buffer, int length) => new Span<byte>((void*)buffer, length);
            static IntPtr AllocZero(int size) => NativeUtils.NotNull((IntPtr)av_mallocz((ulong)size));
            static void Free(IntPtr ptr) => av_free((void*)ptr);
        }

        /// <summary>
        /// <see cref="av_parser_close(FFmpeg.AutoGen.AVCodecParserContext*)"/>
        /// </summary>
        public void Free()
        {
            av_parser_close(this);
            _nativePointer = IntPtr.Zero;
        }

        protected override void DisposeNative() => Free();
    }
}
