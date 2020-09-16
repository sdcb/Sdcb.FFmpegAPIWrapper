// This file was genereated from LINQPad scripts, DO NOT CHANGE DIRECTLY.

using System;
using Sdcb.FFmpegAPIWrapper.Common;
using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;

namespace Sdcb.FFmpegAPIWrapper.MediaCodecs
{
    /// <summary>
    /// <see cref="AVDiscard" />
    /// </summary>
    public enum MediaDiscard
    {
        /// <summary>
        /// <para>discard useless packets like 0 size packets in avi.</para>
        /// <see cref="AVDiscard.AVDISCARD_DEFAULT" />
        /// </summary>
        Default = 0,
        
        /// <summary>
        /// <para>discard all non reference.</para>
        /// <see cref="AVDiscard.AVDISCARD_NONREF" />
        /// </summary>
        Nonref = 8,
        
        /// <summary>
        /// <para>discard all bidirectional frames.</para>
        /// <see cref="AVDiscard.AVDISCARD_BIDIR" />
        /// </summary>
        Bidir = 16,
        
        /// <summary>
        /// <para>discard all non intra frames.</para>
        /// <see cref="AVDiscard.AVDISCARD_NONINTRA" />
        /// </summary>
        Nonintra = 24,
        
        /// <summary>
        /// <para>discard all frames except keyframes.</para>
        /// <see cref="AVDiscard.AVDISCARD_NONKEY" />
        /// </summary>
        Nonkey = 32,
        
        /// <summary>
        /// <para>discard all.</para>
        /// <see cref="AVDiscard.AVDISCARD_ALL" />
        /// </summary>
        All = 48,
        
        /// <summary>
        /// <para>discard nothing.</para>
        /// <see cref="AVDiscard.AVDISCARD_NONE" />
        /// </summary>
        None = -16,
    }
}
