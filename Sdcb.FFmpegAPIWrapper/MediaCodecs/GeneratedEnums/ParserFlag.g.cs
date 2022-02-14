// This file was genereated from LINQPad scripts, DO NOT CHANGE DIRECTLY.

using System;
using Sdcb.FFmpegAPIWrapper.Common;
using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;

namespace Sdcb.FFmpegAPIWrapper.MediaCodecs
{
    /// <summary>See PARSER_FLAG_* </summary>
    [Flags]
    public enum ParserFlag
    {
        None = 0,
        
        /// <summary>
        /// <para>PARSER_FLAG_COMPLETE_FRAMES = 0x1.</para>
        /// <see cref="ffmpeg.PARSER_FLAG_COMPLETE_FRAMES" />
        /// </summary>
        CompleteFrames = 1,
        
        /// <summary>
        /// <para>PARSER_FLAG_ONCE = 0x2.</para>
        /// <see cref="ffmpeg.PARSER_FLAG_ONCE" />
        /// </summary>
        Once = 2,
        
        /// <summary>
        /// <para>PARSER_FLAG_FETCHED_OFFSET = 0x4.</para>
        /// <see cref="ffmpeg.PARSER_FLAG_FETCHED_OFFSET" />
        /// </summary>
        FetchedOffset = 4,
        
        /// <summary>
        /// <para>PARSER_FLAG_USE_CODEC_TS = 0x1000.</para>
        /// <see cref="ffmpeg.PARSER_FLAG_USE_CODEC_TS" />
        /// </summary>
        UseCodecTs = 4096,
        
    }
}
