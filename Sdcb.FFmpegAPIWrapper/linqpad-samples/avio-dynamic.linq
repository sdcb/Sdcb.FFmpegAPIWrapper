<Query Kind="Statements">
  <NuGetReference Prerelease="true">Sdcb.FFmpegAPIWrapper</NuGetReference>
  <Namespace>FFmpeg.AutoGen</Namespace>
  <Namespace>Sdcb.FFmpegAPIWrapper.MediaMuxers</Namespace>
  <Namespace>static FFmpeg.AutoGen.ffmpeg</Namespace>
  <Namespace>System.Buffers.Binary</Namespace>
  <Namespace>System.Runtime.CompilerServices</Namespace>
</Query>

using var io = MediaIO.CreateDynamic();
io.WriteString("Hello World");
using var buffer = io.GetBufferAndClose();
Console.WriteLine(Encoding.UTF8.GetString(buffer.AsSpan()));