using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;

namespace Sdcb.FFmpegAPIWrapper.Common
{
    public struct MediaRational
    {
        /// <summary>
        /// Numerator
        /// </summary>
        public int Num;

        /// <summary>
        /// Denominator
        /// </summary>
        public int Den;

        public MediaRational(int number) : this(number, 1) { }

        public MediaRational(int numerator, int denominator)
        {
            Num = numerator;
            Den = denominator;
        }

        public static implicit operator AVRational(in MediaRational data) => new AVRational
        {
            num = data.Num, 
            den = data.Den, 
        };

        public static implicit operator MediaRational(in AVRational data) => new MediaRational(data.num, data.den);

        public static MediaRational FromDouble(double d, int max) => av_d2q(d, max);

        public double ToDouble() => Num / (double)Den;

        public uint ToIEEEFloat32() => av_q2intfloat(this);

        public unsafe MediaRational Reduce()
        {
            MediaRational result = this;
            av_reduce(&result.Num, &result.Den, Num, Den, int.MaxValue);
            return result;
        }

        public MediaRational Inverse() => new MediaRational(Den, Num);

        public static int Compare(in MediaRational a, in MediaRational b)
        {
            long tmp = a.Num * (long)b.Den - b.Num * (long)a.Den;

            if (tmp != 0) return (int)((tmp ^ a.Den ^ b.Den) >> 63) | 1;
            else if (b.Den != 0 && a.Den != 0) return 0;
            else if (a.Num != 0 && b.Num != 0) return (a.Num >> 31) - (b.Num >> 31);
            else return int.MinValue;
        }

        public static unsafe MediaRational operator*(MediaRational b, in MediaRational c)
        {
            av_reduce(&b.Num, &b.Den,
                b.Num * (long)c.Num,
                b.Den * (long)c.Den, int.MaxValue);
            return b;
        }

        public static MediaRational operator /(in MediaRational b, in MediaRational c) => b * new MediaRational(c.Den, c.Num);

        public static unsafe MediaRational operator +(MediaRational b, in MediaRational c)
        {
            av_reduce(&b.Num, &b.Den,
                b.Num * (long)c.Den + c.Num * (long)b.Den,
                b.Den * (long)c.Den, int.MaxValue);
            return b;
        }

        public static MediaRational operator -(in MediaRational b, in MediaRational c) => b + new MediaRational(-c.Num, c.Den);

        public static bool operator >(in MediaRational a, in MediaRational b) => Compare(a, b) > 0;

        public static bool operator <(in MediaRational a, in MediaRational b) => Compare(a, b) < 0;

        public static bool operator ==(in MediaRational a, in MediaRational b) => Compare(a, b) == 0;

        public static bool operator !=(in MediaRational a, in MediaRational b) => Compare(a, b) != 0;

        public static int Nearer(in MediaRational q, in MediaRational q1, in MediaRational q2) => av_nearer_q(q, q1, q2);

        public static unsafe int FindNearestIndex(in MediaRational q, MediaRational* list) => av_find_nearest_q_idx(q, (AVRational*)list);

        public static MediaRational Gcd(in MediaRational a, in MediaRational b, int maxDenominator, AVRational @default = default) => av_gcd_q(a, b, maxDenominator, @default);

        public override bool Equals(object? obj)
        {
            if (obj is MediaRational r)
            {
                return this == r;
            }
            return false;
        }

        public override int GetHashCode() => Num.GetHashCode() ^ Den.GetHashCode();

        public override string ToString() => $"{Num}/{Den}({ToDouble():F6})";
    }
}
