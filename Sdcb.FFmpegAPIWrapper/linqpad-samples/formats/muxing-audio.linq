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
</Query>

FFmpegLogger.LogWriter = c => Console.Write(c);
using FormatContext fc = FormatContext.AllocOutput(formatName: "mp3");
fc.AudioCodec = Codec.FindEncoderByName("libmp3lame");

MediaStream audioStream = fc.NewStream(fc.AudioCodec);
audioStream.TimeBase = new MediaRational(1, 25);
using var audioCodec = new CodecContext(fc.VideoCodec)
{
	SampleFormat = fc.AudioCodec.SampleFormats.First(), 
	BitRate = 64000, 
	SampleRate = fc.AudioCodec.SupportedSampleRates.First(),
	ChannelLayout = ChannelLayout.Mono, 
	Channels = 1, 
	TimeBase = new MediaRational(1, fc.AudioCodec.SupportedSampleRates.First()), 
};
audioCodec.Open(fc.VideoCodec);
audioStream.Codecpar.CopyFrom(audioCodec);

string outputPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "muxing.mp3");
fc.DumpFormat(streamIndex: 0, outputPath, isOutput: true);

using MediaIO io = MediaIO.OpenWrite(outputPath);
fc.IO = io;
fc.WriteHeader();
foreach (Packet packet in audioCodec.EncodeFrames(VideoFrameSample.Yuv420pSequence(audioCodec.Width, audioCodec.Height).Take(50)))
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
}