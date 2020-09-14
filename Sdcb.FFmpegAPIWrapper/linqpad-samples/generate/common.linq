<Query Kind="Program">
  <NuGetReference Prerelease="true">Sdcb.FFmpegAPIWrapper</NuGetReference>
  <Namespace>FFmpeg.AutoGen</Namespace>
  <Namespace>Sdcb.FFmpegAPIWrapper.Common</Namespace>
  <Namespace>System.CodeDom.Compiler</Namespace>
  <Namespace>Microsoft.CSharp</Namespace>
  <Namespace>System.CodeDom</Namespace>
</Query>

void Main()
{
	
}

Dictionary<string, string> docs = XDocument
	.Load(Path.Combine(Path.GetDirectoryName(typeof(AVRational).Assembly.Location), Path.GetFileNameWithoutExtension(typeof(AVRational).Assembly.Location)) + ".xml")
	.XPathSelectElements("doc/members/member")
	.ToDictionary(k => k.Attribute("name").Value, v => string.Join("\r\n", v.Nodes().Select(x => x.ToString())));

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