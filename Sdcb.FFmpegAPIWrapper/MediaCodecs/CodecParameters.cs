using System;
using Sdcb.FFmpegAPIWrapper.Common;
using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;

namespace Sdcb.FFmpegAPIWrapper.MediaCodecs
{
    public unsafe partial class CodecParameters : FFmpegHandle
    {
        /// <summary>
        /// <see cref="avcodec_parameters_alloc"/>
        /// </summary>
        public static CodecParameters Create() => new CodecParameters(avcodec_parameters_alloc(), isOwner: true);

        /// <summary>
        /// <see cref="avcodec_parameters_copy(AVCodecParameters*, AVCodecParameters*)"/>
        /// </summary>
        public void Copy(CodecParameters source)
        {
            avcodec_parameters_copy(this, source).ThrowIfError();
        }

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
