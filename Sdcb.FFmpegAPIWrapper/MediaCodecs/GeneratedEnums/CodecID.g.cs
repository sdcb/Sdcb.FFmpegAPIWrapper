// This file was genereated from LINQPad scripts, DO NOT CHANGE DIRECTLY.

using System;
using Sdcb.FFmpegAPIWrapper.Common;
using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;

namespace Sdcb.FFmpegAPIWrapper.MediaCodecs
{
    /// <summary>
    /// <para>Identify the syntax and semantics of the bitstream.</para>
    /// <para> The principle is roughly: Two decoders with the same ID can decode the same streams.</para>
    /// <para> Two encoders with the same ID can encode compatible streams.</para>
    /// <para> There may be slight deviations from the principle due to implementation details.</para>
    /// <see cref="AVCodecID" />
    /// </summary>
    public enum CodecID
    {
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_NONE" />
        /// </summary>
        None = 0,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_MPEG1VIDEO" />
        /// </summary>
        Mpeg1video = 1,
        
        /// <summary>
        /// <para>preferred ID for MPEG-1/2 video decoding.</para>
        /// <see cref="AVCodecID.AV_CODEC_ID_MPEG2VIDEO" />
        /// </summary>
        Mpeg2video = 2,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_H261" />
        /// </summary>
        H261 = 3,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_H263" />
        /// </summary>
        H263 = 4,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_RV10" />
        /// </summary>
        Rv10 = 5,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_RV20" />
        /// </summary>
        Rv20 = 6,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_MJPEG" />
        /// </summary>
        Mjpeg = 7,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_MJPEGB" />
        /// </summary>
        Mjpegb = 8,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_LJPEG" />
        /// </summary>
        Ljpeg = 9,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_SP5X" />
        /// </summary>
        Sp5x = 10,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_JPEGLS" />
        /// </summary>
        Jpegls = 11,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_MPEG4" />
        /// </summary>
        Mpeg4 = 12,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_RAWVIDEO" />
        /// </summary>
        Rawvideo = 13,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_MSMPEG4V1" />
        /// </summary>
        Msmpeg4v1 = 14,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_MSMPEG4V2" />
        /// </summary>
        Msmpeg4v2 = 15,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_MSMPEG4V3" />
        /// </summary>
        Msmpeg4v3 = 16,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_WMV1" />
        /// </summary>
        Wmv1 = 17,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_WMV2" />
        /// </summary>
        Wmv2 = 18,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_H263P" />
        /// </summary>
        H263p = 19,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_H263I" />
        /// </summary>
        H263i = 20,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_FLV1" />
        /// </summary>
        Flv1 = 21,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_SVQ1" />
        /// </summary>
        Svq1 = 22,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_SVQ3" />
        /// </summary>
        Svq3 = 23,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_DVVIDEO" />
        /// </summary>
        Dvvideo = 24,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_HUFFYUV" />
        /// </summary>
        Huffyuv = 25,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_CYUV" />
        /// </summary>
        Cyuv = 26,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_H264" />
        /// </summary>
        H264 = 27,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_INDEO3" />
        /// </summary>
        Indeo3 = 28,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_VP3" />
        /// </summary>
        Vp3 = 29,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_THEORA" />
        /// </summary>
        Theora = 30,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_ASV1" />
        /// </summary>
        Asv1 = 31,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_ASV2" />
        /// </summary>
        Asv2 = 32,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_FFV1" />
        /// </summary>
        Ffv1 = 33,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_4XM" />
        /// </summary>
        _4xm = 34,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_VCR1" />
        /// </summary>
        Vcr1 = 35,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_CLJR" />
        /// </summary>
        Cljr = 36,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_MDEC" />
        /// </summary>
        Mdec = 37,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_ROQ" />
        /// </summary>
        Roq = 38,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_INTERPLAY_VIDEO" />
        /// </summary>
        InterplayVideo = 39,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_XAN_WC3" />
        /// </summary>
        XanWc3 = 40,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_XAN_WC4" />
        /// </summary>
        XanWc4 = 41,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_RPZA" />
        /// </summary>
        Rpza = 42,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_CINEPAK" />
        /// </summary>
        Cinepak = 43,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_WS_VQA" />
        /// </summary>
        WsVqa = 44,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_MSRLE" />
        /// </summary>
        Msrle = 45,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_MSVIDEO1" />
        /// </summary>
        Msvideo1 = 46,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_IDCIN" />
        /// </summary>
        Idcin = 47,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_8BPS" />
        /// </summary>
        _8bps = 48,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_SMC" />
        /// </summary>
        Smc = 49,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_FLIC" />
        /// </summary>
        Flic = 50,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_TRUEMOTION1" />
        /// </summary>
        Truemotion1 = 51,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_VMDVIDEO" />
        /// </summary>
        Vmdvideo = 52,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_MSZH" />
        /// </summary>
        Mszh = 53,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_ZLIB" />
        /// </summary>
        Zlib = 54,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_QTRLE" />
        /// </summary>
        Qtrle = 55,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_TSCC" />
        /// </summary>
        Tscc = 56,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_ULTI" />
        /// </summary>
        Ulti = 57,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_QDRAW" />
        /// </summary>
        Qdraw = 58,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_VIXL" />
        /// </summary>
        Vixl = 59,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_QPEG" />
        /// </summary>
        Qpeg = 60,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_PNG" />
        /// </summary>
        Png = 61,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_PPM" />
        /// </summary>
        Ppm = 62,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_PBM" />
        /// </summary>
        Pbm = 63,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_PGM" />
        /// </summary>
        Pgm = 64,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_PGMYUV" />
        /// </summary>
        Pgmyuv = 65,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_PAM" />
        /// </summary>
        Pam = 66,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_FFVHUFF" />
        /// </summary>
        Ffvhuff = 67,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_RV30" />
        /// </summary>
        Rv30 = 68,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_RV40" />
        /// </summary>
        Rv40 = 69,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_VC1" />
        /// </summary>
        Vc1 = 70,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_WMV3" />
        /// </summary>
        Wmv3 = 71,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_LOCO" />
        /// </summary>
        Loco = 72,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_WNV1" />
        /// </summary>
        Wnv1 = 73,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_AASC" />
        /// </summary>
        Aasc = 74,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_INDEO2" />
        /// </summary>
        Indeo2 = 75,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_FRAPS" />
        /// </summary>
        Fraps = 76,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_TRUEMOTION2" />
        /// </summary>
        Truemotion2 = 77,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_BMP" />
        /// </summary>
        Bmp = 78,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_CSCD" />
        /// </summary>
        Cscd = 79,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_MMVIDEO" />
        /// </summary>
        Mmvideo = 80,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_ZMBV" />
        /// </summary>
        Zmbv = 81,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_AVS" />
        /// </summary>
        Avs = 82,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_SMACKVIDEO" />
        /// </summary>
        Smackvideo = 83,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_NUV" />
        /// </summary>
        Nuv = 84,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_KMVC" />
        /// </summary>
        Kmvc = 85,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_FLASHSV" />
        /// </summary>
        Flashsv = 86,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_CAVS" />
        /// </summary>
        Cavs = 87,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_JPEG2000" />
        /// </summary>
        Jpeg2000 = 88,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_VMNC" />
        /// </summary>
        Vmnc = 89,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_VP5" />
        /// </summary>
        Vp5 = 90,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_VP6" />
        /// </summary>
        Vp6 = 91,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_VP6F" />
        /// </summary>
        Vp6f = 92,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_TARGA" />
        /// </summary>
        Targa = 93,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_DSICINVIDEO" />
        /// </summary>
        Dsicinvideo = 94,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_TIERTEXSEQVIDEO" />
        /// </summary>
        Tiertexseqvideo = 95,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_TIFF" />
        /// </summary>
        Tiff = 96,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_GIF" />
        /// </summary>
        Gif = 97,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_DXA" />
        /// </summary>
        Dxa = 98,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_DNXHD" />
        /// </summary>
        Dnxhd = 99,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_THP" />
        /// </summary>
        Thp = 100,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_SGI" />
        /// </summary>
        Sgi = 101,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_C93" />
        /// </summary>
        C93 = 102,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_BETHSOFTVID" />
        /// </summary>
        Bethsoftvid = 103,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_PTX" />
        /// </summary>
        Ptx = 104,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_TXD" />
        /// </summary>
        Txd = 105,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_VP6A" />
        /// </summary>
        Vp6a = 106,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_AMV" />
        /// </summary>
        Amv = 107,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_VB" />
        /// </summary>
        Vb = 108,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_PCX" />
        /// </summary>
        Pcx = 109,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_SUNRAST" />
        /// </summary>
        Sunrast = 110,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_INDEO4" />
        /// </summary>
        Indeo4 = 111,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_INDEO5" />
        /// </summary>
        Indeo5 = 112,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_MIMIC" />
        /// </summary>
        Mimic = 113,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_RL2" />
        /// </summary>
        Rl2 = 114,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_ESCAPE124" />
        /// </summary>
        Escape124 = 115,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_DIRAC" />
        /// </summary>
        Dirac = 116,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_BFI" />
        /// </summary>
        Bfi = 117,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_CMV" />
        /// </summary>
        Cmv = 118,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_MOTIONPIXELS" />
        /// </summary>
        Motionpixels = 119,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_TGV" />
        /// </summary>
        Tgv = 120,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_TGQ" />
        /// </summary>
        Tgq = 121,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_TQI" />
        /// </summary>
        Tqi = 122,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_AURA" />
        /// </summary>
        Aura = 123,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_AURA2" />
        /// </summary>
        Aura2 = 124,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_V210X" />
        /// </summary>
        V210x = 125,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_TMV" />
        /// </summary>
        Tmv = 126,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_V210" />
        /// </summary>
        V210 = 127,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_DPX" />
        /// </summary>
        Dpx = 128,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_MAD" />
        /// </summary>
        Mad = 129,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_FRWU" />
        /// </summary>
        Frwu = 130,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_FLASHSV2" />
        /// </summary>
        Flashsv2 = 131,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_CDGRAPHICS" />
        /// </summary>
        Cdgraphics = 132,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_R210" />
        /// </summary>
        R210 = 133,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_ANM" />
        /// </summary>
        Anm = 134,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_BINKVIDEO" />
        /// </summary>
        Binkvideo = 135,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_IFF_ILBM" />
        /// </summary>
        IffIlbm = 136,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_KGV1" />
        /// </summary>
        Kgv1 = 137,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_YOP" />
        /// </summary>
        Yop = 138,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_VP8" />
        /// </summary>
        Vp8 = 139,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_PICTOR" />
        /// </summary>
        Pictor = 140,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_ANSI" />
        /// </summary>
        Ansi = 141,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_A64_MULTI" />
        /// </summary>
        A64Multi = 142,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_A64_MULTI5" />
        /// </summary>
        A64Multi5 = 143,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_R10K" />
        /// </summary>
        R10k = 144,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_MXPEG" />
        /// </summary>
        Mxpeg = 145,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_LAGARITH" />
        /// </summary>
        Lagarith = 146,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_PRORES" />
        /// </summary>
        Prores = 147,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_JV" />
        /// </summary>
        Jv = 148,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_DFA" />
        /// </summary>
        Dfa = 149,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_WMV3IMAGE" />
        /// </summary>
        Wmv3image = 150,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_VC1IMAGE" />
        /// </summary>
        Vc1image = 151,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_UTVIDEO" />
        /// </summary>
        Utvideo = 152,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_BMV_VIDEO" />
        /// </summary>
        BmvVideo = 153,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_VBLE" />
        /// </summary>
        Vble = 154,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_DXTORY" />
        /// </summary>
        Dxtory = 155,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_V410" />
        /// </summary>
        V410 = 156,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_XWD" />
        /// </summary>
        Xwd = 157,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_CDXL" />
        /// </summary>
        Cdxl = 158,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_XBM" />
        /// </summary>
        Xbm = 159,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_ZEROCODEC" />
        /// </summary>
        Zerocodec = 160,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_MSS1" />
        /// </summary>
        Mss1 = 161,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_MSA1" />
        /// </summary>
        Msa1 = 162,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_TSCC2" />
        /// </summary>
        Tscc2 = 163,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_MTS2" />
        /// </summary>
        Mts2 = 164,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_CLLC" />
        /// </summary>
        Cllc = 165,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_MSS2" />
        /// </summary>
        Mss2 = 166,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_VP9" />
        /// </summary>
        Vp9 = 167,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_AIC" />
        /// </summary>
        Aic = 168,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_ESCAPE130" />
        /// </summary>
        Escape130 = 169,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_G2M" />
        /// </summary>
        G2m = 170,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_WEBP" />
        /// </summary>
        Webp = 171,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_HNM4_VIDEO" />
        /// </summary>
        Hnm4Video = 172,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_HEVC" />
        /// </summary>
        Hevc = 173,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_FIC" />
        /// </summary>
        Fic = 174,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_ALIAS_PIX" />
        /// </summary>
        AliasPix = 175,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_BRENDER_PIX" />
        /// </summary>
        BrenderPix = 176,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_PAF_VIDEO" />
        /// </summary>
        PafVideo = 177,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_EXR" />
        /// </summary>
        Exr = 178,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_VP7" />
        /// </summary>
        Vp7 = 179,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_SANM" />
        /// </summary>
        Sanm = 180,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_SGIRLE" />
        /// </summary>
        Sgirle = 181,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_MVC1" />
        /// </summary>
        Mvc1 = 182,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_MVC2" />
        /// </summary>
        Mvc2 = 183,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_HQX" />
        /// </summary>
        Hqx = 184,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_TDSC" />
        /// </summary>
        Tdsc = 185,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_HQ_HQA" />
        /// </summary>
        HqHqa = 186,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_HAP" />
        /// </summary>
        Hap = 187,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_DDS" />
        /// </summary>
        Dds = 188,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_DXV" />
        /// </summary>
        Dxv = 189,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_SCREENPRESSO" />
        /// </summary>
        Screenpresso = 190,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_RSCC" />
        /// </summary>
        Rscc = 191,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_AVS2" />
        /// </summary>
        Avs2 = 192,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_PGX" />
        /// </summary>
        Pgx = 193,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_AVS3" />
        /// </summary>
        Avs3 = 194,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_MSP2" />
        /// </summary>
        Msp2 = 195,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_VVC" />
        /// </summary>
        Vvc = 196,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_Y41P" />
        /// </summary>
        Y41p = 197,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_AVRP" />
        /// </summary>
        Avrp = 198,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_012V" />
        /// </summary>
        _012v = 199,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_AVUI" />
        /// </summary>
        Avui = 200,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_AYUV" />
        /// </summary>
        Ayuv = 201,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_TARGA_Y216" />
        /// </summary>
        TargaY216 = 202,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_V308" />
        /// </summary>
        V308 = 203,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_V408" />
        /// </summary>
        V408 = 204,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_YUV4" />
        /// </summary>
        Yuv4 = 205,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_AVRN" />
        /// </summary>
        Avrn = 206,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_CPIA" />
        /// </summary>
        Cpia = 207,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_XFACE" />
        /// </summary>
        Xface = 208,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_SNOW" />
        /// </summary>
        Snow = 209,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_SMVJPEG" />
        /// </summary>
        Smvjpeg = 210,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_APNG" />
        /// </summary>
        Apng = 211,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_DAALA" />
        /// </summary>
        Daala = 212,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_CFHD" />
        /// </summary>
        Cfhd = 213,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_TRUEMOTION2RT" />
        /// </summary>
        Truemotion2rt = 214,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_M101" />
        /// </summary>
        M101 = 215,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_MAGICYUV" />
        /// </summary>
        Magicyuv = 216,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_SHEERVIDEO" />
        /// </summary>
        Sheervideo = 217,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_YLC" />
        /// </summary>
        Ylc = 218,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_PSD" />
        /// </summary>
        Psd = 219,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_PIXLET" />
        /// </summary>
        Pixlet = 220,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_SPEEDHQ" />
        /// </summary>
        Speedhq = 221,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_FMVC" />
        /// </summary>
        Fmvc = 222,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_SCPR" />
        /// </summary>
        Scpr = 223,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_CLEARVIDEO" />
        /// </summary>
        Clearvideo = 224,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_XPM" />
        /// </summary>
        Xpm = 225,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_AV1" />
        /// </summary>
        Av1 = 226,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_BITPACKED" />
        /// </summary>
        Bitpacked = 227,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_MSCC" />
        /// </summary>
        Mscc = 228,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_SRGC" />
        /// </summary>
        Srgc = 229,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_SVG" />
        /// </summary>
        Svg = 230,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_GDV" />
        /// </summary>
        Gdv = 231,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_FITS" />
        /// </summary>
        Fits = 232,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_IMM4" />
        /// </summary>
        Imm4 = 233,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_PROSUMER" />
        /// </summary>
        Prosumer = 234,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_MWSC" />
        /// </summary>
        Mwsc = 235,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_WCMV" />
        /// </summary>
        Wcmv = 236,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_RASC" />
        /// </summary>
        Rasc = 237,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_HYMT" />
        /// </summary>
        Hymt = 238,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_ARBC" />
        /// </summary>
        Arbc = 239,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_AGM" />
        /// </summary>
        Agm = 240,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_LSCR" />
        /// </summary>
        Lscr = 241,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_VP4" />
        /// </summary>
        Vp4 = 242,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_IMM5" />
        /// </summary>
        Imm5 = 243,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_MVDV" />
        /// </summary>
        Mvdv = 244,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_MVHA" />
        /// </summary>
        Mvha = 245,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_CDTOONS" />
        /// </summary>
        Cdtoons = 246,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_MV30" />
        /// </summary>
        Mv30 = 247,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_NOTCHLC" />
        /// </summary>
        Notchlc = 248,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_PFM" />
        /// </summary>
        Pfm = 249,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_MOBICLIP" />
        /// </summary>
        Mobiclip = 250,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_PHOTOCD" />
        /// </summary>
        Photocd = 251,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_IPU" />
        /// </summary>
        Ipu = 252,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_ARGO" />
        /// </summary>
        Argo = 253,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_CRI" />
        /// </summary>
        Cri = 254,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_SIMBIOSIS_IMX" />
        /// </summary>
        SimbiosisImx = 255,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_SGA_VIDEO" />
        /// </summary>
        SgaVideo = 256,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_GEM" />
        /// </summary>
        Gem = 257,
        
        /// <summary>
        /// <para>A dummy id pointing at the start of audio codecs.</para>
        /// <see cref="AVCodecID.AV_CODEC_ID_FIRST_AUDIO" />
        /// </summary>
        FirstAudio = 65536,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_PCM_S16LE" />
        /// </summary>
        PcmS16le = 65536,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_PCM_S16BE" />
        /// </summary>
        PcmS16be = 65537,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_PCM_U16LE" />
        /// </summary>
        PcmU16le = 65538,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_PCM_U16BE" />
        /// </summary>
        PcmU16be = 65539,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_PCM_S8" />
        /// </summary>
        PcmS8 = 65540,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_PCM_U8" />
        /// </summary>
        PcmU8 = 65541,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_PCM_MULAW" />
        /// </summary>
        PcmMulaw = 65542,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_PCM_ALAW" />
        /// </summary>
        PcmAlaw = 65543,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_PCM_S32LE" />
        /// </summary>
        PcmS32le = 65544,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_PCM_S32BE" />
        /// </summary>
        PcmS32be = 65545,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_PCM_U32LE" />
        /// </summary>
        PcmU32le = 65546,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_PCM_U32BE" />
        /// </summary>
        PcmU32be = 65547,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_PCM_S24LE" />
        /// </summary>
        PcmS24le = 65548,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_PCM_S24BE" />
        /// </summary>
        PcmS24be = 65549,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_PCM_U24LE" />
        /// </summary>
        PcmU24le = 65550,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_PCM_U24BE" />
        /// </summary>
        PcmU24be = 65551,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_PCM_S24DAUD" />
        /// </summary>
        PcmS24daud = 65552,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_PCM_ZORK" />
        /// </summary>
        PcmZork = 65553,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_PCM_S16LE_PLANAR" />
        /// </summary>
        PcmS16lePlanar = 65554,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_PCM_DVD" />
        /// </summary>
        PcmDvd = 65555,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_PCM_F32BE" />
        /// </summary>
        PcmF32be = 65556,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_PCM_F32LE" />
        /// </summary>
        PcmF32le = 65557,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_PCM_F64BE" />
        /// </summary>
        PcmF64be = 65558,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_PCM_F64LE" />
        /// </summary>
        PcmF64le = 65559,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_PCM_BLURAY" />
        /// </summary>
        PcmBluray = 65560,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_PCM_LXF" />
        /// </summary>
        PcmLxf = 65561,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_S302M" />
        /// </summary>
        S302m = 65562,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_PCM_S8_PLANAR" />
        /// </summary>
        PcmS8Planar = 65563,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_PCM_S24LE_PLANAR" />
        /// </summary>
        PcmS24lePlanar = 65564,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_PCM_S32LE_PLANAR" />
        /// </summary>
        PcmS32lePlanar = 65565,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_PCM_S16BE_PLANAR" />
        /// </summary>
        PcmS16bePlanar = 65566,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_PCM_S64LE" />
        /// </summary>
        PcmS64le = 65567,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_PCM_S64BE" />
        /// </summary>
        PcmS64be = 65568,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_PCM_F16LE" />
        /// </summary>
        PcmF16le = 65569,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_PCM_F24LE" />
        /// </summary>
        PcmF24le = 65570,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_PCM_VIDC" />
        /// </summary>
        PcmVidc = 65571,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_PCM_SGA" />
        /// </summary>
        PcmSga = 65572,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_ADPCM_IMA_QT" />
        /// </summary>
        AdpcmImaQt = 69632,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_ADPCM_IMA_WAV" />
        /// </summary>
        AdpcmImaWav = 69633,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_ADPCM_IMA_DK3" />
        /// </summary>
        AdpcmImaDk3 = 69634,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_ADPCM_IMA_DK4" />
        /// </summary>
        AdpcmImaDk4 = 69635,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_ADPCM_IMA_WS" />
        /// </summary>
        AdpcmImaWs = 69636,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_ADPCM_IMA_SMJPEG" />
        /// </summary>
        AdpcmImaSmjpeg = 69637,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_ADPCM_MS" />
        /// </summary>
        AdpcmMs = 69638,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_ADPCM_4XM" />
        /// </summary>
        Adpcm4xm = 69639,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_ADPCM_XA" />
        /// </summary>
        AdpcmXa = 69640,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_ADPCM_ADX" />
        /// </summary>
        AdpcmAdx = 69641,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_ADPCM_EA" />
        /// </summary>
        AdpcmEa = 69642,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_ADPCM_G726" />
        /// </summary>
        AdpcmG726 = 69643,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_ADPCM_CT" />
        /// </summary>
        AdpcmCt = 69644,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_ADPCM_SWF" />
        /// </summary>
        AdpcmSwf = 69645,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_ADPCM_YAMAHA" />
        /// </summary>
        AdpcmYamaha = 69646,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_ADPCM_SBPRO_4" />
        /// </summary>
        AdpcmSbpro4 = 69647,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_ADPCM_SBPRO_3" />
        /// </summary>
        AdpcmSbpro3 = 69648,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_ADPCM_SBPRO_2" />
        /// </summary>
        AdpcmSbpro2 = 69649,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_ADPCM_THP" />
        /// </summary>
        AdpcmThp = 69650,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_ADPCM_IMA_AMV" />
        /// </summary>
        AdpcmImaAmv = 69651,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_ADPCM_EA_R1" />
        /// </summary>
        AdpcmEaR1 = 69652,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_ADPCM_EA_R3" />
        /// </summary>
        AdpcmEaR3 = 69653,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_ADPCM_EA_R2" />
        /// </summary>
        AdpcmEaR2 = 69654,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_ADPCM_IMA_EA_SEAD" />
        /// </summary>
        AdpcmImaEaSead = 69655,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_ADPCM_IMA_EA_EACS" />
        /// </summary>
        AdpcmImaEaEacs = 69656,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_ADPCM_EA_XAS" />
        /// </summary>
        AdpcmEaXas = 69657,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_ADPCM_EA_MAXIS_XA" />
        /// </summary>
        AdpcmEaMaxisXa = 69658,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_ADPCM_IMA_ISS" />
        /// </summary>
        AdpcmImaIss = 69659,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_ADPCM_G722" />
        /// </summary>
        AdpcmG722 = 69660,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_ADPCM_IMA_APC" />
        /// </summary>
        AdpcmImaApc = 69661,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_ADPCM_VIMA" />
        /// </summary>
        AdpcmVima = 69662,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_ADPCM_AFC" />
        /// </summary>
        AdpcmAfc = 69663,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_ADPCM_IMA_OKI" />
        /// </summary>
        AdpcmImaOki = 69664,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_ADPCM_DTK" />
        /// </summary>
        AdpcmDtk = 69665,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_ADPCM_IMA_RAD" />
        /// </summary>
        AdpcmImaRad = 69666,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_ADPCM_G726LE" />
        /// </summary>
        AdpcmG726le = 69667,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_ADPCM_THP_LE" />
        /// </summary>
        AdpcmThpLe = 69668,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_ADPCM_PSX" />
        /// </summary>
        AdpcmPsx = 69669,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_ADPCM_AICA" />
        /// </summary>
        AdpcmAica = 69670,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_ADPCM_IMA_DAT4" />
        /// </summary>
        AdpcmImaDat4 = 69671,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_ADPCM_MTAF" />
        /// </summary>
        AdpcmMtaf = 69672,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_ADPCM_AGM" />
        /// </summary>
        AdpcmAgm = 69673,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_ADPCM_ARGO" />
        /// </summary>
        AdpcmArgo = 69674,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_ADPCM_IMA_SSI" />
        /// </summary>
        AdpcmImaSsi = 69675,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_ADPCM_ZORK" />
        /// </summary>
        AdpcmZork = 69676,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_ADPCM_IMA_APM" />
        /// </summary>
        AdpcmImaApm = 69677,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_ADPCM_IMA_ALP" />
        /// </summary>
        AdpcmImaAlp = 69678,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_ADPCM_IMA_MTF" />
        /// </summary>
        AdpcmImaMtf = 69679,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_ADPCM_IMA_CUNNING" />
        /// </summary>
        AdpcmImaCunning = 69680,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_ADPCM_IMA_MOFLEX" />
        /// </summary>
        AdpcmImaMoflex = 69681,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_ADPCM_IMA_ACORN" />
        /// </summary>
        AdpcmImaAcorn = 69682,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_AMR_NB" />
        /// </summary>
        AmrNb = 73728,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_AMR_WB" />
        /// </summary>
        AmrWb = 73729,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_RA_144" />
        /// </summary>
        Ra144 = 77824,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_RA_288" />
        /// </summary>
        Ra288 = 77825,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_ROQ_DPCM" />
        /// </summary>
        RoqDpcm = 81920,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_INTERPLAY_DPCM" />
        /// </summary>
        InterplayDpcm = 81921,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_XAN_DPCM" />
        /// </summary>
        XanDpcm = 81922,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_SOL_DPCM" />
        /// </summary>
        SolDpcm = 81923,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_SDX2_DPCM" />
        /// </summary>
        Sdx2Dpcm = 81924,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_GREMLIN_DPCM" />
        /// </summary>
        GremlinDpcm = 81925,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_DERF_DPCM" />
        /// </summary>
        DerfDpcm = 81926,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_MP2" />
        /// </summary>
        Mp2 = 86016,
        
        /// <summary>
        /// <para>preferred ID for decoding MPEG audio layer 1, 2 or 3.</para>
        /// <see cref="AVCodecID.AV_CODEC_ID_MP3" />
        /// </summary>
        Mp3 = 86017,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_AAC" />
        /// </summary>
        Aac = 86018,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_AC3" />
        /// </summary>
        Ac3 = 86019,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_DTS" />
        /// </summary>
        Dts = 86020,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_VORBIS" />
        /// </summary>
        Vorbis = 86021,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_DVAUDIO" />
        /// </summary>
        Dvaudio = 86022,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_WMAV1" />
        /// </summary>
        Wmav1 = 86023,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_WMAV2" />
        /// </summary>
        Wmav2 = 86024,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_MACE3" />
        /// </summary>
        Mace3 = 86025,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_MACE6" />
        /// </summary>
        Mace6 = 86026,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_VMDAUDIO" />
        /// </summary>
        Vmdaudio = 86027,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_FLAC" />
        /// </summary>
        Flac = 86028,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_MP3ADU" />
        /// </summary>
        Mp3adu = 86029,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_MP3ON4" />
        /// </summary>
        Mp3on4 = 86030,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_SHORTEN" />
        /// </summary>
        Shorten = 86031,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_ALAC" />
        /// </summary>
        Alac = 86032,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_WESTWOOD_SND1" />
        /// </summary>
        WestwoodSnd1 = 86033,
        
        /// <summary>
        /// <para>as in Berlin toast format.</para>
        /// <see cref="AVCodecID.AV_CODEC_ID_GSM" />
        /// </summary>
        Gsm = 86034,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_QDM2" />
        /// </summary>
        Qdm2 = 86035,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_COOK" />
        /// </summary>
        Cook = 86036,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_TRUESPEECH" />
        /// </summary>
        Truespeech = 86037,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_TTA" />
        /// </summary>
        Tta = 86038,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_SMACKAUDIO" />
        /// </summary>
        Smackaudio = 86039,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_QCELP" />
        /// </summary>
        Qcelp = 86040,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_WAVPACK" />
        /// </summary>
        Wavpack = 86041,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_DSICINAUDIO" />
        /// </summary>
        Dsicinaudio = 86042,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_IMC" />
        /// </summary>
        Imc = 86043,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_MUSEPACK7" />
        /// </summary>
        Musepack7 = 86044,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_MLP" />
        /// </summary>
        Mlp = 86045,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_GSM_MS" />
        /// </summary>
        GsmMs = 86046,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_ATRAC3" />
        /// </summary>
        Atrac3 = 86047,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_APE" />
        /// </summary>
        Ape = 86048,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_NELLYMOSER" />
        /// </summary>
        Nellymoser = 86049,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_MUSEPACK8" />
        /// </summary>
        Musepack8 = 86050,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_SPEEX" />
        /// </summary>
        Speex = 86051,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_WMAVOICE" />
        /// </summary>
        Wmavoice = 86052,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_WMAPRO" />
        /// </summary>
        Wmapro = 86053,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_WMALOSSLESS" />
        /// </summary>
        Wmalossless = 86054,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_ATRAC3P" />
        /// </summary>
        Atrac3p = 86055,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_EAC3" />
        /// </summary>
        Eac3 = 86056,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_SIPR" />
        /// </summary>
        Sipr = 86057,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_MP1" />
        /// </summary>
        Mp1 = 86058,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_TWINVQ" />
        /// </summary>
        Twinvq = 86059,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_TRUEHD" />
        /// </summary>
        Truehd = 86060,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_MP4ALS" />
        /// </summary>
        Mp4als = 86061,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_ATRAC1" />
        /// </summary>
        Atrac1 = 86062,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_BINKAUDIO_RDFT" />
        /// </summary>
        BinkaudioRdft = 86063,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_BINKAUDIO_DCT" />
        /// </summary>
        BinkaudioDct = 86064,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_AAC_LATM" />
        /// </summary>
        AacLatm = 86065,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_QDMC" />
        /// </summary>
        Qdmc = 86066,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_CELT" />
        /// </summary>
        Celt = 86067,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_G723_1" />
        /// </summary>
        G7231 = 86068,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_G729" />
        /// </summary>
        G729 = 86069,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_8SVX_EXP" />
        /// </summary>
        _8svxExp = 86070,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_8SVX_FIB" />
        /// </summary>
        _8svxFib = 86071,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_BMV_AUDIO" />
        /// </summary>
        BmvAudio = 86072,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_RALF" />
        /// </summary>
        Ralf = 86073,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_IAC" />
        /// </summary>
        Iac = 86074,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_ILBC" />
        /// </summary>
        Ilbc = 86075,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_OPUS" />
        /// </summary>
        Opus = 86076,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_COMFORT_NOISE" />
        /// </summary>
        ComfortNoise = 86077,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_TAK" />
        /// </summary>
        Tak = 86078,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_METASOUND" />
        /// </summary>
        Metasound = 86079,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_PAF_AUDIO" />
        /// </summary>
        PafAudio = 86080,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_ON2AVC" />
        /// </summary>
        On2avc = 86081,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_DSS_SP" />
        /// </summary>
        DssSp = 86082,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_CODEC2" />
        /// </summary>
        Codec2 = 86083,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_FFWAVESYNTH" />
        /// </summary>
        Ffwavesynth = 86084,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_SONIC" />
        /// </summary>
        Sonic = 86085,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_SONIC_LS" />
        /// </summary>
        SonicLs = 86086,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_EVRC" />
        /// </summary>
        Evrc = 86087,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_SMV" />
        /// </summary>
        Smv = 86088,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_DSD_LSBF" />
        /// </summary>
        DsdLsbf = 86089,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_DSD_MSBF" />
        /// </summary>
        DsdMsbf = 86090,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_DSD_LSBF_PLANAR" />
        /// </summary>
        DsdLsbfPlanar = 86091,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_DSD_MSBF_PLANAR" />
        /// </summary>
        DsdMsbfPlanar = 86092,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_4GV" />
        /// </summary>
        _4gv = 86093,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_INTERPLAY_ACM" />
        /// </summary>
        InterplayAcm = 86094,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_XMA1" />
        /// </summary>
        Xma1 = 86095,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_XMA2" />
        /// </summary>
        Xma2 = 86096,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_DST" />
        /// </summary>
        Dst = 86097,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_ATRAC3AL" />
        /// </summary>
        Atrac3al = 86098,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_ATRAC3PAL" />
        /// </summary>
        Atrac3pal = 86099,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_DOLBY_E" />
        /// </summary>
        DolbyE = 86100,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_APTX" />
        /// </summary>
        Aptx = 86101,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_APTX_HD" />
        /// </summary>
        AptxHd = 86102,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_SBC" />
        /// </summary>
        Sbc = 86103,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_ATRAC9" />
        /// </summary>
        Atrac9 = 86104,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_HCOM" />
        /// </summary>
        Hcom = 86105,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_ACELP_KELVIN" />
        /// </summary>
        AcelpKelvin = 86106,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_MPEGH_3D_AUDIO" />
        /// </summary>
        Mpegh3dAudio = 86107,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_SIREN" />
        /// </summary>
        Siren = 86108,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_HCA" />
        /// </summary>
        Hca = 86109,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_FASTAUDIO" />
        /// </summary>
        Fastaudio = 86110,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_MSNSIREN" />
        /// </summary>
        Msnsiren = 86111,
        
        /// <summary>
        /// <para>A dummy ID pointing at the start of subtitle codecs.</para>
        /// <see cref="AVCodecID.AV_CODEC_ID_FIRST_SUBTITLE" />
        /// </summary>
        FirstSubtitle = 94208,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_DVD_SUBTITLE" />
        /// </summary>
        DvdSubtitle = 94208,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_DVB_SUBTITLE" />
        /// </summary>
        DvbSubtitle = 94209,
        
        /// <summary>
        /// <para>raw UTF-8 text.</para>
        /// <see cref="AVCodecID.AV_CODEC_ID_TEXT" />
        /// </summary>
        Text = 94210,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_XSUB" />
        /// </summary>
        Xsub = 94211,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_SSA" />
        /// </summary>
        Ssa = 94212,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_MOV_TEXT" />
        /// </summary>
        MovText = 94213,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_HDMV_PGS_SUBTITLE" />
        /// </summary>
        HdmvPgsSubtitle = 94214,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_DVB_TELETEXT" />
        /// </summary>
        DvbTeletext = 94215,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_SRT" />
        /// </summary>
        Srt = 94216,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_MICRODVD" />
        /// </summary>
        Microdvd = 94217,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_EIA_608" />
        /// </summary>
        Eia608 = 94218,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_JACOSUB" />
        /// </summary>
        Jacosub = 94219,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_SAMI" />
        /// </summary>
        Sami = 94220,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_REALTEXT" />
        /// </summary>
        Realtext = 94221,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_STL" />
        /// </summary>
        Stl = 94222,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_SUBVIEWER1" />
        /// </summary>
        Subviewer1 = 94223,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_SUBVIEWER" />
        /// </summary>
        Subviewer = 94224,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_SUBRIP" />
        /// </summary>
        Subrip = 94225,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_WEBVTT" />
        /// </summary>
        Webvtt = 94226,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_MPL2" />
        /// </summary>
        Mpl2 = 94227,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_VPLAYER" />
        /// </summary>
        Vplayer = 94228,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_PJS" />
        /// </summary>
        Pjs = 94229,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_ASS" />
        /// </summary>
        Ass = 94230,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_HDMV_TEXT_SUBTITLE" />
        /// </summary>
        HdmvTextSubtitle = 94231,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_TTML" />
        /// </summary>
        Ttml = 94232,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_ARIB_CAPTION" />
        /// </summary>
        AribCaption = 94233,
        
        /// <summary>
        /// <para>A dummy ID pointing at the start of various fake codecs.</para>
        /// <see cref="AVCodecID.AV_CODEC_ID_FIRST_UNKNOWN" />
        /// </summary>
        FirstUnknown = 98304,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_TTF" />
        /// </summary>
        Ttf = 98304,
        
        /// <summary>
        /// <para>Contain timestamp estimated through PCR of program stream.</para>
        /// <see cref="AVCodecID.AV_CODEC_ID_SCTE_35" />
        /// </summary>
        Scte35 = 98305,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_EPG" />
        /// </summary>
        Epg = 98306,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_BINTEXT" />
        /// </summary>
        Bintext = 98307,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_XBIN" />
        /// </summary>
        Xbin = 98308,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_IDF" />
        /// </summary>
        Idf = 98309,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_OTF" />
        /// </summary>
        Otf = 98310,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_SMPTE_KLV" />
        /// </summary>
        SmpteKlv = 98311,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_DVD_NAV" />
        /// </summary>
        DvdNav = 98312,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_TIMED_ID3" />
        /// </summary>
        TimedId3 = 98313,
        
        /// <summary>
        /// <see cref="AVCodecID.AV_CODEC_ID_BIN_DATA" />
        /// </summary>
        BinData = 98314,
        
        /// <summary>
        /// <para>codec_id is not known (like AV_CODEC_ID_NONE) but lavf should attempt to identify it.</para>
        /// <see cref="AVCodecID.AV_CODEC_ID_PROBE" />
        /// </summary>
        Probe = 102400,
        
        /// <summary>
        /// <para>_FAKE_ codec to indicate a raw MPEG-2 TS stream (only used by libavformat).</para>
        /// <see cref="AVCodecID.AV_CODEC_ID_MPEG2TS" />
        /// </summary>
        Mpeg2ts = 131072,
        
        /// <summary>
        /// <para>_FAKE_ codec to indicate a MPEG-4 Systems stream (only used by libavformat).</para>
        /// <see cref="AVCodecID.AV_CODEC_ID_MPEG4SYSTEMS" />
        /// </summary>
        Mpeg4systems = 131073,
        
        /// <summary>
        /// <para>Dummy codec for streams containing only metadata information.</para>
        /// <see cref="AVCodecID.AV_CODEC_ID_FFMETADATA" />
        /// </summary>
        Ffmetadata = 135168,
        
        /// <summary>
        /// <para>Passthrough codec, AVFrames wrapped in AVPacket.</para>
        /// <see cref="AVCodecID.AV_CODEC_ID_WRAPPED_AVFRAME" />
        /// </summary>
        WrappedAvframe = 135169,
    }
}
