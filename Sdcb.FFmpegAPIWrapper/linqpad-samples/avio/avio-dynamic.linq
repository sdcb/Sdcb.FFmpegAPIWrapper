<Query Kind="Statements">
  <NuGetReference Prerelease="true">Sdcb.FFmpegAPIWrapper</NuGetReference>
  <Namespace>FFmpeg.AutoGen</Namespace>
  <Namespace>Sdcb.FFmpegAPIWrapper.MediaFormats</Namespace>
  <Namespace>static FFmpeg.AutoGen.ffmpeg</Namespace>
  <Namespace>System.Buffers.Binary</Namespace>
  <Namespace>System.Runtime.CompilerServices</Namespace>
</Query>

ffmpeg.RootPath = "";
using DynamicMediaIO io = MediaIO.OpenDynamic();
io.WriteString("Hello World");
io.Flush();
GetContent(io).Dump();

io.Seek(-6, MediaIOSeek.Current);
io.WriteString("你的名字");
GetContent(io).Dump();

io.Seek("Hello ".Length, MediaIOSeek.Begin);
io.WriteString("YourName");
GetContent(io).Dump();

string GetContent(DynamicMediaIO dio)
{
	Span<byte> buf = stackalloc byte[32];
	var pos = dio.Position;
	dio.Position = 0;
	var c = dio.ReadString(buf, buf.Length);
	dio.Position = pos;
	return Encoding.UTF8.GetString(buf.Slice(0, c - 1));
}