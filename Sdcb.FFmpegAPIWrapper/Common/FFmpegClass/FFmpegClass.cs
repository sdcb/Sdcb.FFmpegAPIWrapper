using FFmpeg.AutoGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace Sdcb.FFmpegAPIWrapper.Common
{
    /// <summary>
    /// <see cref="AVClass"/>
    /// </summary>
    public unsafe class FFmpegClass
    {
        private readonly AVClass* _p;

        private FFmpegClass(AVClass* p)
        {
            if (p == null) throw new ArgumentNullException(nameof(p));
            _p = p; 
        }

        public static FFmpegClass FromNative(AVClass* p)
        {
            if (p == null) return null;
            return new FFmpegClass(p);
        }

        public static implicit operator AVClass*(FFmpegClass data) => data._p;

        public string Name => Marshal.PtrToStringUTF8((IntPtr)_p->class_name);

        public string Version => _p->version.ToFourCC();

        public FFmpegCategory Category => (FFmpegCategory)_p->category;

        public IEnumerable<FFmpegOption> Options => ReadSequence(
            p            : (IntPtr)_p->option, 
            unitSize     : sizeof(AVOption), 
            exitCondition: _p => ((AVOption*)_p)->name == null, 
            valGetter    : _p => new FFmpegOption((AVOption*)_p));

        private static IEnumerable<T> ReadSequence<T>(IntPtr p, int unitSize, Func<IntPtr, bool> exitCondition, Func<IntPtr, T> valGetter)
        {
            if (p == IntPtr.Zero) yield break;

            while (!exitCondition(p))
            {
                yield return valGetter(p);
                p += unitSize;
            }
        }
    }
}
