// This file was genereated from LINQPad scripts, DO NOT CHANGE DIRECTLY.

using System;
using Sdcb.FFmpegAPIWrapper.Common;
using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;

namespace Sdcb.FFmpegAPIWrapper.MediaCodecs
{
    /// <summary>
    /// <para>YUV colorspace type.</para>
    /// <para> These values match the ones defined by ISO/IEC 23091-2_2019 subclause 8.</para>
    /// <para>3.</para>
    /// <see cref="AVColorSpace" />
    /// </summary>
    public enum ColorSpace
    {
        /// <summary>
        /// <para>order of coefficients is actually GBR, also IEC 61966-2-1 (sRGB), YZX and ST 428-1.</para>
        /// <see cref="AVColorSpace.AVCOL_SPC_RGB" />
        /// </summary>
        Rgb = 0,
        
        /// <summary>
        /// <para>also ITU-R BT1361 / IEC 61966-2-4 xvYCC709 / derived in SMPTE RP 177 Annex B.</para>
        /// <see cref="AVColorSpace.AVCOL_SPC_BT709" />
        /// </summary>
        Bt709 = 1,
        
        /// <summary>
        /// <see cref="AVColorSpace.AVCOL_SPC_UNSPECIFIED" />
        /// </summary>
        Unspecified = 2,
        
        /// <summary>
        /// <para>reserved for future use by ITU-T and ISO/IEC just like 15-255 are.</para>
        /// <see cref="AVColorSpace.AVCOL_SPC_RESERVED" />
        /// </summary>
        Reserved = 3,
        
        /// <summary>
        /// <para>FCC Title 47 Code of Federal Regulations 73.</para>
        /// <para>682 (a)(20).</para>
        /// <see cref="AVColorSpace.AVCOL_SPC_FCC" />
        /// </summary>
        Fcc = 4,
        
        /// <summary>
        /// <para>also ITU-R BT601-6 625 / ITU-R BT1358 625 / ITU-R BT1700 625 PAL &amp; SECAM / IEC 61966-2-4 xvYCC601.</para>
        /// <see cref="AVColorSpace.AVCOL_SPC_BT470BG" />
        /// </summary>
        Bt470bg = 5,
        
        /// <summary>
        /// <para>also ITU-R BT601-6 525 / ITU-R BT1358 525 / ITU-R BT1700 NTSC / functionally identical to above.</para>
        /// <see cref="AVColorSpace.AVCOL_SPC_SMPTE170M" />
        /// </summary>
        Smpte170m = 6,
        
        /// <summary>
        /// <para>derived from 170M primaries and D65 white point, 170M is derived from BT470 System M&#39;s primaries.</para>
        /// <see cref="AVColorSpace.AVCOL_SPC_SMPTE240M" />
        /// </summary>
        Smpte240m = 7,
        
        /// <summary>
        /// <para>used by Dirac / VC-2 and H.</para>
        /// <para>264 FRext, see ITU-T SG16.</para>
        /// <see cref="AVColorSpace.AVCOL_SPC_YCGCO" />
        /// </summary>
        Ycgco = 8,
        
        /// <summary>
        /// <see cref="AVColorSpace.AVCOL_SPC_YCOCG" />
        /// </summary>
        Ycocg = 8,
        
        /// <summary>
        /// <para>ITU-R BT2020 non-constant luminance system.</para>
        /// <see cref="AVColorSpace.AVCOL_SPC_BT2020_NCL" />
        /// </summary>
        Bt2020Ncl = 9,
        
        /// <summary>
        /// <para>ITU-R BT2020 constant luminance system.</para>
        /// <see cref="AVColorSpace.AVCOL_SPC_BT2020_CL" />
        /// </summary>
        Bt2020Cl = 10,
        
        /// <summary>
        /// <para>SMPTE 2085, Y&#39;D&#39;zD&#39;x.</para>
        /// <see cref="AVColorSpace.AVCOL_SPC_SMPTE2085" />
        /// </summary>
        Smpte2085 = 11,
        
        /// <summary>
        /// <para>Chromaticity-derived non-constant luminance system.</para>
        /// <see cref="AVColorSpace.AVCOL_SPC_CHROMA_DERIVED_NCL" />
        /// </summary>
        ChromaDerivedNcl = 12,
        
        /// <summary>
        /// <para>Chromaticity-derived constant luminance system.</para>
        /// <see cref="AVColorSpace.AVCOL_SPC_CHROMA_DERIVED_CL" />
        /// </summary>
        ChromaDerivedCl = 13,
        
        /// <summary>
        /// <para>ITU-R BT.</para>
        /// <para>2100-0, ICtCp.</para>
        /// <see cref="AVColorSpace.AVCOL_SPC_ICTCP" />
        /// </summary>
        Ictcp = 14,
        
        /// <summary>
        /// <para>Not part of ABI.</para>
        /// <see cref="AVColorSpace.AVCOL_SPC_NB" />
        /// </summary>
        Nb = 15,
    }
}
