﻿using Sdcb.FFmpegAPIWrapper.Common;
using static FFmpeg.AutoGen.ffmpeg;
using System;
using Sdcb.FFmpegAPIWrapper.MediaCodecs;
using FFmpeg.AutoGen;

namespace Sdcb.FFmpegAPIWrapper.Swscales
{
    public unsafe class FrameConverter : FFmpegSafeObject
    {
        public static implicit operator SwsContext*(FrameConverter data) => (SwsContext*)data._nativePointer;

        public FrameConverter(): base(IntPtr.Zero, isOwner: true)
        {
        }

        /// <summary>
        /// <see cref="sws_getCachedContext(SwsContext*, int, int, AVPixelFormat, int, int, AVPixelFormat, int, SwsFilter*, SwsFilter*, double*)"/>
        /// <see cref="sws_scale(SwsContext*, byte*[], int[], int, int, byte*[], int[])"/>
        /// </summary>
        public void ConvertFrame(Frame sourceFrame, Frame destFrame, ScaleFlag flags = ScaleFlag.Bilinear)
        {
            _nativePointer = NativeUtils.NotNull(
                ptr: (IntPtr)sws_getCachedContext(this,
                    sourceFrame.Width, sourceFrame.Height, (AVPixelFormat)sourceFrame.Format,
                    destFrame.Width, destFrame.Height, (AVPixelFormat)destFrame.Format,
                    flags: (int)flags,
                    srcFilter: null, dstFilter: null, param: null),
                message: PixelConverter.ErrorMessage(
                    sourceFrame.Width, sourceFrame.Height, (PixelFormat)sourceFrame.Format,
                    destFrame.Width, destFrame.Height, (PixelFormat)destFrame.Format, flags));

            sws_scale(this,
                srcSlice: sourceFrame.Data.ToArray4(),
                srcStride: sourceFrame.Linesize.ToArray4(),
                srcSliceY: 0, srcSliceH: sourceFrame.Height,
                dst: destFrame.Data.ToArray4(), destFrame.Linesize.ToArray4()).ThrowIfError();
        }

        /// <summary>
        /// <see cref="sws_freeContext(SwsContext*)"/>
        /// </summary>
        public void Free()
        {
            sws_freeContext(this);
            _nativePointer = IntPtr.Zero;
        }

        protected override void DisposeNative() => Free();
    }
}
