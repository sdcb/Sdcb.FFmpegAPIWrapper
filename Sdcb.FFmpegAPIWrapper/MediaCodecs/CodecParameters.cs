using System;
using Sdcb.FFmpegAPIWrapper.Common;
using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;

namespace Sdcb.FFmpegAPIWrapper.MediaCodecs
{
    public unsafe partial class CodecParameters
    {
        /// <summary>
        /// <see cref="avcodec_parameters_alloc"/>
        /// </summary>
        public static CodecParameters Create() => new CodecParameters(avcodec_parameters_alloc(), isOwner: true);

        /// <summary>
        /// <see cref="avcodec_parameters_copy(AVCodecParameters*, AVCodecParameters*)"/>
        /// </summary>
        public void CopyFrom(CodecParameters source)
        {
            avcodec_parameters_copy(this, source).ThrowIfError();
        }

        /// <summary>
        /// <see cref="avcodec_parameters_from_context(AVCodecParameters*, AVCodecContext*)"/>
        /// </summary>
        public void CopyFrom(CodecContext ctx)
        {
            avcodec_parameters_from_context(this, ctx).ThrowIfError();
        }

        /// <summary>
        /// <see cref="avcodec_parameters_free(AVCodecParameters**)"/>
        /// </summary>
        public void Free()
        {
            AVCodecParameters* ptr = this;
            avcodec_parameters_free(&ptr);
            _nativePointer = (IntPtr)ptr;
        }

        protected override void DisposeNative() => Free();
    }
}
