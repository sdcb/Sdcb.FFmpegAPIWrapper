using System;
using Sdcb.FFmpegAPIWrapper.Common;
using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;
using Sdcb.FFmpegAPIWrapper.MediaCodecs;

namespace Sdcb.FFmpegAPIWrapper.MediaFormats
{
    public unsafe partial struct MediaStream
    {
        /// <summary>
        /// <see cref="av_stream_add_side_data(AVStream*, AVPacketSideDataType, byte*, ulong)"/>
        /// </summary>
        public void AddSideData(PacketSideDataType type, DataPointer data) => 
            av_stream_add_side_data(this, (AVPacketSideDataType)type, (byte*)data.Pointer, (ulong)data.Length).ThrowIfError();

        /// <summary>
        /// <see cref="av_stream_new_side_data(AVStream*, AVPacketSideDataType, int)"/>
        /// </summary>
        public IntPtr NewSideData(PacketSideDataType type, int size) =>
            NativeUtils.NotNull((IntPtr)av_stream_new_side_data(this, (AVPacketSideDataType)type, size));

        /// <summary>
        /// <see cref="av_stream_get_side_data(AVStream*, AVPacketSideDataType, int*)"/>
        /// </summary>
        public DataPointer GetSideData(PacketSideDataType type)
        {
            int size;
            return new DataPointer(av_stream_get_side_data(this, (AVPacketSideDataType)type, &size), size);
        }

        /// <summary>
        /// <see cref="av_index_search_timestamp(AVStream*, long, int)"/>
        /// </summary>
        public int SearchTimestamp(long timestamp, MediaSeek flags = MediaSeek.Backward)
            => av_index_search_timestamp(this, timestamp, (int)flags);
    }
}
