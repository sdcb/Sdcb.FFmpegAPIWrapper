using Sdcb.FFmpegAPIWrapper.MediaCodecs;
using static FFmpeg.AutoGen.ffmpeg;
using System;
using FFmpeg.AutoGen;
using Sdcb.FFmpegAPIWrapper.Common;

namespace Sdcb.FFmpegAPIWrapper.MediaUtils
{
    public static class ImageUtils
    {
        /// <summary>
        /// <see cref="av_image_get_buffer_size(AVPixelFormat, int, int, int)"/>
        /// </summary>
        public static int GetBufferSize(PixelFormat pixelFormat, int width, int height, int align = 1)
            => av_image_get_buffer_size((AVPixelFormat)pixelFormat, width, height, align).ThrowIfError();

        /// <summary>
        /// <see cref="av_image_copy_to_buffer(byte*, int, byte_ptrArray4, int_array4, AVPixelFormat, int, int, int)"/>
        /// </summary>
        public static unsafe int CopyToBuffer(
            PixelFormat pixelFormat, 
            int width, 
            int height, 
            DataPointer dest, 
            byte_ptrArray4 sourceData, int_array4 sourceLinesize, 
            int align = 1)
        {
            return av_image_copy_to_buffer(
                (byte*)dest.Pointer, dest.Length, 
                sourceData, sourceLinesize, 
                (AVPixelFormat)pixelFormat, 
                width, height, align).ThrowIfError();
        }

        /// <summary>
        /// <see cref="av_image_fill_linesizes(ref int_array4, AVPixelFormat, int)"/>
        /// </summary>
        public static unsafe int_array4 GetLinesize(PixelFormat pixelFormat, int width)
        {
            int_array4 linesizes;
            av_image_fill_linesizes(ref linesizes, (AVPixelFormat)pixelFormat, width).ThrowIfError();
            return linesizes;
        }

        /// <summary>
        /// <see cref="av_image_fill_pointers(ref byte_ptrArray4, AVPixelFormat, int, byte*, int_array4)"/>
        /// </summary>
        public static unsafe byte_ptrArray4 ToPlaneData(IntPtr sourceData, int_array4 linesizes, PixelFormat pixelFormat, int height)
        {
            byte_ptrArray4 ret = default;
            av_image_fill_pointers(ret, (AVPixelFormat)pixelFormat, height, (byte*)sourceData, linesizes).ThrowIfError();
            return ret;
        }
    }
}
