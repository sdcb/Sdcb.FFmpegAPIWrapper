// This file was genereated from LINQPad scripts, DO NOT CHANGE DIRECTLY.

using System;
using Sdcb.FFmpegAPIWrapper.Common;
using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;

namespace Sdcb.FFmpegAPIWrapper.Common
{
    /// <summary>
    /// <para>@{ AVOptions provide a generic system to declare options on arbitrary structs (&quot;objects&quot;).</para>
    /// <para> An option can have a help text, a type and a range of possible values.</para>
    /// <para> Options may then be enumerated, read and written to.</para>
    /// <see cref="AVOptionType" />
    /// </summary>
    public enum FFmpegOptionType
    {
        /// <summary>
        /// <see cref="AVOptionType.AV_OPT_TYPE_FLAGS" />
        /// </summary>
        Flags = 0,
        
        /// <summary>
        /// <see cref="AVOptionType.AV_OPT_TYPE_INT" />
        /// </summary>
        Int = 1,
        
        /// <summary>
        /// <see cref="AVOptionType.AV_OPT_TYPE_INT64" />
        /// </summary>
        Int64 = 2,
        
        /// <summary>
        /// <see cref="AVOptionType.AV_OPT_TYPE_DOUBLE" />
        /// </summary>
        Double = 3,
        
        /// <summary>
        /// <see cref="AVOptionType.AV_OPT_TYPE_FLOAT" />
        /// </summary>
        Float = 4,
        
        /// <summary>
        /// <see cref="AVOptionType.AV_OPT_TYPE_STRING" />
        /// </summary>
        String = 5,
        
        /// <summary>
        /// <see cref="AVOptionType.AV_OPT_TYPE_RATIONAL" />
        /// </summary>
        Rational = 6,
        
        /// <summary>
        /// <para>offset must point to a pointer immediately followed by an int for the length.</para>
        /// <see cref="AVOptionType.AV_OPT_TYPE_BINARY" />
        /// </summary>
        Binary = 7,
        
        /// <summary>
        /// <see cref="AVOptionType.AV_OPT_TYPE_DICT" />
        /// </summary>
        Dict = 8,
        
        /// <summary>
        /// <see cref="AVOptionType.AV_OPT_TYPE_UINT64" />
        /// </summary>
        Uint64 = 9,
        
        /// <summary>
        /// <see cref="AVOptionType.AV_OPT_TYPE_CONST" />
        /// </summary>
        Const = 10,
        
        /// <summary>
        /// <para>offset must point to two consecutive integers.</para>
        /// <see cref="AVOptionType.AV_OPT_TYPE_IMAGE_SIZE" />
        /// </summary>
        ImageSize = 11,
        
        /// <summary>
        /// <see cref="AVOptionType.AV_OPT_TYPE_PIXEL_FMT" />
        /// </summary>
        PixelFmt = 12,
        
        /// <summary>
        /// <see cref="AVOptionType.AV_OPT_TYPE_SAMPLE_FMT" />
        /// </summary>
        SampleFmt = 13,
        
        /// <summary>
        /// <para>offset must point to AVRational.</para>
        /// <see cref="AVOptionType.AV_OPT_TYPE_VIDEO_RATE" />
        /// </summary>
        VideoRate = 14,
        
        /// <summary>
        /// <see cref="AVOptionType.AV_OPT_TYPE_DURATION" />
        /// </summary>
        Duration = 15,
        
        /// <summary>
        /// <see cref="AVOptionType.AV_OPT_TYPE_COLOR" />
        /// </summary>
        Color = 16,
        
        /// <summary>
        /// <see cref="AVOptionType.AV_OPT_TYPE_CHANNEL_LAYOUT" />
        /// </summary>
        ChannelLayout = 17,
        
        /// <summary>
        /// <see cref="AVOptionType.AV_OPT_TYPE_BOOL" />
        /// </summary>
        Bool = 18,
    }
}
