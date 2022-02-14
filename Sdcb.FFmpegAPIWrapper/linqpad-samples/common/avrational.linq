<Query Kind="Statements">
  <NuGetReference Prerelease="true">Sdcb.FFmpegAPIWrapper</NuGetReference>
  <Namespace>FFmpeg.AutoGen</Namespace>
  <Namespace>Sdcb.FFmpegAPIWrapper.Common</Namespace>
  <Namespace>static FFmpeg.AutoGen.ffmpeg</Namespace>
  <Namespace>System.Buffers.Binary</Namespace>
  <Namespace>System.Runtime.CompilerServices</Namespace>
  <Namespace>System.Runtime.InteropServices</Namespace>
</Query>

ffmpeg.RootPath = "";
var a = new MediaRational(2, 3);
var b = new MediaRational(3, 4);
var c = new MediaRational(100, 101);
Util.HorizontalRun(true, a, b, c).Dump("a, b, c");
(a + b).Dump("+");
(a - b).Dump("-");
(a * b).Dump("*");
(a / b).Dump("/");
MediaRational.Gcd(a, b, 1000).Dump();
MediaRational.Nearer(new MediaRational(0), a, b).Dump();
var array = new[]
{
	a, b, c, new MediaRational(), 
};
fixed(MediaRational* p = array)
{
	MediaRational.FindNearestIndex(new MediaRational(1), p).Dump();
}