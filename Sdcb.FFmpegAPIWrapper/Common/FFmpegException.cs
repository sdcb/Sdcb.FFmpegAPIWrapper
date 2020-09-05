﻿using System;
using System.Runtime.InteropServices;
using static FFmpeg.AutoGen.ffmpeg;

namespace Sdcb.FFmpegAPIWrapper.Common
{
    public class FFmpegException : Exception
	{
		private FFmpegException(int errorCode, string message) : base(message)
		{
			HResult = errorCode;
		}

		public unsafe static FFmpegException FromErrorCode(int errorCode, string info)
		{
			byte* buffer = stackalloc byte[AV_ERROR_MAX_STRING_SIZE];
			av_strerror(errorCode, buffer, AV_ERROR_MAX_STRING_SIZE);
			string prefix = info ?? $"FFmpeg error {errorCode}";
			string message = $"[{prefix}]: {Marshal.PtrToStringUTF8((IntPtr)buffer)}";
			return new FFmpegException(errorCode, message);
		}
	}

	internal static class FFmpegValidation
    {
		public static int ThrowIfError(this int errorCode, string message = null)
        {
			if (errorCode < 0)
            {
				throw FFmpegException.FromErrorCode(errorCode, message);
            }
			return errorCode;
        }
    }
}