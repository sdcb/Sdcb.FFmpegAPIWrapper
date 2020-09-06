using FFmpeg.AutoGen;

namespace Sdcb.FFmpegAPIWrapper.Common
{
    /// <summary>
    /// <see cref="AVOptionType"/>
    /// </summary>
    public enum FFmpegOptionType
    {
        Flags = AVOptionType.AV_OPT_TYPE_FLAGS,
        Int = AVOptionType.AV_OPT_TYPE_INT, 
        Int64 = AVOptionType.AV_OPT_TYPE_INT64, 
        Double = AVOptionType.AV_OPT_TYPE_DOUBLE, 
        Float = AVOptionType.AV_OPT_TYPE_FLOAT, 
        String = AVOptionType.AV_OPT_TYPE_STRING, 
        Rational = AVOptionType.AV_OPT_TYPE_RATIONAL, 
        Binary = AVOptionType.AV_OPT_TYPE_BINARY, 
        Dict = AVOptionType.AV_OPT_TYPE_DICT, 
        Uint64 = AVOptionType.AV_OPT_TYPE_UINT64, 
        Const = AVOptionType.AV_OPT_TYPE_CONST, 
        ImageSize = AVOptionType.AV_OPT_TYPE_IMAGE_SIZE, 
        PixelFormat = AVOptionType.AV_OPT_TYPE_PIXEL_FMT, 
        SampleFormat = AVOptionType.AV_OPT_TYPE_SAMPLE_FMT, 
        VideoRate = AVOptionType.AV_OPT_TYPE_VIDEO_RATE, 
        Duration = AVOptionType.AV_OPT_TYPE_DURATION, 
        Color = AVOptionType.AV_OPT_TYPE_COLOR, 
        ChannelLayout = AVOptionType.AV_OPT_TYPE_CHANNEL_LAYOUT, 
        Bool = AVOptionType.AV_OPT_TYPE_BOOL
    }
}