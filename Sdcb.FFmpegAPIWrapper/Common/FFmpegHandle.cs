using System;

namespace Sdcb.FFmpegAPIWrapper.Common
{
    public abstract class FFmpegHandle : IDisposable
    {
        protected IntPtr _handle;
        protected bool _isOwner;

        protected FFmpegHandle(IntPtr handle, bool isOwner)
        {
            _handle = handle;
            _isOwner = isOwner;
        }

        public abstract void Close();

        private void Dispose(bool disposing)
        {
            if (_handle != IntPtr.Zero)
            {
                if (_isOwner)
                {
                    if (!disposing)
                    {
                        LogMemoryLeakWarning?.Invoke($"Warning: potential memory leak: [0x{_handle:X}]");
                    }
                    Close();
                }

                _handle = IntPtr.Zero;
            }
        }

        ~FFmpegHandle() => Dispose(disposing: false);

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        public static Action<string> LogMemoryLeakWarning;
    }
}
