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
	
	string BuildPrefix() => IsObsoleteField(field.Name) ? "[Obsolete]\r\n" : "";

	(string destType, string method) FromTypeString(FieldInfo field)
	{
		Type fieldType = field.FieldType;
		return (fieldTypeName: fieldType.Name, fieldName: field.Name) switch
		{
			("AVClass*", _) => call("FFmpegClass", "FromNative"),
			("AVCodec*", _) => call("MediaCodec", "FromNative"),
			("AVRational", _) => direct("MediaRational"),
			("Void*", _) => force("IntPtr"),
			("AVPixelFormat", _) => force("PixelFormat"), 
			("AVSampleFormat", _) => force("SampleFormat"), 
			("AVCodecID", _) => force("CodecID"), 
			("AVMediaType", _) => force("MediaType"), 
			("AVDiscard", _) => force("MediaDiscard"), 
			(_, "flags") => force("CodecFlag"),
			(_, "flags2") => force("CodecFlag2"),
			(_, "ildct_cmp") => force("DctComparison"),
			(_, "slice_flags") => force("CodecSliceFlag"),
			(_, "mb_decision") => force("MacroblockDecision"),
			(_, "export_side_data") => force("CodecExportData"), 
			var x when GetFriendlyTypeName(fieldType) != x.fieldTypeName => direct(GetFriendlyTypeName(fieldType)),
			var x => direct(x.fieldTypeName),
		};
		
		(string, string) force(string s) => (s, "force");
		(string, string) direct(string s) => (s, null);
		(string, string) call(string s, string m) => (s, "." + m);
	}
}

bool IsObsoleteField(string fieldName) => new HashSet<string>
{
	nameof(AVCodecContext.b_frame_strategy),
	nameof(AVCodecContext.mpeg_quant),
	nameof(AVCodecContext.prediction_method),
	nameof(AVCodecContext.pre_me),
	nameof(AVCodecContext.scenechange_threshold),
	nameof(AVCodecContext.noise_reduction),
	nameof(AVCodecContext.me_penalty_compensation),
	nameof(AVCodecContext.brd_scale),
	nameof(AVCodecContext.chromaoffset),
	nameof(AVCodecContext.b_sensitivity),
	nameof(AVCodecContext.refcounted_frames),
	nameof(AVCodecContext.coder_type),
	nameof(AVCodecContext.context_model),
	nameof(AVCodecContext.frame_skip_threshold),
	nameof(AVCodecContext.frame_skip_factor),
	nameof(AVCodecContext.frame_skip_exp),
	nameof(AVCodecContext.frame_skip_cmp),
	nameof(AVCodecContext.min_prediction_order),
	nameof(AVCodecContext.max_prediction_order),
	nameof(AVCodecContext.timecode_frame_start),
	nameof(AVCodecContext.rtp_callback),
	nameof(AVCodecContext.rtp_payload_size),
	nameof(AVCodecContext.mv_bits),
	nameof(AVCodecContext.header_bits),
	nameof(AVCodecContext.i_tex_bits),
	nameof(AVCodecContext.p_tex_bits),
	nameof(AVCodecContext.i_count),
	nameof(AVCodecContext.p_count),
	nameof(AVCodecContext.skip_count),
	nameof(AVCodecContext.misc_bits),
	nameof(AVCodecContext.frame_bits),
	nameof(AVCodecContext.coded_frame),
	nameof(AVCodecContext.vbv_delay),
	nameof(AVCodecContext.side_data_only_packets),
}.Contains(fieldName);