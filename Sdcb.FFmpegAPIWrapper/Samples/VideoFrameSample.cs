using FFmpeg.AutoGen;
using Sdcb.FFmpegAPIWrapper.MediaCodecs;
using System.Collections.Generic;
using System.Threading;

namespace Sdcb.FFmpegAPIWrapper.Samples
{
    public static class VideoFrameSample
    {
		public static IEnumerable<Frame> Yuv420pSequence(int width, int height, CancellationToken cancellationToken = default)
		{
			using Frame frame = Frame.CreateWritableVideo(width, height, PixelFormat.Yuv420p);
			for (long i = 0; !cancellationToken.IsCancellationRequested; ++i)
			{
				FillYuv420p(frame, i);
				yield return frame;
			}
		}

		public static unsafe void FillYuv420p(Frame frame, long i)
		{
			int_array8 linesize = frame.Linesize;
			int linesize0 = linesize._[0];
			int linesize1 = linesize._[1];
			int linesize2 = linesize._[2];

			byte* data0 = frame.Data._0;
			byte* data1 = frame.Data._1;
			byte* data2 = frame.Data._2;

			/* prepare a dummy image */
			/* Y */
			for (int y = 0; y < frame.Height; y++)
			{
				for (int x = 0; x < frame.Width; x++)
				{
					data0[y * linesize0 + x] = (byte)(x + y + i * 3);
				}
			}
			/* Cb and Cr */
			for (int y = 0; y < frame.Height / 2; y++)
			{
				for (int x = 0; x < frame.Width / 2; x++)
				{
					data1[y * linesize1 + x] = (byte)(128 + y + i * 2);
					data2[y * linesize2 + x] = (byte)(64 + x + i * 5);
				}
			}

			frame.Pts = i;
		}
	}
}
