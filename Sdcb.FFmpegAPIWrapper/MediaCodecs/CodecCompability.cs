using static FFmpeg.AutoGen.ffmpeg;
using System;

namespace Sdcb.FFmpegAPIWrapper.MediaCodecs
{
	/// <summary>
	/// AV_CODEC_*
	/// </summary>
    [Flags]
    public enum CodecCompability : uint
	{
		None = 0,

		DrawHorizBand = AV_CODEC_CAP_DRAW_HORIZ_BAND,

		DR1 = AV_CODEC_CAP_DR1,

		Truncated = AV_CODEC_CAP_TRUNCATED,

		Delay = AV_CODEC_CAP_DELAY,

		SmallLastFrame = AV_CODEC_CAP_SMALL_LAST_FRAME,

		SubFrames = AV_CODEC_CAP_SUBFRAMES,

		Experimental = AV_CODEC_CAP_EXPERIMENTAL,

		ChannelConf = AV_CODEC_CAP_CHANNEL_CONF,
		
		FrameThreads = AV_CODEC_CAP_FRAME_THREADS,

		SliceThreads = AV_CODEC_CAP_SLICE_THREADS,

		ParamChange = AV_CODEC_CAP_PARAM_CHANGE,

		AutoThreads = AV_CODEC_CAP_AUTO_THREADS,

		VariableFrameSize = AV_CODEC_CAP_VARIABLE_FRAME_SIZE,

		AvoidProbing = AV_CODEC_CAP_AVOID_PROBING,

		IntraOnly = AV_CODEC_CAP_INTRA_ONLY,

		Lossless = AV_CODEC_CAP_LOSSLESS,

		Hardware = AV_CODEC_CAP_HARDWARE,

		Hybrid = AV_CODEC_CAP_HYBRID,

		ReorderedOpaque = AV_CODEC_CAP_ENCODER_REORDERED_OPAQUE,

		Flush = AV_CODEC_CAP_ENCODER_FLUSH,
	}
}
