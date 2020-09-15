<Query Kind="Statements">
  <NuGetReference Prerelease="true">Sdcb.FFmpegAPIWrapper</NuGetReference>
  <Namespace>FFmpeg.AutoGen</Namespace>
  <Namespace>Sdcb.FFmpegAPIWrapper.Common</Namespace>
  <Namespace>System.CodeDom.Compiler</Namespace>
  <Namespace>Microsoft.CSharp</Namespace>
  <Namespace>System.CodeDom</Namespace>
</Query>

#load ".\common"

string baseDir = Path.GetFullPath(Path.Combine(Util.CurrentQuery.Location, @"..\..\MediaCodecs\GeneratedEnums"));
Directory.CreateDirectory(baseDir);
Environment.CurrentDirectory = baseDir;

string ns = "Sdcb.FFmpegAPIWrapper.MediaCodecs";
WriteEnum(typeof(AVSampleFormat), ns, "MediaSampleFormat");
WriteEnum(typeof(AVPixelFormat), ns, "MediaPixelFormat");
WriteEnum(typeof(AVMediaType), ns, "MediaType");
WriteEnum(typeof(AVAudioServiceType), ns, "AudioServiceType");

WriteConstEnum("AV_CODEC_FLAG_", ns, "CodecFlag");
WriteConstEnum("AV_CODEC_FLAG2_", ns, "CodecFlag2");
WriteConstEnum("SLICE_FLAG_", ns, "CodecSliceFlag");
WriteConstEnum("AV_CH_LAYOUT_", ns, "ChannelLayout");
WriteConstEnum("AV_CODEC_CAP_", ns, "CodecCompability");
WriteConstEnum("FF_MB_DECISION_", ns, "MBDecisions");
WriteConstEnum("FF_CMP_", ns, "DctComparison");


void WriteConstEnum(string prefix, string ns, string newName)
{
	using var _file = new StreamWriter(newName + ".g.cs");
	using var writer = new IndentedTextWriter(_file, new string(' ', 4));
	FieldInfo[] fields = typeof(ffmpeg)
		.GetFields(BindingFlags.Static | BindingFlags.Public)
		.Where(x => x.Name.StartsWith(prefix))
		.ToArray();
	Debug.Assert(fields.Length > 0);

	decimal maxValue = fields.Max(x => Convert.ToDecimal(x.GetValue(null)));
	Type underlyingType = maxValue switch
	{
		> long.MaxValue => typeof(ulong),
		> uint.MaxValue => typeof(long),
		> int.MaxValue => typeof(uint),
		_ => typeof(int)
	};

	WriteBasic(writer, ns, WriteBody);

	void WriteBody()
	{
		string suffix = underlyingType switch
		{
			var x when x == typeof(int) => "",
			_ => " : " + GetFriendlyTypeName(underlyingType),
		};

		writer.WriteLine($"public enum {newName}{suffix}");
		PushIndent(writer, WriteElements);
	}

	void WriteElements()
	{
		foreach (FieldInfo field in fields)
		{
			string name = PascalCase(field.Name.Replace(prefix, ""));

			WriteMultiLines(writer, BuildFieldDocument(field));
			writer.WriteLine($"{name} = {CSharpLiteral(field.GetValue(null), underlyingType)},");
			if (field != fields.Last())
			{
				writer.WriteLine();
			}
		}
	}
}

void WriteEnum(Type enumType, string ns, string newName)
{
	using var _file = new StreamWriter(newName + ".g.cs");
	using var writer = new IndentedTextWriter(_file, new string(' ', 4));

	Type underlyingType = Enum.GetUnderlyingType(enumType);
	WriteBasic(writer, ns, WriteBody);

	void WriteBody()
	{
		string suffix = underlyingType != typeof(int) ? " : " + GetFriendlyTypeName(underlyingType) : "";

		WriteMultiLines(writer, BuildTypeDocument(enumType));
		writer.WriteLine($"public enum {newName}{suffix}");
		PushIndent(writer, WriteElements);
	}

	void WriteElements()
	{
		string[] names = Enum.GetNames(enumType);
		Array values = Enum.GetValues(enumType);
		string commonPrefix = FindCommonPrefix(names);

		for (var i = 0; i < names.Length; ++i)
		{
			string cname = names[i];
			string name = PascalCase(cname.Replace(commonPrefix, ""));

			WriteMultiLines(writer, BuildFieldDocument(enumType.GetField(cname)));
			writer.WriteLine($"{name} = {CSharpLiteral(values.GetValue(i), underlyingType)},");
			if (i < names.Length - 1)
			{
				writer.WriteLine();
			}
		}
	}

	string FindCommonPrefix(string[] names) => new string(names
		.First()
		.Substring(0, names.Min(s => s.Length))
		.TakeWhile((c, i) => names.All(s => s[i] == c))
		.ToArray());
}

string CSharpLiteral(object val, Type underlyingType) => Type.GetTypeCode(underlyingType) switch
{
	TypeCode.Int32 => $"0x{val:X}",
	TypeCode.UInt32 => $"0x{val:X}U",
	TypeCode.Int64 => $"0x{val:X}L",
	TypeCode.UInt64 => $"0x{val:X}UL",
	_ => throw new ArgumentOutOfRangeException(),
};

void WriteMultiLines(IndentedTextWriter writer, string multiLines)
{
	foreach (string line in multiLines.Split("\r\n", StringSplitOptions.RemoveEmptyEntries))
	{
		writer.WriteLine(line);
	}
}