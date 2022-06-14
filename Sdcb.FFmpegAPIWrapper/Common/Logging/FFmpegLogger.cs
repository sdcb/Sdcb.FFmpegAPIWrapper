using FFmpeg.AutoGen;
using System;
using System.Runtime.InteropServices;
using static FFmpeg.AutoGen.ffmpeg;

namespace Sdcb.FFmpegAPIWrapper.Common
{
    public static class FFmpegLogger
    {
		/// <summary>
		/// <see cref="av_log_get_level"/>
		/// <see cref="av_log_set_level(int)"/>
		/// </summary>
		public static AVLog LogLevel
        {
			get => (AVLog)av_log_get_level();
			set => av_log_set_level((int)value);
        }

		/// <summary>
		/// <see cref="av_log_get_flags"/>
		/// <see cref="av_log_set_flags(int)"/>
		/// </summary>
		public static AVLog LogFlags
        {
			get => (AVLog)av_log_get_flags();
			set => av_log_set_flags((int)value);
        }

		/// <summary>
		/// <see cref="av_log_set_callback(av_log_set_callback_callback_func)"/>
		/// </summary>
		public static unsafe Action<string> LogWriter
        {
			set => av_log_set_callback(LogCallback = value switch
			{
				null => av_log_default_callback, 
				_ => (p0, level, format, vl) =>
                {
                    if (level > av_log_get_level()) return;

                    const int lineSize = 1024;
                    int printPrefix = 1;
                    byte* lineBuffer = stackalloc byte[lineSize];
                    av_log_format_line2(p0, level, format, vl, lineBuffer, lineSize, &printPrefix);
                    value.Invoke(Marshal.PtrToStringUTF8((IntPtr)lineBuffer)!);
                }
            });
        }

		private static av_log_set_callback_callback? LogCallback;

		/// <summary>
		/// <see cref="av_log(void*, int, string)"/>
		/// </summary>
		public unsafe static void Log(AVLog level, string message) => av_log(null, (int)level, message);

		public static void LogTrace(string message) => Log(AVLog.Trace, message);
		public static void LogDebug(string message) => Log(AVLog.Debug, message);
		public static void LogVerbose(string message) => Log(AVLog.Verbose, message);
		public static void LogInfo(string message) => Log(AVLog.Info, message);
		public static void LogWarning(string message) => Log(AVLog.Warning, message);
		public static void LogError(string message) => Log(AVLog.Error, message);
		public static void LogFatal(string message) => Log(AVLog.Fatal, message);
		public static void LogPanic(string message) => Log(AVLog.Panic, message);
		public static void LogQuiet(string message) => Log(AVLog.Quiet, message);
    }
}
