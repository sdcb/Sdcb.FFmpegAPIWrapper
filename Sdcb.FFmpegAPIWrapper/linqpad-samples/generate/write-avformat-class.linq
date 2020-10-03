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
WriteClass(new GenerateOption(typeof(AVFormatContext), ns, "FormatContext")
{
	FieldNameMapping = new()
	{
		["iformat"] = "InputFormat",
		["oformat"] = "OutputFormat", 
		["pb"] = "IO",
	},
	FieldTypeMapping = new()
	{
		["url"] = str(),
		["flags"] = force("FormatFlag"),
		["event_flags"] = force("EventFlag"),
		["avio_flags"] = force("MediaIOFlags"),
	},
	AdditionalNamespaces = new string[] {"Sdcb.FFmpegAPIWrapper.MediaCodecs" }, 
	WriteStub = true, 
});

WriteStruct(new GenerateOption(typeof(AVInputFormat), ns, "InputFormat")
{
	FieldTypeMapping = new()
	{
		["name"] = str(),
		["long_name"] = str(),
		["extensions"] = str(),
		["mime_type"] = str(),
	}, 
	WriteStub = false,
	PrivateMemberFrom = nameof(AVInputFormat.next)
});

WriteStruct(new GenerateOption(typeof(AVOutputFormat), ns, "OutputFormat")
{
	FieldTypeMapping = new()
	{
		["name"] = str(),
		["long_name"] = str(),
		["extensions"] = str(),
		["mime_type"] = str(),
	},
	AdditionalNamespaces = new string[] { "Sdcb.FFmpegAPIWrapper.MediaCodecs" },
	PrivateMemberFrom = nameof(AVInputFormat.next)
});