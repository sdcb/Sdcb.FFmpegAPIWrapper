<Query Kind="Statements">
  <NuGetReference Prerelease="true">Sdcb.FFmpegAPIWrapper</NuGetReference>
  <Namespace>FFmpeg.AutoGen</Namespace>
  <Namespace>Sdcb.FFmpegAPIWrapper.Common</Namespace>
  <Namespace>Sdcb.FFmpegAPIWrapper.MediaCodecs</Namespace>
  <Namespace>Sdcb.FFmpegAPIWrapper.MediaFormats</Namespace>
  <Namespace>Sdcb.FFmpegAPIWrapper.MediaUtils</Namespace>
  <Namespace>Sdcb.FFmpegAPIWrapper.Samples</Namespace>
  <Namespace>static FFmpeg.AutoGen.ffmpeg</Namespace>
  <Namespace>System.Buffers.Binary</Namespace>
  <Namespace>System.Runtime.CompilerServices</Namespace>
  <Namespace>System.Runtime.InteropServices</Namespace>
  <Namespace>Sdcb.FFmpegAPIWrapper.Swresamples</Namespace>
  <Namespace>Sdcb.FFmpegAPIWrapper.Toolboxs</Namespace>
</Query>

FFmpegLogger.LogWriter = c => Console.Write(c);
using FormatContext fc = FormatContext.AllocOutput(OutputFormat.Guess(shortName: "adts"));
fc.AudioCodec = Codec.FindEncoderByName("aac");

MediaStream audioStream = fc.NewStream(fc.AudioCodec);
using CodecContext audioCodec = new CodecContext(fc.AudioCodec)
{
    SampleFormat = fc.AudioCodec.SampleFormats.First(),
    BitRate = 64000,
    SampleRate = 44100,
    ChannelLayout = ChannelLayout.Stereo,
    TimeBase = new MediaRational(1, 44100),
};
audioCodec.Open(fc.AudioCodec);
audioStream.Codecpar.CopyFrom(audioCodec);

string outputPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "muxing.aac");
fc.DumpFormat(streamIndex: 0, outputPath, isOutput: true);

using MediaIO io = MediaIO.OpenWrite(outputPath);
fc.IO = io;
fc.WriteHeader();

foreach (Packet packet in 
	audioCodec.EncodeFrames(
	audioCodec.ConvertFrames(
	GetSampleFrames(audioCodec.ChannelLayout, audioCodec.SampleRate, audioCodec.FrameSize).Take(500))))
{
	try
	{
		packet.RescaleTimestamp(audioCodec.TimeBase, audioStream.TimeBase);
		packet.StreamIndex = audioStream.Index;
		LogPacket(fc, packet);
		fc.InterleavedWritePacket(packet);
	}
	finally
	{
		packet.Unreference();
	}
}
fc.WriteTrailer();

unsafe void LogPacket(FormatContext fc, Packet packet)
{
	MediaRational timebase = MediaStream.FromNative(fc.Streams[packet.StreamIndex]).TimeBase;

	Console.WriteLine("pts:{0} pts_time:{1} dts:{2} dts_time:{3} duration:{4} duration_time:{5} stream_index:{6}",
		   av_ts2str(packet.Pts), av_ts2timestr(packet.Pts, timebase),
		   av_ts2str(packet.Dts), av_ts2timestr(packet.Dts, timebase),
		   av_ts2str(packet.Duration), av_ts2timestr(packet.Duration, timebase),
		   packet.StreamIndex);

	static string av_ts2str(long pts) => pts == AV_NOPTS_VALUE ? "NOPTS" : pts.ToString();
	static unsafe string av_ts2timestr(long pts, MediaRational timebase) => pts == AV_NOPTS_VALUE
		? "NOPTS"
		: (1.0 * pts * timebase.Num / timebase.Den).ToString("N6");

	int v = 3;
	int* pv = &v;
}

IEnumerable<Frame> GetSampleFrames(ChannelLayout channelLayout, int sampleRate, int sampleCount)
{
	using var frame = new Frame
	{
		Format = (int)SampleFormat.S16,
		ChannelLayout = channelLayout,
		SampleRate = sampleRate,
		NbSamples = sampleCount,
	};
	frame.EnsureBuffer();

	float t = 0;
	float tincr = (float)(2 * M_PI * 110.0 / frame.SampleRate);
	int nextPts = 0;
	for (var i = 0; ; ++i)
	{
		FillS16Frame(frame, ref t, ref tincr, ref nextPts);
		yield return frame;
	}
}

unsafe void FillS16Frame(Frame frame, ref float t, ref float tincr, ref int nextPts)
{
	float tincr2 = (float)(2 * M_PI * 110.0 / frame.SampleRate / frame.SampleRate);
	
	Span<short> q = new Span<short>((void*)frame.Data._0, frame.Linesize._0 / 2);

	for (int sampleId = 0; sampleId < frame.NbSamples; ++sampleId)
	{
		int v = (int)(Math.Cos(t) * 20000);
		for (int channelId = 0; channelId < frame.Channels; ++channelId)
			q[sampleId * frame.Channels + channelId] = (short)v;
		t += tincr;
		tincr += tincr2;
	}
}