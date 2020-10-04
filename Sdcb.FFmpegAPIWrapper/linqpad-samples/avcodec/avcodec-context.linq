<Query Kind="Program">
  <NuGetReference Prerelease="true">Sdcb.FFmpegAPIWrapper</NuGetReference>
  <Namespace>FFmpeg.AutoGen</Namespace>
  <Namespace>Sdcb.FFmpegAPIWrapper.Common</Namespace>
  <Namespace>Sdcb.FFmpegAPIWrapper.MediaCodecs</Namespace>
  <Namespace>Sdcb.FFmpegAPIWrapper.MediaUtils</Namespace>
  <Namespace>Sdcb.FFmpegAPIWrapper.Samples</Namespace>
  <Namespace>static FFmpeg.AutoGen.ffmpeg</Namespace>
  <Namespace>System.Buffers.Binary</Namespace>
  <Namespace>System.Runtime.CompilerServices</Namespace>
  <Namespace>System.Runtime.InteropServices</Namespace>
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
	string yuvFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\avcodec-context-demo-yuv";
	Directory.CreateDirectory(yuvFolder);
	foreach (var x in DecodeSampleH265(file).Select((x, i) => (bytes: x, i)))
	{
		File.WriteAllBytes(yuvFolder + @$"\{x.i}.yuv", x.bytes);
	}
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
	c.Options.Set("preset", "fast");
	c.Open(codec);

	var writer = new BinaryWriter(stream);
	writer.Write((int)codec.Id);
	foreach (Packet packet in c.EncodeFrames(VideoFrameSample.Yuv420pSequence(c.Width, c.Height).Take(30)))
	{
		Console.WriteLine($"packet {packet.Pts}, size={packet.Size}");
		writer.Write(packet.AsSpan());
	}
	Console.WriteLine($"All done, total size={stream.Position}");
}

IEnumerable<byte[]> DecodeSampleH265(Stream stream)
{
	using var reader = new BinaryReader(stream);
	CodecID codecId = (CodecID)reader.ReadInt32();
	Codec codec = Codec.FindDecoder(codecId);
	using var c = new CodecContext(codec); 
	c.Open(codec);
	using var parser = new CodecParserContext(codec.Id);
	using var packet = new Packet();
	using var frame = new Frame();
	foreach (DataPointer dp in parser.Parse(c, stream))
	{
		packet.Data = dp.Pointer;
		packet.Size = dp.Length;
		foreach (var _ in c.DecodePacket(packet, frame))
		{
			yield return frame.ToImageBuffer();
		}
	}

	foreach (var _ in c.DecodePacket(null, frame))
	{
		yield return frame.ToImageBuffer();
	}
}