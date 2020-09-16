// This file was genereated from LINQPad scripts, DO NOT CHANGE DIRECTLY.

using System;
using Sdcb.FFmpegAPIWrapper.Common;
using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;

namespace Sdcb.FFmpegAPIWrapper.MediaCodecs
{
    /// <summary>
    /// <para>Pixel format.</para>
    /// <see cref="AVPixelFormat" />
    /// </summary>
    public enum PixelFormat
    {
        /// <summary>
        /// <para>planar YUV 4:2:0, 12bpp, (1 Cr &amp; Cb sample per 2x2 Y samples).</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUV420P" />
        /// </summary>
        Yuv420p = 0,
        
        /// <summary>
        /// <para>packed YUV 4:2:2, 16bpp, Y0 Cb Y1 Cr.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUYV422" />
        /// </summary>
        Yuyv422 = 1,
        
        /// <summary>
        /// <para>packed RGB 8:8:8, 24bpp, RGBRGB.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_RGB24" />
        /// </summary>
        Rgb24 = 2,
        
        /// <summary>
        /// <para>packed RGB 8:8:8, 24bpp, BGRBGR.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_BGR24" />
        /// </summary>
        Bgr24 = 3,
        
        /// <summary>
        /// <para>planar YUV 4:2:2, 16bpp, (1 Cr &amp; Cb sample per 2x1 Y samples).</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUV422P" />
        /// </summary>
        Yuv422p = 4,
        
        /// <summary>
        /// <para>planar YUV 4:4:4, 24bpp, (1 Cr &amp; Cb sample per 1x1 Y samples).</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUV444P" />
        /// </summary>
        Yuv444p = 5,
        
        /// <summary>
        /// <para>planar YUV 4:1:0, 9bpp, (1 Cr &amp; Cb sample per 4x4 Y samples).</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUV410P" />
        /// </summary>
        Yuv410p = 6,
        
        /// <summary>
        /// <para>planar YUV 4:1:1, 12bpp, (1 Cr &amp; Cb sample per 4x1 Y samples).</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUV411P" />
        /// </summary>
        Yuv411p = 7,
        
        /// <summary>
        /// <para>Y , 8bpp.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_GRAY8" />
        /// </summary>
        Gray8 = 8,
        
        /// <summary>
        /// <para>Y , 1bpp, 0 is white, 1 is black, in each byte pixels are ordered from the msb to the lsb.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_MONOWHITE" />
        /// </summary>
        Monowhite = 9,
        
        /// <summary>
        /// <para>Y , 1bpp, 0 is black, 1 is white, in each byte pixels are ordered from the msb to the lsb.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_MONOBLACK" />
        /// </summary>
        Monoblack = 10,
        
        /// <summary>
        /// <para>8 bits with AV_PIX_FMT_RGB32 palette.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_PAL8" />
        /// </summary>
        Pal8 = 11,
        
        /// <summary>
        /// <para>planar YUV 4:2:0, 12bpp, full scale (JPEG), deprecated in favor of AV_PIX_FMT_YUV420P and setting color_range.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUVJ420P" />
        /// </summary>
        Yuvj420p = 12,
        
        /// <summary>
        /// <para>planar YUV 4:2:2, 16bpp, full scale (JPEG), deprecated in favor of AV_PIX_FMT_YUV422P and setting color_range.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUVJ422P" />
        /// </summary>
        Yuvj422p = 13,
        
        /// <summary>
        /// <para>planar YUV 4:4:4, 24bpp, full scale (JPEG), deprecated in favor of AV_PIX_FMT_YUV444P and setting color_range.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUVJ444P" />
        /// </summary>
        Yuvj444p = 14,
        
        /// <summary>
        /// <para>packed YUV 4:2:2, 16bpp, Cb Y0 Cr Y1.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_UYVY422" />
        /// </summary>
        Uyvy422 = 15,
        
        /// <summary>
        /// <para>packed YUV 4:1:1, 12bpp, Cb Y0 Y1 Cr Y2 Y3.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_UYYVYY411" />
        /// </summary>
        Uyyvyy411 = 16,
        
        /// <summary>
        /// <para>packed RGB 3:3:2, 8bpp, (msb)2B 3G 3R(lsb).</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_BGR8" />
        /// </summary>
        Bgr8 = 17,
        
        /// <summary>
        /// <para>packed RGB 1:2:1 bitstream, 4bpp, (msb)1B 2G 1R(lsb), a byte contains two pixels, the first pixel in the byte is the one composed by the 4 msb bits.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_BGR4" />
        /// </summary>
        Bgr4 = 18,
        
        /// <summary>
        /// <para>packed RGB 1:2:1, 8bpp, (msb)1B 2G 1R(lsb).</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_BGR4_BYTE" />
        /// </summary>
        Bgr4Byte = 19,
        
        /// <summary>
        /// <para>packed RGB 3:3:2, 8bpp, (msb)2R 3G 3B(lsb).</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_RGB8" />
        /// </summary>
        Rgb8 = 20,
        
        /// <summary>
        /// <para>packed RGB 1:2:1 bitstream, 4bpp, (msb)1R 2G 1B(lsb), a byte contains two pixels, the first pixel in the byte is the one composed by the 4 msb bits.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_RGB4" />
        /// </summary>
        Rgb4 = 21,
        
        /// <summary>
        /// <para>packed RGB 1:2:1, 8bpp, (msb)1R 2G 1B(lsb).</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_RGB4_BYTE" />
        /// </summary>
        Rgb4Byte = 22,
        
        /// <summary>
        /// <para>planar YUV 4:2:0, 12bpp, 1 plane for Y and 1 plane for the UV components, which are interleaved (first byte U and the following byte V).</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_NV12" />
        /// </summary>
        Nv12 = 23,
        
        /// <summary>
        /// <para>as above, but U and V bytes are swapped.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_NV21" />
        /// </summary>
        Nv21 = 24,
        
        /// <summary>
        /// <para>packed ARGB 8:8:8:8, 32bpp, ARGBARGB.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_ARGB" />
        /// </summary>
        Argb = 25,
        
        /// <summary>
        /// <para>packed RGBA 8:8:8:8, 32bpp, RGBARGBA.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_RGBA" />
        /// </summary>
        Rgba = 26,
        
        /// <summary>
        /// <para>packed ABGR 8:8:8:8, 32bpp, ABGRABGR.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_ABGR" />
        /// </summary>
        Abgr = 27,
        
        /// <summary>
        /// <para>packed BGRA 8:8:8:8, 32bpp, BGRABGRA.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_BGRA" />
        /// </summary>
        Bgra = 28,
        
        /// <summary>
        /// <para>Y , 16bpp, big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_GRAY16BE" />
        /// </summary>
        Gray16be = 29,
        
        /// <summary>
        /// <para>Y , 16bpp, little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_GRAY16LE" />
        /// </summary>
        Gray16le = 30,
        
        /// <summary>
        /// <para>planar YUV 4:4:0 (1 Cr &amp; Cb sample per 1x2 Y samples).</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUV440P" />
        /// </summary>
        Yuv440p = 31,
        
        /// <summary>
        /// <para>planar YUV 4:4:0 full scale (JPEG), deprecated in favor of AV_PIX_FMT_YUV440P and setting color_range.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUVJ440P" />
        /// </summary>
        Yuvj440p = 32,
        
        /// <summary>
        /// <para>planar YUV 4:2:0, 20bpp, (1 Cr &amp; Cb sample per 2x2 Y &amp; A samples).</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUVA420P" />
        /// </summary>
        Yuva420p = 33,
        
        /// <summary>
        /// <para>packed RGB 16:16:16, 48bpp, 16R, 16G, 16B, the 2-byte value for each R/G/B component is stored as big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_RGB48BE" />
        /// </summary>
        Rgb48be = 34,
        
        /// <summary>
        /// <para>packed RGB 16:16:16, 48bpp, 16R, 16G, 16B, the 2-byte value for each R/G/B component is stored as little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_RGB48LE" />
        /// </summary>
        Rgb48le = 35,
        
        /// <summary>
        /// <para>packed RGB 5:6:5, 16bpp, (msb) 5R 6G 5B(lsb), big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_RGB565BE" />
        /// </summary>
        Rgb565be = 36,
        
        /// <summary>
        /// <para>packed RGB 5:6:5, 16bpp, (msb) 5R 6G 5B(lsb), little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_RGB565LE" />
        /// </summary>
        Rgb565le = 37,
        
        /// <summary>
        /// <para>packed RGB 5:5:5, 16bpp, (msb)1X 5R 5G 5B(lsb), big-endian , X=unused/undefined.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_RGB555BE" />
        /// </summary>
        Rgb555be = 38,
        
        /// <summary>
        /// <para>packed RGB 5:5:5, 16bpp, (msb)1X 5R 5G 5B(lsb), little-endian, X=unused/undefined.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_RGB555LE" />
        /// </summary>
        Rgb555le = 39,
        
        /// <summary>
        /// <para>packed BGR 5:6:5, 16bpp, (msb) 5B 6G 5R(lsb), big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_BGR565BE" />
        /// </summary>
        Bgr565be = 40,
        
        /// <summary>
        /// <para>packed BGR 5:6:5, 16bpp, (msb) 5B 6G 5R(lsb), little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_BGR565LE" />
        /// </summary>
        Bgr565le = 41,
        
        /// <summary>
        /// <para>packed BGR 5:5:5, 16bpp, (msb)1X 5B 5G 5R(lsb), big-endian , X=unused/undefined.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_BGR555BE" />
        /// </summary>
        Bgr555be = 42,
        
        /// <summary>
        /// <para>packed BGR 5:5:5, 16bpp, (msb)1X 5B 5G 5R(lsb), little-endian, X=unused/undefined.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_BGR555LE" />
        /// </summary>
        Bgr555le = 43,
        
        /// <summary>
        /// <para>HW acceleration through VA API at motion compensation entry-point, Picture.</para>
        /// <para>data[3] contains a vaapi_render_state struct which contains macroblocks as well as various fields extracted from headers.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_VAAPI_MOCO" />
        /// </summary>
        VaapiMoco = 44,
        
        /// <summary>
        /// <para>HW acceleration through VA API at IDCT entry-point, Picture.</para>
        /// <para>data[3] contains a vaapi_render_state struct which contains fields extracted from headers.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_VAAPI_IDCT" />
        /// </summary>
        VaapiIdct = 45,
        
        /// <summary>
        /// <para>@}.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_VAAPI" />
        /// </summary>
        Vaapi = 46,
        
        /// <summary>
        /// <para>HW decoding through VA API, Picture.</para>
        /// <para>data[3] contains a VASurfaceID.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_VAAPI_VLD" />
        /// </summary>
        VaapiVld = 46,
        
        /// <summary>
        /// <para>planar YUV 4:2:0, 24bpp, (1 Cr &amp; Cb sample per 2x2 Y samples), little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUV420P16LE" />
        /// </summary>
        Yuv420p16le = 47,
        
        /// <summary>
        /// <para>planar YUV 4:2:0, 24bpp, (1 Cr &amp; Cb sample per 2x2 Y samples), big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUV420P16BE" />
        /// </summary>
        Yuv420p16be = 48,
        
        /// <summary>
        /// <para>planar YUV 4:2:2, 32bpp, (1 Cr &amp; Cb sample per 2x1 Y samples), little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUV422P16LE" />
        /// </summary>
        Yuv422p16le = 49,
        
        /// <summary>
        /// <para>planar YUV 4:2:2, 32bpp, (1 Cr &amp; Cb sample per 2x1 Y samples), big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUV422P16BE" />
        /// </summary>
        Yuv422p16be = 50,
        
        /// <summary>
        /// <para>planar YUV 4:4:4, 48bpp, (1 Cr &amp; Cb sample per 1x1 Y samples), little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUV444P16LE" />
        /// </summary>
        Yuv444p16le = 51,
        
        /// <summary>
        /// <para>planar YUV 4:4:4, 48bpp, (1 Cr &amp; Cb sample per 1x1 Y samples), big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUV444P16BE" />
        /// </summary>
        Yuv444p16be = 52,
        
        /// <summary>
        /// <para>HW decoding through DXVA2, Picture.</para>
        /// <para>data[3] contains a LPDIRECT3DSURFACE9 pointer.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_DXVA2_VLD" />
        /// </summary>
        Dxva2Vld = 53,
        
        /// <summary>
        /// <para>packed RGB 4:4:4, 16bpp, (msb)4X 4R 4G 4B(lsb), little-endian, X=unused/undefined.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_RGB444LE" />
        /// </summary>
        Rgb444le = 54,
        
        /// <summary>
        /// <para>packed RGB 4:4:4, 16bpp, (msb)4X 4R 4G 4B(lsb), big-endian, X=unused/undefined.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_RGB444BE" />
        /// </summary>
        Rgb444be = 55,
        
        /// <summary>
        /// <para>packed BGR 4:4:4, 16bpp, (msb)4X 4B 4G 4R(lsb), little-endian, X=unused/undefined.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_BGR444LE" />
        /// </summary>
        Bgr444le = 56,
        
        /// <summary>
        /// <para>packed BGR 4:4:4, 16bpp, (msb)4X 4B 4G 4R(lsb), big-endian, X=unused/undefined.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_BGR444BE" />
        /// </summary>
        Bgr444be = 57,
        
        /// <summary>
        /// <para>8 bits gray, 8 bits alpha.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YA8" />
        /// </summary>
        Ya8 = 58,
        
        /// <summary>
        /// <para>alias for AV_PIX_FMT_YA8.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_Y400A" />
        /// </summary>
        Y400a = 58,
        
        /// <summary>
        /// <para>alias for AV_PIX_FMT_YA8.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_GRAY8A" />
        /// </summary>
        Gray8a = 58,
        
        /// <summary>
        /// <para>packed RGB 16:16:16, 48bpp, 16B, 16G, 16R, the 2-byte value for each R/G/B component is stored as big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_BGR48BE" />
        /// </summary>
        Bgr48be = 59,
        
        /// <summary>
        /// <para>packed RGB 16:16:16, 48bpp, 16B, 16G, 16R, the 2-byte value for each R/G/B component is stored as little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_BGR48LE" />
        /// </summary>
        Bgr48le = 60,
        
        /// <summary>
        /// <para>planar YUV 4:2:0, 13.</para>
        /// <para>5bpp, (1 Cr &amp; Cb sample per 2x2 Y samples), big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUV420P9BE" />
        /// </summary>
        Yuv420p9be = 61,
        
        /// <summary>
        /// <para>planar YUV 4:2:0, 13.</para>
        /// <para>5bpp, (1 Cr &amp; Cb sample per 2x2 Y samples), little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUV420P9LE" />
        /// </summary>
        Yuv420p9le = 62,
        
        /// <summary>
        /// <para>planar YUV 4:2:0, 15bpp, (1 Cr &amp; Cb sample per 2x2 Y samples), big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUV420P10BE" />
        /// </summary>
        Yuv420p10be = 63,
        
        /// <summary>
        /// <para>planar YUV 4:2:0, 15bpp, (1 Cr &amp; Cb sample per 2x2 Y samples), little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUV420P10LE" />
        /// </summary>
        Yuv420p10le = 64,
        
        /// <summary>
        /// <para>planar YUV 4:2:2, 20bpp, (1 Cr &amp; Cb sample per 2x1 Y samples), big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUV422P10BE" />
        /// </summary>
        Yuv422p10be = 65,
        
        /// <summary>
        /// <para>planar YUV 4:2:2, 20bpp, (1 Cr &amp; Cb sample per 2x1 Y samples), little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUV422P10LE" />
        /// </summary>
        Yuv422p10le = 66,
        
        /// <summary>
        /// <para>planar YUV 4:4:4, 27bpp, (1 Cr &amp; Cb sample per 1x1 Y samples), big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUV444P9BE" />
        /// </summary>
        Yuv444p9be = 67,
        
        /// <summary>
        /// <para>planar YUV 4:4:4, 27bpp, (1 Cr &amp; Cb sample per 1x1 Y samples), little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUV444P9LE" />
        /// </summary>
        Yuv444p9le = 68,
        
        /// <summary>
        /// <para>planar YUV 4:4:4, 30bpp, (1 Cr &amp; Cb sample per 1x1 Y samples), big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUV444P10BE" />
        /// </summary>
        Yuv444p10be = 69,
        
        /// <summary>
        /// <para>planar YUV 4:4:4, 30bpp, (1 Cr &amp; Cb sample per 1x1 Y samples), little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUV444P10LE" />
        /// </summary>
        Yuv444p10le = 70,
        
        /// <summary>
        /// <para>planar YUV 4:2:2, 18bpp, (1 Cr &amp; Cb sample per 2x1 Y samples), big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUV422P9BE" />
        /// </summary>
        Yuv422p9be = 71,
        
        /// <summary>
        /// <para>planar YUV 4:2:2, 18bpp, (1 Cr &amp; Cb sample per 2x1 Y samples), little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUV422P9LE" />
        /// </summary>
        Yuv422p9le = 72,
        
        /// <summary>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_GBR24P" />
        /// </summary>
        Gbr24p = 73,
        
        /// <summary>
        /// <para>planar GBR 4:4:4 24bpp.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_GBRP" />
        /// </summary>
        Gbrp = 73,
        
        /// <summary>
        /// <para>planar GBR 4:4:4 27bpp, big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_GBRP9BE" />
        /// </summary>
        Gbrp9be = 74,
        
        /// <summary>
        /// <para>planar GBR 4:4:4 27bpp, little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_GBRP9LE" />
        /// </summary>
        Gbrp9le = 75,
        
        /// <summary>
        /// <para>planar GBR 4:4:4 30bpp, big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_GBRP10BE" />
        /// </summary>
        Gbrp10be = 76,
        
        /// <summary>
        /// <para>planar GBR 4:4:4 30bpp, little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_GBRP10LE" />
        /// </summary>
        Gbrp10le = 77,
        
        /// <summary>
        /// <para>planar GBR 4:4:4 48bpp, big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_GBRP16BE" />
        /// </summary>
        Gbrp16be = 78,
        
        /// <summary>
        /// <para>planar GBR 4:4:4 48bpp, little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_GBRP16LE" />
        /// </summary>
        Gbrp16le = 79,
        
        /// <summary>
        /// <para>planar YUV 4:2:2 24bpp, (1 Cr &amp; Cb sample per 2x1 Y &amp; A samples).</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUVA422P" />
        /// </summary>
        Yuva422p = 80,
        
        /// <summary>
        /// <para>planar YUV 4:4:4 32bpp, (1 Cr &amp; Cb sample per 1x1 Y &amp; A samples).</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUVA444P" />
        /// </summary>
        Yuva444p = 81,
        
        /// <summary>
        /// <para>planar YUV 4:2:0 22.</para>
        /// <para>5bpp, (1 Cr &amp; Cb sample per 2x2 Y &amp; A samples), big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUVA420P9BE" />
        /// </summary>
        Yuva420p9be = 82,
        
        /// <summary>
        /// <para>planar YUV 4:2:0 22.</para>
        /// <para>5bpp, (1 Cr &amp; Cb sample per 2x2 Y &amp; A samples), little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUVA420P9LE" />
        /// </summary>
        Yuva420p9le = 83,
        
        /// <summary>
        /// <para>planar YUV 4:2:2 27bpp, (1 Cr &amp; Cb sample per 2x1 Y &amp; A samples), big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUVA422P9BE" />
        /// </summary>
        Yuva422p9be = 84,
        
        /// <summary>
        /// <para>planar YUV 4:2:2 27bpp, (1 Cr &amp; Cb sample per 2x1 Y &amp; A samples), little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUVA422P9LE" />
        /// </summary>
        Yuva422p9le = 85,
        
        /// <summary>
        /// <para>planar YUV 4:4:4 36bpp, (1 Cr &amp; Cb sample per 1x1 Y &amp; A samples), big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUVA444P9BE" />
        /// </summary>
        Yuva444p9be = 86,
        
        /// <summary>
        /// <para>planar YUV 4:4:4 36bpp, (1 Cr &amp; Cb sample per 1x1 Y &amp; A samples), little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUVA444P9LE" />
        /// </summary>
        Yuva444p9le = 87,
        
        /// <summary>
        /// <para>planar YUV 4:2:0 25bpp, (1 Cr &amp; Cb sample per 2x2 Y &amp; A samples, big-endian).</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUVA420P10BE" />
        /// </summary>
        Yuva420p10be = 88,
        
        /// <summary>
        /// <para>planar YUV 4:2:0 25bpp, (1 Cr &amp; Cb sample per 2x2 Y &amp; A samples, little-endian).</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUVA420P10LE" />
        /// </summary>
        Yuva420p10le = 89,
        
        /// <summary>
        /// <para>planar YUV 4:2:2 30bpp, (1 Cr &amp; Cb sample per 2x1 Y &amp; A samples, big-endian).</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUVA422P10BE" />
        /// </summary>
        Yuva422p10be = 90,
        
        /// <summary>
        /// <para>planar YUV 4:2:2 30bpp, (1 Cr &amp; Cb sample per 2x1 Y &amp; A samples, little-endian).</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUVA422P10LE" />
        /// </summary>
        Yuva422p10le = 91,
        
        /// <summary>
        /// <para>planar YUV 4:4:4 40bpp, (1 Cr &amp; Cb sample per 1x1 Y &amp; A samples, big-endian).</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUVA444P10BE" />
        /// </summary>
        Yuva444p10be = 92,
        
        /// <summary>
        /// <para>planar YUV 4:4:4 40bpp, (1 Cr &amp; Cb sample per 1x1 Y &amp; A samples, little-endian).</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUVA444P10LE" />
        /// </summary>
        Yuva444p10le = 93,
        
        /// <summary>
        /// <para>planar YUV 4:2:0 40bpp, (1 Cr &amp; Cb sample per 2x2 Y &amp; A samples, big-endian).</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUVA420P16BE" />
        /// </summary>
        Yuva420p16be = 94,
        
        /// <summary>
        /// <para>planar YUV 4:2:0 40bpp, (1 Cr &amp; Cb sample per 2x2 Y &amp; A samples, little-endian).</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUVA420P16LE" />
        /// </summary>
        Yuva420p16le = 95,
        
        /// <summary>
        /// <para>planar YUV 4:2:2 48bpp, (1 Cr &amp; Cb sample per 2x1 Y &amp; A samples, big-endian).</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUVA422P16BE" />
        /// </summary>
        Yuva422p16be = 96,
        
        /// <summary>
        /// <para>planar YUV 4:2:2 48bpp, (1 Cr &amp; Cb sample per 2x1 Y &amp; A samples, little-endian).</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUVA422P16LE" />
        /// </summary>
        Yuva422p16le = 97,
        
        /// <summary>
        /// <para>planar YUV 4:4:4 64bpp, (1 Cr &amp; Cb sample per 1x1 Y &amp; A samples, big-endian).</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUVA444P16BE" />
        /// </summary>
        Yuva444p16be = 98,
        
        /// <summary>
        /// <para>planar YUV 4:4:4 64bpp, (1 Cr &amp; Cb sample per 1x1 Y &amp; A samples, little-endian).</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUVA444P16LE" />
        /// </summary>
        Yuva444p16le = 99,
        
        /// <summary>
        /// <para>HW acceleration through VDPAU, Picture.</para>
        /// <para>data[3] contains a VdpVideoSurface.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_VDPAU" />
        /// </summary>
        Vdpau = 100,
        
        /// <summary>
        /// <para>packed XYZ 4:4:4, 36 bpp, (msb) 12X, 12Y, 12Z (lsb), the 2-byte value for each X/Y/Z is stored as little-endian, the 4 lower bits are set to 0.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_XYZ12LE" />
        /// </summary>
        Xyz12le = 101,
        
        /// <summary>
        /// <para>packed XYZ 4:4:4, 36 bpp, (msb) 12X, 12Y, 12Z (lsb), the 2-byte value for each X/Y/Z is stored as big-endian, the 4 lower bits are set to 0.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_XYZ12BE" />
        /// </summary>
        Xyz12be = 102,
        
        /// <summary>
        /// <para>interleaved chroma YUV 4:2:2, 16bpp, (1 Cr &amp; Cb sample per 2x1 Y samples).</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_NV16" />
        /// </summary>
        Nv16 = 103,
        
        /// <summary>
        /// <para>interleaved chroma YUV 4:2:2, 20bpp, (1 Cr &amp; Cb sample per 2x1 Y samples), little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_NV20LE" />
        /// </summary>
        Nv20le = 104,
        
        /// <summary>
        /// <para>interleaved chroma YUV 4:2:2, 20bpp, (1 Cr &amp; Cb sample per 2x1 Y samples), big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_NV20BE" />
        /// </summary>
        Nv20be = 105,
        
        /// <summary>
        /// <para>packed RGBA 16:16:16:16, 64bpp, 16R, 16G, 16B, 16A, the 2-byte value for each R/G/B/A component is stored as big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_RGBA64BE" />
        /// </summary>
        Rgba64be = 106,
        
        /// <summary>
        /// <para>packed RGBA 16:16:16:16, 64bpp, 16R, 16G, 16B, 16A, the 2-byte value for each R/G/B/A component is stored as little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_RGBA64LE" />
        /// </summary>
        Rgba64le = 107,
        
        /// <summary>
        /// <para>packed RGBA 16:16:16:16, 64bpp, 16B, 16G, 16R, 16A, the 2-byte value for each R/G/B/A component is stored as big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_BGRA64BE" />
        /// </summary>
        Bgra64be = 108,
        
        /// <summary>
        /// <para>packed RGBA 16:16:16:16, 64bpp, 16B, 16G, 16R, 16A, the 2-byte value for each R/G/B/A component is stored as little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_BGRA64LE" />
        /// </summary>
        Bgra64le = 109,
        
        /// <summary>
        /// <para>packed YUV 4:2:2, 16bpp, Y0 Cr Y1 Cb.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YVYU422" />
        /// </summary>
        Yvyu422 = 110,
        
        /// <summary>
        /// <para>16 bits gray, 16 bits alpha (big-endian).</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YA16BE" />
        /// </summary>
        Ya16be = 111,
        
        /// <summary>
        /// <para>16 bits gray, 16 bits alpha (little-endian).</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YA16LE" />
        /// </summary>
        Ya16le = 112,
        
        /// <summary>
        /// <para>planar GBRA 4:4:4:4 32bpp.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_GBRAP" />
        /// </summary>
        Gbrap = 113,
        
        /// <summary>
        /// <para>planar GBRA 4:4:4:4 64bpp, big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_GBRAP16BE" />
        /// </summary>
        Gbrap16be = 114,
        
        /// <summary>
        /// <para>planar GBRA 4:4:4:4 64bpp, little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_GBRAP16LE" />
        /// </summary>
        Gbrap16le = 115,
        
        /// <summary>
        /// <para>HW acceleration through QSV, data[3] contains a pointer to the mfxFrameSurface1 structure.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_QSV" />
        /// </summary>
        Qsv = 116,
        
        /// <summary>
        /// <para>HW acceleration though MMAL, data[3] contains a pointer to the MMAL_BUFFER_HEADER_T structure.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_MMAL" />
        /// </summary>
        Mmal = 117,
        
        /// <summary>
        /// <para>HW decoding through Direct3D11 via old API, Picture.</para>
        /// <para>data[3] contains a ID3D11VideoDecoderOutputView pointer.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_D3D11VA_VLD" />
        /// </summary>
        D3d11vaVld = 118,
        
        /// <summary>
        /// <para>HW acceleration through CUDA.</para>
        /// <para> data[i] contain CUdeviceptr pointers exactly as for system memory frames.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_CUDA" />
        /// </summary>
        Cuda = 119,
        
        /// <summary>
        /// <para>packed RGB 8:8:8, 32bpp, XRGBXRGB.</para>
        /// <para> X=unused/undefined.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_0RGB" />
        /// </summary>
        _0rgb = 120,
        
        /// <summary>
        /// <para>packed RGB 8:8:8, 32bpp, RGBXRGBX.</para>
        /// <para> X=unused/undefined.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_RGB0" />
        /// </summary>
        Rgb0 = 121,
        
        /// <summary>
        /// <para>packed BGR 8:8:8, 32bpp, XBGRXBGR.</para>
        /// <para> X=unused/undefined.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_0BGR" />
        /// </summary>
        _0bgr = 122,
        
        /// <summary>
        /// <para>packed BGR 8:8:8, 32bpp, BGRXBGRX.</para>
        /// <para> X=unused/undefined.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_BGR0" />
        /// </summary>
        Bgr0 = 123,
        
        /// <summary>
        /// <para>planar YUV 4:2:0,18bpp, (1 Cr &amp; Cb sample per 2x2 Y samples), big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUV420P12BE" />
        /// </summary>
        Yuv420p12be = 124,
        
        /// <summary>
        /// <para>planar YUV 4:2:0,18bpp, (1 Cr &amp; Cb sample per 2x2 Y samples), little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUV420P12LE" />
        /// </summary>
        Yuv420p12le = 125,
        
        /// <summary>
        /// <para>planar YUV 4:2:0,21bpp, (1 Cr &amp; Cb sample per 2x2 Y samples), big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUV420P14BE" />
        /// </summary>
        Yuv420p14be = 126,
        
        /// <summary>
        /// <para>planar YUV 4:2:0,21bpp, (1 Cr &amp; Cb sample per 2x2 Y samples), little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUV420P14LE" />
        /// </summary>
        Yuv420p14le = 127,
        
        /// <summary>
        /// <para>planar YUV 4:2:2,24bpp, (1 Cr &amp; Cb sample per 2x1 Y samples), big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUV422P12BE" />
        /// </summary>
        Yuv422p12be = 128,
        
        /// <summary>
        /// <para>planar YUV 4:2:2,24bpp, (1 Cr &amp; Cb sample per 2x1 Y samples), little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUV422P12LE" />
        /// </summary>
        Yuv422p12le = 129,
        
        /// <summary>
        /// <para>planar YUV 4:2:2,28bpp, (1 Cr &amp; Cb sample per 2x1 Y samples), big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUV422P14BE" />
        /// </summary>
        Yuv422p14be = 130,
        
        /// <summary>
        /// <para>planar YUV 4:2:2,28bpp, (1 Cr &amp; Cb sample per 2x1 Y samples), little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUV422P14LE" />
        /// </summary>
        Yuv422p14le = 131,
        
        /// <summary>
        /// <para>planar YUV 4:4:4,36bpp, (1 Cr &amp; Cb sample per 1x1 Y samples), big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUV444P12BE" />
        /// </summary>
        Yuv444p12be = 132,
        
        /// <summary>
        /// <para>planar YUV 4:4:4,36bpp, (1 Cr &amp; Cb sample per 1x1 Y samples), little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUV444P12LE" />
        /// </summary>
        Yuv444p12le = 133,
        
        /// <summary>
        /// <para>planar YUV 4:4:4,42bpp, (1 Cr &amp; Cb sample per 1x1 Y samples), big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUV444P14BE" />
        /// </summary>
        Yuv444p14be = 134,
        
        /// <summary>
        /// <para>planar YUV 4:4:4,42bpp, (1 Cr &amp; Cb sample per 1x1 Y samples), little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUV444P14LE" />
        /// </summary>
        Yuv444p14le = 135,
        
        /// <summary>
        /// <para>planar GBR 4:4:4 36bpp, big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_GBRP12BE" />
        /// </summary>
        Gbrp12be = 136,
        
        /// <summary>
        /// <para>planar GBR 4:4:4 36bpp, little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_GBRP12LE" />
        /// </summary>
        Gbrp12le = 137,
        
        /// <summary>
        /// <para>planar GBR 4:4:4 42bpp, big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_GBRP14BE" />
        /// </summary>
        Gbrp14be = 138,
        
        /// <summary>
        /// <para>planar GBR 4:4:4 42bpp, little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_GBRP14LE" />
        /// </summary>
        Gbrp14le = 139,
        
        /// <summary>
        /// <para>planar YUV 4:1:1, 12bpp, (1 Cr &amp; Cb sample per 4x1 Y samples) full scale (JPEG), deprecated in favor of AV_PIX_FMT_YUV411P and setting color_range.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUVJ411P" />
        /// </summary>
        Yuvj411p = 140,
        
        /// <summary>
        /// <para>bayer, BGBG.</para>
        /// <para>(odd line), GRGR.</para>
        /// <para>(even line), 8-bit samples.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_BAYER_BGGR8" />
        /// </summary>
        BayerBggr8 = 141,
        
        /// <summary>
        /// <para>bayer, RGRG.</para>
        /// <para>(odd line), GBGB.</para>
        /// <para>(even line), 8-bit samples.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_BAYER_RGGB8" />
        /// </summary>
        BayerRggb8 = 142,
        
        /// <summary>
        /// <para>bayer, GBGB.</para>
        /// <para>(odd line), RGRG.</para>
        /// <para>(even line), 8-bit samples.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_BAYER_GBRG8" />
        /// </summary>
        BayerGbrg8 = 143,
        
        /// <summary>
        /// <para>bayer, GRGR.</para>
        /// <para>(odd line), BGBG.</para>
        /// <para>(even line), 8-bit samples.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_BAYER_GRBG8" />
        /// </summary>
        BayerGrbg8 = 144,
        
        /// <summary>
        /// <para>bayer, BGBG.</para>
        /// <para>(odd line), GRGR.</para>
        /// <para>(even line), 16-bit samples, little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_BAYER_BGGR16LE" />
        /// </summary>
        BayerBggr16le = 145,
        
        /// <summary>
        /// <para>bayer, BGBG.</para>
        /// <para>(odd line), GRGR.</para>
        /// <para>(even line), 16-bit samples, big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_BAYER_BGGR16BE" />
        /// </summary>
        BayerBggr16be = 146,
        
        /// <summary>
        /// <para>bayer, RGRG.</para>
        /// <para>(odd line), GBGB.</para>
        /// <para>(even line), 16-bit samples, little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_BAYER_RGGB16LE" />
        /// </summary>
        BayerRggb16le = 147,
        
        /// <summary>
        /// <para>bayer, RGRG.</para>
        /// <para>(odd line), GBGB.</para>
        /// <para>(even line), 16-bit samples, big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_BAYER_RGGB16BE" />
        /// </summary>
        BayerRggb16be = 148,
        
        /// <summary>
        /// <para>bayer, GBGB.</para>
        /// <para>(odd line), RGRG.</para>
        /// <para>(even line), 16-bit samples, little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_BAYER_GBRG16LE" />
        /// </summary>
        BayerGbrg16le = 149,
        
        /// <summary>
        /// <para>bayer, GBGB.</para>
        /// <para>(odd line), RGRG.</para>
        /// <para>(even line), 16-bit samples, big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_BAYER_GBRG16BE" />
        /// </summary>
        BayerGbrg16be = 150,
        
        /// <summary>
        /// <para>bayer, GRGR.</para>
        /// <para>(odd line), BGBG.</para>
        /// <para>(even line), 16-bit samples, little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_BAYER_GRBG16LE" />
        /// </summary>
        BayerGrbg16le = 151,
        
        /// <summary>
        /// <para>bayer, GRGR.</para>
        /// <para>(odd line), BGBG.</para>
        /// <para>(even line), 16-bit samples, big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_BAYER_GRBG16BE" />
        /// </summary>
        BayerGrbg16be = 152,
        
        /// <summary>
        /// <para>XVideo Motion Acceleration via common packet passing.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_XVMC" />
        /// </summary>
        Xvmc = 153,
        
        /// <summary>
        /// <para>planar YUV 4:4:0,20bpp, (1 Cr &amp; Cb sample per 1x2 Y samples), little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUV440P10LE" />
        /// </summary>
        Yuv440p10le = 154,
        
        /// <summary>
        /// <para>planar YUV 4:4:0,20bpp, (1 Cr &amp; Cb sample per 1x2 Y samples), big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUV440P10BE" />
        /// </summary>
        Yuv440p10be = 155,
        
        /// <summary>
        /// <para>planar YUV 4:4:0,24bpp, (1 Cr &amp; Cb sample per 1x2 Y samples), little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUV440P12LE" />
        /// </summary>
        Yuv440p12le = 156,
        
        /// <summary>
        /// <para>planar YUV 4:4:0,24bpp, (1 Cr &amp; Cb sample per 1x2 Y samples), big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUV440P12BE" />
        /// </summary>
        Yuv440p12be = 157,
        
        /// <summary>
        /// <para>packed AYUV 4:4:4,64bpp (1 Cr &amp; Cb sample per 1x1 Y &amp; A samples), little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_AYUV64LE" />
        /// </summary>
        Ayuv64le = 158,
        
        /// <summary>
        /// <para>packed AYUV 4:4:4,64bpp (1 Cr &amp; Cb sample per 1x1 Y &amp; A samples), big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_AYUV64BE" />
        /// </summary>
        Ayuv64be = 159,
        
        /// <summary>
        /// <para>hardware decoding through Videotoolbox.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_VIDEOTOOLBOX" />
        /// </summary>
        Videotoolbox = 160,
        
        /// <summary>
        /// <para>like NV12, with 10bpp per component, data in the high bits, zeros in the low bits, little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_P010LE" />
        /// </summary>
        P010le = 161,
        
        /// <summary>
        /// <para>like NV12, with 10bpp per component, data in the high bits, zeros in the low bits, big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_P010BE" />
        /// </summary>
        P010be = 162,
        
        /// <summary>
        /// <para>planar GBR 4:4:4:4 48bpp, big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_GBRAP12BE" />
        /// </summary>
        Gbrap12be = 163,
        
        /// <summary>
        /// <para>planar GBR 4:4:4:4 48bpp, little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_GBRAP12LE" />
        /// </summary>
        Gbrap12le = 164,
        
        /// <summary>
        /// <para>planar GBR 4:4:4:4 40bpp, big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_GBRAP10BE" />
        /// </summary>
        Gbrap10be = 165,
        
        /// <summary>
        /// <para>planar GBR 4:4:4:4 40bpp, little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_GBRAP10LE" />
        /// </summary>
        Gbrap10le = 166,
        
        /// <summary>
        /// <para>hardware decoding through MediaCodec.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_MEDIACODEC" />
        /// </summary>
        Mediacodec = 167,
        
        /// <summary>
        /// <para>Y , 12bpp, big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_GRAY12BE" />
        /// </summary>
        Gray12be = 168,
        
        /// <summary>
        /// <para>Y , 12bpp, little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_GRAY12LE" />
        /// </summary>
        Gray12le = 169,
        
        /// <summary>
        /// <para>Y , 10bpp, big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_GRAY10BE" />
        /// </summary>
        Gray10be = 170,
        
        /// <summary>
        /// <para>Y , 10bpp, little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_GRAY10LE" />
        /// </summary>
        Gray10le = 171,
        
        /// <summary>
        /// <para>like NV12, with 16bpp per component, little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_P016LE" />
        /// </summary>
        P016le = 172,
        
        /// <summary>
        /// <para>like NV12, with 16bpp per component, big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_P016BE" />
        /// </summary>
        P016be = 173,
        
        /// <summary>
        /// <para>Hardware surfaces for Direct3D11.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_D3D11" />
        /// </summary>
        D3d11 = 174,
        
        /// <summary>
        /// <para>Y , 9bpp, big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_GRAY9BE" />
        /// </summary>
        Gray9be = 175,
        
        /// <summary>
        /// <para>Y , 9bpp, little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_GRAY9LE" />
        /// </summary>
        Gray9le = 176,
        
        /// <summary>
        /// <para>IEEE-754 single precision planar GBR 4:4:4, 96bpp, big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_GBRPF32BE" />
        /// </summary>
        Gbrpf32be = 177,
        
        /// <summary>
        /// <para>IEEE-754 single precision planar GBR 4:4:4, 96bpp, little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_GBRPF32LE" />
        /// </summary>
        Gbrpf32le = 178,
        
        /// <summary>
        /// <para>IEEE-754 single precision planar GBRA 4:4:4:4, 128bpp, big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_GBRAPF32BE" />
        /// </summary>
        Gbrapf32be = 179,
        
        /// <summary>
        /// <para>IEEE-754 single precision planar GBRA 4:4:4:4, 128bpp, little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_GBRAPF32LE" />
        /// </summary>
        Gbrapf32le = 180,
        
        /// <summary>
        /// <para>DRM-managed buffers exposed through PRIME buffer sharing.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_DRM_PRIME" />
        /// </summary>
        DrmPrime = 181,
        
        /// <summary>
        /// <para>Hardware surfaces for OpenCL.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_OPENCL" />
        /// </summary>
        Opencl = 182,
        
        /// <summary>
        /// <para>Y , 14bpp, big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_GRAY14BE" />
        /// </summary>
        Gray14be = 183,
        
        /// <summary>
        /// <para>Y , 14bpp, little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_GRAY14LE" />
        /// </summary>
        Gray14le = 184,
        
        /// <summary>
        /// <para>IEEE-754 single precision Y, 32bpp, big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_GRAYF32BE" />
        /// </summary>
        Grayf32be = 185,
        
        /// <summary>
        /// <para>IEEE-754 single precision Y, 32bpp, little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_GRAYF32LE" />
        /// </summary>
        Grayf32le = 186,
        
        /// <summary>
        /// <para>planar YUV 4:2:2,24bpp, (1 Cr &amp; Cb sample per 2x1 Y samples), 12b alpha, big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUVA422P12BE" />
        /// </summary>
        Yuva422p12be = 187,
        
        /// <summary>
        /// <para>planar YUV 4:2:2,24bpp, (1 Cr &amp; Cb sample per 2x1 Y samples), 12b alpha, little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUVA422P12LE" />
        /// </summary>
        Yuva422p12le = 188,
        
        /// <summary>
        /// <para>planar YUV 4:4:4,36bpp, (1 Cr &amp; Cb sample per 1x1 Y samples), 12b alpha, big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUVA444P12BE" />
        /// </summary>
        Yuva444p12be = 189,
        
        /// <summary>
        /// <para>planar YUV 4:4:4,36bpp, (1 Cr &amp; Cb sample per 1x1 Y samples), 12b alpha, little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUVA444P12LE" />
        /// </summary>
        Yuva444p12le = 190,
        
        /// <summary>
        /// <para>planar YUV 4:4:4, 24bpp, 1 plane for Y and 1 plane for the UV components, which are interleaved (first byte U and the following byte V).</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_NV24" />
        /// </summary>
        Nv24 = 191,
        
        /// <summary>
        /// <para>as above, but U and V bytes are swapped.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_NV42" />
        /// </summary>
        Nv42 = 192,
        
        /// <summary>
        /// <para>Vulkan hardware images.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_VULKAN" />
        /// </summary>
        Vulkan = 193,
        
        /// <summary>
        /// <para>packed YUV 4:2:2 like YUYV422, 20bpp, data in the high bits, big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_Y210BE" />
        /// </summary>
        Y210be = 194,
        
        /// <summary>
        /// <para>packed YUV 4:2:2 like YUYV422, 20bpp, data in the high bits, little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_Y210LE" />
        /// </summary>
        Y210le = 195,
        
        /// <summary>
        /// <para>number of pixel formats, DO NOT USE THIS if you want to link with shared libav* because the number of formats might differ between versions.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_NB" />
        /// </summary>
        Nb = 196,
        
        /// <summary>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_NONE" />
        /// </summary>
        None = -1,
    }
}
