using System;
using Sdcb.FFmpegAPIWrapper.Common;
using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;

namespace Sdcb.FFmpegAPIWrapper.MediaCodecs
{
    public unsafe partial class CodecParameters : FFmpegHandle
    {
        /// <summary>
        /// <see cref="avcodec_parameters_free(AVCodecParameters**)"/>
        /// </summary>
        public override void Close()
        {
            AVCodecParameters* ptr = this;
            avcodec_parameters_free(&ptr);
            _handle = (IntPtr)ptr;
        }
    }
}
