<Query Kind="Statements">
  <NuGetReference Prerelease="true">Sdcb.FFmpegAPIWrapper</NuGetReference>
  <Namespace>Sdcb.FFmpegAPIWrapper.Common</Namespace>
  <Namespace>FFmpeg.AutoGen</Namespace>
</Query>

Util.NewProcess = true;
new
{
	FFmpegLogger.LogFlags, 
	FFmpegLogger.LogLevel
}.Dump("default settings");

FFmpegLogger.Log(LogLevel.Warning, "test\n"); // invisible
FFmpegLogger.LogWriter = x => Console.Write(x);
{
	FFmpegLogger.Log(LogLevel.Warning, "test\n");
	FFmpegLogger.Log(LogLevel.Info, "test\n");
	FFmpegLogger.Log(LogLevel.Verbose, "test\n");
}
FFmpegLogger.LogFlags = LogFlags.PrintLevel.Dump("LogFlags");
{
	FFmpegLogger.Log(LogLevel.Warning, "test\n");
	FFmpegLogger.Log(LogLevel.Info, "test\n");
	FFmpegLogger.Log(LogLevel.Verbose, "test\n");
}
FFmpegLogger.LogLevel = LogLevel.Verbose.Dump("LogLevel");
{
	FFmpegLogger.Log(LogLevel.Warning, "test\n");
	FFmpegLogger.Log(LogLevel.Info, "test\n");
	FFmpegLogger.Log(LogLevel.Verbose, "test\n");
}
