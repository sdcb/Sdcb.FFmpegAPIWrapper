﻿using Sdcb.FFmpegAPIWrapper.Common;
using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;
using System;

namespace Sdcb.FFmpegAPIWrapper.MediaCodecs
{
    public unsafe partial class CodecContext : FFmpegHandle
    {
        public const int CompressionDefault = FF_COMPRESSION_DEFAULT;

        /// <summary>
        /// <see cref="avcodec_parameters_from_context(AVCodecParameters*, AVCodecContext*)"/>
        /// </summary>
        public void ToParameter(AVCodecParameters* parameter)
        {
            avcodec_parameters_from_context(parameter, this).ThrowIfError();
        }

        public void FromParameter(AVCodecParameters* parameter)
        {

        }

        public override void Close()
        {
            AVCodecContext* ptr = this;
            avcodec_free_context(&ptr);
            _handle = (IntPtr)ptr;
        }
    }
}