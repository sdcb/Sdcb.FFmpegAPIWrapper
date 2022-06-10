// This file was genereated from LINQPad scripts, DO NOT CHANGE DIRECTLY.

using System;
using Sdcb.FFmpegAPIWrapper.Common;
using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;

namespace Sdcb.FFmpegAPIWrapper.MediaCodecs
{
    /// <summary>
    /// <see cref="AVPacketSideData" />
    /// </summary>
    public unsafe partial struct PacketSideData
    {
        private AVPacketSideData* _ptr;
        
        public static implicit operator AVPacketSideData*(PacketSideData? data)
            => data.HasValue ? (AVPacketSideData*)data.Value._ptr : null;
        
        private PacketSideData(AVPacketSideData* ptr)
        {
            if (ptr == null)
            {
                throw new ArgumentNullException(nameof(ptr));
            }
            _ptr = ptr;
        }
        
        public static PacketSideData FromNative(AVPacketSideData* ptr) => new PacketSideData(ptr);
        public static PacketSideData FromNative(IntPtr ptr) => new PacketSideData((AVPacketSideData*)ptr);
        internal static PacketSideData? FromNativeOrNull(AVPacketSideData* ptr)
            => ptr != null ? new PacketSideData?(new PacketSideData(ptr)) : null;
        
        /// <summary>
        /// <see cref="AVPacketSideData.data" />
        /// </summary>
        public IntPtr Data
        {
            get => (IntPtr)_ptr->data;
            set => _ptr->data = (byte*)value;
        }
        
        /// <summary>
        /// <see cref="AVPacketSideData.size" />
        /// </summary>
        public int Size
        {
            get => _ptr->size;
            set => _ptr->size = value;
        }
        
        /// <summary>
        /// <see cref="AVPacketSideData.type" />
        /// </summary>
        public PacketSideDataType Type
        {
            get => (PacketSideDataType)_ptr->type;
            set => _ptr->type = (AVPacketSideDataType)value;
        }
    }
}
