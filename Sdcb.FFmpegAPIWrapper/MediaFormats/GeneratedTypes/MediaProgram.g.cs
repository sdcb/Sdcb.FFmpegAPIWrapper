// This file was genereated from LINQPad scripts, DO NOT CHANGE DIRECTLY.

using System;
using Sdcb.FFmpegAPIWrapper.Common;
using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;
using Sdcb.FFmpegAPIWrapper.MediaCodecs;

namespace Sdcb.FFmpegAPIWrapper.MediaFormats
{
    /// <summary>
    /// <para>New fields can be added to the end with minor version bumps.</para>
    /// <para> Removal, reordering and changes to existing fields require a major version bump.</para>
    /// <para> sizeof(AVProgram) must not be used outside libav*.</para>
    /// <see cref="AVProgram" />
    /// </summary>
    public unsafe partial struct MediaProgram
    {
        private AVProgram* _ptr;
        
        public static implicit operator AVProgram*(MediaProgram? data)
            => data.HasValue ? (AVProgram*)data.Value._ptr : null;
        
        private MediaProgram(AVProgram* ptr)
        {
            if (ptr == null)
            {
                throw new ArgumentNullException(nameof(ptr));
            }
            _ptr = ptr;
        }
        
        public static MediaProgram FromNative(AVProgram* ptr) => new MediaProgram(ptr);
        
        /// <summary>
        /// <see cref="AVProgram.id" />
        /// </summary>
        public int Id
        {
            get => _ptr->id;
            set => _ptr->id = value;
        }
        
        /// <summary>
        /// <see cref="AVProgram.flags" />
        /// </summary>
        public int Flags
        {
            get => _ptr->flags;
            set => _ptr->flags = value;
        }
        
        /// <summary>
        /// <para>selects which program to discard and which to feed to the caller.</para>
        /// <see cref="AVProgram.discard" />
        /// </summary>
        public MediaDiscard Discard
        {
            get => (MediaDiscard)_ptr->discard;
            set => _ptr->discard = (AVDiscard)value;
        }
        
        /// <summary>
        /// <see cref="AVProgram.stream_index" />
        /// </summary>
        public uint* StreamIndex
        {
            get => _ptr->stream_index;
            set => _ptr->stream_index = value;
        }
        
        /// <summary>
        /// <see cref="AVProgram.nb_stream_indexes" />
        /// </summary>
        public uint NbStreamIndexes
        {
            get => _ptr->nb_stream_indexes;
            set => _ptr->nb_stream_indexes = value;
        }
        
        /// <summary>
        /// <see cref="AVProgram.metadata" />
        /// </summary>
        public MediaDictionary Metadata
        {
            get => MediaDictionary.FromNative(_ptr->metadata, isOwner: false);
            set => _ptr->metadata = value;
        }
        
        /// <summary>
        /// <see cref="AVProgram.program_num" />
        /// </summary>
        public int ProgramNum
        {
            get => _ptr->program_num;
            set => _ptr->program_num = value;
        }
        
        /// <summary>
        /// <see cref="AVProgram.pmt_pid" />
        /// </summary>
        public int PmtPid
        {
            get => _ptr->pmt_pid;
            set => _ptr->pmt_pid = value;
        }
        
        /// <summary>
        /// <see cref="AVProgram.pcr_pid" />
        /// </summary>
        public int PcrPid
        {
            get => _ptr->pcr_pid;
            set => _ptr->pcr_pid = value;
        }
        
        /// <summary>
        /// <see cref="AVProgram.pmt_version" />
        /// </summary>
        public int PmtVersion
        {
            get => _ptr->pmt_version;
            set => _ptr->pmt_version = value;
        }
        
        /// <summary>
        /// <para>*************************************************************** All fields below this line are not part of the public API.</para>
        /// <para> They may not be used outside of libavformat and can be changed and removed at will.</para>
        /// <para> New public fields should be added right above.</para>
        /// <para> ****************************************************************.</para>
        /// <see cref="AVProgram.start_time" />
        /// </summary>
        public long StartTime
        {
            get => _ptr->start_time;
            set => _ptr->start_time = value;
        }
        
        /// <summary>
        /// <see cref="AVProgram.end_time" />
        /// </summary>
        public long EndTime
        {
            get => _ptr->end_time;
            set => _ptr->end_time = value;
        }
        
        /// <summary>
        /// <para>reference dts for wrap detection.</para>
        /// <see cref="AVProgram.pts_wrap_reference" />
        /// </summary>
        public long PtsWrapReference
        {
            get => _ptr->pts_wrap_reference;
            set => _ptr->pts_wrap_reference = value;
        }
        
        /// <summary>
        /// <para>behavior on wrap detection.</para>
        /// <see cref="AVProgram.pts_wrap_behavior" />
        /// </summary>
        public int PtsWrapBehavior
        {
            get => _ptr->pts_wrap_behavior;
            set => _ptr->pts_wrap_behavior = value;
        }
    }
}
