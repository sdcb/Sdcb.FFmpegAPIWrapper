<Query Kind="Statements">
  <NuGetReference Prerelease="true">Sdcb.FFmpegAPIWrapper</NuGetReference>
  <Namespace>Sdcb.FFmpegAPIWrapper.MediaMuxers</Namespace>
</Query>

CheckProtocols();
TestReadWrite();
TestReadHttp();

void CheckProtocols()
{
	string[] inputs = new[]
	{
		"test.mp4", 
		"https://www.baidu.com", 
		"http://taobao.com",
	};
	inputs.Select(x => new
	{
		Url = x, 
		FfmpegProtocol = MediaIO.GetUrlProtocol(x)
	}).Dump();
}

void TestReadWrite()
{
	string tempFile = Path.GetTempFileName();
	{
		using var io = MediaIO.Open(tempFile, MediaIOFlags.Write);
		io.Write(Encoding.UTF8.GetBytes("Hello World").AsSpan());
	}
	string tempFile2 = tempFile + ".temp";
	MediaIO.Move(tempFile, tempFile2);
	File.Exists(tempFile2).Dump("exist " + tempFile2);
	File.Copy(tempFile2, tempFile);
	MediaIO.Delete(tempFile2);
	File.Exists(tempFile2).Dump("exist " + tempFile2 + " (deleted)");
	{
		using var io = MediaIO.Open(tempFile, MediaIOFlags.Read);
		var buffer = new byte[4096].AsSpan();
		int len = io.Read(buffer);
		string text = Encoding.UTF8.GetString(buffer.Slice(0, len).ToArray());
		Console.WriteLine(text);
	}
	File.Delete(tempFile);
}

void TestReadHttp()
{
	MediaIO.Check("https://www.baidu.com", MediaIOFlags.Read).Dump("check https://www.baidu.com - read");
	using var io2 = MediaIO.Open("https://www.baidu.com");
	var buffer = new byte[4096].AsSpan();
	int len = io2.Read(buffer);
	Encoding.UTF8.GetString(buffer.Slice(0, len).ToArray()).Length.Dump("https://www.baidu.com length");
}