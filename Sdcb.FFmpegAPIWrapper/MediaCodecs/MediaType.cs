using FFmpeg.AutoGen;

namespace Sdcb.FFmpegAPIWrapper.MediaCodecs
{
    public enum MediaType
	{
		Unknown = AVMediaType.AVMEDIA_TYPE_UNKNOWN,
		Video = AVMediaType.AVMEDIA_TYPE_VIDEO,
		Audio = AVMediaType.AVMEDIA_TYPE_AUDIO,
		Data = AVMediaType.AVMEDIA_TYPE_DATA,
		Subtitle = AVMediaType.AVMEDIA_TYPE_SUBTITLE,
		Attachment = AVMediaType.AVMEDIA_TYPE_ATTACHMENT,
		NB = AVMediaType.AVMEDIA_TYPE_NB,
	}
}
