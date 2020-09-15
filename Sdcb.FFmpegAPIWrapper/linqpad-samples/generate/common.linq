<Query Kind="Program">
  <NuGetReference Prerelease="true">Sdcb.FFmpegAPIWrapper</NuGetReference>
  <Namespace>FFmpeg.AutoGen</Namespace>
  <Namespace>Sdcb.FFmpegAPIWrapper.Common</Namespace>
  <Namespace>System.CodeDom.Compiler</Namespace>
  <Namespace>Microsoft.CSharp</Namespace>
  <Namespace>System.CodeDom</Namespace>
  <Namespace>System.Web</Namespace>
</Query>

void Main()
{

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

string PascalCase(string input)
{
	return string.Concat(input
		.Split('_')
		.Select(x => char.ToUpper(x[0]) + x[1..]));
}

void PushIndent(IndentedTextWriter writer, Action action)
{
	writer.WriteLine("{");
	writer.Indent += 1;
	action();
	writer.Indent -= 1;
	writer.WriteLine("}");
}

void WriteBasic(IndentedTextWriter writer, string ns, Action bodyWriter)
{
	writer.WriteLine("using System;");
	writer.WriteLine("using Sdcb.FFmpegAPIWrapper.Common;");
	writer.WriteLine("using FFmpeg.AutoGen;");
	writer.WriteLine("using static FFmpeg.AutoGen.ffmpeg;");
	writer.WriteLine();

	writer.WriteLine($"namespace {ns}");
	PushIndent(writer, bodyWriter);
}

CodeDomProvider csharpCompiler = new CSharpCodeProvider();
string IdentifierConvert(string syntax)
{
	return csharpCompiler.IsValidIdentifier(syntax) ? syntax : "@" + syntax;
}

Dictionary<string, DocumentEntry> docs = XDocument
	.Load(Path.Combine(Path.GetDirectoryName(typeof(AVRational).Assembly.Location), Path.GetFileNameWithoutExtension(typeof(AVRational).Assembly.Location)) + ".xml")
	.XPathSelectElements("doc/members/member")
	.ToDictionary(k => k.Attribute("name").Value, v =>
	{
		return new DocumentEntry(
			v.XPathSelectElement("summary")?.Value,
			v.XPathSelectElements("param").Select(x => new DocumentParameter(x.Attribute("name").Value, x.Value)).ToArray(),
			v.XPathSelectElement("results")?.Value);
	});

bool TryGetFieldDocument(FieldInfo field, out DocumentEntry value) => docs.TryGetValue($"F:{field.DeclaringType.FullName}.{field.Name}", out value);

string BuildPropertyXml(FieldInfo field)
{
	TryGetFieldDocument(field, out DocumentEntry d);
	var sb = new StringBuilder();
	
	sb.AppendLine("/// <summary>");
	if (d?.summary != null)
	{
		foreach (var line in d.summary.Split('.', StringSplitOptions.RemoveEmptyEntries))
		{
			sb.AppendLine("/// <para>" + HttpUtility.HtmlEncode(line) + ".</para>");
		}
	}
	sb.AppendLine($"/// <see cref=\"{field.DeclaringType.Name}.{field.Name}\" />");
	sb.AppendLine("/// </summary>");

//	foreach (var p in d.parameters)
//	{
//		sb.AppendLine($"/// <param name=\"{p.name}\">{HttpUtility.HtmlEncode(p.description)}</param>");
//	}
//
//	if (d.results != null)
//	{
//		sb.AppendLine($"/// <results>{HttpUtility.HtmlEncode(d.results)}</results>");
//	}

	return sb.ToString();
}

public class DocumentEntry
{
	public string summary { get; set; }
	public DocumentParameter[] parameters { get; set; }
	public string results { get; set; }

	public DocumentEntry(string summary, DocumentParameter[] parameters, string results)
	{
		this.summary = summary;
		this.parameters = parameters;
		this.results = results;
	}
}
public class DocumentParameter
{
	public string name { get; set; }
	public string description { get; set; }

	public DocumentParameter(string name, string description)
	{
		this.name = name;
		this.description = description;
	}
}