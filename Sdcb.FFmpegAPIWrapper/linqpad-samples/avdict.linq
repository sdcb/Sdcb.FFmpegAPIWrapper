<Query Kind="Statements">
  <NuGetReference Prerelease="true">Sdcb.FFmpegAPIWrapper</NuGetReference>
  <Namespace>FFmpeg.AutoGen</Namespace>
  <Namespace>Sdcb.FFmpegAPIWrapper.MediaMuxers</Namespace>
  <Namespace>static FFmpeg.AutoGen.ffmpeg</Namespace>
  <Namespace>System.Buffers.Binary</Namespace>
  <Namespace>System.Runtime.CompilerServices</Namespace>
  <Namespace>Sdcb.FFmpegAPIWrapper.Common</Namespace>
  <Namespace>System.Runtime.InteropServices</Namespace>
</Query>

using var dic = MediaDictionary.CreateEmpty();
dic.Add("1", "One");
dic["2"] = "Two";
dic["3"] = "Three";
dic["2"].Dump("Original");
dic["2"] = "Two-Changed-1"; // changed
dic["2"].Dump("Changed");
dic.Add("2", "Two-Changed-2");
dic["2"].Dump("Not Changed");

dic.Dump("Current Values");

dic.Remove("3").Dump("Remove \"3\"");
dic.Remove("3").Dump("Remove \"3\" again");

dic.Dump();

using var dic2 = MediaDictionary.Copy(dic);
dic["4"] = "Four";
dic2["4"] = "Four for dic2";

new { dic, dic2 }.Dump();

dic2.Dispose();
dic2.Dump("Disposed dic2");

dic.Set("5", "Five");
dic.Set("5", "Five2", MediaDictionarySetFlags.AllowSameKey);
dic.Dump("Same key");
dic.Remove("5").Dump("remove 5 once");
dic.Remove("5").Dump("remove 5 again");
dic.Remove("5").Dump("remove 5 again");

dic.Set("6", "Six", MediaDictionarySetFlags.AppendValue);
dic.Set("6", "Six", MediaDictionarySetFlags.AppendValue);
dic.Set("6", "Six", MediaDictionarySetFlags.AppendValue);
dic["6"].Dump();