// This file was genereated from LINQPad scripts, DO NOT CHANGE DIRECTLY.

using System;
using Sdcb.FFmpegAPIWrapper.Common;
using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;

namespace Sdcb.FFmpegAPIWrapper.MediaCodecs
{
    /// <summary>See AV_PKT_FLAG_* </summary>
    [Flags]
    public enum PacketFlag
    {
        None = 0,
        
        /// <summary>
        /// <para>AV_PKT_FLAG_KEY = 0x0001.</para>
        /// <see cref="ffmpeg.AV_PKT_FLAG_KEY" />
        /// </summary>
        Key = 1,
        
        /// <summary>
        /// <para>AV_PKT_FLAG_CORRUPT = 0x0002.</para>
        /// <see cref="ffmpeg.AV_PKT_FLAG_CORRUPT" />
        /// </summary>
        Corrupt = 2,
        
        /// <summary>
        /// <para>AV_PKT_FLAG_DISCARD = 0x0004.</para>
        /// <see cref="ffmpeg.AV_PKT_FLAG_DISCARD" />
        /// </summary>
        Discard = 4,
        
        /// <summary>
        /// <para>AV_PKT_FLAG_TRUSTED = 0x0008.</para>
        /// <see cref="ffmpeg.AV_PKT_FLAG_TRUSTED" />
        /// </summary>
        Trusted = 8,
        
        /// <summary>
        /// <para>AV_PKT_FLAG_DISPOSABLE = 0x0010.</para>
        /// <see cref="ffmpeg.AV_PKT_FLAG_DISPOSABLE" />
        /// </summary>
        Disposable = 16,
        
    }
}
