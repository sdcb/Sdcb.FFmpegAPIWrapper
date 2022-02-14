<Query Kind="Statements">
  <NuGetReference Prerelease="true">Sdcb.FFmpegAPIWrapper</NuGetReference>
  <Namespace>FFmpeg.AutoGen</Namespace>
  <Namespace>Sdcb.FFmpegAPIWrapper.MediaFormats</Namespace>
  <Namespace>static FFmpeg.AutoGen.ffmpeg</Namespace>
  <Namespace>System.Buffers.Binary</Namespace>
  <Namespace>System.Runtime.CompilerServices</Namespace>
</Query>

ffmpeg.RootPath = "";

{
	using var ms = new MemoryStream();
	using var io = MediaIO.WriteStream(ms);
	for (var i = 0; i < 5; ++i)
	{
		io.WriteString("Hello World");
		io.Flush();
		GC.Collect();
	}

	Encoding.UTF8.GetString(ms.ToArray()[..^1]).Dump("write");
}

{
	using var ms = new MemoryStream(Encoding.UTF8.GetBytes("Hello World"));
	
	using var io = MediaIO.ReadStream(ms);
	var buffer = new byte[io.Size];
	
	var c = io.Read(buffer.AsSpan());
	Debug.Assert(c == buffer.Length);
	
	Encoding.UTF8.GetString(buffer).Dump("read");
}