using Sdcb.FFmpegAPIWrapper.Common;
using static FFmpeg.AutoGen.ffmpeg;
using System;
using System.Collections.Generic;
using System.Text;
using FFmpeg.AutoGen;

namespace Sdcb.FFmpegAPIWrapper.MediaCodecs
{
    public unsafe partial class Frame : FFmpegHandle
    {
        /// <summary>
        /// <see cref="av_frame_alloc"/>
        /// </summary>
        public static Frame Create() => FromNative(av_frame_alloc(), true);

        /// <summary>
        /// <see cref="av_frame_is_writable(AVFrame*)"/>
        /// </summary>
        public bool IsWritable => av_frame_is_writable(this) != 0;

        /// <summary>
        /// <see cref="av_frame_ref(AVFrame*, AVFrame*)"/>
        /// </summary>
        public void Reference(Frame other) => av_frame_ref(this, other).ThrowIfError();

        /// <summary>
        /// <see cref="av_frame_unref(AVFrame*)"/>
        /// </summary>
        public void Unreference() => av_frame_unref(this);

        /// <summary>
        /// <see cref="av_frame_clone(AVFrame*)"/>
        /// </summary>
        public Frame Clone() => FromNative(av_frame_clone(this), isOwner: true);

        /// <summary>
        /// <see cref="av_frame_copy(AVFrame*, AVFrame*)"/>
        /// </summary>
        public void CopyTo(Frame other) => av_frame_copy(other, this).ThrowIfError();

        /// <summary>
        /// <see cref="av_frame_copy_props(AVFrame*, AVFrame*)"/>
        /// </summary>
        public void CopyPropsTo(Frame other) => av_frame_copy_props(other, this).ThrowIfError();

        /// <summary>
        /// <see cref="av_frame_move_ref(AVFrame*, AVFrame*)"/>
        /// </summary>
        public void MoveReferenceTo(Frame dest) => av_frame_move_ref(dest, this);

        /// <summary>
        /// <see cref="av_frame_get_buffer(AVFrame*, int)"/>
        /// </summary>
        public void EnsureBuffer(int align = 0) => av_frame_get_buffer(this, align).ThrowIfError();

        /// <summary>
        /// <see cref="av_frame_make_writable(AVFrame*)"/>
        /// </summary>
        public void MakeWritable() => av_frame_make_writable(this).ThrowIfError();

        /// <summary>
        /// <see cref="av_frame_free(AVFrame**)"/>
        /// </summary>
        public override void Close()
        {
            AVFrame* ptr = this;
            av_frame_free(&ptr);
            _handle = (IntPtr)ptr;
        }

        public static string GetColorspaceName(ColorSpace val) => av_get_colorspace_name((AVColorSpace)val);
    }
}
