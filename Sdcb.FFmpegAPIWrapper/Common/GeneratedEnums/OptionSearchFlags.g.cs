// This file was genereated from LINQPad scripts, DO NOT CHANGE DIRECTLY.

using System;
using Sdcb.FFmpegAPIWrapper.Common;
using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;

namespace Sdcb.FFmpegAPIWrapper.Common
{
    [Flags]
    public enum OptionSearchFlags
    {
        None = 0,
        
        /// <summary>
        /// <para>AV_OPT_SEARCH_CHILDREN = (1 &lt;&lt; 0).</para>
        /// <see cref="ffmpeg.AV_OPT_SEARCH_CHILDREN" />
        /// </summary>
        Children = 1,
        
        /// <summary>
        /// <para>AV_OPT_SEARCH_FAKE_OBJ = (1 &lt;&lt; 1).</para>
        /// <see cref="ffmpeg.AV_OPT_SEARCH_FAKE_OBJ" />
        /// </summary>
        FakeObj = 2,
        
    }
}
