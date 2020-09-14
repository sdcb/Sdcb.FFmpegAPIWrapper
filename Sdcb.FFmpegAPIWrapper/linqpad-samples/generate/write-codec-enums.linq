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
Dictionary<string, string> docs = XDocument.Load(Path.Combine(Path.GetDirectoryName(typeof(AVRational).Assembly.Location), Path.GetFileNameWithoutExtension(typeof(AVRational).Assembly.Location)) + ".xml")
		.XPathSelectElements("doc/members/member")
		.ToDictionary(k => k.Attribute("name").Value, v => string.Join("\r\n", v.Nodes().Select(x => x.ToString())));
		
void WriteEnum(Type enumType, string newName)
{
	using var _file = new StreamWriter(newName + ".g.cs");
	using var writer = new IndentedTextWriter(_file, new string(' ', 4));
	
	WriteBasic(writer, "Sdcb.FFmpegAPIWrapper.MediaCodecs", WriteBody);
	
	void WriteBody()
	{
		Type underlyingType = Enum.GetUnderlyingType(enumType);
		string suffix = underlyingType != typeof(int) ? " : " + GetFriendlyTypeName(underlyingType) : "";
		writer.WriteLine($"public enum {newName}{suffix}");
		PushIndent(writer, WriteElements);
	}
	
	void WriteElements()
	{
		string[] names = Enum.GetNames(enumType);
		Array values = Enum.GetValues(enumType);
		string commonPrefix = FindCommonPrefix(names);
		
		for(var i = 0; i < names.Length; ++i)
		{
			
		}
	}

	string FindCommonPrefix(string[] names) => new string(names
		.First()
		.Substring(0, names.Min(s => s.Length))
		.TakeWhile((c, i) => names.All(s => s[i] == c))
		.ToArray());
}