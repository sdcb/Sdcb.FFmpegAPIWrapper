using System;

namespace Sdcb.FFmpegAPIWrapper.Common
{
    public abstract class FFmpegHandle : IDisposable
    {
        protected IntPtr _handle;

        protected FFmpegHandle(IntPtr handle)
        {
            _handle = handle;
        }

        protected abstract void Close();

        private void Dispose(bool disposing)
        {
            if (_handle != IntPtr.Zero)
            {
                if (disposing)
                {
                    Close();
                }

                _handle = IntPtr.Zero;
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
