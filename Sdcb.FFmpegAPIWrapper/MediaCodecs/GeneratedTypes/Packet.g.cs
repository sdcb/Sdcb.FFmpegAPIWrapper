// This file was genereated from LINQPad scripts, DO NOT CHANGE DIRECTLY.

using System;
using Sdcb.FFmpegAPIWrapper.Common;
using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;

namespace Sdcb.FFmpegAPIWrapper.MediaCodecs
{
    /// <summary>
    /// <para>This structure stores compressed data.</para>
    /// <para> It is typically exported by demuxers and then passed as input to decoders, or received as output from encoders and then passed to muxers.</para>
    /// <see cref="AVPacket" />
    /// </summary>
    public unsafe partial class Packet : FFmpegSafeObject
    {
        protected AVPacket* Pointer => this;
        
        public static implicit operator AVPacket*(Packet data) => data != null ? (AVPacket*)data._nativePointer : null;
        
        protected Packet(AVPacket* ptr, bool isOwner): base(NativeUtils.NotNull((IntPtr)ptr), isOwner)
        {
        }
        
        public static Packet FromNative(AVPacket* ptr, bool isOwner) => new Packet(ptr, isOwner);
        
        /// <summary>
        /// <para>A reference to the reference-counted buffer where the packet data is stored.</para>
        /// <para> May be NULL, then the packet data is not reference-counted.</para>
        /// <see cref="AVPacket.buf" />
        /// </summary>
        public BufferReference Buf
        {
            get => BufferReference.FromNative(Pointer->buf, isOwner: false);
            set => Pointer->buf = value;
        }
        
        /// <summary>
        /// <para>Presentation timestamp in AVStream-&gt;time_base units; the time at which the decompressed packet will be presented to the user.</para>
        /// <para> Can be AV_NOPTS_VALUE if it is not stored in the file.</para>
        /// <para> pts MUST be larger or equal to dts as presentation cannot happen before decompression, unless one wants to view hex dumps.</para>
        /// <para> Some formats misuse the terms dts and pts/cts to mean something different.</para>
        /// <para> Such timestamps must be converted to true pts/dts before they are stored in AVPacket.</para>
        /// <see cref="AVPacket.pts" />
        /// </summary>
        public long Pts
        {
            get => Pointer->pts;
            set => Pointer->pts = value;
        }
        
        /// <summary>
        /// <para>Decompression timestamp in AVStream-&gt;time_base units; the time at which the packet is decompressed.</para>
        /// <para> Can be AV_NOPTS_VALUE if it is not stored in the file.</para>
        /// <see cref="AVPacket.dts" />
        /// </summary>
        public long Dts
        {
            get => Pointer->dts;
            set => Pointer->dts = value;
        }
        
        /// <summary>
        /// <see cref="AVPacket.data" />
        /// </summary>
        public IntPtr Data
        {
            get => (IntPtr)Pointer->data;
            set => Pointer->data = (byte*)value;
        }
        
        /// <summary>
        /// <see cref="AVPacket.size" />
        /// </summary>
        public int Size
        {
            get => Pointer->size;
            set => Pointer->size = value;
        }
        
        /// <summary>
        /// <see cref="AVPacket.stream_index" />
        /// </summary>
        public int StreamIndex
        {
            get => Pointer->stream_index;
            set => Pointer->stream_index = value;
        }
        
        /// <summary>
        /// <para>A combination of AV_PKT_FLAG values.</para>
        /// <see cref="AVPacket.flags" />
        /// </summary>
        public PacketFlag Flags
        {
            get => (PacketFlag)Pointer->flags;
            set => Pointer->flags = (int)value;
        }
        
        /// <summary>
        /// <para>Additional packet data that can be provided by the container.</para>
        /// <para> Packet can contain several types of side information.</para>
        /// <see cref="AVPacket.side_data" />
        /// </summary>
        public AVPacketSideData* SideData
        {
            get => Pointer->side_data;
            set => Pointer->side_data = value;
        }
        
        /// <summary>
        /// <see cref="AVPacket.side_data_elems" />
        /// </summary>
        public int SideDataElems
        {
            get => Pointer->side_data_elems;
            set => Pointer->side_data_elems = value;
        }
        
        /// <summary>
        /// <para>Duration of this packet in AVStream-&gt;time_base units, 0 if unknown.</para>
        /// <para> Equals next_pts - this_pts in presentation order.</para>
        /// <see cref="AVPacket.duration" />
        /// </summary>
        public long Duration
        {
            get => Pointer->duration;
            set => Pointer->duration = value;
        }
        
        /// <summary>
        /// <para>byte position in stream, -1 if unknown.</para>
        /// <see cref="AVPacket.pos" />
        /// </summary>
        public long Pos
        {
            get => Pointer->pos;
            set => Pointer->pos = value;
        }
        
        /// <summary>
        /// <para>for some private data of the user.</para>
        /// <see cref="AVPacket.opaque" />
        /// </summary>
        public IntPtr Opaque
        {
            get => (IntPtr)Pointer->opaque;
            set => Pointer->opaque = (void*)value;
        }
        
        /// <summary>
        /// <para>AVBufferRef for free use by the API user.</para>
        /// <para> FFmpeg will never check the contents of the buffer ref.</para>
        /// <para> FFmpeg calls av_buffer_unref() on it when the packet is unreferenced.</para>
        /// <para> av_packet_copy_props() calls create a new reference with av_buffer_ref() for the target packet&#39;s opaque_ref field.</para>
        /// <see cref="AVPacket.opaque_ref" />
        /// </summary>
        public BufferReference OpaqueRef
        {
            get => BufferReference.FromNative(Pointer->opaque_ref, isOwner: false);
            set => Pointer->opaque_ref = value;
        }
        
        /// <summary>
        /// <para>Time base of the packet&#39;s timestamps.</para>
        /// <para> In the future, this field may be set on packets output by encoders or demuxers, but its value will be by default ignored on input to decoders or muxers.</para>
        /// <see cref="AVPacket.time_base" />
        /// </summary>
        public MediaRational TimeBase
        {
            get => Pointer->time_base;
            set => Pointer->time_base = value;
        }
    }
}
