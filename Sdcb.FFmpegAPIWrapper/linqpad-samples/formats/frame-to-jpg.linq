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
using var frame = Frame.CreateWritableVideo(1920, 1080, PixelFormat.Yuv420p);
VideoFrameSample.FillYuv420p(frame, 0);
// mjpeg -> jpeg
// apng -> png
byte[] data = frame.Encode(formatName: "mjpeg");
data.Length.Dump("Image Size");
Util.Image(data).Dump();