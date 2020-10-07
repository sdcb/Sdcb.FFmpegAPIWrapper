using Sdcb.FFmpegAPIWrapper.MediaCodecs;
using Sdcb.FFmpegAPIWrapper.Swresamples;
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
        public static IEnumerable<Frame> ConvertFrames(this CodecContext c, IEnumerable<Frame> sourceFrames, ScaleFlag flags = ScaleFlag.Bilinear)
        {
            using var destFrame = c.CreateFrame();
            int pts = 0;
            if (c.Codec.Type == MediaType.Video)
            {
                using var frameConverter = new FrameConverter();
                foreach (var sourceFrame in sourceFrames)
                {
                    frameConverter.ConvertFrame(sourceFrame, destFrame, flags);
                    destFrame.Pts = pts++;
                    yield return destFrame;
                }
            }
            else if (c.Codec.Type == MediaType.Audio)
            {
                using var frameConverter = new SampleConverter();
                foreach (var sourceFrame in sourceFrames)
                {
                    frameConverter.ConvertFrame(destFrame, sourceFrame);
                    destFrame.Pts = pts += c.FrameSize;
                    yield return destFrame;
                }
            }
        }
    }
}
