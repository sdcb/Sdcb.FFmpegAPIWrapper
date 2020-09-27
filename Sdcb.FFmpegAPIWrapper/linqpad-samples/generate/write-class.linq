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
	
	string ns = "Sdcb.FFmpegAPIWrapper.MediaCodecs";
	WriteClass(typeof(AVCodecParameters), ns, "CodecParameters");
	WriteClass(typeof(AVFrame), ns, "Frame");
	WriteClass(typeof(AVPacket), ns, "Packet", writeStub: true);
	WriteStruct(typeof(AVPacketSideData), ns, "PacketSideData");
}

void WriteClass(Type targetType, string ns, string newName, 
	Func<string, string> propNameMapping = null,
	bool writeStub = false)
{
	if (propNameMapping == null) propNameMapping = str => null;

	using var _file = new StreamWriter($"{newName}.g.cs");
	using var writer = new IndentedTextWriter(_file, new string(' ', 4));

	WriteBasic(writer, ns, () =>
	{
		WriteMultiLines(writer, BuildTypeDocument(targetType));
		writer.WriteLine($"public unsafe partial class {newName} : FFmpegSafeObject");
		PushIndent(writer, WriteClassBodies);
	});
	
	if (writeStub && !File.Exists(newName + ".stub.cs"))
	{
		using var placeholder = new StreamWriter($"{newName}.stub.cs");
		using var placeholderWriter = new IndentedTextWriter(placeholder, new string(' ', 4));
		WriteBasic(placeholderWriter, ns, () =>
		{
			placeholderWriter.WriteLine($"public unsafe partial class {newName} : FFmpegHandle");
			PushIndent(placeholderWriter, () =>
			{
				placeholderWriter.WriteLine("public override void Close()");
				PushIndent(placeholderWriter, () =>
				{
					placeholderWriter.WriteLine("throw new NotImplementedException();");
				});
			});
		}, withHeader: false);
	}

	void WriteClassBodies()
	{
		writer.WriteLine($"protected {targetType.Name}* Pointer => this;");
		writer.WriteLine();
		writer.WriteLine($"public static implicit operator {targetType.Name}*({newName} data) => data != null ? ({targetType.Name}*)data._nativePointer : null;");
		writer.WriteLine();

		writer.WriteLine($"protected {newName}({targetType.Name}* ptr, bool isOwner): base(NativeUtils.NotNull((IntPtr)ptr), isOwner)");
		writer.WriteLine("{");
		writer.WriteLine("}");
		writer.WriteLine();
		writer.WriteLine($"public static {newName} FromNative({targetType.Name}* ptr, bool isOwner) => new {newName}(ptr, isOwner);");
		writer.WriteLine();

		foreach (string line in string.Join("\r\n\r\n", targetType
			.GetFields()
			.Select(Convert))
			.Split("\r\n"))
		{
			writer.WriteLine(line);
		};
	}

	string Convert(FieldInfo field)
	{
		string fieldName = IdentifierConvert(field.Name);
		string propName = PropertyConvert(field);
		(string destType, string method) = FromTypeString(field, propNameMapping);
		ObsoleteAttribute obsolete = field.GetCustomAttribute<ObsoleteAttribute>();

		return BuildFieldDocument(field) + BuildPrefix(field, obsolete) + method switch
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
	}
}

string BuildPrefix(FieldInfo field, ObsoleteAttribute obsolete)
{
	if (obsolete != null)
	{
		if (obsolete.Message != null)
		{
			return $"[Obsolete(\"{obsolete.Message}\")]\r\n";
		}
		else
		{
			return $"[Obsolete]\r\n";
		}
	}
	return "";
}

void WriteStruct(Type targetType, string ns, string newName,
	Func<string, string> propNameMapping = null,
	bool writeStub = false)
{
	if (propNameMapping == null) propNameMapping = str => null;

	using var _file = new StreamWriter($"{newName}.g.cs");
	using var writer = new IndentedTextWriter(_file, new string(' ', 4));

	WriteBasic(writer, ns, () =>
	{
		WriteMultiLines(writer, BuildTypeDocument(targetType));
		writer.WriteLine($"public unsafe partial struct {newName}");
		PushIndent(writer, WriteClassBodies);
	});

	if (writeStub && !File.Exists(newName + ".stub.cs"))
	{
		using var placeholder = new StreamWriter($"{newName}.stub.cs");
		using var placeholderWriter = new IndentedTextWriter(placeholder, new string(' ', 4));
		WriteBasic(placeholderWriter, ns, () =>
		{
			placeholderWriter.WriteLine($"public unsafe partial struct {newName}");
			PushIndent(placeholderWriter, () =>
			{
				placeholderWriter.WriteLine("public override void Close()");
				PushIndent(placeholderWriter, () =>
				{
					placeholderWriter.WriteLine("throw new NotImplementedException();");
				});
			});
		}, withHeader: false);
	}

	void WriteClassBodies()
	{
		writer.WriteLine($"private {targetType.Name}* _ptr;");
		writer.WriteLine();
		writer.WriteLine($"public static implicit operator {targetType.Name}*({newName} data) => ({targetType.Name}*)data._ptr;");
		writer.WriteLine();
		writer.WriteLine($"private {newName}({targetType.Name}* ptr)");
		writer.WriteLine("{");
		writer.WriteLine("    if (ptr == null)");
		writer.WriteLine("    {");
		writer.WriteLine("        throw new ArgumentNullException(nameof(ptr));");
		writer.WriteLine("    }");
		writer.WriteLine("    _ptr = ptr;");
		writer.WriteLine("}");
		writer.WriteLine();
		writer.WriteLine($"public static {newName} FromNative({targetType.Name}* ptr) => new {newName}(ptr);");
		writer.WriteLine();

		foreach (string line in string.Join("\r\n\r\n", targetType
			.GetFields()
			.Select(Convert))
			.Split("\r\n"))
		{
			writer.WriteLine(line);
		};
	}

	string Convert(FieldInfo field)
	{
		string fieldName = IdentifierConvert(field.Name);
		string propName = PropertyConvert(field);
		(string destType, string method) = FromTypeString(field, propNameMapping);
		ObsoleteAttribute obsolete = field.GetCustomAttribute<ObsoleteAttribute>();

		return BuildFieldDocument(field) + BuildPrefix(field, obsolete) + method switch
		{
			null =>
				$"public {destType} {propName}\r\n" +
				$"{{\r\n" +
				$"    get => _ptr->{fieldName};\r\n" +
				$"    set => _ptr->{fieldName} = value;\r\n" +
				$"}}",
			"force" =>
				$"public {destType} {propName}\r\n" +
				$"{{\r\n" +
				$"    get => ({destType})_ptr->{fieldName};\r\n" +
				$"    set => _ptr->{fieldName} = ({GetFriendlyTypeName(field.FieldType)})value;\r\n" +
				$"}}",
			var x when x.StartsWith(".") =>
				$"public {destType} {propName}\r\n" +
				$"{{\r\n" +
				$"    get => {destType}{method}(_ptr->{fieldName});\r\n" +
				$"    set => _ptr->{fieldName} = value;\r\n" +
				$"}}",
			_ => throw new ArgumentOutOfRangeException(method),
		};
	}
}

(string destType, string method) FromTypeString(FieldInfo field, Func<string, string> propNameMapping)
{
	Type fieldType = field.FieldType;
	return (fieldTypeName: fieldType.Name, fieldName: field.Name) switch
	{
		("AVClass*", _) => call("FFmpegClass", "FromNative"),
		("AVCodec*", _) => call("Codec", "FromNative"),
		("AVRational", _) => direct("MediaRational"),
		("Void*", _) => force("IntPtr"),
		("Byte*", _) => force("IntPtr"),
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
		("AVPictureType", _) => force("PictureType"),
		("AVPacketSideDataType", _) => force("PacketSideDataType"),
		var x when propNameMapping(field.Name) != null => force(propNameMapping(field.Name)),
		var x when GetFriendlyTypeName(fieldType) != x.fieldTypeName => direct(GetFriendlyTypeName(fieldType)),
		var x => direct(x.fieldTypeName),
	};

	(string, string) force(string s) => (s, "force");
	(string, string) direct(string s) => (s, null);
	(string, string) call(string s, string m) => (s, "." + m);
}

string PropertyConvert(FieldInfo field)
{
	Dictionary<string, string> knownMapping = new()
	{
		["pkt"] = "Packet",
		["pix_"] = "Pixel_",
		["fmt"] = "Format",
		["ctx"] = "Context",
		["priv_"] = "Private_",
		["pict_"] = "Picture_",
		["av_class"] = "FFmpegClass",
	};

	string fieldName = field.Name;
	foreach (var m in knownMapping)
	{
		fieldName = fieldName.Replace(m.Key, m.Value);
	}

	return PascalCase(fieldName);
}