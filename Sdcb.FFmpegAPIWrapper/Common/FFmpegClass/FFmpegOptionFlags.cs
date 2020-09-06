using static FFmpeg.AutoGen.ffmpeg;
using System;

namespace Sdcb.FFmpegAPIWrapper.Common
{
    /// <summary>
    /// AV_OPT_FLAG_
    /// </summary>
    [Flags]
    public enum FFmpegOptionFlags
    {
        /// <summary>
        /// <see cref="AV_OPT_FLAG_ENCODING_PARAM"/>
        /// </summary>
        Encoding = AV_OPT_FLAG_ENCODING_PARAM, 

        /// <summary>
        /// <see cref="AV_OPT_FLAG_DECODING_PARAM"/>
        /// </summary>
        Decoding = AV_OPT_FLAG_DECODING_PARAM, 

        /// <summary>
        /// <see cref="AV_OPT_FLAG_AUDIO_PARAM"/>
        /// </summary>
        Audio = AV_OPT_FLAG_AUDIO_PARAM,

        /// <summary>
        /// <see cref="AV_OPT_FLAG_VIDEO_PARAM"/>
        /// </summary>
        Video = AV_OPT_FLAG_VIDEO_PARAM,

        /// <summary>
        /// <see cref="AV_OPT_FLAG_SUBTITLE_PARAM"/>
        /// </summary>
        Subtitle = AV_OPT_FLAG_SUBTITLE_PARAM,

        /// <summary>
        /// <see cref="AV_OPT_FLAG_EXPORT"/>
        /// </summary>
        Export = AV_OPT_FLAG_EXPORT,

        /// <summary>
        /// <see cref="AV_OPT_FLAG_READONLY"/>
        /// </summary>
        Readonly = AV_OPT_FLAG_READONLY,

        /// <summary>
        /// <see cref="AV_OPT_FLAG_BSF_PARAM"/>
        /// </summary>
        Bsf = AV_OPT_FLAG_BSF_PARAM,

        /// <summary>
        /// <see cref="AV_OPT_FLAG_RUNTIME_PARAM"/>
        /// </summary>
        Runtime = AV_OPT_FLAG_RUNTIME_PARAM,

        /// <summary>
        /// <see cref="AV_OPT_FLAG_FILTERING_PARAM"/>
        /// </summary>
        Filtering = AV_OPT_FLAG_FILTERING_PARAM,

        /// <summary>
        /// <see cref="AV_OPT_FLAG_DEPRECATED"/>
        /// </summary>
        Deprecated = AV_OPT_FLAG_DEPRECATED,

        /// <summary>
        /// <see cref="AV_OPT_FLAG_CHILD_CONSTS"/>
        /// </summary>
        ChildConsts = AV_OPT_FLAG_CHILD_CONSTS,
    }
}
