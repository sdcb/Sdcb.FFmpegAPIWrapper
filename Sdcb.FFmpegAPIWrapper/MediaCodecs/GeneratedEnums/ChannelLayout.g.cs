// This file was genereated from LINQPad scripts, DO NOT CHANGE DIRECTLY.

using System;
using Sdcb.FFmpegAPIWrapper.Common;
using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;

namespace Sdcb.FFmpegAPIWrapper.MediaCodecs
{
    [Flags]
    public enum ChannelLayout : ulong
    {
        /// <summary>
        /// <para>AV_CH_LAYOUT_STEREO = (AV_CH_FRONT_LEFT|AV_CH_FRONT_RIGHT).</para>
        /// <see cref="ffmpeg.AV_CH_LAYOUT_STEREO" />
        /// </summary>
        Stereo = 0x3UL,
        
        /// <summary>
        /// <para>AV_CH_LAYOUT_MONO = (AV_CH_FRONT_CENTER).</para>
        /// <see cref="ffmpeg.AV_CH_LAYOUT_MONO" />
        /// </summary>
        Mono = 0x4UL,
        
        /// <summary>
        /// <para>AV_CH_LAYOUT_SURROUND = (AV_CH_LAYOUT_STEREO|AV_CH_FRONT_CENTER).</para>
        /// <see cref="ffmpeg.AV_CH_LAYOUT_SURROUND" />
        /// </summary>
        Surround = 0x7UL,
        
        /// <summary>
        /// <para>AV_CH_LAYOUT_2POINT1 = (AV_CH_LAYOUT_STEREO|AV_CH_LOW_FREQUENCY).</para>
        /// <see cref="ffmpeg.AV_CH_LAYOUT_2POINT1" />
        /// </summary>
        _2point1 = 0xBUL,
        
        /// <summary>
        /// <para>AV_CH_LAYOUT_3POINT1 = (AV_CH_LAYOUT_SURROUND|AV_CH_LOW_FREQUENCY).</para>
        /// <see cref="ffmpeg.AV_CH_LAYOUT_3POINT1" />
        /// </summary>
        _3point1 = 0xFUL,
        
        /// <summary>
        /// <para>AV_CH_LAYOUT_QUAD = (AV_CH_LAYOUT_STEREO|AV_CH_BACK_LEFT|AV_CH_BACK_RIGHT).</para>
        /// <see cref="ffmpeg.AV_CH_LAYOUT_QUAD" />
        /// </summary>
        Quad = 0x33UL,
        
        /// <summary>
        /// <para>AV_CH_LAYOUT_5POINT0_BACK = (AV_CH_LAYOUT_SURROUND|AV_CH_BACK_LEFT|AV_CH_BACK_RIGHT).</para>
        /// <see cref="ffmpeg.AV_CH_LAYOUT_5POINT0_BACK" />
        /// </summary>
        _5point0Back = 0x37UL,
        
        /// <summary>
        /// <para>AV_CH_LAYOUT_5POINT1_BACK = (AV_CH_LAYOUT_5POINT0_BACK|AV_CH_LOW_FREQUENCY).</para>
        /// <see cref="ffmpeg.AV_CH_LAYOUT_5POINT1_BACK" />
        /// </summary>
        _5point1Back = 0x3FUL,
        
        /// <summary>
        /// <para>AV_CH_LAYOUT_7POINT1_WIDE_BACK = (AV_CH_LAYOUT_5POINT1_BACK|AV_CH_FRONT_LEFT_OF_CENTER|AV_CH_FRONT_RIGHT_OF_CENTER).</para>
        /// <see cref="ffmpeg.AV_CH_LAYOUT_7POINT1_WIDE_BACK" />
        /// </summary>
        _7point1WideBack = 0xFFUL,
        
        /// <summary>
        /// <para>AV_CH_LAYOUT_2_1 = (AV_CH_LAYOUT_STEREO|AV_CH_BACK_CENTER).</para>
        /// <see cref="ffmpeg.AV_CH_LAYOUT_2_1" />
        /// </summary>
        _21 = 0x103UL,
        
        /// <summary>
        /// <para>AV_CH_LAYOUT_4POINT0 = (AV_CH_LAYOUT_SURROUND|AV_CH_BACK_CENTER).</para>
        /// <see cref="ffmpeg.AV_CH_LAYOUT_4POINT0" />
        /// </summary>
        _4point0 = 0x107UL,
        
        /// <summary>
        /// <para>AV_CH_LAYOUT_4POINT1 = (AV_CH_LAYOUT_4POINT0|AV_CH_LOW_FREQUENCY).</para>
        /// <see cref="ffmpeg.AV_CH_LAYOUT_4POINT1" />
        /// </summary>
        _4point1 = 0x10FUL,
        
        /// <summary>
        /// <para>AV_CH_LAYOUT_HEXAGONAL = (AV_CH_LAYOUT_5POINT0_BACK|AV_CH_BACK_CENTER).</para>
        /// <see cref="ffmpeg.AV_CH_LAYOUT_HEXAGONAL" />
        /// </summary>
        Hexagonal = 0x137UL,
        
        /// <summary>
        /// <para>AV_CH_LAYOUT_6POINT1_BACK = (AV_CH_LAYOUT_5POINT1_BACK|AV_CH_BACK_CENTER).</para>
        /// <see cref="ffmpeg.AV_CH_LAYOUT_6POINT1_BACK" />
        /// </summary>
        _6point1Back = 0x13FUL,
        
        /// <summary>
        /// <para>AV_CH_LAYOUT_2_2 = (AV_CH_LAYOUT_STEREO|AV_CH_SIDE_LEFT|AV_CH_SIDE_RIGHT).</para>
        /// <see cref="ffmpeg.AV_CH_LAYOUT_2_2" />
        /// </summary>
        _22 = 0x603UL,
        
        /// <summary>
        /// <para>AV_CH_LAYOUT_5POINT0 = (AV_CH_LAYOUT_SURROUND|AV_CH_SIDE_LEFT|AV_CH_SIDE_RIGHT).</para>
        /// <see cref="ffmpeg.AV_CH_LAYOUT_5POINT0" />
        /// </summary>
        _5point0 = 0x607UL,
        
        /// <summary>
        /// <para>AV_CH_LAYOUT_5POINT1 = (AV_CH_LAYOUT_5POINT0|AV_CH_LOW_FREQUENCY).</para>
        /// <see cref="ffmpeg.AV_CH_LAYOUT_5POINT1" />
        /// </summary>
        _5point1 = 0x60FUL,
        
        /// <summary>
        /// <para>AV_CH_LAYOUT_7POINT0 = (AV_CH_LAYOUT_5POINT0|AV_CH_BACK_LEFT|AV_CH_BACK_RIGHT).</para>
        /// <see cref="ffmpeg.AV_CH_LAYOUT_7POINT0" />
        /// </summary>
        _7point0 = 0x637UL,
        
        /// <summary>
        /// <para>AV_CH_LAYOUT_7POINT1 = (AV_CH_LAYOUT_5POINT1|AV_CH_BACK_LEFT|AV_CH_BACK_RIGHT).</para>
        /// <see cref="ffmpeg.AV_CH_LAYOUT_7POINT1" />
        /// </summary>
        _7point1 = 0x63FUL,
        
        /// <summary>
        /// <para>AV_CH_LAYOUT_6POINT0_FRONT = (AV_CH_LAYOUT_2_2|AV_CH_FRONT_LEFT_OF_CENTER|AV_CH_FRONT_RIGHT_OF_CENTER).</para>
        /// <see cref="ffmpeg.AV_CH_LAYOUT_6POINT0_FRONT" />
        /// </summary>
        _6point0Front = 0x6C3UL,
        
        /// <summary>
        /// <para>AV_CH_LAYOUT_7POINT0_FRONT = (AV_CH_LAYOUT_5POINT0|AV_CH_FRONT_LEFT_OF_CENTER|AV_CH_FRONT_RIGHT_OF_CENTER).</para>
        /// <see cref="ffmpeg.AV_CH_LAYOUT_7POINT0_FRONT" />
        /// </summary>
        _7point0Front = 0x6C7UL,
        
        /// <summary>
        /// <para>AV_CH_LAYOUT_6POINT1_FRONT = (AV_CH_LAYOUT_6POINT0_FRONT|AV_CH_LOW_FREQUENCY).</para>
        /// <see cref="ffmpeg.AV_CH_LAYOUT_6POINT1_FRONT" />
        /// </summary>
        _6point1Front = 0x6CBUL,
        
        /// <summary>
        /// <para>AV_CH_LAYOUT_7POINT1_WIDE = (AV_CH_LAYOUT_5POINT1|AV_CH_FRONT_LEFT_OF_CENTER|AV_CH_FRONT_RIGHT_OF_CENTER).</para>
        /// <see cref="ffmpeg.AV_CH_LAYOUT_7POINT1_WIDE" />
        /// </summary>
        _7point1Wide = 0x6CFUL,
        
        /// <summary>
        /// <para>AV_CH_LAYOUT_6POINT0 = (AV_CH_LAYOUT_5POINT0|AV_CH_BACK_CENTER).</para>
        /// <see cref="ffmpeg.AV_CH_LAYOUT_6POINT0" />
        /// </summary>
        _6point0 = 0x707UL,
        
        /// <summary>
        /// <para>AV_CH_LAYOUT_6POINT1 = (AV_CH_LAYOUT_5POINT1|AV_CH_BACK_CENTER).</para>
        /// <see cref="ffmpeg.AV_CH_LAYOUT_6POINT1" />
        /// </summary>
        _6point1 = 0x70FUL,
        
        /// <summary>
        /// <para>AV_CH_LAYOUT_OCTAGONAL = (AV_CH_LAYOUT_5POINT0|AV_CH_BACK_LEFT|AV_CH_BACK_CENTER|AV_CH_BACK_RIGHT).</para>
        /// <see cref="ffmpeg.AV_CH_LAYOUT_OCTAGONAL" />
        /// </summary>
        Octagonal = 0x737UL,
        
        /// <summary>
        /// <para>AV_CH_LAYOUT_STEREO_DOWNMIX = (AV_CH_STEREO_LEFT|AV_CH_STEREO_RIGHT).</para>
        /// <see cref="ffmpeg.AV_CH_LAYOUT_STEREO_DOWNMIX" />
        /// </summary>
        StereoDownmix = 0x60000000UL,
        
        /// <summary>
        /// <para>AV_CH_LAYOUT_HEXADECAGONAL = (AV_CH_LAYOUT_OCTAGONAL|AV_CH_WIDE_LEFT|AV_CH_WIDE_RIGHT|AV_CH_TOP_BACK_LEFT|AV_CH_TOP_BACK_RIGHT|AV_CH_TOP_BACK_CENTER|AV_CH_TOP_FRONT_CENTER|AV_CH_TOP_FRONT_LEFT|AV_CH_TOP_FRONT_RIGHT).</para>
        /// <see cref="ffmpeg.AV_CH_LAYOUT_HEXADECAGONAL" />
        /// </summary>
        Hexadecagonal = 0x18003F737UL,
        
        /// <summary>
        /// <para>AV_CH_LAYOUT_NATIVE = 0x8000000000000000ULL.</para>
        /// <see cref="ffmpeg.AV_CH_LAYOUT_NATIVE" />
        /// </summary>
        Native = 0x8000000000000000UL,
        
    }
}
