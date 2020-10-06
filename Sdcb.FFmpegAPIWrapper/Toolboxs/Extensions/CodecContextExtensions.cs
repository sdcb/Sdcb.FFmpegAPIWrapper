using Sdcb.FFmpegAPIWrapper.MediaCodecs;
using Sdcb.FFmpegAPIWrapper.Swscales;
using System.Collections.Generic;

namespace Sdcb.FFmpegAPIWrapper.Toolboxs
{
    public static class CodecContextExtensions
    {
        /// <summary>
        /// <see cref="sws_getCachedContext(SwsContext*, int, int, AVPixelFormat, int, int, AVPixelFormat, int, SwsFilter*, SwsFilter*, double*)"/>
        /// <see cref="sws_scale(SwsContext*, byte*[], int[], int, int, byte*[], int[])"/>
        /// </summary>
        public static IEnumerable<Frame> ConvertVideoFrames(this CodecContext c, IEnumerable<Frame> sourceFrames, ScaleFlag flags = ScaleFlag.Bilinear)
        {
            using var destFrame = c.CreateVideoFrame();
            using var frameConverter = new FrameConverter();
            foreach (var sourceFrame in sourceFrames)
            {
                frameConverter.ConvertFrame(sourceFrame, destFrame, flags);
                yield return destFrame;
            }
        }
    }
}
