using FFmpeg.AutoGen;
using System.Collections.Generic;
using System.Text;

namespace Sdcb.FFmpegAPIWrapper.Common
{
    public unsafe struct Int32x8
    {
        public static readonly int Size = 8;
        public int _0, _1, _2, _3, _4, _5, _6, _7;

        public Int32x8(int v0, int v1, int v2, int v3, int v4, int v5, int v6, int v7)
        {
            _0 = v0;
            _1 = v1;
            _2 = v2;
            _3 = v3;
            _4 = v4;
            _5 = v5;
            _6 = v6;
            _7 = v7;
        }

        public int[] ToArray() => new[] { _0, _1, _2, _3, _4, _5, _6, _7 };

        public static implicit operator Int32x8(int_array8 s) => *(Int32x8*)&s;

        public static implicit operator int_array8(Int32x8 s) => *(int_array8*)&s;

        public static explicit operator Int32x4(Int32x8 s) => new Int32x4(s._0, s._1, s._2, s._3);

        public static explicit operator Int32x8(Int32x4 s) => new Int32x8(s._0, s._1, s._2, s._3, 0, 0, 0, 0);
    }
}
