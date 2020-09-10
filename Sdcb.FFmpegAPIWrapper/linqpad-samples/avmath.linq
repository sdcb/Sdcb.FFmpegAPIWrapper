<Query Kind="Statements">
  <NuGetReference Prerelease="true">Sdcb.FFmpegAPIWrapper</NuGetReference>
  <Namespace>FFmpeg.AutoGen</Namespace>
  <Namespace>Sdcb.FFmpegAPIWrapper.MediaMuxers</Namespace>
  <Namespace>static FFmpeg.AutoGen.ffmpeg</Namespace>
  <Namespace>System.Buffers.Binary</Namespace>
  <Namespace>System.Runtime.CompilerServices</Namespace>
  <Namespace>Sdcb.FFmpegAPIWrapper.Common</Namespace>
  <Namespace>System.Runtime.InteropServices</Namespace>
</Query>

MediaMath.Gcd(12, 18).Dump("gcd(12, 18)");
MediaMath.Rescale(3, 4, 5).Dump("3*4/5");
MediaMath.Rescale(3, 4, 5, MediaRounding.AwayZero).Dump("3*4/5, away-zero");
MediaMath.CompareTs(10, new MediaRational(1, 10), 19, new MediaRational(1, 20)).Dump("Compare(10 * 1/10, 19 * 1/20)");