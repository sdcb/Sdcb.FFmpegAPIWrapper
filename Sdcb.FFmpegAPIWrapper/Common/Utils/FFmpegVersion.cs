using System;
using System.Buffers.Binary;
using System.Linq;

namespace Sdcb.FFmpegAPIWrapper.Common
{
    internal static class FFmpegVersion
    {
        /// <summary>
        /// Parse to: Major.Minor.Micro
        /// </summary>
        public static string ToVersionString(this int ffmpegVersion) => string.Join(".", BitConverter.GetBytes(BinaryPrimitives.ReverseEndianness(ffmpegVersion)).Skip(1));

        /// <summary>
        /// Parse to: Major.Minor.Micro
        /// </summary>
        public static string ToVersionString(this uint ffmpegVersion) => ToVersionString((int)ffmpegVersion);
    }
}
