using System;
using Sdcb.FFmpegAPIWrapper.Common;
using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;

namespace Sdcb.FFmpegAPIWrapper.MediaCodecs
{
    public unsafe partial class Packet: FFmpegHandle
    {
        /// <summary>
        /// <see cref="av_packet_alloc"/>
        /// </summary>
        public static Packet Create() => FromNative(av_packet_alloc(), isOwner: true);

        /// <summary>
        /// <see cref="av_packet_clone(AVPacket*)"/>
        /// </summary>
        /// <returns></returns>
        public Packet Clone() => FromNative(av_packet_clone(this), isOwner: true);

        /// <summary>
        /// <see cref="av_init_packet(AVPacket*)"/>
        /// <para>Note: Packet has already initialized in <see cref="Create"/>, call <see cref="Initialize"/> is not required after that.</para>
        /// </summary>
        private void Initialize() => av_init_packet(this);

        /// <summary>
        /// <see cref="av_new_packet(AVPacket*, int)"/>
        /// </summary>
        private void AllocBuffer(int size) => av_new_packet(this, size);

        /// <summary>
        /// <see cref="av_shrink_packet(AVPacket*, int)"/>
        /// </summary>
        public void Shink(int size) => av_shrink_packet(this, size);

        /// <summary>
        /// <see cref=""/>
        /// </summary>
        public void Grow(int growBy) => av_grow_packet(this, growBy);

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
