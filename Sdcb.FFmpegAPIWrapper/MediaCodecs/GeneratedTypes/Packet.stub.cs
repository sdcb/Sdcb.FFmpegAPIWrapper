using System;
using Sdcb.FFmpegAPIWrapper.Common;
using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;

namespace Sdcb.FFmpegAPIWrapper.MediaCodecs
{
    public unsafe partial class Packet: FFmpegHandle
    {
        /// <summary>
        /// <see cref="av_packet_free(AVPacket**)"/>
        /// </summary>
        public override void Close()
        {
            AVPacket* ptr = this;
            av_packet_free(&ptr);
            
            _handle = (IntPtr)ptr;
        }
    }
}
