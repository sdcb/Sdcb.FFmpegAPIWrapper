<Query Kind="Statements">
  <NuGetReference Prerelease="true">Sdcb.FFmpegAPIWrapper</NuGetReference>
  <Namespace>Sdcb.FFmpegAPIWrapper.MediaMuxers</Namespace>
  <Namespace>Sdcb.FFmpegAPIWrapper.Common</Namespace>
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
	public string Protocol { get; set; }
	public bool Input { get; set; }
	public bool Output { get; set; }
	public IEnumerable<FFmpegOption> Options { get; set; }
	public string Version { get; set; }
}