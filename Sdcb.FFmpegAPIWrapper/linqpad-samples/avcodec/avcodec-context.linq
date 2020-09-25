<Query Kind="Statements">
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

FFmpegLogger.LogWriter = x => Console.Write(x);

var codec = Codec.FindEncoder(CodecID.Hevc);
using var cc = CodecContext.FromCodec(codec);
cc.Options.Dump();
//av_opt_set(cc, "preset", "fast", 0).Dump();
//cc.Dump();
//
//cc.BitRate = 400_000;
//cc.Width = 352;
//cc.Height = 288;
//cc.TimeBase = new MediaRational(1, 25);
//cc.Framerate = new MediaRational(25, 1);
//cc.GopSize = 10;
//cc.MaxBFrames = 1;
//cc.PixelFormat = PixelFormat.Yuv420p;
//
////codecContext.GopSize = 
//cc.Open(codec);
//cc.Dump();