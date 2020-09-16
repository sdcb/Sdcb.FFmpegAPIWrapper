// This file was genereated from LINQPad scripts, DO NOT CHANGE DIRECTLY.

using System;
using Sdcb.FFmpegAPIWrapper.Common;
using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;

namespace Sdcb.FFmpegAPIWrapper.MediaCodecs
{
    /// <summary>
    /// <para>Color Transfer Characteristic.</para>
    /// <para> These values match the ones defined by ISO/IEC 23001-8_2013 &#167; 7.</para>
    /// <para>2.</para>
    /// <see cref="AVColorTransferCharacteristic" />
    /// </summary>
    public enum ColorTransferCharacteristic
    {
        /// <summary>
        /// <see cref="AVColorTransferCharacteristic.AVCOL_TRC_RESERVED0" />
        /// </summary>
        Reserved0 = 0,
        
        /// <summary>
        /// <para>also ITU-R BT1361.</para>
        /// <see cref="AVColorTransferCharacteristic.AVCOL_TRC_BT709" />
        /// </summary>
        Bt709 = 1,
        
        /// <summary>
        /// <see cref="AVColorTransferCharacteristic.AVCOL_TRC_UNSPECIFIED" />
        /// </summary>
        Unspecified = 2,
        
        /// <summary>
        /// <see cref="AVColorTransferCharacteristic.AVCOL_TRC_RESERVED" />
        /// </summary>
        Reserved = 3,
        
        /// <summary>
        /// <para>also ITU-R BT470M / ITU-R BT1700 625 PAL &amp; SECAM.</para>
        /// <see cref="AVColorTransferCharacteristic.AVCOL_TRC_GAMMA22" />
        /// </summary>
        Gamma22 = 4,
        
        /// <summary>
        /// <para>also ITU-R BT470BG.</para>
        /// <see cref="AVColorTransferCharacteristic.AVCOL_TRC_GAMMA28" />
        /// </summary>
        Gamma28 = 5,
        
        /// <summary>
        /// <para>also ITU-R BT601-6 525 or 625 / ITU-R BT1358 525 or 625 / ITU-R BT1700 NTSC.</para>
        /// <see cref="AVColorTransferCharacteristic.AVCOL_TRC_SMPTE170M" />
        /// </summary>
        Smpte170m = 6,
        
        /// <summary>
        /// <see cref="AVColorTransferCharacteristic.AVCOL_TRC_SMPTE240M" />
        /// </summary>
        Smpte240m = 7,
        
        /// <summary>
        /// <para>&quot;Linear transfer characteristics&quot;.</para>
        /// <see cref="AVColorTransferCharacteristic.AVCOL_TRC_LINEAR" />
        /// </summary>
        Linear = 8,
        
        /// <summary>
        /// <para>&quot;Logarithmic transfer characteristic (100:1 range)&quot;.</para>
        /// <see cref="AVColorTransferCharacteristic.AVCOL_TRC_LOG" />
        /// </summary>
        Log = 9,
        
        /// <summary>
        /// <para>&quot;Logarithmic transfer characteristic (100 * Sqrt(10) : 1 range)&quot;.</para>
        /// <see cref="AVColorTransferCharacteristic.AVCOL_TRC_LOG_SQRT" />
        /// </summary>
        LogSqrt = 10,
        
        /// <summary>
        /// <para>IEC 61966-2-4.</para>
        /// <see cref="AVColorTransferCharacteristic.AVCOL_TRC_IEC61966_2_4" />
        /// </summary>
        Iec6196624 = 11,
        
        /// <summary>
        /// <para>ITU-R BT1361 Extended Colour Gamut.</para>
        /// <see cref="AVColorTransferCharacteristic.AVCOL_TRC_BT1361_ECG" />
        /// </summary>
        Bt1361Ecg = 12,
        
        /// <summary>
        /// <para>IEC 61966-2-1 (sRGB or sYCC).</para>
        /// <see cref="AVColorTransferCharacteristic.AVCOL_TRC_IEC61966_2_1" />
        /// </summary>
        Iec6196621 = 13,
        
        /// <summary>
        /// <para>ITU-R BT2020 for 10-bit system.</para>
        /// <see cref="AVColorTransferCharacteristic.AVCOL_TRC_BT2020_10" />
        /// </summary>
        Bt202010 = 14,
        
        /// <summary>
        /// <para>ITU-R BT2020 for 12-bit system.</para>
        /// <see cref="AVColorTransferCharacteristic.AVCOL_TRC_BT2020_12" />
        /// </summary>
        Bt202012 = 15,
        
        /// <summary>
        /// <para>SMPTE ST 2084 for 10-, 12-, 14- and 16-bit systems.</para>
        /// <see cref="AVColorTransferCharacteristic.AVCOL_TRC_SMPTE2084" />
        /// </summary>
        Smpte2084 = 16,
        
        /// <summary>
        /// <see cref="AVColorTransferCharacteristic.AVCOL_TRC_SMPTEST2084" />
        /// </summary>
        Smptest2084 = 16,
        
        /// <summary>
        /// <para>SMPTE ST 428-1.</para>
        /// <see cref="AVColorTransferCharacteristic.AVCOL_TRC_SMPTE428" />
        /// </summary>
        Smpte428 = 17,
        
        /// <summary>
        /// <see cref="AVColorTransferCharacteristic.AVCOL_TRC_SMPTEST428_1" />
        /// </summary>
        Smptest4281 = 17,
        
        /// <summary>
        /// <para>ARIB STD-B67, known as &quot;Hybrid log-gamma&quot;.</para>
        /// <see cref="AVColorTransferCharacteristic.AVCOL_TRC_ARIB_STD_B67" />
        /// </summary>
        AribStdB67 = 18,
        
        /// <summary>
        /// <para>Not part of ABI.</para>
        /// <see cref="AVColorTransferCharacteristic.AVCOL_TRC_NB" />
        /// </summary>
        Nb = 19,
    }
}
