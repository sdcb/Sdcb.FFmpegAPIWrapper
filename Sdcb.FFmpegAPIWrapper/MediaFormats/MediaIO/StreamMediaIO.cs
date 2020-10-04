using FFmpeg.AutoGen;
using System;

namespace Sdcb.FFmpegAPIWrapper.MediaFormats
{
    unsafe internal class StreamMediaIO : MediaIO
    {
        private readonly object _callbackObject;

        public StreamMediaIO(AVIOContext* ptr, bool isOwner, object callbackObject) : base(ptr, isOwner)
        {
            _callbackObject = callbackObject;
        }

        protected override void DisposeNative()
        {
            base.DisposeNative();
            GC.KeepAlive(_callbackObject);
        }
    }
}
