using System;
using System.Collections.Generic;
using System.Text;
using static FFmpeg.AutoGen.ffmpeg;

namespace Sdcb.FFmpegAPIWrapper.MediaCodecs
{
    public enum CodecResult
    {
        Success = 0, 
        Again = 1, 
        EOF = 2, 
    }
}