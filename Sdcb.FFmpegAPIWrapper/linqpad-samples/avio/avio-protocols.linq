<Query Kind="Statements">
  <NuGetReference Prerelease="true">Sdcb.FFmpegAPIWrapper</NuGetReference>
  <Namespace>Sdcb.FFmpegAPIWrapper.Common</Namespace>
  <Namespace>Sdcb.FFmpegAPIWrapper.MediaFormats</Namespace>
  <Namespace>FFmpeg.AutoGen</Namespace>
</Query>

TestProtocols().Dump();

IEnumerable<object> TestProtocols()
{
	var inputProtocols = MediaIO.InputProtocols.ToHashSet();
	var outputProtocols = MediaIO.OutputProtocols.ToHashSet();
	return inputProtocols.Union(outputProtocols)
		.OrderBy(x => x)
		.Select(x => new FFmpegProtocol
		{
			Protocol = x,
			Input = inputProtocols.Contains(x),
			Output = outputProtocols.Contains(x),
			Version = MediaIO.GetProtocolClass(x)?.Version,
			Options = MediaIO.GetProtocolClass(x)?.Options,
		});
}

public record FFmpegProtocol
{
	public string Protocol { get; init; }
	public bool Input { get; init; }
	public bool Output { get; init; }
	public IEnumerable<FFmpegOption>? Options { get; init; }
	public string? Version { get; init; }
}