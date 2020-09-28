using Sdcb.FFmpegAPIWrapper.Common;
using System;
using System.Collections.Generic;
using System.Text;
using static FFmpeg.AutoGen.ffmpeg;

namespace Sdcb.FFmpegAPIWrapper.MediaCodecs
{
    public unsafe partial class CodecParserContext
    {
        private const long NoPts = long.MinValue;
        

        public CodecParserContext(CodecID codecId) : base(NativeUtils.NotNull((IntPtr)av_parser_init((int)codecId)), isOwner: true)
        {
        }

        public int Parse(CodecContext codecContext, Span<byte> data, out DataPointer result, long pts = NoPts, long dts = NoPts, long pos = 0)
        {
            byte* outBuffer;
            int outBufferSize;
            fixed(byte* ptr = data)
            {
                int length = av_parser_parse2(this, codecContext, &outBuffer, &outBufferSize, ptr, data.Length, pts, dts, pos).ThrowIfError();
                result = new DataPointer(outBuffer, outBufferSize);
                return length;
            }
        }

        protected override void DisposeNative()
        {
            throw new NotImplementedException();
        }
    }
}
