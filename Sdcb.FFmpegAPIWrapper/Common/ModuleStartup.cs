using FFmpeg.AutoGen;
using System.Runtime.CompilerServices;

namespace Sdcb.FFmpegAPIWrapper.Common
{
    internal class ModuleStartup
    {
#pragma warning disable CA2255 // 不应在库中使用 “ModuleInitializer” 属性
        [ModuleInitializer]
#pragma warning restore CA2255 // 不应在库中使用 “ModuleInitializer” 属性
        public static void OnStart()
        {
        }
    }
}
