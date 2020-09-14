using System;

namespace Sdcb.FFmpegAPIWrapper.MediaCodecs
{
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
