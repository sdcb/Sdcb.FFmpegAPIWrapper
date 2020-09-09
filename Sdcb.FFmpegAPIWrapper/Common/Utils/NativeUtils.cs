using System;
using System.Collections.Generic;

namespace Sdcb.FFmpegAPIWrapper.Common
{
    internal static class NativeUtils
    {
		public static IEnumerable<T> ReadSequence<T>(IntPtr p, int unitSize, Func<IntPtr, bool> exitCondition, Func<IntPtr, T> valGetter)
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
