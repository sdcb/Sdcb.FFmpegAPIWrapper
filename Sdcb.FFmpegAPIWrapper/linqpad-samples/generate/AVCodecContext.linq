<Query Kind="Statements">
  <NuGetReference Prerelease="true">Sdcb.FFmpegAPIWrapper</NuGetReference>
  <Namespace>FFmpeg.AutoGen</Namespace>
  <Namespace>Sdcb.FFmpegAPIWrapper.Common</Namespace>
</Query>

typeof(AVCodecContext)
	.GetFields()
	.Where(x => TypeMap(x.FieldType) == x.FieldType.Name)
	.Select(x => @$"public {TypeMap(x.FieldType)} {x.Name}
{{
    get => Pointer->{x.Name};
    set => Pointer->{x.Name} = value;
}}")
	.Dump();
	
string TypeMap(Type type)
{
	return type.Name switch
	{
		"Int32" => "int", 
		"UInt32" => "uint", 
		"Int64" => "long", 
		"UInt64" => "ulong", 
		"Single" => "float", 
		"AVClass*" => "FFmpegClass", 
		"AVCodec*" => "MediaCodec", 
		"AVRational" => "FFmpegRational", 
		var x when x.EndsWith("*") => "IntPtr", 
		var x => x, 
	};
}