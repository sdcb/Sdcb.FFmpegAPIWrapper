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
	writer.WriteLine("{");
	PushIndent(writer, bodyWriter);
	writer.WriteLine("}");
}

void WriteLine(string text = null) => writer.WriteLine(text);

string Convert(FieldInfo field)
{
	string fieldName = IdentifierConvert(field.Name);
	string propName = PascalCase(field.Name);
	(string destType, string method) = FromTypeString(field);
	string docKey = $"F:{field.DeclaringType.FullName}.{fieldName}";
	string document = "";
	if (docs.TryGetValue(docKey, out document))
	{
		document = String.Join("\r\n", document
			.Split("\r\n")
			.Select(x => "/// " + x)) + "\r\n";
	}

	return document + method switch
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
		return fieldType.Name switch
		{
			"AVClass*" => ("FFmpegClass", ".FromNative"),
			"AVCodec*" => ("MediaCodec", ".FromNative"),
			"AVRational" => ("MediaRational", null),
			"Void*" => ("IntPtr", "force"),
			var x when field.Name == "flags" => ("CodecFlags", "force"),
			var x when field.Name == "flags2" => ("CodecFlags2", "force"),
			var x when field.Name == "ildct_cmp" => ("InterlacedDctComparison", "force"),
			var x when field.Name == "slice_flags" => ("CodecSliceFlags", "force"),
			var x when field.Name == "mb_decision" => ("MacroblockDecisions", "force"),
			var x when GetFriendlyTypeName(fieldType) != x => (GetFriendlyTypeName(fieldType), null),
			var x => new(x, null),
		};
	}
}