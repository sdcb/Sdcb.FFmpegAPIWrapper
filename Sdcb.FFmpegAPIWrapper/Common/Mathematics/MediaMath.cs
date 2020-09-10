using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;

namespace Sdcb.FFmpegAPIWrapper.Common
{
    public static class MediaMath
    {
        /// <summary>
        /// e
        /// </summary>
        public const double E = 2.7182818284590452354;

        /// <summary>
        /// log_e 2
        /// </summary>
        public const double Ln2 = 0.69314718055994530942;

        /// <summary>
        /// log_e 10
        /// </summary>
        public const double Ln10 = 2.30258509299404568402;

        /// <summary>
        /// log_2 10
        /// </summary>
        public const double Log2_10 = 3.32192809488736234787;

        /// <summary>
        /// phi / golden ratio
        /// </summary>
        public const double Phi = 1.61803398874989484820;

        /// <summary>
        /// pi
        /// </summary>
        public const double PI = 3.14159265358979323846;

        /// <summary>
        /// pi/2
        /// </summary>
        public const double PI2 = 1.57079632679489661923;

        /// <summary>
        /// 1/sqrt(2)
        /// </summary>
        public const double Sqrt1_2 = 0.70710678118654752440;

        /// <summary>
        /// sqrt(2)
        /// </summary>
        public const double Sqrt2 = 1.41421356237309504880;

        /// <summary>
        /// <see cref="av_gcd(long, long)"/>
        /// </summary>
        public static long Gcd(long a, long b) => av_gcd(a, b);

        /// <summary>
        /// <para>a * b / c</para>
        /// <see cref="av_rescale(long, long, long)"/>
        /// </summary>
        public static long Rescale(long a, long b, long c) => av_rescale(a, b, c);

        /// <summary>
        /// <para>a * b / c, with rounding</para>
        /// <see cref="av_rescale_rnd(long, long, long, AVRounding)"/>
        /// </summary>
        public static long Rescale(long a, long b, long c, MediaRounding rounding) => av_rescale_rnd(a, b, c, (AVRounding)rounding);

        /// <summary>
        /// <para>a * bq / cq</para>
        /// <see cref="av_rescale_q(long, AVRational, AVRational)"/>
        /// </summary>
        public static long Rescale(long a, in MediaRational bq, in MediaRational cq) => av_rescale_q(a, bq, cq);

        /// <summary>
        /// <para>a * bq / cq, with rounding</para>
        /// <see cref="av_rescale_q_rnd(long, AVRational, AVRational, AVRounding)"/>
        /// </summary>
        public static long Rescale(long a, in MediaRational bq, in MediaRational cq, MediaRounding rounding) => av_rescale_q_rnd(a, bq, cq, (AVRounding)rounding);

        /// <summary>
        /// <code>Compare(t1 * r1, t2 * r2)</code>
        /// <see cref="av_compare_ts(long, AVRational, long, AVRational)"/>
        /// </summary>
        public static int CompareTs(long t1, MediaRational r1, long t2, MediaRational r2) => av_compare_ts(t1, r1, t2, r2);

        /// <summary>
        /// <code>Compare(a % mod, b % mod)</code>
        /// <see cref="av_compare_mod(ulong, ulong, ulong)"/>
        /// </summary>
        public static long CompareMod(ulong a, ulong b, ulong mod) => av_compare_mod(a, b, mod);

        /// <summary>
        /// <see cref="av_rescale_delta(AVRational, long, AVRational, int, long*, AVRational)"/>
        /// </summary>
        public static unsafe long RescaleDelta(
            in MediaRational inputTimebase,
            in long inputTimestamp,
            in MediaRational durationTimebase,
            int duration,
            long* last,
            MediaRational outputTimebase) => av_rescale_delta(inputTimebase, inputTimestamp, durationTimebase, duration, last, outputTimebase);

        /// <summary>
        /// <see cref="av_add_stable(AVRational, long, AVRational, long)"/>
        /// </summary>
        public static long StableAdd(in MediaRational inputTimebase, long inputTimestamp, in MediaRational incrementTimebase, long incrementTimestamp)
            => av_add_stable(inputTimebase, inputTimestamp, incrementTimebase, incrementTimestamp);
    }
}
