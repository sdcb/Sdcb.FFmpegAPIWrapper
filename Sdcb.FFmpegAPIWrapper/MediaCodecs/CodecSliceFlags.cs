using System;

namespace Sdcb.FFmpegAPIWrapper.MediaCodecs
{
    [Flags]
    public enum CodecSliceFlags
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
}
