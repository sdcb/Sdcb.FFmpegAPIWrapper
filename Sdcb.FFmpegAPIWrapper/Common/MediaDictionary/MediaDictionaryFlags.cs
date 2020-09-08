using System;
using static FFmpeg.AutoGen.ffmpeg;

namespace Sdcb.FFmpegAPIWrapper.Common
{
    [Flags]
    public enum MediaDictionaryReadFlags : int
    {
        /// <summary>
        /// <see cref="AV_DICT_MATCH_CASE"/>
        /// </summary>
        CaseSensitive = AV_DICT_MATCH_CASE,

        /// <summary>
        /// <see cref="AV_DICT_IGNORE_SUFFIX"/>
        /// </summary>
        IgnoreSuffix = 2,
    }

    [Flags]
    public enum MediaDictionarySetFlags : int
    {
        /// <summary>
        /// <see cref="AV_DICT_DONT_OVERWRITE"/>
        /// </summary>
        NoOverwrite = 16,

        /// <summary>
        /// <see cref="AV_DICT_APPEND"/>
        /// </summary>
        AppendValue = AV_DICT_APPEND,

        /// <summary>
        /// <see cref="AV_DICT_MULTIKEY"/>
        /// </summary>
        AllowSameKey = AV_DICT_MULTIKEY,
    }
}
