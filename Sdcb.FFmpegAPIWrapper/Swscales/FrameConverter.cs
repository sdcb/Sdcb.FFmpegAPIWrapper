using Sdcb.FFmpegAPIWrapper.Common;
using static FFmpeg.AutoGen.ffmpeg;
using System;
using Sdcb.FFmpegAPIWrapper.MediaCodecs;
using FFmpeg.AutoGen;

namespace Sdcb.FFmpegAPIWrapper.Swscales
{
    public unsafe class FrameConverter : PixelConverter
    {
        public FrameConverter(): base(IntPtr.Zero, isOwner: true)
        {
        }

        public void ConvertFrame(Frame sourceFrame, Frame destFrame, ScaleFlag flags = ScaleFlag.None)
        {
            _nativePointer = NativeUtils.NotNull(
                ptr: (IntPtr)sws_getCachedContext(this,
                    sourceFrame.Width, sourceFrame.Height, (AVPixelFormat)sourceFrame.Format,
                    destFrame.Width, destFrame.Height, (AVPixelFormat)destFrame.Format,
                    flags: (int)flags,
                    srcFilter: null, dstFilter: null, param: null),
                message: ErrorMessage(
                    sourceFrame.Width, sourceFrame.Height, (PixelFormat)sourceFrame.Format,
                    destFrame.Width, destFrame.Height, (PixelFormat)destFrame.Format, flags));

            Convert(
                (Ptr4)sourceFrame.Data, (Int32x4)sourceFrame.Linesize, sourceFrame.Height, 
                (Ptr4)destFrame.Data, (Int32x4)destFrame.Linesize);
        }
    }
}
