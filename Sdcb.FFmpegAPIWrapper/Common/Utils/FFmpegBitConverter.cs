using System;
using System.Buffers.Binary;
using System.Linq;

namespace Sdcb.FFmpegAPIWrapper.Common
{
    internal static class FFmpegBitConverter
    {
        /// <summary>
        /// fourcc (LSB first, so "ABCD" -> ('D'<<24) + ('C'<<16) + ('B'<<8) + 'A').
        /// </summary>
        public static string ToFourCC(this int ffmpegVersion) => string.Join(".", BitConverter.GetBytes(BinaryPrimitives.ReverseEndianness(ffmpegVersion)).SkipWhile(v => v == 0));

        /// <summary>
        /// fourcc (LSB first, so "ABCD" -> ('D'<<24) + ('C'<<16) + ('B'<<8) + 'A').
        /// </summary>
        public static string ToFourCC(this uint ffmpegVersion) => ToFourCC((int)ffmpegVersion);
    }
}
