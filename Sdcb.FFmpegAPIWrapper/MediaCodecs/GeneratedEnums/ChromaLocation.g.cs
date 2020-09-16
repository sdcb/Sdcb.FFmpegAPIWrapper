// This file was genereated from LINQPad scripts, DO NOT CHANGE DIRECTLY.

using System;
using Sdcb.FFmpegAPIWrapper.Common;
using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;

namespace Sdcb.FFmpegAPIWrapper.MediaCodecs
{
    /// <summary>
    /// <para>Location of chroma samples.</para>
    /// <see cref="AVChromaLocation" />
    /// </summary>
    public enum ChromaLocation
    {
        /// <summary>
        /// <see cref="AVChromaLocation.AVCHROMA_LOC_UNSPECIFIED" />
        /// </summary>
        Unspecified = 0,
        
        /// <summary>
        /// <para>MPEG-2/4 4:2:0, H.</para>
        /// <para>264 default for 4:2:0.</para>
        /// <see cref="AVChromaLocation.AVCHROMA_LOC_LEFT" />
        /// </summary>
        Left = 1,
        
        /// <summary>
        /// <para>MPEG-1 4:2:0, JPEG 4:2:0, H.</para>
        /// <para>263 4:2:0.</para>
        /// <see cref="AVChromaLocation.AVCHROMA_LOC_CENTER" />
        /// </summary>
        Center = 2,
        
        /// <summary>
        /// <para>ITU-R 601, SMPTE 274M 296M S314M(DV 4:1:1), mpeg2 4:2:2.</para>
        /// <see cref="AVChromaLocation.AVCHROMA_LOC_TOPLEFT" />
        /// </summary>
        Topleft = 3,
        
        /// <summary>
        /// <see cref="AVChromaLocation.AVCHROMA_LOC_TOP" />
        /// </summary>
        Top = 4,
        
        /// <summary>
        /// <see cref="AVChromaLocation.AVCHROMA_LOC_BOTTOMLEFT" />
        /// </summary>
        Bottomleft = 5,
        
        /// <summary>
        /// <see cref="AVChromaLocation.AVCHROMA_LOC_BOTTOM" />
        /// </summary>
        Bottom = 6,
        
        /// <summary>
        /// <para>Not part of ABI.</para>
        /// <see cref="AVChromaLocation.AVCHROMA_LOC_NB" />
        /// </summary>
        Nb = 7,
    }
}
