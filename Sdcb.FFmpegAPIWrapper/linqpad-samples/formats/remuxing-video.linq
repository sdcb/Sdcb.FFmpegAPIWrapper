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
  <Namespace>Sdcb.FFmpegAPIWrapper.Swscales</Namespace>
  <Namespace>Sdcb.FFmpegAPIWrapper.Toolboxs</Namespace>
</Query>

FFmpegLogger.LogWriter = c => Console.Write(c);
//FFmpegLogger.LogLevel = LogLevel.Debug;
string inputPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "muxing.mp4");
string outputPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "remuxing.mp4");

using FormatContext input = FormatContext.OpenInput(inputPath);
MediaStream inputStream = input.FindBestStream(MediaType.Video);
Codec inputCodec = Codec.FindDecoder(inputStream.Codecpar.CodecId);
using CodecContext decoder = new CodecContext(inputCodec);
decoder.FillParameters(inputStream.Codecpar);
decoder.Open();

using FormatContext output = FormatContext.AllocOutput(fileName: outputPath);
Codec outputCodec = Codec.FindEncoderByName("libvpx-vp9");
var outputStream = new MediaStream(output);
using CodecContext encoder = new CodecContext(outputCodec)
{
    Width = inputStream.Codecpar.Width / 2,
    Height = inputStream.Codecpar.Height / 2,
    TimeBase = inputStream.RealFrameRate.Inverse(), 
	PixelFormat = outputCodec.PixelFormats.First(),
	BitRate = 1 * 1024 * 1024,
};
encoder.Open();
outputStream.Codecpar.CopyFrom(encoder);

output.DumpFormat(streamIndex: 0, outputPath, isOutput: true);
using var io = MediaIO.OpenWrite(outputPath);
output.IO = io;

output.WriteHeader();
foreach (Packet outPacket in 
	encoder.EncodeFrames(
	encoder.ConvertFrames(
	decoder.DecodePackets(
	input.ReadPackets().Where(x => x.StreamIndex == inputStream.Index)))))
{
	outPacket.RescaleTimestamp(encoder.TimeBase, outputStream.TimeBase);
	outPacket.StreamIndex = outputStream.Index;
	LogPacket(output, outPacket);
	output.InterleavedWritePacket(outPacket);
}
output.WriteTrailer();

unsafe void LogPacket(FormatContext fc, Packet packet)
{
	MediaRational timebase = MediaStream.FromNative(fc.Streams[packet.StreamIndex]).TimeBase;

	Console.WriteLine("pts:{0} pts_time:{1} dts:{2} dts_time:{3} duration:{4} duration_time:{5} stream_index:{6} size:{7}",
		   av_ts2str(packet.Pts), av_ts2timestr(packet.Pts, timebase),
		   av_ts2str(packet.Dts), av_ts2timestr(packet.Dts, timebase),
		   av_ts2str(packet.Duration), av_ts2timestr(packet.Duration, timebase),
		   packet.StreamIndex, packet.Size);

	static string av_ts2str(long pts) => pts == AV_NOPTS_VALUE ? "NOPTS" : pts.ToString();
	static unsafe string av_ts2timestr(long pts, MediaRational timebase) => pts == AV_NOPTS_VALUE
		? "NOPTS"
		: (1.0 * pts * timebase.Num / timebase.Den).ToString("N6");
}