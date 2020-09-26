<Query Kind="Statements">
  <NuGetReference Prerelease="true">Sdcb.FFmpegAPIWrapper</NuGetReference>
  <Namespace>FFmpeg.AutoGen</Namespace>
  <Namespace>Sdcb.FFmpegAPIWrapper.Common</Namespace>
  <Namespace>System.CodeDom.Compiler</Namespace>
  <Namespace>Microsoft.CSharp</Namespace>
  <Namespace>System.CodeDom</Namespace>
</Query>

#load ".\common"
#load "generate\write-class"

string baseDir = Path.GetFullPath(Path.Combine(Util.CurrentQuery.Location, @"..\..\MediaCodecs\GeneratedTypes"));
Directory.CreateDirectory(baseDir);
Environment.CurrentDirectory = baseDir;

WriteClass(typeof(AVCodecContext), "Sdcb.FFmpegAPIWrapper.MediaCodecs", "CodecContext", x => x switch
{
	"flags" => "CodecFlag",
	"flags2" => "CodecFlag2",
	"ildct_cmp" => "DctComparison",
	"slice_flags" => "CodecSliceFlag",
	"mb_decision" => "MacroblockDecision",
	"export_side_data" => "CodecExportData",
	_ => null, 
});