﻿using Sdcb.FFmpegAPIWrapper.MediaCodecs;
using static FFmpeg.AutoGen.ffmpeg;
using System;
using System.Collections.Generic;
using System.Text;
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
        /// <see cref="av_image_copy_to_buffer(byte*, int, byte_ptrArray4, int_array4, AVPixelFormat, int, int, int)"/>
        /// </summary>
        public static unsafe int CopyToBuffer(
            PixelFormat pixelFormat,
            int width,
            int height,
            DataPointer dest,
            byte_ptrArray8 sourceData, int_array8 sourceLinesize,
            int align = 1)
        {
            
            byte_ptrArray4 internalData = new byte_ptrArray4();
            internalData.UpdateFrom(sourceData.ToArray()[..4]);
            int_array4 internalLinesize = new int_array4();
            internalLinesize.UpdateFrom(sourceLinesize);

            return av_image_copy_to_buffer(
                (byte*)dest.Pointer, dest.Length,
                internalData, internalLinesize,
                (AVPixelFormat)pixelFormat,
                width, height, align).ThrowIfError();
        }
    }
}
