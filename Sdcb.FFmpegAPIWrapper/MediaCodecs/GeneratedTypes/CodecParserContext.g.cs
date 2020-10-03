// This file was genereated from LINQPad scripts, DO NOT CHANGE DIRECTLY.

using System;
using Sdcb.FFmpegAPIWrapper.Common;
using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;

namespace Sdcb.FFmpegAPIWrapper.MediaCodecs
{
    /// <summary>
    /// <see cref="AVCodecParserContext" />
    /// </summary>
    public unsafe partial class CodecParserContext : FFmpegSafeObject
    {
        protected AVCodecParserContext* Pointer => this;
        
        public static implicit operator AVCodecParserContext*(CodecParserContext data) => data != null ? (AVCodecParserContext*)data._nativePointer : null;
        
        protected CodecParserContext(AVCodecParserContext* ptr, bool isOwner): base(NativeUtils.NotNull((IntPtr)ptr), isOwner)
        {
        }
        
        public static CodecParserContext FromNative(AVCodecParserContext* ptr, bool isOwner) => new CodecParserContext(ptr, isOwner);
        
        /// <summary>
        /// <see cref="AVCodecParserContext.priv_data" />
        /// </summary>
        public IntPtr PrivateData
        {
            get => (IntPtr)Pointer->priv_data;
            set => Pointer->priv_data = (void*)value;
        }
        
        /// <summary>
        /// <see cref="AVCodecParserContext.parser" />
        /// </summary>
        public AVCodecParser* Parser
        {
            get => Pointer->parser;
            set => Pointer->parser = value;
        }
        
        /// <summary>
        /// <see cref="AVCodecParserContext.frame_offset" />
        /// </summary>
        public long FrameOffset
        {
            get => Pointer->frame_offset;
            set => Pointer->frame_offset = value;
        }
        
        /// <summary>
        /// <see cref="AVCodecParserContext.cur_offset" />
        /// </summary>
        public long CurOffset
        {
            get => Pointer->cur_offset;
            set => Pointer->cur_offset = value;
        }
        
        /// <summary>
        /// <see cref="AVCodecParserContext.next_frame_offset" />
        /// </summary>
        public long NextFrameOffset
        {
            get => Pointer->next_frame_offset;
            set => Pointer->next_frame_offset = value;
        }
        
        /// <summary>
        /// <see cref="AVCodecParserContext.pict_type" />
        /// </summary>
        public int PictureType
        {
            get => Pointer->pict_type;
            set => Pointer->pict_type = value;
        }
        
        /// <summary>
        /// <para>This field is used for proper frame duration computation in lavf.</para>
        /// <para> It signals, how much longer the frame duration of the current frame is compared to normal frame duration.</para>
        /// <see cref="AVCodecParserContext.repeat_pict" />
        /// </summary>
        public int RepeatPicture
        {
            get => Pointer->repeat_pict;
            set => Pointer->repeat_pict = value;
        }
        
        /// <summary>
        /// <see cref="AVCodecParserContext.pts" />
        /// </summary>
        public long Pts
        {
            get => Pointer->pts;
            set => Pointer->pts = value;
        }
        
        /// <summary>
        /// <see cref="AVCodecParserContext.dts" />
        /// </summary>
        public long Dts
        {
            get => Pointer->dts;
            set => Pointer->dts = value;
        }
        
        /// <summary>
        /// <see cref="AVCodecParserContext.last_pts" />
        /// </summary>
        public long LastPts
        {
            get => Pointer->last_pts;
            set => Pointer->last_pts = value;
        }
        
        /// <summary>
        /// <see cref="AVCodecParserContext.last_dts" />
        /// </summary>
        public long LastDts
        {
            get => Pointer->last_dts;
            set => Pointer->last_dts = value;
        }
        
        /// <summary>
        /// <see cref="AVCodecParserContext.fetch_timestamp" />
        /// </summary>
        public int FetchTimestamp
        {
            get => Pointer->fetch_timestamp;
            set => Pointer->fetch_timestamp = value;
        }
        
        /// <summary>
        /// <see cref="AVCodecParserContext.cur_frame_start_index" />
        /// </summary>
        public int CurFrameStartIndex
        {
            get => Pointer->cur_frame_start_index;
            set => Pointer->cur_frame_start_index = value;
        }
        
        /// <summary>
        /// <see cref="AVCodecParserContext.cur_frame_offset" />
        /// </summary>
        public long_array4 CurFrameOffset
        {
            get => Pointer->cur_frame_offset;
            set => Pointer->cur_frame_offset = value;
        }
        
        /// <summary>
        /// <see cref="AVCodecParserContext.cur_frame_pts" />
        /// </summary>
        public long_array4 CurFramePts
        {
            get => Pointer->cur_frame_pts;
            set => Pointer->cur_frame_pts = value;
        }
        
        /// <summary>
        /// <see cref="AVCodecParserContext.cur_frame_dts" />
        /// </summary>
        public long_array4 CurFrameDts
        {
            get => Pointer->cur_frame_dts;
            set => Pointer->cur_frame_dts = value;
        }
        
        /// <summary>
        /// <see cref="AVCodecParserContext.flags" />
        /// </summary>
        public ParserFlag Flags
        {
            get => (ParserFlag)Pointer->flags;
            set => Pointer->flags = (int)value;
        }
        
        /// <summary>
        /// <para>byte offset from starting packet start.</para>
        /// <see cref="AVCodecParserContext.offset" />
        /// </summary>
        public long Offset
        {
            get => Pointer->offset;
            set => Pointer->offset = value;
        }
        
        /// <summary>
        /// <see cref="AVCodecParserContext.cur_frame_end" />
        /// </summary>
        public long_array4 CurFrameEnd
        {
            get => Pointer->cur_frame_end;
            set => Pointer->cur_frame_end = value;
        }
        
        /// <summary>
        /// <para>Set by parser to 1 for key frames and 0 for non-key frames.</para>
        /// <para> It is initialized to -1, so if the parser doesn&#39;t set this flag, old-style fallback using AV_PICTURE_TYPE_I picture type as key frames will be used.</para>
        /// <see cref="AVCodecParserContext.key_frame" />
        /// </summary>
        public int KeyFrame
        {
            get => Pointer->key_frame;
            set => Pointer->key_frame = value;
        }
        
        /// <summary>
        /// <para>Synchronization point for start of timestamp generation.</para>
        /// <see cref="AVCodecParserContext.dts_sync_point" />
        /// </summary>
        public int DtsSyncPoint
        {
            get => Pointer->dts_sync_point;
            set => Pointer->dts_sync_point = value;
        }
        
        /// <summary>
        /// <para>Offset of the current timestamp against last timestamp sync point in units of AVCodecContext.</para>
        /// <para>time_base.</para>
        /// <see cref="AVCodecParserContext.dts_ref_dts_delta" />
        /// </summary>
        public int DtsRefDtsDelta
        {
            get => Pointer->dts_ref_dts_delta;
            set => Pointer->dts_ref_dts_delta = value;
        }
        
        /// <summary>
        /// <para>Presentation delay of current frame in units of AVCodecContext.</para>
        /// <para>time_base.</para>
        /// <see cref="AVCodecParserContext.pts_dts_delta" />
        /// </summary>
        public int PtsDtsDelta
        {
            get => Pointer->pts_dts_delta;
            set => Pointer->pts_dts_delta = value;
        }
        
        /// <summary>
        /// <para>Position of the packet in file.</para>
        /// <see cref="AVCodecParserContext.cur_frame_pos" />
        /// </summary>
        public long_array4 CurFramePos
        {
            get => Pointer->cur_frame_pos;
            set => Pointer->cur_frame_pos = value;
        }
        
        /// <summary>
        /// <para>Byte position of currently parsed frame in stream.</para>
        /// <see cref="AVCodecParserContext.pos" />
        /// </summary>
        public long Pos
        {
            get => Pointer->pos;
            set => Pointer->pos = value;
        }
        
        /// <summary>
        /// <para>Previous frame byte position.</para>
        /// <see cref="AVCodecParserContext.last_pos" />
        /// </summary>
        public long LastPos
        {
            get => Pointer->last_pos;
            set => Pointer->last_pos = value;
        }
        
        /// <summary>
        /// <para>Duration of the current frame.</para>
        /// <para> For audio, this is in units of 1 / AVCodecContext.</para>
        /// <para>sample_rate.</para>
        /// <para> For all other types, this is in units of AVCodecContext.</para>
        /// <para>time_base.</para>
        /// <see cref="AVCodecParserContext.duration" />
        /// </summary>
        public int Duration
        {
            get => Pointer->duration;
            set => Pointer->duration = value;
        }
        
        /// <summary>
        /// <see cref="AVCodecParserContext.field_order" />
        /// </summary>
        public FieldOrder FieldOrder
        {
            get => (FieldOrder)Pointer->field_order;
            set => Pointer->field_order = (AVFieldOrder)value;
        }
        
        /// <summary>
        /// <para>Indicate whether a picture is coded as a frame, top field or bottom field.</para>
        /// <see cref="AVCodecParserContext.picture_structure" />
        /// </summary>
        public AVPictureStructure PictureStructure
        {
            get => Pointer->picture_structure;
            set => Pointer->picture_structure = value;
        }
        
        /// <summary>
        /// <para>Picture number incremented in presentation or output order.</para>
        /// <para> This field may be reinitialized at the first picture of a new sequence.</para>
        /// <see cref="AVCodecParserContext.output_picture_number" />
        /// </summary>
        public int OutputPictureNumber
        {
            get => Pointer->output_picture_number;
            set => Pointer->output_picture_number = value;
        }
        
        /// <summary>
        /// <para>Dimensions of the decoded video intended for presentation.</para>
        /// <see cref="AVCodecParserContext.width" />
        /// </summary>
        public int Width
        {
            get => Pointer->width;
            set => Pointer->width = value;
        }
        
        /// <summary>
        /// <see cref="AVCodecParserContext.height" />
        /// </summary>
        public int Height
        {
            get => Pointer->height;
            set => Pointer->height = value;
        }
        
        /// <summary>
        /// <para>Dimensions of the coded video.</para>
        /// <see cref="AVCodecParserContext.coded_width" />
        /// </summary>
        public int CodedWidth
        {
            get => Pointer->coded_width;
            set => Pointer->coded_width = value;
        }
        
        /// <summary>
        /// <see cref="AVCodecParserContext.coded_height" />
        /// </summary>
        public int CodedHeight
        {
            get => Pointer->coded_height;
            set => Pointer->coded_height = value;
        }
        
        /// <summary>
        /// <para>The format of the coded data, corresponds to enum AVPixelFormat for video and for enum AVSampleFormat for audio.</para>
        /// <see cref="AVCodecParserContext.format" />
        /// </summary>
        public int Format
        {
            get => Pointer->format;
            set => Pointer->format = value;
        }
    }
}
