<Query Kind="Statements">
  <NuGetReference Prerelease="true">Sdcb.FFmpegAPIWrapper</NuGetReference>
  <Namespace>FFmpeg.AutoGen</Namespace>
  <Namespace>Sdcb.FFmpegAPIWrapper.Common</Namespace>
  <Namespace>System.CodeDom.Compiler</Namespace>
  <Namespace>Microsoft.CSharp</Namespace>
  <Namespace>System.CodeDom</Namespace>
</Query>

#load ".\common"
#load ".\write-class"

string baseDir = Path.GetFullPath(Path.Combine(Util.CurrentQuery.Location, @"..\..\Common\GeneratedTypes"));
Directory.CreateDirectory(baseDir);
Environment.CurrentDirectory = baseDir;

string ns = "Sdcb.FFmpegAPIWrapper.Common";
WriteClass(typeof(AVBufferRef), ns, "BufferReference");
//WriteClass(typeof(AVBufferPool), ns, "BufferPool");