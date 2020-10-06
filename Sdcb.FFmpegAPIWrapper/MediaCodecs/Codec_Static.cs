using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;
using Sdcb.FFmpegAPIWrapper.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sdcb.FFmpegAPIWrapper.MediaCodecs
{
    public unsafe partial struct Codec
    {
        public static implicit operator AVCodec*(Codec? data) => data != null ? data.Value._p : null;

        public unsafe static Codec FromNative(IntPtr p) => FromNative((AVCodec*)p);

        public unsafe static Codec FromNative(AVCodec* p) => new Codec(p);

        /// <summary>
        /// <see cref="av_codec_iterate(void**)"/>
        /// </summary>
        public static IEnumerable<Codec> All => NativeUtils
            .EnumeratePtrIterator(ptr => (IntPtr)(av_codec_iterate((void**)ptr)))
            .Select(FromNative);

        public static IEnumerable<Codec> Encoders => All.Where(x => x.IsEncoder);

        public static IEnumerable<Codec> Decoders => All.Where(x => x.IsDecoder);

        /// <summary>
        /// <see cref="avcodec_find_decoder(AVCodecID)"/>
        /// </summary>
        public static Codec FindDecoder(CodecID id) => FromNative(FindChecking(avcodec_find_decoder((AVCodecID)id), (AVCodecID)id));

        public static IEnumerable<Codec> FindDecoders(CodecID id) => Decoders.Where(x => x.Id == id);

        /// <summary>
        /// <see cref="avcodec_find_decoder_by_name(string)"/>
        /// </summary>
        public static Codec FindDecoderByName(string name) => FromNative(FindChecking(avcodec_find_decoder_by_name(name), name));

        /// <summary>
        /// <see cref="avcodec_find_encoder(AVCodecID)"/>
        /// </summary>
        public static Codec FindEncoder(CodecID id) => FromNative(FindChecking(avcodec_find_encoder((AVCodecID)id), (AVCodecID)id));

        public static IEnumerable<Codec> FindEncoders(CodecID id) => Encoders.Where(x => x.Id == id);

        /// <summary>
        /// <see cref="avcodec_find_encoder_by_name(string)"/>
        /// </summary>
        public static Codec FindEncoderByName(string name) => FromNative(FindChecking(avcodec_find_encoder_by_name(name), name));

        private static AVCodec* FindChecking(AVCodec* codec, AVCodecID id) => codec != null ? codec : throw new FFmpegException($"codec id {id} not found.");
        private static AVCodec* FindChecking(AVCodec* codec, string name) => codec != null ? codec : throw new FFmpegException($"codec name '{name}' not found.");

        /// <summary>
        /// <see cref="avcodec_version"/>
        /// </summary>
        public static string Version => avcodec_version().ToFourCC();

        /// <summary>
        /// <see cref="avcodec_configuration"/>
        /// </summary>
        public static HashSet<string> Configuration => avcodec_configuration()
            .Split(' ')
            .ToHashSet();

        /// <summary>
        /// <see cref="avcodec_license"/>
        /// </summary>
        public static string License => avcodec_license();
    }
}
