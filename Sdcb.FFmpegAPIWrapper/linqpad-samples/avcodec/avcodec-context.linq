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
  <Namespace>Sdcb.FFmpegAPIWrapper.Toolboxs</Namespace>
</Query>

void Main1()
{
	// 向桌面输出h265
	ffmpeg.RootPath = "";
	FFmpegLogger.LogWriter = x => Console.Write(x);
	string destPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\avcodec-context-demo.h265";

	using Stream file = File.OpenWrite(destPath);
	WriteSampleH265(file);
}

void Main2()
{
	// 将h265转换为jpg保存
	ffmpeg.RootPath = "";
	FFmpegLogger.LogWriter = x => Console.Write(x);
	string h265File = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\avcodec-context-demo.h265";

	using Stream file = File.OpenRead(h265File);
	string jpgFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\avcodec-context-demo-jpg";
	Directory.CreateDirectory(jpgFolder);
	int i = 0;
	foreach (Frame x in DecodeSampleH265(file))
	{
		x.WriteImageTo(jpgFolder + @$"\{i++}.jpg");
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
		PixelFormat = PixelFormat.Yuv420p,
	};
	//c.PrivateOptions.Set("preset", "fast");
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

IEnumerable<Frame> DecodeSampleH265(Stream stream)
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
			yield return frame;
		}
	}

	foreach (var _ in c.DecodePacket(null, frame))
	{
		yield return frame;
	}
}