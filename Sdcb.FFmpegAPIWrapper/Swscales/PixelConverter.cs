using Sdcb.FFmpegAPIWrapper.Common;
using static FFmpeg.AutoGen.ffmpeg;
using System;
using System.Collections.Generic;
using Sdcb.FFmpegAPIWrapper.MediaCodecs;
using FFmpeg.AutoGen;
using Sdcb.FFmpegAPIWrapper.MediaUtils;
using System.Linq;

namespace Sdcb.FFmpegAPIWrapper.Swscales
{
    public unsafe class PixelConverter : FFmpegSafeObject
    {
        public static implicit operator SwsContext*(PixelConverter data) => (SwsContext*)data._nativePointer;
        public static PixelConverter FromNative(SwsContext* ptr, bool isOwner) => new PixelConverter((IntPtr)ptr, isOwner);

        protected PixelConverter(IntPtr nativePointer, bool isOwner) : base(nativePointer, isOwner)
        {
        }

        /// <summary>
        /// <see cref="sws_getContext(int, int, AVPixelFormat, int, int, AVPixelFormat, int, SwsFilter*, SwsFilter*, double*)"/>
        /// </summary>
        public PixelConverter(
            int sourceWidth, int sourceHeight, PixelFormat sourcePixelFormat,
            int destWidth, int destHeight, PixelFormat destPixelFormat,
            ScaleFlag flags = ScaleFlag.Bilinear)
        {
            _nativePointer = NativeUtils.NotNull(
                ptr: (IntPtr)sws_getContext(
                    sourceWidth, sourceHeight, (AVPixelFormat)sourcePixelFormat,
                    destWidth, destHeight, (AVPixelFormat)destPixelFormat,
                    flags: (int)flags,
                    srcFilter: null,
                    dstFilter: null,
                    param: null),
                message: ErrorMessage(sourceWidth, sourceHeight, sourcePixelFormat, destWidth, destHeight, destPixelFormat, flags));

            _isOwner = true;
        }

        internal static string ErrorMessage(
            int sourceWidth, int sourceHeight, PixelFormat sourcePixelFormat,
            int destWidth, int destHeight, PixelFormat destPixelFormat,
            ScaleFlag flags) =>
            string.Format("Impossible to create scale context for the conversion fmt:{0} s:{1}x{2} -> fmt:{3} s:{4}x{5} (sws_flags: {6})",
                PixelUtils.GetPixelFormatName(sourcePixelFormat), sourceWidth, sourceHeight,
                PixelUtils.GetPixelFormatName(destPixelFormat), destWidth, destHeight, flags);

        /// <summary>
        /// <see cref="sws_scale(SwsContext*, byte*[], int[], int, int, byte*[], int[])"/>
        /// </summary>
        public void Convert(Ptr4 sourceData, Int32x4 sourceLinesize, int sourceSliceH, Ptr4 destData, Int32x4 destLinesize, int sourceSliceY = 0) =>
            sws_scale(this,
                srcSlice: sourceData.ToBytePtrArray(), srcStride: sourceLinesize.ToArray(), srcSliceY: sourceSliceY, srcSliceH: sourceSliceH,
                destData.ToBytePtrArray(), destLinesize.ToArray()).ThrowIfError();

        public FFmpegOptions Options => new FFmpegOptions(this);

        /// <summary>
        /// <see cref="sws_freeContext(SwsContext*)"/>
        /// </summary>
        public void Free()
        {
            sws_freeContext(this);
            _nativePointer = IntPtr.Zero;
        }

        protected override void DisposeNative() => Free();

        /// <summary>
        /// <see cref="swscale_version"/>
        /// </summary>
        public static string Version => swscale_version().ToFourCC();

        /// <summary>
        /// <see cref="swscale_configuration"/>
        /// </summary>
        public static HashSet<string> Configuration => swscale_configuration()
            .Split(' ')
            .ToHashSet();

        /// <summary>
        /// <see cref="swscale_license"/>
        /// </summary>
        public static string License => swscale_license();
    }
}
