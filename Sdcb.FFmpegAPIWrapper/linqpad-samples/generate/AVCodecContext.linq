<Query Kind="Statements">
  <NuGetReference Prerelease="true">Sdcb.FFmpegAPIWrapper</NuGetReference>
  <Namespace>FFmpeg.AutoGen</Namespace>
  <Namespace>Sdcb.FFmpegAPIWrapper.Common</Namespace>
  <Namespace>System.CodeDom.Compiler</Namespace>
  <Namespace>Microsoft.CSharp</Namespace>
  <Namespace>System.CodeDom</Namespace>
</Query>

Environment.CurrentDirectory = Path.GetFullPath(Path.Combine(Util.CurrentQuery.Location, @"..\..\MediaCodecs"));
using var _file = new StreamWriter("MediaCodecContext.g.cs");
using var writer = new IndentedTextWriter(_file, new string(' ', 4));

WriteUsings();
WriteNamespace("Sdcb.FFmpegAPIWrapper.MediaCodecs", 
	() => WriteClass("MediaCodecContext : FFmpegHandle", WriteClassBodies));
	

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
	
	using var c = new FieldInfoConverter();
	foreach (string line in string.Join("\r\n\r\n", typeof(AVCodecContext)
		.GetFields()
		.Select(c.Convert))
		.Split("\r\n"))
	{
		WriteLine(line);
	};
}

void WriteUsings()
{
	WriteLine("using System;");
	WriteLine("using Sdcb.FFmpegAPIWrapper.Common;");
	WriteLine("using FFmpeg.AutoGen;");
	WriteLine("using static FFmpeg.AutoGen.ffmpeg;");
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

public class FieldInfoConverter : IDisposable
{
	public string Convert(FieldInfo field)
	{
		string fieldName = IdentifierConvert(field.Name);
		string propName = PascalCase(fieldName);
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
	}

	string PascalCase(string input)
	{
		return string.Concat(input
			.Split('_')
			.Select(x => char.ToUpper(x[0]) + x[1..]));
	}

	string IdentifierConvert(string syntax)
	{
		return compiler.IsValidIdentifier(syntax) ? syntax : "@" + syntax;
	}

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
			var x when GetFriendlyTypeName(fieldType) != x => (GetFriendlyTypeName(fieldType), null),
			var x => new (x, null),
		};
	}

	string GetFriendlyTypeName(Type type, bool includeNamespace = false)
	{
		var aliasMapping = new Dictionary<Type, string>()
		{
			{ typeof(void), "void" },
			{ typeof(char), "char" },
			{ typeof(string), "string" },
			{ typeof(bool), "bool" },
			{ typeof(object), "object" },
			{ typeof(float), "float" },
			{ typeof(double), "double" },
			{ typeof(decimal), "decimal" },
			{ typeof(sbyte), "sbyte" },
			{ typeof(short), "short" },
			{ typeof(int), "int" },
			{ typeof(long), "long" },
			{ typeof(byte), "byte" },
			{ typeof(ushort), "ushort" },
			{ typeof(uint), "uint" },
			{ typeof(ulong), "ulong" },
		};

		return GetTypeNameCore(type);

		string GetTypeNameCore(Type type)
		{
			if (type.IsPointer)
				return GetTypeNameCore(type.GetElementType()) + "*";
			if (type.IsByRef)
				return GetTypeNameCore(type.GetElementType());

			if (type.IsArray)
			{
				Type elementType = type.GetElementType();
				int dimensions = type.GetArrayRank();

				return String.Format("{0}[{1}]", GetTypeNameCore(elementType), new string(',', dimensions - 1));
			}

			if (type.IsGenericType && !type.IsGenericTypeDefinition)
			{
				Type baseType = type.GetGenericTypeDefinition();

				Type[] typeArgs = type.GetGenericArguments();

				if (baseType.IsValueType && baseType.Name == "Nullable`1")
					return GetTypeNameCore(typeArgs[0]) + "?";

				string argStrings = String.Join(", ", typeArgs.Select(GetTypeNameCore));

				return String.Format("{0}<{1}>", GetTypeNameCore(baseType).Split(new char[] { '`' }, 2)[0], argStrings);
			}

			if (aliasMapping.TryGetValue(type, out string alias))
			{
				return alias;
			}

			return includeNamespace ? type.FullName : type.Name;
		}
	}

	CodeDomProvider compiler = new CSharpCodeProvider();

	Dictionary<string, string> docs = XDocument.Load(Path.Combine(Path.GetDirectoryName(typeof(AVRational).Assembly.Location), Path.GetFileNameWithoutExtension(typeof(AVRational).Assembly.Location)) + ".xml")
		.XPathSelectElements("doc/members/member")
		.ToDictionary(k => k.Attribute("name").Value, v => string.Join("\r\n", v.Nodes().Select(x => x.ToString())));

	public void Dispose() => compiler.Dispose();
}