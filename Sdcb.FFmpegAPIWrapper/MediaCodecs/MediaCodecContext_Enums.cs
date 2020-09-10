using Sdcb.FFmpegAPIWrapper.Common;
using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;
using System;

namespace Sdcb.FFmpegAPIWrapper.MediaCodecs
{
    public unsafe partial class MediaCodecContext
    {
        [Flags]
        public enum SliceFlags
        {
            /// <summary>
            /// draw_horiz_band() is called in coded order instead of display
            /// </summary>
            CodedOrder = 0x0001,

            /// <summary>
            /// allow draw_horiz_band() with field slices (MPEG-2 field pics)
            /// </summary>
            AllowField = 0x0002,

            /// <summary>
            /// allow draw_horiz_band() with 1 component at a time (SVQ1)
            /// </summary>
            AllowPlane = 0x0004,
        }

        [Flags]
        public enum MacroblockDecisions
        {
            /// <summary>
            /// uses <see cref="MacroblockComparison"/>
            /// </summary>
            Simple = 0,

            /// <summary>
            /// chooses the one which needs the fewest bits
            /// </summary>
            Bits = 1,

            /// <summary>
            /// rate distortion
            /// </summary>
            RateDistortion = 2, 
        }
    }
}
