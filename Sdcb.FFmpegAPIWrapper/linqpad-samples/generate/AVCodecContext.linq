<Query Kind="Statements">
  <NuGetReference Prerelease="true">Sdcb.FFmpegAPIWrapper</NuGetReference>
  <Namespace>FFmpeg.AutoGen</Namespace>
  <Namespace>Sdcb.FFmpegAPIWrapper.Common</Namespace>
  <Namespace>System.CodeDom.Compiler</Namespace>
  <Namespace>Microsoft.CSharp</Namespace>
  <Namespace>System.CodeDom</Namespace>
</Query>

#load ".\common"
#load "generate\write-class"

string baseDir = Path.GetFullPath(Path.Combine(Util.CurrentQuery.Location, @"..\..\MediaCodecs\GeneratedTypes"));
Directory.CreateDirectory(baseDir);
Environment.CurrentDirectory = baseDir;

var obsoleteFields = new HashSet<string>
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
};
WriteClass(typeof(AVCodecContext), "Sdcb.FFmpegAPIWrapper.MediaCodecs", "CodecContext", obsoleteFields, x => x switch
{
	"flags" => "CodecFlag",
	"flags2" => "CodecFlag2",
	"ildct_cmp" => "DctComparison",
	"slice_flags" => "CodecSliceFlag",
	"mb_decision" => "MacroblockDecision",
	"export_side_data" => "CodecExportData",
	_ => null, 
});