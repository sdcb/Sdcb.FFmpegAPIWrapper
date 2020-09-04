using System;

namespace Sdcb.FFmpegAPIWrapper.Common
{
    public abstract class FFmpegHandle : IDisposable
    {
        protected readonly IntPtr _handle;

        private bool _disposed;

        protected FFmpegHandle(IntPtr handle)
        {
            _handle = handle;
        }

        protected abstract void Close();

        private void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    Close();
                }

                _disposed = true;
            }
        }

        ~FFmpegHandle()
        {
            Dispose(disposing: false);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
