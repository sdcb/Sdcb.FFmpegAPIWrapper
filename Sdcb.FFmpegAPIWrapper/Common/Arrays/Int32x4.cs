using FFmpeg.AutoGen;

namespace Sdcb.FFmpegAPIWrapper.Common
{
    public unsafe struct Int32x4
    {
        public static readonly int Size = 4;
        public int _0, _1, _2, _3;

        public Int32x4(int v0, int v1, int v2, int v3)
        {
            _0 = v0;
            _1 = v1;
            _2 = v2;
            _3 = v3;
        }

        public int[] ToArray() => new[] { _0, _1, _2, _3 };

        public static implicit operator Int32x4(int_array4 s) => *(Int32x4*)&s;

        public static implicit operator int_array4(Int32x4 s) => *(int_array4*)&s;
    }
}
