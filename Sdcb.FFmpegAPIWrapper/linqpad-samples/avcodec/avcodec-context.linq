<Query Kind="Program">
  <NuGetReference Prerelease="true">Sdcb.FFmpegAPIWrapper</NuGetReference>
  <Namespace>FFmpeg.AutoGen</Namespace>
  <Namespace>Sdcb.FFmpegAPIWrapper.MediaMuxers</Namespace>
  <Namespace>static FFmpeg.AutoGen.ffmpeg</Namespace>
  <Namespace>System.Buffers.Binary</Namespace>
  <Namespace>System.Runtime.CompilerServices</Namespace>
  <Namespace>Sdcb.FFmpegAPIWrapper.Common</Namespace>
  <Namespace>System.Runtime.InteropServices</Namespace>
  <Namespace>Sdcb.FFmpegAPIWrapper.MediaCodecs</Namespace>
  <Namespace>Sdcb.FFmpegAPIWrapper.Samples</Namespace>
</Query>

void Main1()
{
	FFmpegLogger.LogWriter = x => Console.Write(x);	
	string destPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\avcodec-context-demo.h265";

	using Stream file = File.OpenWrite(destPath);
	WriteSampleH265(file);
}

void Main2()
{
	FFmpegLogger.LogWriter = x => Console.Write(x);
	string destPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\avcodec-context-demo.h265";
	
	using Stream file = File.OpenRead(destPath);
	
}

void WriteSampleH265(Stream stream)
{
	Codec codec = Codec.FindEncoder(CodecID.Hevc);
	using CodecContext c = new CodecContext(codec)
	{
		BitRate = 1 * 1024 * 1024, // 1M
		Width = 1920,
		Height = 1080,
		TimeBase = new MediaRational(1, 15),
		Framerate = new MediaRational(15, 1),
		GopSize = 10,
		MaxBFrames = 1,
		PixelFormat = PixelFormat.Yuv420p,
	};
	c.Options.Set("x265-params", "log=none");
	c.Options.Set("preset", "fast");
	c.Open(codec);

	var writer = new BinaryWriter(stream);
	writer.Write(codec.
		foreach (Packet packet in c.EncodeFrames(VideoFrameSample.Yuv420pSequence(c.Width, c.Height).Take(30)))
	{
		Console.WriteLine($"packet {packet.Pts}, size={packet.Size}");
		stream.Write(packet.AsSpan());
	}
	Console.WriteLine($"All done, total size={stream.Position}");
}

void DecodeSampleH265(Stream stream)
{

}