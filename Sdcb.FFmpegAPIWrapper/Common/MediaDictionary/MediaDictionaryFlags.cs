using System;
using static FFmpeg.AutoGen.ffmpeg;

namespace Sdcb.FFmpegAPIWrapper.Common
{
    [Flags]
    public enum MediaDictionaryFlags : int
    {
        /// <summary>
        /// <see cref="AV_DICT_MATCH_CASE"/>
        /// </summary>
        CaseSensitive = AV_DICT_MATCH_CASE,

        /// <summary>
        /// <see cref="AV_DICT_IGNORE_SUFFIX"/>
        /// </summary>
        IgnoreSuffix = 2,

        //AV_DICT_DONT_STRDUP_KEY = 4, // Not suppord in managed code
        //AV_DICT_DONT_STRDUP_VAL = 8, // Not suppord in managed code

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
