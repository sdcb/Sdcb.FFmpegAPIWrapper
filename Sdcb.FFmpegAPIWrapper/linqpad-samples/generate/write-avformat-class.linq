<Query Kind="Statements">
  <NuGetReference Prerelease="true">Sdcb.FFmpegAPIWrapper</NuGetReference>
  <Namespace>FFmpeg.AutoGen</Namespace>
  <Namespace>Sdcb.FFmpegAPIWrapper.Common</Namespace>
  <Namespace>System.CodeDom.Compiler</Namespace>
  <Namespace>Microsoft.CSharp</Namespace>
  <Namespace>System.CodeDom</Namespace>
</Query>

#load ".\common"
#load ".\write-class"

string baseDir = Path.GetFullPath(Path.Combine(Util.CurrentQuery.Location, @"..\..\MediaFormats\GeneratedTypes"));
Directory.CreateDirectory(baseDir);
Environment.CurrentDirectory = baseDir;

string ns = "Sdcb.FFmpegAPIWrapper.MediaFormats";
WriteClass(typeof(AVFormatContext), ns, "FormatContext", propNameMapping: x => x switch
{	
	"iformat" => "InputFormat", 
	"pb" => "IO",
	_ => null,
}, propTypeMapping: x => x switch
{
	"url" => str(),	
	"flags" => force("FormatFlag"), 
	"event_flags" => force("EventFlag"), 
	"avio_flags" => force("MediaIOFlags"), 
	_ => null
}, additionalNamespaces: new[] { "Sdcb.FFmpegAPIWrapper.MediaCodecs" });
WriteClass(typeof(AVInputFormat), ns, "InputFormat", propTypeMapping: x => x switch
{
	"name" => str(), 
	"long_name" => str(), 
	"mime_type" => str(), 
	_ => null, 
});
WriteClass(typeof(AVOutputFormat), ns, "OutputFormat", propTypeMapping: x => x switch
{
	"name" => str(),
	"long_name" => str(),
	"mime_type" => str(),
	_ => null,
}, additionalNamespaces: new[] { "Sdcb.FFmpegAPIWrapper.MediaCodecs" });
//WriteClass(typeof(AVBufferPool), ns, "BufferPool");