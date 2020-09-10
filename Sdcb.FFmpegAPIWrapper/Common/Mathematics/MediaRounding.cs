using System;
using System.Collections.Generic;
using System.Text;
using FFmpeg.AutoGen;

namespace Sdcb.FFmpegAPIWrapper.Common
{
    /// <summary>
    /// <see cref="AVRounding"/>
    /// </summary>
    public enum MediaRounding
    {
        /// <summary>
        /// Round toward zero
        /// </summary>
        Zero = 0, 

        /// <summary>
        /// Round away from zero
        /// </summary>
        AwayZero = 1, 

        /// <summary>
        /// Round toward -infinity
        /// </summary>
        Down = 2, 

        /// <summary>
        /// Round toward +infinity
        /// </summary>
        Up = 3, 

        /// <summary>
        /// Round to nearest and halfway cases away from zero.
        /// </summary>
        NearInf = 5,

        PassMinMax = 8192, 
    }
}
