<Query Kind="Statements">
  <NuGetReference Prerelease="true">Sdcb.FFmpegAPIWrapper</NuGetReference>
  <Namespace>FFmpeg.AutoGen</Namespace>
  <Namespace>Sdcb.FFmpegAPIWrapper.Common</Namespace>
  <Namespace>System.CodeDom.Compiler</Namespace>
  <Namespace>Microsoft.CSharp</Namespace>
  <Namespace>System.CodeDom</Namespace>
</Query>

#load ".\common"

{
	SetDir(@"\MediaCodecs\GeneratedEnums");

	string ns = "Sdcb.FFmpegAPIWrapper.MediaCodecs";
	WriteEnum(typeof(AVSampleFormat), ns, "SampleFormat");
	WriteEnum(typeof(AVPixelFormat), ns, "PixelFormat");
	WriteEnum(typeof(AVMediaType), ns, "MediaType");
	WriteEnum(typeof(AVAudioServiceType), ns, "AudioServiceType");
	WriteEnum(typeof(AVCodecID), ns, "CodecID");
	WriteEnum(typeof(AVDiscard), ns, "MediaDiscard");
	WriteEnum(typeof(AVFieldOrder), ns, "FieldOrder");
	WriteEnum(typeof(AVColorRange), ns, "ColorRange");
	WriteEnum(typeof(AVColorPrimaries), ns, "ColorPrimaries");
	WriteEnum(typeof(AVColorTransferCharacteristic), ns, "ColorTransferCharacteristic");
	WriteEnum(typeof(AVColorSpace), ns, "ColorSpace");
	WriteEnum(typeof(AVChromaLocation), ns, "ChromaLocation");
	WriteEnum(typeof(AVPictureType), ns, "PictureType");
	WriteEnum(typeof(AVPacketSideDataType), ns, "PacketSideDataType");

	WriteConstEnum("AV_CODEC_FLAG_", ns, "CodecFlag");
	WriteConstEnum("AV_CODEC_FLAG2_", ns, "CodecFlag2");
	WriteConstEnum("SLICE_FLAG_", ns, "CodecSliceFlag");
	WriteConstEnum("AV_CH_LAYOUT_", ns, "ChannelLayout");
	WriteConstEnum("AV_CODEC_CAP_", ns, "CodecCompability");
	WriteConstEnum("FF_MB_DECISION_", ns, "MacroblockDecision");
	WriteConstEnum("FF_CMP_", ns, "DctComparison");
	WriteConstEnum("AV_CODEC_EXPORT_DATA_", ns, "CodecExportData");
}

{
	SetDir(@"\Common\GeneratedEnums");
	string ns = "Sdcb.FFmpegAPIWrapper.Common";
	WriteEnum(typeof(AVClassCategory), ns, "FFmpegCategory");
	WriteEnum(typeof(AVOptionType), ns, "FFmpegOptionType");
	WriteConstEnum("AV_OPT_FLAG_", ns, "FFmpegOptionFlags");
	WriteConstEnum("AV_OPT_SEARCH_", ns, "OptionSearchFlags");
}

void WriteConstEnum(string prefix, string ns, string newName)
{
	using var _file = new StreamWriter(newName + ".g.cs");
	using var writer = new IndentedTextWriter(_file, new string(' ', 4));
	FieldInfo[] fields = typeof(ffmpeg)
		.GetFields(BindingFlags.Static | BindingFlags.Public)
		.Where(x => x.Name.StartsWith(prefix))
		.ToArray();
	Debug.Assert(fields.Length > 0);

	Type underlyingType = FindBestTypeForValues(fields.Select(x => Convert.ToDecimal(x.GetValue(null))));

	WriteBasic(writer, ns, WriteBody);

	void WriteBody()
	{
		string suffix = underlyingType switch
		{
			var x when x == typeof(int) => "",
			_ => " : " + GetFriendlyTypeName(underlyingType),
		};

		if (underlyingType == typeof(uint) || underlyingType == typeof(ulong))
		{
			writer.WriteLine("[Flags]");
		}
		writer.WriteLine($"public enum {newName}{suffix}");
		PushIndent(writer, WriteElements);
	}

	void WriteElements()
	{
		foreach (FieldInfo field in fields.OrderBy(x => Convert.ToDecimal(x.GetValue(null))))
		{
			string name = PascalCase(field.Name.Replace(prefix, ""));

			WriteMultiLines(writer, BuildFieldDocument(field));
			writer.WriteLine($"{name} = {CSharpLiteral(field.GetValue(null), underlyingType)},");
			writer.WriteLine();
		}
	}

	Type FindBestTypeForValues(IEnumerable<decimal> values) => values.Max() switch
	{
		> long.MaxValue => typeof(ulong),
		> uint.MaxValue => typeof(long),
		> int.MaxValue => typeof(uint),
		_ => typeof(int)
	};
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
		if (underlyingType == typeof(uint) || underlyingType == typeof(ulong))
		{
			writer.WriteLine("[Flags]");
		}
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
	TypeCode.Int32 => $"{(int)val}",
	TypeCode.UInt32 => $"0x{val:X}U",
	TypeCode.Int64 => $"0x{val:X}L",
	TypeCode.UInt64 => $"0x{val:X}UL",
	_ => throw new ArgumentOutOfRangeException(),
};

void SetDir(string dir)
{
	string baseDir = Path.GetFullPath(Path.Combine(Util.CurrentQuery.Location, @"..\.." + dir));
	Directory.CreateDirectory(baseDir);
	Environment.CurrentDirectory = baseDir;

	foreach (var item in Directory.EnumerateFiles(".", "*.g.cs"))
	{
		File.Delete(item);
		Util.FixedFont($"Deleted {item}").Dump();
	}
}