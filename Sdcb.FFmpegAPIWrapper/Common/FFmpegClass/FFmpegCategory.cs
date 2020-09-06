using FFmpeg.AutoGen;

namespace Sdcb.FFmpegAPIWrapper.Common
{
    /// <summary>
    /// <see cref="AVClassCategory"/>
    /// </summary>
    public enum FFmpegCategory
    {
        NA = AVClassCategory.AV_CLASS_CATEGORY_NA, 
        Input = AVClassCategory.AV_CLASS_CATEGORY_INPUT, 
        Output = AVClassCategory.AV_CLASS_CATEGORY_OUTPUT, 
        Muxer = AVClassCategory.AV_CLASS_CATEGORY_MUXER, 
        Demuxer = AVClassCategory.AV_CLASS_CATEGORY_DEMUXER, 
        Encoder = AVClassCategory.AV_CLASS_CATEGORY_ENCODER, 
        Decoder = AVClassCategory.AV_CLASS_CATEGORY_DECODER, 
        Filter = AVClassCategory.AV_CLASS_CATEGORY_FILTER, 
        BitstreamFilter = AVClassCategory.AV_CLASS_CATEGORY_BITSTREAM_FILTER, 
        Swscaler = AVClassCategory.AV_CLASS_CATEGORY_SWSCALER, 
        Swresampler = AVClassCategory.AV_CLASS_CATEGORY_SWRESAMPLER, 
        DeviceVideoOutput = AVClassCategory.AV_CLASS_CATEGORY_DEVICE_VIDEO_OUTPUT, 
        DeviceVideoInput = AVClassCategory.AV_CLASS_CATEGORY_DEVICE_VIDEO_INPUT, 
        DeviceAudioOutput = AVClassCategory.AV_CLASS_CATEGORY_DEVICE_AUDIO_OUTPUT, 
        DeviceAudioInput = AVClassCategory.AV_CLASS_CATEGORY_DEVICE_AUDIO_INPUT, 
        DeviceOutput = AVClassCategory.AV_CLASS_CATEGORY_DEVICE_OUTPUT, 
        DeviceInput = AVClassCategory.AV_CLASS_CATEGORY_DEVICE_INPUT, 
        NotAbi = AVClassCategory.AV_CLASS_CATEGORY_NB, 
    }
}
