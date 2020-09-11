<Query Kind="Statements">
  <NuGetReference Prerelease="true">Sdcb.FFmpegAPIWrapper</NuGetReference>
  <Namespace>FFmpeg.AutoGen</Namespace>
  <Namespace>Sdcb.FFmpegAPIWrapper.Common</Namespace>
  <Namespace>System.CodeDom.Compiler</Namespace>
</Query>

Environment.CurrentDirectory = Path.GetFullPath(Path.Combine(Util.CurrentQuery.Location, @"..\..\MediaCodecs"));
using var _file = new StreamWriter("MediaCodecContext.g.cs");
using var writer = new IndentedTextWriter(_file, new string(' ', 4));

WriteUsings();
WriteNamespace("Sdcb.FFmpegAPIWrapper.MediaCodecs", 
	() => WriteClass("MediaCodecContext2 : FFmpegHandle", WriteClassBodies));
	
IEnumerable<string> WriteField(FieldInfo fieldInfo)
{
	var m = TypeMap(fieldInfo.FieldType);
	//	return @$"public {m.type} {fieldInfo.Name}
	//{{
	//    get => Pointer->{fieldInfo.Name};
	//    set => Pointer->{fieldInfo.Name} = value;
	//}}";
	yield return $@"public {m.type} {fieldInfo.Name}";
	yield return $@"{{";
	yield return $@"    get => ";
	yield return $@"    set => ";
	yield return $@"}}";	
	
	(string type, string conv) TypeMap(Type type)
	{
		return type.Name switch
		{
			"Int32" => ("int", null),
			"UInt32" => ("uint", null),
			"Int64" => ("long", null),
			"UInt64" => ("ulong", null),
			"Single" => ("float", null),
			"AVClass*" => ("FFmpegClass", ".FromNative"),
			"AVCodec*" => ("MediaCodec", ".FromNative"),
			"AVRational" => ("FFmpegRational", null),
			"void*" => ("IntPtr", "force"), 
			//var x when x.EndsWith("*") => "IntPtr",
			var x => (x, null),
		};
	}
}

void WriteClassBodies()
{
	WriteLine("private AVCodecContext* Pointer => this;");
	WriteLine();
	WriteLine("public static implicit operator AVCodecContext*(MediaCodecContext2 data) => (AVCodecContext*)data._handle;");
	WriteLine();
	foreach (var line in string.Join("\r\n\r\n", typeof(AVCodecContext)
		.GetFields()
		.Select(WriteField))
		.Split("\r\n"))
	{
		WriteLine(line);
	};
}

void WriteUsings()
{
	WriteLine("using Sdcb.FFmpegAPIWrapper.Common;");
	WriteLine("using FFmpeg.AutoGen;");
	WriteLine("using static FFmpeg.AutoGen.ffmpeg;");
	WriteLine("using System;");
	WriteLine();
}

void WriteNamespace(string ns, Action bodyWriter)
{
	WriteLine($"namespace {ns}");
	WriteLine("{");
	PushIndent(bodyWriter);
	WriteLine("}");
}

void WriteClass(string className, Action bodyWriter)
{
	writer.WriteLine($"public unsafe partial class {className}");
	writer.WriteLine("{");
	PushIndent(bodyWriter);
	writer.WriteLine("}");
}

void PushIndent(Action action)
{
	writer.Indent += 1;
	action();
	writer.Indent -= 1;
}

void WriteLine(string text = null) => writer.WriteLine(text);

record TypeConversionInfo
{
	public static TypeConversionInfo FromTypeString(string typeName)
	{
		
	}
}