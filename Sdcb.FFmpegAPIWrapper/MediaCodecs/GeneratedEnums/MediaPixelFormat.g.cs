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
    public enum MediaPixelFormat
    {
        /// <summary>
        /// <para>planar YUV 4:2:0, 12bpp, (1 Cr &amp; Cb sample per 2x2 Y samples).</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUV420P" />
        /// </summary>
        Yuv420p = 0x00000000,
        
        /// <summary>
        /// <para>packed YUV 4:2:2, 16bpp, Y0 Cb Y1 Cr.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUYV422" />
        /// </summary>
        Yuyv422 = 0x00000001,
        
        /// <summary>
        /// <para>packed RGB 8:8:8, 24bpp, RGBRGB.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_RGB24" />
        /// </summary>
        Rgb24 = 0x00000002,
        
        /// <summary>
        /// <para>packed RGB 8:8:8, 24bpp, BGRBGR.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_BGR24" />
        /// </summary>
        Bgr24 = 0x00000003,
        
        /// <summary>
        /// <para>planar YUV 4:2:2, 16bpp, (1 Cr &amp; Cb sample per 2x1 Y samples).</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUV422P" />
        /// </summary>
        Yuv422p = 0x00000004,
        
        /// <summary>
        /// <para>planar YUV 4:4:4, 24bpp, (1 Cr &amp; Cb sample per 1x1 Y samples).</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUV444P" />
        /// </summary>
        Yuv444p = 0x00000005,
        
        /// <summary>
        /// <para>planar YUV 4:1:0, 9bpp, (1 Cr &amp; Cb sample per 4x4 Y samples).</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUV410P" />
        /// </summary>
        Yuv410p = 0x00000006,
        
        /// <summary>
        /// <para>planar YUV 4:1:1, 12bpp, (1 Cr &amp; Cb sample per 4x1 Y samples).</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUV411P" />
        /// </summary>
        Yuv411p = 0x00000007,
        
        /// <summary>
        /// <para>Y , 8bpp.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_GRAY8" />
        /// </summary>
        Gray8 = 0x00000008,
        
        /// <summary>
        /// <para>Y , 1bpp, 0 is white, 1 is black, in each byte pixels are ordered from the msb to the lsb.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_MONOWHITE" />
        /// </summary>
        Monowhite = 0x00000009,
        
        /// <summary>
        /// <para>Y , 1bpp, 0 is black, 1 is white, in each byte pixels are ordered from the msb to the lsb.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_MONOBLACK" />
        /// </summary>
        Monoblack = 0x0000000A,
        
        /// <summary>
        /// <para>8 bits with AV_PIX_FMT_RGB32 palette.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_PAL8" />
        /// </summary>
        Pal8 = 0x0000000B,
        
        /// <summary>
        /// <para>planar YUV 4:2:0, 12bpp, full scale (JPEG), deprecated in favor of AV_PIX_FMT_YUV420P and setting color_range.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUVJ420P" />
        /// </summary>
        Yuvj420p = 0x0000000C,
        
        /// <summary>
        /// <para>planar YUV 4:2:2, 16bpp, full scale (JPEG), deprecated in favor of AV_PIX_FMT_YUV422P and setting color_range.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUVJ422P" />
        /// </summary>
        Yuvj422p = 0x0000000D,
        
        /// <summary>
        /// <para>planar YUV 4:4:4, 24bpp, full scale (JPEG), deprecated in favor of AV_PIX_FMT_YUV444P and setting color_range.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUVJ444P" />
        /// </summary>
        Yuvj444p = 0x0000000E,
        
        /// <summary>
        /// <para>packed YUV 4:2:2, 16bpp, Cb Y0 Cr Y1.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_UYVY422" />
        /// </summary>
        Uyvy422 = 0x0000000F,
        
        /// <summary>
        /// <para>packed YUV 4:1:1, 12bpp, Cb Y0 Y1 Cr Y2 Y3.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_UYYVYY411" />
        /// </summary>
        Uyyvyy411 = 0x00000010,
        
        /// <summary>
        /// <para>packed RGB 3:3:2, 8bpp, (msb)2B 3G 3R(lsb).</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_BGR8" />
        /// </summary>
        Bgr8 = 0x00000011,
        
        /// <summary>
        /// <para>packed RGB 1:2:1 bitstream, 4bpp, (msb)1B 2G 1R(lsb), a byte contains two pixels, the first pixel in the byte is the one composed by the 4 msb bits.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_BGR4" />
        /// </summary>
        Bgr4 = 0x00000012,
        
        /// <summary>
        /// <para>packed RGB 1:2:1, 8bpp, (msb)1B 2G 1R(lsb).</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_BGR4_BYTE" />
        /// </summary>
        Bgr4Byte = 0x00000013,
        
        /// <summary>
        /// <para>packed RGB 3:3:2, 8bpp, (msb)2R 3G 3B(lsb).</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_RGB8" />
        /// </summary>
        Rgb8 = 0x00000014,
        
        /// <summary>
        /// <para>packed RGB 1:2:1 bitstream, 4bpp, (msb)1R 2G 1B(lsb), a byte contains two pixels, the first pixel in the byte is the one composed by the 4 msb bits.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_RGB4" />
        /// </summary>
        Rgb4 = 0x00000015,
        
        /// <summary>
        /// <para>packed RGB 1:2:1, 8bpp, (msb)1R 2G 1B(lsb).</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_RGB4_BYTE" />
        /// </summary>
        Rgb4Byte = 0x00000016,
        
        /// <summary>
        /// <para>planar YUV 4:2:0, 12bpp, 1 plane for Y and 1 plane for the UV components, which are interleaved (first byte U and the following byte V).</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_NV12" />
        /// </summary>
        Nv12 = 0x00000017,
        
        /// <summary>
        /// <para>as above, but U and V bytes are swapped.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_NV21" />
        /// </summary>
        Nv21 = 0x00000018,
        
        /// <summary>
        /// <para>packed ARGB 8:8:8:8, 32bpp, ARGBARGB.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_ARGB" />
        /// </summary>
        Argb = 0x00000019,
        
        /// <summary>
        /// <para>packed RGBA 8:8:8:8, 32bpp, RGBARGBA.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_RGBA" />
        /// </summary>
        Rgba = 0x0000001A,
        
        /// <summary>
        /// <para>packed ABGR 8:8:8:8, 32bpp, ABGRABGR.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_ABGR" />
        /// </summary>
        Abgr = 0x0000001B,
        
        /// <summary>
        /// <para>packed BGRA 8:8:8:8, 32bpp, BGRABGRA.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_BGRA" />
        /// </summary>
        Bgra = 0x0000001C,
        
        /// <summary>
        /// <para>Y , 16bpp, big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_GRAY16BE" />
        /// </summary>
        Gray16be = 0x0000001D,
        
        /// <summary>
        /// <para>Y , 16bpp, little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_GRAY16LE" />
        /// </summary>
        Gray16le = 0x0000001E,
        
        /// <summary>
        /// <para>planar YUV 4:4:0 (1 Cr &amp; Cb sample per 1x2 Y samples).</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUV440P" />
        /// </summary>
        Yuv440p = 0x0000001F,
        
        /// <summary>
        /// <para>planar YUV 4:4:0 full scale (JPEG), deprecated in favor of AV_PIX_FMT_YUV440P and setting color_range.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUVJ440P" />
        /// </summary>
        Yuvj440p = 0x00000020,
        
        /// <summary>
        /// <para>planar YUV 4:2:0, 20bpp, (1 Cr &amp; Cb sample per 2x2 Y &amp; A samples).</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUVA420P" />
        /// </summary>
        Yuva420p = 0x00000021,
        
        /// <summary>
        /// <para>packed RGB 16:16:16, 48bpp, 16R, 16G, 16B, the 2-byte value for each R/G/B component is stored as big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_RGB48BE" />
        /// </summary>
        Rgb48be = 0x00000022,
        
        /// <summary>
        /// <para>packed RGB 16:16:16, 48bpp, 16R, 16G, 16B, the 2-byte value for each R/G/B component is stored as little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_RGB48LE" />
        /// </summary>
        Rgb48le = 0x00000023,
        
        /// <summary>
        /// <para>packed RGB 5:6:5, 16bpp, (msb) 5R 6G 5B(lsb), big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_RGB565BE" />
        /// </summary>
        Rgb565be = 0x00000024,
        
        /// <summary>
        /// <para>packed RGB 5:6:5, 16bpp, (msb) 5R 6G 5B(lsb), little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_RGB565LE" />
        /// </summary>
        Rgb565le = 0x00000025,
        
        /// <summary>
        /// <para>packed RGB 5:5:5, 16bpp, (msb)1X 5R 5G 5B(lsb), big-endian , X=unused/undefined.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_RGB555BE" />
        /// </summary>
        Rgb555be = 0x00000026,
        
        /// <summary>
        /// <para>packed RGB 5:5:5, 16bpp, (msb)1X 5R 5G 5B(lsb), little-endian, X=unused/undefined.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_RGB555LE" />
        /// </summary>
        Rgb555le = 0x00000027,
        
        /// <summary>
        /// <para>packed BGR 5:6:5, 16bpp, (msb) 5B 6G 5R(lsb), big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_BGR565BE" />
        /// </summary>
        Bgr565be = 0x00000028,
        
        /// <summary>
        /// <para>packed BGR 5:6:5, 16bpp, (msb) 5B 6G 5R(lsb), little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_BGR565LE" />
        /// </summary>
        Bgr565le = 0x00000029,
        
        /// <summary>
        /// <para>packed BGR 5:5:5, 16bpp, (msb)1X 5B 5G 5R(lsb), big-endian , X=unused/undefined.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_BGR555BE" />
        /// </summary>
        Bgr555be = 0x0000002A,
        
        /// <summary>
        /// <para>packed BGR 5:5:5, 16bpp, (msb)1X 5B 5G 5R(lsb), little-endian, X=unused/undefined.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_BGR555LE" />
        /// </summary>
        Bgr555le = 0x0000002B,
        
        /// <summary>
        /// <para>HW acceleration through VA API at motion compensation entry-point, Picture.</para>
        /// <para>data[3] contains a vaapi_render_state struct which contains macroblocks as well as various fields extracted from headers.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_VAAPI_MOCO" />
        /// </summary>
        VaapiMoco = 0x0000002C,
        
        /// <summary>
        /// <para>HW acceleration through VA API at IDCT entry-point, Picture.</para>
        /// <para>data[3] contains a vaapi_render_state struct which contains fields extracted from headers.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_VAAPI_IDCT" />
        /// </summary>
        VaapiIdct = 0x0000002D,
        
        /// <summary>
        /// <para>@}.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_VAAPI" />
        /// </summary>
        Vaapi = 0x0000002E,
        
        /// <summary>
        /// <para>HW decoding through VA API, Picture.</para>
        /// <para>data[3] contains a VASurfaceID.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_VAAPI_VLD" />
        /// </summary>
        VaapiVld = 0x0000002E,
        
        /// <summary>
        /// <para>planar YUV 4:2:0, 24bpp, (1 Cr &amp; Cb sample per 2x2 Y samples), little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUV420P16LE" />
        /// </summary>
        Yuv420p16le = 0x0000002F,
        
        /// <summary>
        /// <para>planar YUV 4:2:0, 24bpp, (1 Cr &amp; Cb sample per 2x2 Y samples), big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUV420P16BE" />
        /// </summary>
        Yuv420p16be = 0x00000030,
        
        /// <summary>
        /// <para>planar YUV 4:2:2, 32bpp, (1 Cr &amp; Cb sample per 2x1 Y samples), little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUV422P16LE" />
        /// </summary>
        Yuv422p16le = 0x00000031,
        
        /// <summary>
        /// <para>planar YUV 4:2:2, 32bpp, (1 Cr &amp; Cb sample per 2x1 Y samples), big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUV422P16BE" />
        /// </summary>
        Yuv422p16be = 0x00000032,
        
        /// <summary>
        /// <para>planar YUV 4:4:4, 48bpp, (1 Cr &amp; Cb sample per 1x1 Y samples), little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUV444P16LE" />
        /// </summary>
        Yuv444p16le = 0x00000033,
        
        /// <summary>
        /// <para>planar YUV 4:4:4, 48bpp, (1 Cr &amp; Cb sample per 1x1 Y samples), big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUV444P16BE" />
        /// </summary>
        Yuv444p16be = 0x00000034,
        
        /// <summary>
        /// <para>HW decoding through DXVA2, Picture.</para>
        /// <para>data[3] contains a LPDIRECT3DSURFACE9 pointer.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_DXVA2_VLD" />
        /// </summary>
        Dxva2Vld = 0x00000035,
        
        /// <summary>
        /// <para>packed RGB 4:4:4, 16bpp, (msb)4X 4R 4G 4B(lsb), little-endian, X=unused/undefined.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_RGB444LE" />
        /// </summary>
        Rgb444le = 0x00000036,
        
        /// <summary>
        /// <para>packed RGB 4:4:4, 16bpp, (msb)4X 4R 4G 4B(lsb), big-endian, X=unused/undefined.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_RGB444BE" />
        /// </summary>
        Rgb444be = 0x00000037,
        
        /// <summary>
        /// <para>packed BGR 4:4:4, 16bpp, (msb)4X 4B 4G 4R(lsb), little-endian, X=unused/undefined.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_BGR444LE" />
        /// </summary>
        Bgr444le = 0x00000038,
        
        /// <summary>
        /// <para>packed BGR 4:4:4, 16bpp, (msb)4X 4B 4G 4R(lsb), big-endian, X=unused/undefined.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_BGR444BE" />
        /// </summary>
        Bgr444be = 0x00000039,
        
        /// <summary>
        /// <para>8 bits gray, 8 bits alpha.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YA8" />
        /// </summary>
        Ya8 = 0x0000003A,
        
        /// <summary>
        /// <para>alias for AV_PIX_FMT_YA8.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_Y400A" />
        /// </summary>
        Y400a = 0x0000003A,
        
        /// <summary>
        /// <para>alias for AV_PIX_FMT_YA8.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_GRAY8A" />
        /// </summary>
        Gray8a = 0x0000003A,
        
        /// <summary>
        /// <para>packed RGB 16:16:16, 48bpp, 16B, 16G, 16R, the 2-byte value for each R/G/B component is stored as big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_BGR48BE" />
        /// </summary>
        Bgr48be = 0x0000003B,
        
        /// <summary>
        /// <para>packed RGB 16:16:16, 48bpp, 16B, 16G, 16R, the 2-byte value for each R/G/B component is stored as little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_BGR48LE" />
        /// </summary>
        Bgr48le = 0x0000003C,
        
        /// <summary>
        /// <para>planar YUV 4:2:0, 13.</para>
        /// <para>5bpp, (1 Cr &amp; Cb sample per 2x2 Y samples), big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUV420P9BE" />
        /// </summary>
        Yuv420p9be = 0x0000003D,
        
        /// <summary>
        /// <para>planar YUV 4:2:0, 13.</para>
        /// <para>5bpp, (1 Cr &amp; Cb sample per 2x2 Y samples), little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUV420P9LE" />
        /// </summary>
        Yuv420p9le = 0x0000003E,
        
        /// <summary>
        /// <para>planar YUV 4:2:0, 15bpp, (1 Cr &amp; Cb sample per 2x2 Y samples), big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUV420P10BE" />
        /// </summary>
        Yuv420p10be = 0x0000003F,
        
        /// <summary>
        /// <para>planar YUV 4:2:0, 15bpp, (1 Cr &amp; Cb sample per 2x2 Y samples), little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUV420P10LE" />
        /// </summary>
        Yuv420p10le = 0x00000040,
        
        /// <summary>
        /// <para>planar YUV 4:2:2, 20bpp, (1 Cr &amp; Cb sample per 2x1 Y samples), big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUV422P10BE" />
        /// </summary>
        Yuv422p10be = 0x00000041,
        
        /// <summary>
        /// <para>planar YUV 4:2:2, 20bpp, (1 Cr &amp; Cb sample per 2x1 Y samples), little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUV422P10LE" />
        /// </summary>
        Yuv422p10le = 0x00000042,
        
        /// <summary>
        /// <para>planar YUV 4:4:4, 27bpp, (1 Cr &amp; Cb sample per 1x1 Y samples), big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUV444P9BE" />
        /// </summary>
        Yuv444p9be = 0x00000043,
        
        /// <summary>
        /// <para>planar YUV 4:4:4, 27bpp, (1 Cr &amp; Cb sample per 1x1 Y samples), little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUV444P9LE" />
        /// </summary>
        Yuv444p9le = 0x00000044,
        
        /// <summary>
        /// <para>planar YUV 4:4:4, 30bpp, (1 Cr &amp; Cb sample per 1x1 Y samples), big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUV444P10BE" />
        /// </summary>
        Yuv444p10be = 0x00000045,
        
        /// <summary>
        /// <para>planar YUV 4:4:4, 30bpp, (1 Cr &amp; Cb sample per 1x1 Y samples), little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUV444P10LE" />
        /// </summary>
        Yuv444p10le = 0x00000046,
        
        /// <summary>
        /// <para>planar YUV 4:2:2, 18bpp, (1 Cr &amp; Cb sample per 2x1 Y samples), big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUV422P9BE" />
        /// </summary>
        Yuv422p9be = 0x00000047,
        
        /// <summary>
        /// <para>planar YUV 4:2:2, 18bpp, (1 Cr &amp; Cb sample per 2x1 Y samples), little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUV422P9LE" />
        /// </summary>
        Yuv422p9le = 0x00000048,
        
        /// <summary>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_GBR24P" />
        /// </summary>
        Gbr24p = 0x00000049,
        
        /// <summary>
        /// <para>planar GBR 4:4:4 24bpp.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_GBRP" />
        /// </summary>
        Gbrp = 0x00000049,
        
        /// <summary>
        /// <para>planar GBR 4:4:4 27bpp, big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_GBRP9BE" />
        /// </summary>
        Gbrp9be = 0x0000004A,
        
        /// <summary>
        /// <para>planar GBR 4:4:4 27bpp, little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_GBRP9LE" />
        /// </summary>
        Gbrp9le = 0x0000004B,
        
        /// <summary>
        /// <para>planar GBR 4:4:4 30bpp, big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_GBRP10BE" />
        /// </summary>
        Gbrp10be = 0x0000004C,
        
        /// <summary>
        /// <para>planar GBR 4:4:4 30bpp, little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_GBRP10LE" />
        /// </summary>
        Gbrp10le = 0x0000004D,
        
        /// <summary>
        /// <para>planar GBR 4:4:4 48bpp, big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_GBRP16BE" />
        /// </summary>
        Gbrp16be = 0x0000004E,
        
        /// <summary>
        /// <para>planar GBR 4:4:4 48bpp, little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_GBRP16LE" />
        /// </summary>
        Gbrp16le = 0x0000004F,
        
        /// <summary>
        /// <para>planar YUV 4:2:2 24bpp, (1 Cr &amp; Cb sample per 2x1 Y &amp; A samples).</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUVA422P" />
        /// </summary>
        Yuva422p = 0x00000050,
        
        /// <summary>
        /// <para>planar YUV 4:4:4 32bpp, (1 Cr &amp; Cb sample per 1x1 Y &amp; A samples).</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUVA444P" />
        /// </summary>
        Yuva444p = 0x00000051,
        
        /// <summary>
        /// <para>planar YUV 4:2:0 22.</para>
        /// <para>5bpp, (1 Cr &amp; Cb sample per 2x2 Y &amp; A samples), big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUVA420P9BE" />
        /// </summary>
        Yuva420p9be = 0x00000052,
        
        /// <summary>
        /// <para>planar YUV 4:2:0 22.</para>
        /// <para>5bpp, (1 Cr &amp; Cb sample per 2x2 Y &amp; A samples), little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUVA420P9LE" />
        /// </summary>
        Yuva420p9le = 0x00000053,
        
        /// <summary>
        /// <para>planar YUV 4:2:2 27bpp, (1 Cr &amp; Cb sample per 2x1 Y &amp; A samples), big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUVA422P9BE" />
        /// </summary>
        Yuva422p9be = 0x00000054,
        
        /// <summary>
        /// <para>planar YUV 4:2:2 27bpp, (1 Cr &amp; Cb sample per 2x1 Y &amp; A samples), little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUVA422P9LE" />
        /// </summary>
        Yuva422p9le = 0x00000055,
        
        /// <summary>
        /// <para>planar YUV 4:4:4 36bpp, (1 Cr &amp; Cb sample per 1x1 Y &amp; A samples), big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUVA444P9BE" />
        /// </summary>
        Yuva444p9be = 0x00000056,
        
        /// <summary>
        /// <para>planar YUV 4:4:4 36bpp, (1 Cr &amp; Cb sample per 1x1 Y &amp; A samples), little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUVA444P9LE" />
        /// </summary>
        Yuva444p9le = 0x00000057,
        
        /// <summary>
        /// <para>planar YUV 4:2:0 25bpp, (1 Cr &amp; Cb sample per 2x2 Y &amp; A samples, big-endian).</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUVA420P10BE" />
        /// </summary>
        Yuva420p10be = 0x00000058,
        
        /// <summary>
        /// <para>planar YUV 4:2:0 25bpp, (1 Cr &amp; Cb sample per 2x2 Y &amp; A samples, little-endian).</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUVA420P10LE" />
        /// </summary>
        Yuva420p10le = 0x00000059,
        
        /// <summary>
        /// <para>planar YUV 4:2:2 30bpp, (1 Cr &amp; Cb sample per 2x1 Y &amp; A samples, big-endian).</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUVA422P10BE" />
        /// </summary>
        Yuva422p10be = 0x0000005A,
        
        /// <summary>
        /// <para>planar YUV 4:2:2 30bpp, (1 Cr &amp; Cb sample per 2x1 Y &amp; A samples, little-endian).</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUVA422P10LE" />
        /// </summary>
        Yuva422p10le = 0x0000005B,
        
        /// <summary>
        /// <para>planar YUV 4:4:4 40bpp, (1 Cr &amp; Cb sample per 1x1 Y &amp; A samples, big-endian).</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUVA444P10BE" />
        /// </summary>
        Yuva444p10be = 0x0000005C,
        
        /// <summary>
        /// <para>planar YUV 4:4:4 40bpp, (1 Cr &amp; Cb sample per 1x1 Y &amp; A samples, little-endian).</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUVA444P10LE" />
        /// </summary>
        Yuva444p10le = 0x0000005D,
        
        /// <summary>
        /// <para>planar YUV 4:2:0 40bpp, (1 Cr &amp; Cb sample per 2x2 Y &amp; A samples, big-endian).</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUVA420P16BE" />
        /// </summary>
        Yuva420p16be = 0x0000005E,
        
        /// <summary>
        /// <para>planar YUV 4:2:0 40bpp, (1 Cr &amp; Cb sample per 2x2 Y &amp; A samples, little-endian).</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUVA420P16LE" />
        /// </summary>
        Yuva420p16le = 0x0000005F,
        
        /// <summary>
        /// <para>planar YUV 4:2:2 48bpp, (1 Cr &amp; Cb sample per 2x1 Y &amp; A samples, big-endian).</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUVA422P16BE" />
        /// </summary>
        Yuva422p16be = 0x00000060,
        
        /// <summary>
        /// <para>planar YUV 4:2:2 48bpp, (1 Cr &amp; Cb sample per 2x1 Y &amp; A samples, little-endian).</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUVA422P16LE" />
        /// </summary>
        Yuva422p16le = 0x00000061,
        
        /// <summary>
        /// <para>planar YUV 4:4:4 64bpp, (1 Cr &amp; Cb sample per 1x1 Y &amp; A samples, big-endian).</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUVA444P16BE" />
        /// </summary>
        Yuva444p16be = 0x00000062,
        
        /// <summary>
        /// <para>planar YUV 4:4:4 64bpp, (1 Cr &amp; Cb sample per 1x1 Y &amp; A samples, little-endian).</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUVA444P16LE" />
        /// </summary>
        Yuva444p16le = 0x00000063,
        
        /// <summary>
        /// <para>HW acceleration through VDPAU, Picture.</para>
        /// <para>data[3] contains a VdpVideoSurface.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_VDPAU" />
        /// </summary>
        Vdpau = 0x00000064,
        
        /// <summary>
        /// <para>packed XYZ 4:4:4, 36 bpp, (msb) 12X, 12Y, 12Z (lsb), the 2-byte value for each X/Y/Z is stored as little-endian, the 4 lower bits are set to 0.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_XYZ12LE" />
        /// </summary>
        Xyz12le = 0x00000065,
        
        /// <summary>
        /// <para>packed XYZ 4:4:4, 36 bpp, (msb) 12X, 12Y, 12Z (lsb), the 2-byte value for each X/Y/Z is stored as big-endian, the 4 lower bits are set to 0.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_XYZ12BE" />
        /// </summary>
        Xyz12be = 0x00000066,
        
        /// <summary>
        /// <para>interleaved chroma YUV 4:2:2, 16bpp, (1 Cr &amp; Cb sample per 2x1 Y samples).</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_NV16" />
        /// </summary>
        Nv16 = 0x00000067,
        
        /// <summary>
        /// <para>interleaved chroma YUV 4:2:2, 20bpp, (1 Cr &amp; Cb sample per 2x1 Y samples), little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_NV20LE" />
        /// </summary>
        Nv20le = 0x00000068,
        
        /// <summary>
        /// <para>interleaved chroma YUV 4:2:2, 20bpp, (1 Cr &amp; Cb sample per 2x1 Y samples), big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_NV20BE" />
        /// </summary>
        Nv20be = 0x00000069,
        
        /// <summary>
        /// <para>packed RGBA 16:16:16:16, 64bpp, 16R, 16G, 16B, 16A, the 2-byte value for each R/G/B/A component is stored as big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_RGBA64BE" />
        /// </summary>
        Rgba64be = 0x0000006A,
        
        /// <summary>
        /// <para>packed RGBA 16:16:16:16, 64bpp, 16R, 16G, 16B, 16A, the 2-byte value for each R/G/B/A component is stored as little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_RGBA64LE" />
        /// </summary>
        Rgba64le = 0x0000006B,
        
        /// <summary>
        /// <para>packed RGBA 16:16:16:16, 64bpp, 16B, 16G, 16R, 16A, the 2-byte value for each R/G/B/A component is stored as big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_BGRA64BE" />
        /// </summary>
        Bgra64be = 0x0000006C,
        
        /// <summary>
        /// <para>packed RGBA 16:16:16:16, 64bpp, 16B, 16G, 16R, 16A, the 2-byte value for each R/G/B/A component is stored as little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_BGRA64LE" />
        /// </summary>
        Bgra64le = 0x0000006D,
        
        /// <summary>
        /// <para>packed YUV 4:2:2, 16bpp, Y0 Cr Y1 Cb.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YVYU422" />
        /// </summary>
        Yvyu422 = 0x0000006E,
        
        /// <summary>
        /// <para>16 bits gray, 16 bits alpha (big-endian).</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YA16BE" />
        /// </summary>
        Ya16be = 0x0000006F,
        
        /// <summary>
        /// <para>16 bits gray, 16 bits alpha (little-endian).</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YA16LE" />
        /// </summary>
        Ya16le = 0x00000070,
        
        /// <summary>
        /// <para>planar GBRA 4:4:4:4 32bpp.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_GBRAP" />
        /// </summary>
        Gbrap = 0x00000071,
        
        /// <summary>
        /// <para>planar GBRA 4:4:4:4 64bpp, big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_GBRAP16BE" />
        /// </summary>
        Gbrap16be = 0x00000072,
        
        /// <summary>
        /// <para>planar GBRA 4:4:4:4 64bpp, little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_GBRAP16LE" />
        /// </summary>
        Gbrap16le = 0x00000073,
        
        /// <summary>
        /// <para>HW acceleration through QSV, data[3] contains a pointer to the mfxFrameSurface1 structure.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_QSV" />
        /// </summary>
        Qsv = 0x00000074,
        
        /// <summary>
        /// <para>HW acceleration though MMAL, data[3] contains a pointer to the MMAL_BUFFER_HEADER_T structure.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_MMAL" />
        /// </summary>
        Mmal = 0x00000075,
        
        /// <summary>
        /// <para>HW decoding through Direct3D11 via old API, Picture.</para>
        /// <para>data[3] contains a ID3D11VideoDecoderOutputView pointer.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_D3D11VA_VLD" />
        /// </summary>
        D3d11vaVld = 0x00000076,
        
        /// <summary>
        /// <para>HW acceleration through CUDA.</para>
        /// <para> data[i] contain CUdeviceptr pointers exactly as for system memory frames.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_CUDA" />
        /// </summary>
        Cuda = 0x00000077,
        
        /// <summary>
        /// <para>packed RGB 8:8:8, 32bpp, XRGBXRGB.</para>
        /// <para> X=unused/undefined.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_0RGB" />
        /// </summary>
        _0rgb = 0x00000078,
        
        /// <summary>
        /// <para>packed RGB 8:8:8, 32bpp, RGBXRGBX.</para>
        /// <para> X=unused/undefined.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_RGB0" />
        /// </summary>
        Rgb0 = 0x00000079,
        
        /// <summary>
        /// <para>packed BGR 8:8:8, 32bpp, XBGRXBGR.</para>
        /// <para> X=unused/undefined.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_0BGR" />
        /// </summary>
        _0bgr = 0x0000007A,
        
        /// <summary>
        /// <para>packed BGR 8:8:8, 32bpp, BGRXBGRX.</para>
        /// <para> X=unused/undefined.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_BGR0" />
        /// </summary>
        Bgr0 = 0x0000007B,
        
        /// <summary>
        /// <para>planar YUV 4:2:0,18bpp, (1 Cr &amp; Cb sample per 2x2 Y samples), big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUV420P12BE" />
        /// </summary>
        Yuv420p12be = 0x0000007C,
        
        /// <summary>
        /// <para>planar YUV 4:2:0,18bpp, (1 Cr &amp; Cb sample per 2x2 Y samples), little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUV420P12LE" />
        /// </summary>
        Yuv420p12le = 0x0000007D,
        
        /// <summary>
        /// <para>planar YUV 4:2:0,21bpp, (1 Cr &amp; Cb sample per 2x2 Y samples), big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUV420P14BE" />
        /// </summary>
        Yuv420p14be = 0x0000007E,
        
        /// <summary>
        /// <para>planar YUV 4:2:0,21bpp, (1 Cr &amp; Cb sample per 2x2 Y samples), little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUV420P14LE" />
        /// </summary>
        Yuv420p14le = 0x0000007F,
        
        /// <summary>
        /// <para>planar YUV 4:2:2,24bpp, (1 Cr &amp; Cb sample per 2x1 Y samples), big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUV422P12BE" />
        /// </summary>
        Yuv422p12be = 0x00000080,
        
        /// <summary>
        /// <para>planar YUV 4:2:2,24bpp, (1 Cr &amp; Cb sample per 2x1 Y samples), little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUV422P12LE" />
        /// </summary>
        Yuv422p12le = 0x00000081,
        
        /// <summary>
        /// <para>planar YUV 4:2:2,28bpp, (1 Cr &amp; Cb sample per 2x1 Y samples), big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUV422P14BE" />
        /// </summary>
        Yuv422p14be = 0x00000082,
        
        /// <summary>
        /// <para>planar YUV 4:2:2,28bpp, (1 Cr &amp; Cb sample per 2x1 Y samples), little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUV422P14LE" />
        /// </summary>
        Yuv422p14le = 0x00000083,
        
        /// <summary>
        /// <para>planar YUV 4:4:4,36bpp, (1 Cr &amp; Cb sample per 1x1 Y samples), big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUV444P12BE" />
        /// </summary>
        Yuv444p12be = 0x00000084,
        
        /// <summary>
        /// <para>planar YUV 4:4:4,36bpp, (1 Cr &amp; Cb sample per 1x1 Y samples), little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUV444P12LE" />
        /// </summary>
        Yuv444p12le = 0x00000085,
        
        /// <summary>
        /// <para>planar YUV 4:4:4,42bpp, (1 Cr &amp; Cb sample per 1x1 Y samples), big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUV444P14BE" />
        /// </summary>
        Yuv444p14be = 0x00000086,
        
        /// <summary>
        /// <para>planar YUV 4:4:4,42bpp, (1 Cr &amp; Cb sample per 1x1 Y samples), little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUV444P14LE" />
        /// </summary>
        Yuv444p14le = 0x00000087,
        
        /// <summary>
        /// <para>planar GBR 4:4:4 36bpp, big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_GBRP12BE" />
        /// </summary>
        Gbrp12be = 0x00000088,
        
        /// <summary>
        /// <para>planar GBR 4:4:4 36bpp, little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_GBRP12LE" />
        /// </summary>
        Gbrp12le = 0x00000089,
        
        /// <summary>
        /// <para>planar GBR 4:4:4 42bpp, big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_GBRP14BE" />
        /// </summary>
        Gbrp14be = 0x0000008A,
        
        /// <summary>
        /// <para>planar GBR 4:4:4 42bpp, little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_GBRP14LE" />
        /// </summary>
        Gbrp14le = 0x0000008B,
        
        /// <summary>
        /// <para>planar YUV 4:1:1, 12bpp, (1 Cr &amp; Cb sample per 4x1 Y samples) full scale (JPEG), deprecated in favor of AV_PIX_FMT_YUV411P and setting color_range.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUVJ411P" />
        /// </summary>
        Yuvj411p = 0x0000008C,
        
        /// <summary>
        /// <para>bayer, BGBG.</para>
        /// <para>(odd line), GRGR.</para>
        /// <para>(even line), 8-bit samples.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_BAYER_BGGR8" />
        /// </summary>
        BayerBggr8 = 0x0000008D,
        
        /// <summary>
        /// <para>bayer, RGRG.</para>
        /// <para>(odd line), GBGB.</para>
        /// <para>(even line), 8-bit samples.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_BAYER_RGGB8" />
        /// </summary>
        BayerRggb8 = 0x0000008E,
        
        /// <summary>
        /// <para>bayer, GBGB.</para>
        /// <para>(odd line), RGRG.</para>
        /// <para>(even line), 8-bit samples.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_BAYER_GBRG8" />
        /// </summary>
        BayerGbrg8 = 0x0000008F,
        
        /// <summary>
        /// <para>bayer, GRGR.</para>
        /// <para>(odd line), BGBG.</para>
        /// <para>(even line), 8-bit samples.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_BAYER_GRBG8" />
        /// </summary>
        BayerGrbg8 = 0x00000090,
        
        /// <summary>
        /// <para>bayer, BGBG.</para>
        /// <para>(odd line), GRGR.</para>
        /// <para>(even line), 16-bit samples, little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_BAYER_BGGR16LE" />
        /// </summary>
        BayerBggr16le = 0x00000091,
        
        /// <summary>
        /// <para>bayer, BGBG.</para>
        /// <para>(odd line), GRGR.</para>
        /// <para>(even line), 16-bit samples, big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_BAYER_BGGR16BE" />
        /// </summary>
        BayerBggr16be = 0x00000092,
        
        /// <summary>
        /// <para>bayer, RGRG.</para>
        /// <para>(odd line), GBGB.</para>
        /// <para>(even line), 16-bit samples, little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_BAYER_RGGB16LE" />
        /// </summary>
        BayerRggb16le = 0x00000093,
        
        /// <summary>
        /// <para>bayer, RGRG.</para>
        /// <para>(odd line), GBGB.</para>
        /// <para>(even line), 16-bit samples, big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_BAYER_RGGB16BE" />
        /// </summary>
        BayerRggb16be = 0x00000094,
        
        /// <summary>
        /// <para>bayer, GBGB.</para>
        /// <para>(odd line), RGRG.</para>
        /// <para>(even line), 16-bit samples, little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_BAYER_GBRG16LE" />
        /// </summary>
        BayerGbrg16le = 0x00000095,
        
        /// <summary>
        /// <para>bayer, GBGB.</para>
        /// <para>(odd line), RGRG.</para>
        /// <para>(even line), 16-bit samples, big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_BAYER_GBRG16BE" />
        /// </summary>
        BayerGbrg16be = 0x00000096,
        
        /// <summary>
        /// <para>bayer, GRGR.</para>
        /// <para>(odd line), BGBG.</para>
        /// <para>(even line), 16-bit samples, little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_BAYER_GRBG16LE" />
        /// </summary>
        BayerGrbg16le = 0x00000097,
        
        /// <summary>
        /// <para>bayer, GRGR.</para>
        /// <para>(odd line), BGBG.</para>
        /// <para>(even line), 16-bit samples, big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_BAYER_GRBG16BE" />
        /// </summary>
        BayerGrbg16be = 0x00000098,
        
        /// <summary>
        /// <para>XVideo Motion Acceleration via common packet passing.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_XVMC" />
        /// </summary>
        Xvmc = 0x00000099,
        
        /// <summary>
        /// <para>planar YUV 4:4:0,20bpp, (1 Cr &amp; Cb sample per 1x2 Y samples), little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUV440P10LE" />
        /// </summary>
        Yuv440p10le = 0x0000009A,
        
        /// <summary>
        /// <para>planar YUV 4:4:0,20bpp, (1 Cr &amp; Cb sample per 1x2 Y samples), big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUV440P10BE" />
        /// </summary>
        Yuv440p10be = 0x0000009B,
        
        /// <summary>
        /// <para>planar YUV 4:4:0,24bpp, (1 Cr &amp; Cb sample per 1x2 Y samples), little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUV440P12LE" />
        /// </summary>
        Yuv440p12le = 0x0000009C,
        
        /// <summary>
        /// <para>planar YUV 4:4:0,24bpp, (1 Cr &amp; Cb sample per 1x2 Y samples), big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUV440P12BE" />
        /// </summary>
        Yuv440p12be = 0x0000009D,
        
        /// <summary>
        /// <para>packed AYUV 4:4:4,64bpp (1 Cr &amp; Cb sample per 1x1 Y &amp; A samples), little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_AYUV64LE" />
        /// </summary>
        Ayuv64le = 0x0000009E,
        
        /// <summary>
        /// <para>packed AYUV 4:4:4,64bpp (1 Cr &amp; Cb sample per 1x1 Y &amp; A samples), big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_AYUV64BE" />
        /// </summary>
        Ayuv64be = 0x0000009F,
        
        /// <summary>
        /// <para>hardware decoding through Videotoolbox.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_VIDEOTOOLBOX" />
        /// </summary>
        Videotoolbox = 0x000000A0,
        
        /// <summary>
        /// <para>like NV12, with 10bpp per component, data in the high bits, zeros in the low bits, little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_P010LE" />
        /// </summary>
        P010le = 0x000000A1,
        
        /// <summary>
        /// <para>like NV12, with 10bpp per component, data in the high bits, zeros in the low bits, big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_P010BE" />
        /// </summary>
        P010be = 0x000000A2,
        
        /// <summary>
        /// <para>planar GBR 4:4:4:4 48bpp, big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_GBRAP12BE" />
        /// </summary>
        Gbrap12be = 0x000000A3,
        
        /// <summary>
        /// <para>planar GBR 4:4:4:4 48bpp, little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_GBRAP12LE" />
        /// </summary>
        Gbrap12le = 0x000000A4,
        
        /// <summary>
        /// <para>planar GBR 4:4:4:4 40bpp, big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_GBRAP10BE" />
        /// </summary>
        Gbrap10be = 0x000000A5,
        
        /// <summary>
        /// <para>planar GBR 4:4:4:4 40bpp, little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_GBRAP10LE" />
        /// </summary>
        Gbrap10le = 0x000000A6,
        
        /// <summary>
        /// <para>hardware decoding through MediaCodec.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_MEDIACODEC" />
        /// </summary>
        Mediacodec = 0x000000A7,
        
        /// <summary>
        /// <para>Y , 12bpp, big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_GRAY12BE" />
        /// </summary>
        Gray12be = 0x000000A8,
        
        /// <summary>
        /// <para>Y , 12bpp, little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_GRAY12LE" />
        /// </summary>
        Gray12le = 0x000000A9,
        
        /// <summary>
        /// <para>Y , 10bpp, big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_GRAY10BE" />
        /// </summary>
        Gray10be = 0x000000AA,
        
        /// <summary>
        /// <para>Y , 10bpp, little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_GRAY10LE" />
        /// </summary>
        Gray10le = 0x000000AB,
        
        /// <summary>
        /// <para>like NV12, with 16bpp per component, little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_P016LE" />
        /// </summary>
        P016le = 0x000000AC,
        
        /// <summary>
        /// <para>like NV12, with 16bpp per component, big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_P016BE" />
        /// </summary>
        P016be = 0x000000AD,
        
        /// <summary>
        /// <para>Hardware surfaces for Direct3D11.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_D3D11" />
        /// </summary>
        D3d11 = 0x000000AE,
        
        /// <summary>
        /// <para>Y , 9bpp, big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_GRAY9BE" />
        /// </summary>
        Gray9be = 0x000000AF,
        
        /// <summary>
        /// <para>Y , 9bpp, little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_GRAY9LE" />
        /// </summary>
        Gray9le = 0x000000B0,
        
        /// <summary>
        /// <para>IEEE-754 single precision planar GBR 4:4:4, 96bpp, big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_GBRPF32BE" />
        /// </summary>
        Gbrpf32be = 0x000000B1,
        
        /// <summary>
        /// <para>IEEE-754 single precision planar GBR 4:4:4, 96bpp, little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_GBRPF32LE" />
        /// </summary>
        Gbrpf32le = 0x000000B2,
        
        /// <summary>
        /// <para>IEEE-754 single precision planar GBRA 4:4:4:4, 128bpp, big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_GBRAPF32BE" />
        /// </summary>
        Gbrapf32be = 0x000000B3,
        
        /// <summary>
        /// <para>IEEE-754 single precision planar GBRA 4:4:4:4, 128bpp, little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_GBRAPF32LE" />
        /// </summary>
        Gbrapf32le = 0x000000B4,
        
        /// <summary>
        /// <para>DRM-managed buffers exposed through PRIME buffer sharing.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_DRM_PRIME" />
        /// </summary>
        DrmPrime = 0x000000B5,
        
        /// <summary>
        /// <para>Hardware surfaces for OpenCL.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_OPENCL" />
        /// </summary>
        Opencl = 0x000000B6,
        
        /// <summary>
        /// <para>Y , 14bpp, big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_GRAY14BE" />
        /// </summary>
        Gray14be = 0x000000B7,
        
        /// <summary>
        /// <para>Y , 14bpp, little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_GRAY14LE" />
        /// </summary>
        Gray14le = 0x000000B8,
        
        /// <summary>
        /// <para>IEEE-754 single precision Y, 32bpp, big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_GRAYF32BE" />
        /// </summary>
        Grayf32be = 0x000000B9,
        
        /// <summary>
        /// <para>IEEE-754 single precision Y, 32bpp, little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_GRAYF32LE" />
        /// </summary>
        Grayf32le = 0x000000BA,
        
        /// <summary>
        /// <para>planar YUV 4:2:2,24bpp, (1 Cr &amp; Cb sample per 2x1 Y samples), 12b alpha, big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUVA422P12BE" />
        /// </summary>
        Yuva422p12be = 0x000000BB,
        
        /// <summary>
        /// <para>planar YUV 4:2:2,24bpp, (1 Cr &amp; Cb sample per 2x1 Y samples), 12b alpha, little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUVA422P12LE" />
        /// </summary>
        Yuva422p12le = 0x000000BC,
        
        /// <summary>
        /// <para>planar YUV 4:4:4,36bpp, (1 Cr &amp; Cb sample per 1x1 Y samples), 12b alpha, big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUVA444P12BE" />
        /// </summary>
        Yuva444p12be = 0x000000BD,
        
        /// <summary>
        /// <para>planar YUV 4:4:4,36bpp, (1 Cr &amp; Cb sample per 1x1 Y samples), 12b alpha, little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_YUVA444P12LE" />
        /// </summary>
        Yuva444p12le = 0x000000BE,
        
        /// <summary>
        /// <para>planar YUV 4:4:4, 24bpp, 1 plane for Y and 1 plane for the UV components, which are interleaved (first byte U and the following byte V).</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_NV24" />
        /// </summary>
        Nv24 = 0x000000BF,
        
        /// <summary>
        /// <para>as above, but U and V bytes are swapped.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_NV42" />
        /// </summary>
        Nv42 = 0x000000C0,
        
        /// <summary>
        /// <para>Vulkan hardware images.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_VULKAN" />
        /// </summary>
        Vulkan = 0x000000C1,
        
        /// <summary>
        /// <para>packed YUV 4:2:2 like YUYV422, 20bpp, data in the high bits, big-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_Y210BE" />
        /// </summary>
        Y210be = 0x000000C2,
        
        /// <summary>
        /// <para>packed YUV 4:2:2 like YUYV422, 20bpp, data in the high bits, little-endian.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_Y210LE" />
        /// </summary>
        Y210le = 0x000000C3,
        
        /// <summary>
        /// <para>number of pixel formats, DO NOT USE THIS if you want to link with shared libav* because the number of formats might differ between versions.</para>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_NB" />
        /// </summary>
        Nb = 0x000000C4,
        
        /// <summary>
        /// <see cref="AVPixelFormat.AV_PIX_FMT_NONE" />
        /// </summary>
        None = 0xFFFFFFFF,
    }
}
