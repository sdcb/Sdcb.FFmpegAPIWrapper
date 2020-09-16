<Query Kind="Program">
  <NuGetReference Prerelease="true">Sdcb.FFmpegAPIWrapper</NuGetReference>
  <Namespace>FFmpeg.AutoGen</Namespace>
  <Namespace>Sdcb.FFmpegAPIWrapper.Common</Namespace>
  <Namespace>System.CodeDom.Compiler</Namespace>
  <Namespace>Microsoft.CSharp</Namespace>
  <Namespace>System.CodeDom</Namespace>
</Query>

#load ".\common"

void Main()
{
	string baseDir = Path.GetFullPath(Path.Combine(Util.CurrentQuery.Location, @"..\..\MediaCodecs\GeneratedTypes"));
	Directory.CreateDirectory(baseDir);
	Environment.CurrentDirectory = baseDir;
	
	WriteClass(typeof(AVCodecParameters), "Sdcb.FFmpegAPIWrapper.MediaCodecs", "CodecParameters");
}

void WriteClass(Type targetType, string ns, string newName, HashSet<string> obsoleteFields = null, Func<string, string> propNameMapping = null)
{
	if (obsoleteFields == null) obsoleteFields = new HashSet<string>();
	if (propNameMapping == null) propNameMapping = str => null;

	using var _file = new StreamWriter($"{newName}.g.cs");
	using var writer = new IndentedTextWriter(_file, new string(' ', 4));

	WriteBasic(writer, ns, () =>
	{
		WriteMultiLines(writer, BuildTypeDocument(targetType));
		writer.WriteLine($"public unsafe partial class {newName}: FFmpegHandle");
		PushIndent(writer, WriteClassBodies);
	});

	void WriteClassBodies()
	{
		WriteLine($"protected {targetType.Name}* Pointer => this;");
		WriteLine();
		WriteLine($"public static implicit operator {targetType.Name}*({newName} data) => ({targetType.Name}*)data._handle;");
		WriteLine();

		WriteLine($"protected {newName}({targetType.Name}* ptr, bool isOwner): base((IntPtr)ptr, isOwner)");
		WriteLine("{");
		WriteLine("    if (ptr == null)");
		WriteLine("    {");
		WriteLine("        throw new ArgumentNullException(nameof(ptr));");
		WriteLine("    }");
		WriteLine("}");
		WriteLine();
		WriteLine($"public static {newName} FromNative({targetType.Name}* ptr, bool isOwner) => new {newName}(ptr, isOwner);");
		WriteLine();

		foreach (string line in string.Join("\r\n\r\n", targetType
			.GetFields()
			.Select(Convert))
			.Split("\r\n"))
		{
			WriteLine(line);
		};
	}

	void WriteLine(string text = null) => writer.WriteLine(text);

	string PropertyConvert(FieldInfo field)
	{
		Dictionary<string, string> knownMapping = new()
		{
			["pkt"] = "Packet",
			["pix_"] = "Pixel_",
			["fmt"] = "Format",
			["ctx"] = "Context",
			["priv_"] = "Private_"
		};

		string fieldName = field.Name;
		foreach (var m in knownMapping)
		{
			fieldName = fieldName.Replace(m.Key, m.Value);
		}

		return PascalCase(fieldName);
	}

	string Convert(FieldInfo field)
	{
		string fieldName = IdentifierConvert(field.Name);
		string propName = PropertyConvert(field);
		(string destType, string method) = FromTypeString(field);

		return BuildFieldDocument(field) + BuildPrefix() + method switch
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

		string BuildPrefix() => obsoleteFields.Contains(field.Name) ? "[Obsolete]\r\n" : "";

		(string destType, string method) FromTypeString(FieldInfo field)
		{
			Type fieldType = field.FieldType;
			return (fieldTypeName: fieldType.Name, fieldName: field.Name) switch
			{
				("AVClass*", _) => call("FFmpegClass", "FromNative"),
				("AVCodec*", _) => call("Codec", "FromNative"),
				("AVRational", _) => direct("MediaRational"),
				("Void*", _) => force("IntPtr"),
				("AVPixelFormat", _) => force("PixelFormat"),
				("AVSampleFormat", _) => force("SampleFormat"),
				("AVCodecID", _) => force("CodecID"),
				("AVMediaType", _) => force("MediaType"),
				("AVDiscard", _) => force("MediaDiscard"),
				("AVFieldOrder", _) => force("FieldOrder"),
				("AVColorRange", _) => force("ColorRange"),
				("AVColorPrimaries", _) => force("ColorPrimaries"),
				("AVColorTransferCharacteristic", _) => force("ColorTransferCharacteristic"),
				("AVColorSpace", _) => force("ColorSpace"),
				("AVChromaLocation", _) => force("ChromaLocation"),
				var x when propNameMapping(field.Name) != null => force(propNameMapping(field.Name)),
				var x when GetFriendlyTypeName(fieldType) != x.fieldTypeName => direct(GetFriendlyTypeName(fieldType)),
				var x => direct(x.fieldTypeName),
			};

			(string, string) force(string s) => (s, "force");
			(string, string) direct(string s) => (s, null);
			(string, string) call(string s, string m) => (s, "." + m);
		}
	}
}