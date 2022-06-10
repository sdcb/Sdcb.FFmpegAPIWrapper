using System;
using Sdcb.FFmpegAPIWrapper.Common;
using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;

namespace Sdcb.FFmpegAPIWrapper.MediaCodecs
{
    public unsafe partial class Packet: FFmpegSafeObject
    {
        /// <summary>
        /// <see cref="av_packet_alloc"/>
        /// </summary>
        public Packet() : base(NativeUtils.NotNull((IntPtr)av_packet_alloc()), isOwner: true)
        {
        }

        /// <summary>
        /// <see cref="av_packet_clone(AVPacket*)"/>
        /// </summary>
        /// <returns></returns>
        public Packet Clone() => FromNative(av_packet_clone(this), isOwner: true);

        /// <summary>
        /// Initialize optional fields of a packet with default values.
        /// This function is deprecated. Once it's removed, sizeof(AVPacket) will not be a part of the ABI anymore.
        /// <see cref="av_init_packet(AVPacket*)"/>
        /// </summary>
        [Obsolete]
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
        /// <see cref="av_grow_packet(AVPacket*, int)"/>
        /// </summary>
        public void Grow(int growBy) => av_grow_packet(this, growBy);


        /// <summary>
        /// <see cref="av_packet_from_data(AVPacket*, byte*, int)"/>
        /// </summary>
        public void FromData(Span<byte> data)
        {
            fixed(byte* ptr = data)
            {
                av_packet_from_data(this, ptr, data.Length).ThrowIfError();
            }
        }

        /// <summary>
        /// <see cref="av_packet_new_side_data(AVPacket*, AVPacketSideDataType, int)"/>
        /// </summary>
        public IntPtr NewSideData(PacketSideDataType type, int size) => (IntPtr)av_packet_new_side_data(this, (AVPacketSideDataType)type, size);

        /// <summary>
        /// <see cref="av_packet_add_side_data(AVPacket*, AVPacketSideDataType, byte*, ulong)"/>
        /// </summary>\
        public void AddSideData(PacketSideDataType type, Span<byte> data)
        {
            fixed(byte* ptr = data)
            {
                av_packet_add_side_data(this, (AVPacketSideDataType)type, ptr, (ulong)data.Length).ThrowIfError();
            }
        }

        /// <summary>
        /// <see cref="av_packet_shrink_side_data(AVPacket*, AVPacketSideDataType, int)"/>
        /// </summary>
        public void ShinkSideData(PacketSideDataType type, int size) => av_packet_shrink_side_data(this, (AVPacketSideDataType)type, size).ThrowIfError();

        /// <summary>
        /// <see cref="av_packet_get_side_data(AVPacket*, AVPacketSideDataType, int*)"/>
        /// </summary>
        public DataPointer GetSideData(PacketSideDataType type)
        {
            int size;
            return new DataPointer(av_packet_get_side_data(this, (AVPacketSideDataType)type, &size), size);
        }

        /// <summary>
        /// <see cref="av_packet_free_side_data(AVPacket*)"/>
        /// </summary>
        public void FreeSideData() => av_packet_free_side_data(this);

        /// <summary>
        /// <see cref="av_packet_ref(AVPacket*, AVPacket*)"/>
        /// </summary>
        public void Reference(Packet dest) => av_packet_ref(dest, this);

        /// <summary>
        /// <see cref="av_packet_unref(AVPacket*)"/>
        /// </summary>
        public void Unreference() => av_packet_unref(this);

        /// <summary>
        /// <see cref="av_packet_move_ref(AVPacket*, AVPacket*)"/>
        /// </summary>
        public void MoveReference(Packet dest) => av_packet_move_ref(dest, this);

        /// <summary>
        /// <see cref="av_packet_copy_props(AVPacket*, AVPacket*)"/>
        /// </summary>
        public void CopyPropsFrom(Packet source) => av_packet_copy_props(this, source);

        /// <summary>
        /// <see cref="av_packet_make_refcounted(AVPacket*)"/>
        /// </summary>
        public void MakeReferenceCounted() => av_packet_make_refcounted(this).ThrowIfError();

        /// <summary>
        /// <see cref="av_packet_make_writable(AVPacket*)"/>
        /// </summary>
        public void MakeWritable() => av_packet_make_writable(this).ThrowIfError();

        /// <summary>
        /// <see cref="av_packet_rescale_ts(AVPacket*, AVRational, AVRational)"/>
        /// </summary>
        public void RescaleTimestamp(MediaRational source, MediaRational dest) => av_packet_rescale_ts(this, source, dest);

        /// <summary>
        /// <see cref="av_packet_free(AVPacket**)"/>
        /// </summary>
        public void Free()
        {
            AVPacket* ptr = this;
            av_packet_free(&ptr);
            _nativePointer = (IntPtr)ptr;
        }

        public Span<byte> AsSpan() => new Span<byte>((void*)Data, Size);

        protected override void DisposeNative() => Free();

        /// <summary>
        /// <see cref="av_packet_side_data_name(AVPacketSideDataType)"/>
        /// </summary>
        public static string GetSideDataName(PacketSideDataType type) => av_packet_side_data_name((AVPacketSideDataType)type);

        /// <summary>
        /// <see cref="av_packet_pack_dictionary(AVDictionary*, int*)"/>
        /// </summary>
        public static DataPointer PackDirectory(MediaDictionary dict)
        {
            int size;
            return new DataPointer(av_packet_pack_dictionary(dict, &size), (int)size);
        }

        /// <summary>
        /// <see cref="av_packet_unpack_dictionary(byte*, int, AVDictionary**)"/>
        /// </summary>
        public static MediaDictionary UnpackDictionary(Span<byte> data)
        {
            AVDictionary* dict = null;
            fixed(byte* ptr = data)
            {
                av_packet_unpack_dictionary(ptr, data.Length, &dict).ThrowIfError();
            }
            return MediaDictionary.FromNative(dict, isOwner: true);
        }
    }
}
