using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;
using Sdcb.FFmpegAPIWrapper.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sdcb.FFmpegAPIWrapper.MediaCodecs
{
    public unsafe partial struct MediaCodec
    {
        public static implicit operator AVCodec*(MediaCodec data) => data._p;

        public unsafe static MediaCodec FromNative(IntPtr p) => FromNative((AVCodec*)p);

        public unsafe static MediaCodec FromNative(AVCodec* p) => new MediaCodec(p);

        /// <summary>
        /// <see cref="av_codec_iterate(void**)"/>
        /// </summary>
        public static IEnumerable<MediaCodec> MediaCodecs => NativeUtils
            .EnumeratePtrIterator(ptr => (IntPtr)(av_codec_iterate((void**)ptr)))
            .Select(FromNative);

        /// <summary>
        /// <see cref="avcodec_find_decoder(AVCodecID)"/>
        /// </summary>
        public static MediaCodec FindDecoder(AVCodecID id) => FromNative(FindChecking(avcodec_find_decoder(id), id));

        /// <summary>
        /// <see cref="avcodec_find_decoder_by_name(string)"/>
        /// </summary>
        public static MediaCodec FindDecoderByName(string name) => FromNative(FindChecking(avcodec_find_decoder_by_name(name), name));

        /// <summary>
        /// <see cref="avcodec_find_encoder(AVCodecID)"/>
        /// </summary>
        public static MediaCodec FindEncoder(AVCodecID id) => FromNative(FindChecking(avcodec_find_encoder(id), id));

        /// <summary>
        /// <see cref="avcodec_find_encoder_by_name(string)"/>
        /// </summary>
        public static MediaCodec FindEncoderByName(string name) => FromNative(FindChecking(avcodec_find_encoder_by_name(name), name));

        private static AVCodec* FindChecking(AVCodec* codec, AVCodecID id) => codec != null ? codec : throw new FFmpegException($"codec id {id} not found.");
        private static AVCodec* FindChecking(AVCodec* codec, string name) => codec != null ? codec : throw new FFmpegException($"codec name '{name}' not found.");

        /// <summary>
        /// <see cref="avcodec_version"/>
        /// </summary>
        public static string Version => avcodec_version().ToVersionString();

        /// <summary>
        /// <see cref="avcodec_configuration"/>
        /// </summary>
        public static Dictionary<string, bool> Configuration => avcodec_configuration()
            .Split(' ')
            .Select(x => x.TrimStart('-').Split('-', 2))
            .ToDictionary(k => k[1], v => v[0] == "enable");

        /// <summary>
        /// <see cref="avcodec_license"/>
        /// </summary>
        public static string License => avcodec_license();
    }
}
