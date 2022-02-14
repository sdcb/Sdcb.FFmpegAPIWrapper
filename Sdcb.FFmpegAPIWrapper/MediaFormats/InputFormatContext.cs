using System;
using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;

namespace Sdcb.FFmpegAPIWrapper.MediaFormats
{
    internal unsafe partial class InputFormatContext : FormatContext
    {
        internal protected InputFormatContext(AVFormatContext* ptr, bool isOwner) : base(ptr, isOwner)
        {
        }

        /// <summary>
        /// <see cref="avformat_close_input(AVFormatContext**)"/>
        /// </summary>
        public void CloseInput()
        {
            AVFormatContext* ptr = this;
            avformat_close_input(&ptr);
            _nativePointer = (IntPtr)ptr;
        }

        protected override void DisposeNative() => CloseInput();
    }
}
