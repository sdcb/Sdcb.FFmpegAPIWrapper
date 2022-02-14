// This file was genereated from LINQPad scripts, DO NOT CHANGE DIRECTLY.

using System;
using Sdcb.FFmpegAPIWrapper.Common;
using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;

namespace Sdcb.FFmpegAPIWrapper.MediaCodecs
{
    /// <summary>
    /// <para>Chromaticity coordinates of the source primaries.</para>
    /// <para> These values match the ones defined by ISO/IEC 23091-2_2019 subclause 8.</para>
    /// <para>1 and ITU-T H.</para>
    /// <para>273.</para>
    /// <see cref="AVColorPrimaries" />
    /// </summary>
    public enum ColorPrimaries
    {
        /// <summary>
        /// <see cref="AVColorPrimaries.AVCOL_PRI_RESERVED0" />
        /// </summary>
        Reserved0 = 0,
        
        /// <summary>
        /// <para>also ITU-R BT1361 / IEC 61966-2-4 / SMPTE RP 177 Annex B.</para>
        /// <see cref="AVColorPrimaries.AVCOL_PRI_BT709" />
        /// </summary>
        Bt709 = 1,
        
        /// <summary>
        /// <see cref="AVColorPrimaries.AVCOL_PRI_UNSPECIFIED" />
        /// </summary>
        Unspecified = 2,
        
        /// <summary>
        /// <see cref="AVColorPrimaries.AVCOL_PRI_RESERVED" />
        /// </summary>
        Reserved = 3,
        
        /// <summary>
        /// <para>also FCC Title 47 Code of Federal Regulations 73.</para>
        /// <para>682 (a)(20).</para>
        /// <see cref="AVColorPrimaries.AVCOL_PRI_BT470M" />
        /// </summary>
        Bt470m = 4,
        
        /// <summary>
        /// <para>also ITU-R BT601-6 625 / ITU-R BT1358 625 / ITU-R BT1700 625 PAL &amp; SECAM.</para>
        /// <see cref="AVColorPrimaries.AVCOL_PRI_BT470BG" />
        /// </summary>
        Bt470bg = 5,
        
        /// <summary>
        /// <para>also ITU-R BT601-6 525 / ITU-R BT1358 525 / ITU-R BT1700 NTSC.</para>
        /// <see cref="AVColorPrimaries.AVCOL_PRI_SMPTE170M" />
        /// </summary>
        Smpte170m = 6,
        
        /// <summary>
        /// <para>identical to above, also called &quot;SMPTE C&quot; even though it uses D65.</para>
        /// <see cref="AVColorPrimaries.AVCOL_PRI_SMPTE240M" />
        /// </summary>
        Smpte240m = 7,
        
        /// <summary>
        /// <para>colour filters using Illuminant C.</para>
        /// <see cref="AVColorPrimaries.AVCOL_PRI_FILM" />
        /// </summary>
        Film = 8,
        
        /// <summary>
        /// <para>ITU-R BT2020.</para>
        /// <see cref="AVColorPrimaries.AVCOL_PRI_BT2020" />
        /// </summary>
        Bt2020 = 9,
        
        /// <summary>
        /// <para>SMPTE ST 428-1 (CIE 1931 XYZ).</para>
        /// <see cref="AVColorPrimaries.AVCOL_PRI_SMPTE428" />
        /// </summary>
        Smpte428 = 10,
        
        /// <summary>
        /// <see cref="AVColorPrimaries.AVCOL_PRI_SMPTEST428_1" />
        /// </summary>
        Smptest4281 = 10,
        
        /// <summary>
        /// <para>SMPTE ST 431-2 (2011) / DCI P3.</para>
        /// <see cref="AVColorPrimaries.AVCOL_PRI_SMPTE431" />
        /// </summary>
        Smpte431 = 11,
        
        /// <summary>
        /// <para>SMPTE ST 432-1 (2010) / P3 D65 / Display P3.</para>
        /// <see cref="AVColorPrimaries.AVCOL_PRI_SMPTE432" />
        /// </summary>
        Smpte432 = 12,
        
        /// <summary>
        /// <para>EBU Tech.</para>
        /// <para> 3213-E (nothing there) / one of JEDEC P22 group phosphors.</para>
        /// <see cref="AVColorPrimaries.AVCOL_PRI_EBU3213" />
        /// </summary>
        Ebu3213 = 22,
        
        /// <summary>
        /// <see cref="AVColorPrimaries.AVCOL_PRI_JEDEC_P22" />
        /// </summary>
        JedecP22 = 22,
        
        /// <summary>
        /// <para>Not part of ABI.</para>
        /// <see cref="AVColorPrimaries.AVCOL_PRI_NB" />
        /// </summary>
        Nb = 23,
    }
}
