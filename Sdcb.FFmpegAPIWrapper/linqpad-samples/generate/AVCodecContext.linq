<Query Kind="Statements">
  <NuGetReference Prerelease="true">Sdcb.FFmpegAPIWrapper</NuGetReference>
  <Namespace>FFmpeg.AutoGen</Namespace>
  <Namespace>Sdcb.FFmpegAPIWrapper.Common</Namespace>
  <Namespace>System.CodeDom.Compiler</Namespace>
  <Namespace>Microsoft.CSharp</Namespace>
  <Namespace>System.CodeDom</Namespace>
</Query>

#load ".\common"

Environment.CurrentDirectory = Path.GetFullPath(Path.Combine(Util.CurrentQuery.Location, @"..\..\MediaCodecs"));
using var _file = new StreamWriter("MediaCodecContext.g.cs");
using var writer = new IndentedTextWriter(_file, new string(' ', 4));

WriteBasic(writer, "Sdcb.FFmpegAPIWrapper.MediaCodecs", () => WriteClass("MediaCodecContext : FFmpegHandle", WriteClassBodies));
	
void WriteClassBodies()
{
	WriteLine("private AVCodecContext* Pointer => this;");
	WriteLine();
	WriteLine("public static implicit operator AVCodecContext*(MediaCodecContext data) => (AVCodecContext*)data._handle;");
	WriteLine();
	
    WriteLine("public MediaCodecContext(AVCodecContext* ptr) : base((IntPtr)ptr) ");
    WriteLine("{");
    WriteLine("    if (ptr == null)");
    WriteLine("    {");
    WriteLine("        throw new ArgumentNullException(nameof(ptr));");
    WriteLine("    }");
    WriteLine("}");
	WriteLine();
	
	foreach (string line in string.Join("\r\n\r\n", typeof(AVCodecContext)
		.GetFields()
		.Select(Convert))
		.Split("\r\n"))
	{
		WriteLine(line);
	};
}

void WriteClass(string className, Action bodyWriter)
{
	writer.WriteLine($"public unsafe partial class {className}");
	PushIndent(writer, bodyWriter);
}

void WriteLine(string text = null) => writer.WriteLine(text);

string Convert(FieldInfo field)
{
	string fieldName = IdentifierConvert(field.Name);
	string propName = PascalCase(field.Name);
	(string destType, string method) = FromTypeString(field);

	return BuildFieldDocument(field) + method switch
	{
		null =>
			$"public {destType} {propName}\r\n" +
			$"{{\r\n" +
			$"    get => Pointer->{fieldName};\r\n" +
			$"    set => Pointer->{fieldName} = value;\r\n" +
			$"}}",
		"force" =>
			$"public {destType} {propName}\r\n" +
			$"{{\r\n" +
			$"    get => ({destType})Pointer->{fieldName};\r\n" +
			$"    set => Pointer->{fieldName} = ({GetFriendlyTypeName(field.FieldType)})value;\r\n" +
			$"}}",
		var x when x.StartsWith(".") =>
			$"public {destType} {propName}\r\n" +
			$"{{\r\n" +
			$"    get => {destType}{method}(Pointer->{fieldName});\r\n" +
			$"    set => Pointer->{fieldName} = value;\r\n" +
			$"}}",
		_ => throw new ArgumentOutOfRangeException(method),
	};

	(string destType, string method) FromTypeString(FieldInfo field)
	{
		Type fieldType = field.FieldType;
		return (fieldTypeName: fieldType.Name, fieldName: field.Name) switch
		{
			("AVClass*", _) => call("FFmpegClass", "FromNative"),
			("AVCodec*", _) => call("MediaCodec", "FromNative"),
			("AVRational", _) => direct("MediaRational"),
			("Void*", _) => force("IntPtr"),
			("AVPixelFormat", _) => force("MediaPixelFormat"), 
			("AVSampleFormat", _) => force("MediaSampleFormat"), 
			(_, "flags") => force("CodecFlag"),
			(_, "flags2") => force("CodecFlag2"),
			(_, "ildct_cmp") => force("DctComparison"),
			(_, "slice_flags") => force("CodecSliceFlag"),
			(_, "mb_decision") => force("MacroblockDecision"),
			var x when GetFriendlyTypeName(fieldType) != x.fieldTypeName => direct(GetFriendlyTypeName(fieldType)),
			var x => direct(x.fieldTypeName),
		};
		
		(string, string) force(string s) => (s, "force");
		(string, string) direct(string s) => (s, null);
		(string, string) call(string s, string m) => (s, "." + m);
	}
}