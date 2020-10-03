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
	
}

void WriteClass(Type targetType, string ns, string newName, 
	Func<string, (string, string?)?> propTypeMapping = null!,
	Func<string, string?> propNameMapping = null!, 
	string[]? additionalNamespaces = null, 
	bool writeStub = false)
{
	if (propTypeMapping == null) propTypeMapping = _ => null;
	if (propNameMapping == null) propNameMapping = _ => null;
	
	using var _file = new StreamWriter($"{newName}.g.cs");
	using var writer = new IndentedTextWriter(_file, new string(' ', 4));

	WriteBasic(writer, ns, () =>
	{
		WriteMultiLines(writer, BuildTypeDocument(targetType));
		writer.WriteLine($"public unsafe partial class {newName} : FFmpegSafeObject");
		PushIndent(writer, WriteClassBodies);
	}, additionalNamespaces: additionalNamespaces);
	
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
			.Select(x => Convert(x, "Pointer", propNameMapping, propTypeMapping)))
			.Split("\r\n"))
		{
			writer.WriteLine(line);
		};
	}
}

string BuildPrefix(FieldInfo field, ObsoleteAttribute? obsolete)
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
	Func<string, (string, string?)?> propTypeMapping = null!,
	Func<string, string?> propNameMapping = null!, 
	bool writeStub = false, 
	bool hideCallback = true)
{
	if (propTypeMapping == null) propTypeMapping = _ => null;
	if (propNameMapping == null) propNameMapping = _ => null;

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
			.Select(x => Convert(x, "_ptr", propNameMapping, propTypeMapping)))
			.Split("\r\n"))
		{
			writer.WriteLine(line);
		};
	}
}

string Convert(FieldInfo field, string pointerName, Func<string, string?> propNameMapping, Func<string, (string, string?)?> propTypeMapping)
{
	string fieldName = IdentifierConvert(field.Name);
	string propName = FieldConvert(field.Name, propNameMapping);
	(string destType, string? method) = FromTypeString(field, propTypeMapping);
	ObsoleteAttribute? obsolete = field.GetCustomAttribute<ObsoleteAttribute>();

	bool isCallback = field.FieldType.Name.EndsWith("_func");
	bool isObsolete = obsolete != null;
	string modifier = (isCallback || isObsolete) ? "internal" : "public";

	return BuildFieldDocument(field) + BuildPrefix(field, obsolete) + method switch
	{
		null =>
			$"{modifier} {destType} {propName}\r\n" +
			$"{{\r\n" +
			$"    get => {pointerName}->{fieldName};\r\n" +
			$"    set => {pointerName}->{fieldName} = value;\r\n" +
			$"}}",
		"str" =>
			$"{modifier} {destType} {propName}\r\n" +
			$"{{\r\n" +
			$"    get => System.Runtime.InteropServices.Marshal.PtrToStringUTF8((IntPtr){pointerName}->{fieldName});\r\n" + 
	        $"    set\r\n" + 
	        $"    {{\r\n" + 
	        $"        if ({pointerName}->{fieldName} != null)\r\n" + 
	        $"        {{\r\n" + 
	        $"            av_free({pointerName}->{fieldName});\r\n" + 
	        $"            {pointerName}->{fieldName} = null;\r\n" + 
	        $"        }}\r\n" + 
			$"\r\n" + 
	        $"        if (value != null)\r\n" + 
	        $"        {{\r\n" + 
	        $"            {pointerName}->{fieldName} = av_strdup(value);\r\n" + 
	        $"        }}\r\n" + 
	        $"    }}\r\n" + 
	        $"}}\r\n", 
		"force" =>
			$"{modifier} {destType} {propName}\r\n" +
			$"{{\r\n" +
			$"    get => ({destType}){pointerName}->{fieldName};\r\n" +
			$"    set => {pointerName}->{fieldName} = ({GetFriendlyTypeName(field.FieldType)})value;\r\n" +
			$"}}",
		".FromNativeNotOwner" =>
			$"{modifier} {destType} {propName}\r\n" +
			$"{{\r\n" +
			$"    get => {destType}.FromNative({pointerName}->{fieldName}, isOwner: false);\r\n" +
			$"    set => {pointerName}->{fieldName} = value;\r\n" +
			$"}}",
		var x when x.StartsWith('.') =>
			$"{modifier} {destType} {propName}\r\n" +
			$"{{\r\n" +
			$"    get => {destType}{method}({pointerName}->{fieldName});\r\n" +
			$"    set => {pointerName}->{fieldName} = value;\r\n" +
			$"}}",
		_ => throw new ArgumentOutOfRangeException(method),
	};
}

(string destType, string? method) FromTypeString(FieldInfo field, Func<string, (string destType, string? method)?> propTypeMapping)
{
	Type fieldType = field.FieldType;
	return (fieldTypeName: fieldType.Name, fieldName: field.Name) switch
	{
		var x when propTypeMapping(field.Name) != null => propTypeMapping(field.Name)!.Value,
		("AVClass*", _) => call("FFmpegClass", "FromNative"),
		("AVCodec*", _) => call("Codec", "FromNative"),
		("AVIOContext*", _) => call("MediaIO", "FromNativeNotOwner"),
		("AVRational", _) => direct("MediaRational"),
		("AVDictionary*", _) => call("MediaDictionary", "FromNativeNotOwner"), 
		("Void*", _) => force("IntPtr"),
		("Byte*", _) => force("IntPtr"),
		("byte_ptrArray4", _) => force("Ptr4"),
		("void_ptrArray4", _) => force("Ptr4"),
		("byte_ptrArray8", _) => force("Ptr8"),
		("void_ptrArray8", _) => force("Ptr8"),
		("int_array4", _) => force("Int32x4"), 
		("int_array8", _) => force("Int32x8"), 
		("AVBufferRef*", _) => call("BufferReference", "FromNativeNotOwner"), 
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
		("AVDurationEstimationMethod", _) => force("DurationEstimationMethod"), 
		("AVInputFormat*", _) => call("InputFormat", "FromNativeNotOwner"), 
		("AVOutputFormat*", _) => call("OutputFormat", "FromNativeNotOwner"), 
		var x when GetFriendlyTypeName(fieldType) != x.fieldTypeName => direct(GetFriendlyTypeName(fieldType)),
		var x => direct(x.fieldTypeName),
	};
}

(string, string) str() => ("string", "str");
(string, string) force(string s) => (s, "force");
(string, string?) direct(string s) => (s, null);
(string, string) call(string s, string m) => (s, "." + m);