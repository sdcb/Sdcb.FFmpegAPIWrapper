using System;
using static FFmpeg.AutoGen.ffmpeg;
using System.Collections.Generic;
using System.Text;
using FFmpeg.AutoGen;
using System.Linq;

namespace Sdcb.FFmpegAPIWrapper.Common
{
    public unsafe class FFmpegOptions
    {
        private readonly void* _obj;

        public FFmpegOptions(void* ptr)
        {
            if (ptr == null)
            {
                throw new ArgumentNullException(nameof(ptr));
            }
            _obj = ptr;
        }

        /// <summary>
        /// <see cref="av_opt_set(void*, string, string, int)"/>
        /// </summary>
        public void Set(string key, string value, OptionSearchFlags searchFlags) => av_opt_set(_obj, key, value, (int)searchFlags).ThrowIfError();

        /// <summary>
        /// <see cref="av_opt_get(void*, string, int, byte**)"/>
        /// </summary>
        public IntPtr GetData(string key, OptionSearchFlags searchFlags)
        {
            byte* outVal;
            av_opt_get(_obj, key, (int)searchFlags, &outVal).ThrowIfError();
            return (IntPtr)outVal;
        }

        public Dictionary<string, IntPtr> OptionValues => Options.ToDictionary(k => k.Name, v => GetData(v.Name, 0));

        /// <summary>
        /// <see cref="av_opt_next(void*, AVOption*)"/>
        /// </summary>
        public IEnumerable<FFmpegOption> Options
        {
            get
            {
                IntPtr prev = IntPtr.Zero;
                while (true)
                {
                    prev = av_opt_next_safe(prev);
                    if (prev == IntPtr.Zero) break;
                    yield return new FFmpegOption(prev);
                }

                IntPtr av_opt_next_safe(IntPtr prev) => (IntPtr)av_opt_next(_obj, (AVOption*)prev);
            }
        }
    }
}
