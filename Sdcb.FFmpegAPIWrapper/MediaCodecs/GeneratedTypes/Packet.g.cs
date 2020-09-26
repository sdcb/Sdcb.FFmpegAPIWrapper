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
        
        public static implicit operator AVPacket*(Packet data) => (AVPacket*)data._nativePointer;
        
        protected Packet(AVPacket* ptr, bool isOwner): base((IntPtr)ptr, isOwner)
        {
            if (ptr == null)
            {
                throw new ArgumentNullException(nameof(ptr));
            }
        }
        
        public static Packet FromNative(AVPacket* ptr, bool isOwner) => new Packet(ptr, isOwner);
        
        /// <summary>
        /// <para>A reference to the reference-counted buffer where the packet data is stored.</para>
        /// <para> May be NULL, then the packet data is not reference-counted.</para>
        /// <see cref="AVPacket.buf" />
        /// </summary>
        public AVBufferRef* Buf
        {
            get => Pointer->buf;
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
        public int Flags
        {
            get => Pointer->flags;
            set => Pointer->flags = value;
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
        /// <see cref="AVPacket.convergence_duration" />
        /// </summary>
        [Obsolete("Same as the duration field, but as int64_t. This was required for Matroska subtitles, whose duration values could overflow when the duration field was still an int.")]
        public long ConvergenceDuration
        {
            get => Pointer->convergence_duration;
            set => Pointer->convergence_duration = value;
        }
    }
}
