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
</Query>

void Main()
{
	FFmpegLogger.LogWriter = x => Console.Write(x);
	
	Codec codec = Codec.FindEncoder(CodecID.Hevc);
	using CodecContext c = new CodecContext(codec)
	{
		BitRate = 400_000, 
		Width = 352, 
		Height = 288, 
		TimeBase = new MediaRational(1, 25), 
		Framerate = new MediaRational(25, 1), 
		GopSize = 10, 
		MaxBFrames = 1, 
		PixelFormat = PixelFormat.Yuv420p, 	
	};
	c.Options.Set("preset", "slow");
	c.Open(codec);
	
	using var frame = new Frame()
	{
		Format = (int)c.PixelFormat, 
		Width = c.Width, 
		Height = c.Height, 
	};
	frame.EnsureBuffer();
	
	using var stream = new MemoryStream();
	using var packet = new Packet();
	for (var i = 0; i < 25; ++i)
	{
		frame.MakeWritable();
		frame.Pts = i;
		Encode(c, frame, packet, stream);
	}
	Encode(c, null, packet, stream);
	string destPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\avcodec-context-demo.h265";
	File.WriteAllBytes(destPath, stream.ToArray());
}

void Encode(CodecContext c, Frame? frame, Packet packet, Stream stream)
{
	if (frame != null)
	{
		Console.WriteLine($"Send frame {frame.Pts}");
	}
	
	c.SendFrame(frame);
	while (true)
	{
		CodecResult s = c.ReceivePacket(packet);
		if (s == CodecResult.Again || s == CodecResult.EOF) return;
		stream.Write(packet.AsSpan());
		Console.WriteLine($"Write packet {packet.Pts} (size={packet.Size})");
		packet.Unreference();
	}
}