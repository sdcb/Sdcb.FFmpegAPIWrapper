using System;
using static FFmpeg.AutoGen.ffmpeg;

namespace Sdcb.FFmpegAPIWrapper.MediaCodecs
{
    /// <summary>
    /// AV_CODEC_FLAG_*
    /// </summary>
    [Flags]
    public enum MediaCodecFlags : uint
    {
        Unaligned = AV_CODEC_FLAG_UNALIGNED,

        Qscale = AV_CODEC_FLAG_QSCALE, 

        _4MV = AV_CODEC_FLAG_4MV, 

        OutputCorrupt = AV_CODEC_FLAG_OUTPUT_CORRUPT, 

        Qpel = AV_CODEC_FLAG_QPEL, 

        DropChanged = AV_CODEC_FLAG_DROPCHANGED, 

        Pass1 = AV_CODEC_FLAG_PASS1, 

        Pass2 = AV_CODEC_FLAG_PASS2, 

        LoopFilter = AV_CODEC_FLAG_LOOP_FILTER, 

        Gray = AV_CODEC_FLAG_GRAY, 

        PSNR = AV_CODEC_FLAG_PSNR, 

        Truncated = AV_CODEC_FLAG_TRUNCATED, 

        InterlacedDct = AV_CODEC_FLAG_INTERLACED_DCT, 

        LowDelay = AV_CODEC_FLAG_LOW_DELAY, 

        GlobalHeader = AV_CODEC_FLAG_GLOBAL_HEADER, 

        Bitexact = AV_CODEC_FLAG_BITEXACT, 

        AdvancedPred = AV_CODEC_FLAG_AC_PRED, 

        InterlacedMotionEstimation = AV_CODEC_FLAG_INTERLACED_ME, 

        ClosedGop = AV_CODEC_FLAG_CLOSED_GOP, 
    }

    /// <summary>
    /// AV_CODEC_FLAG2_*
    /// </summary>
    [Flags]
    public enum MediaCodecFlags2 : uint
    {
        Fast = AV_CODEC_FLAG2_FAST, 

        NoOutput = AV_CODEC_FLAG2_NO_OUTPUT, 

        LocalHeader = AV_CODEC_FLAG2_LOCAL_HEADER, 

        [Obsolete]
        DropFrameTimecode = AV_CODEC_FLAG2_DROP_FRAME_TIMECODE, 

        Chunks = AV_CODEC_FLAG2_CHUNKS, 

        ShowAll = AV_CODEC_FLAG2_SHOW_ALL, 

        ExportMvs = AV_CODEC_FLAG2_EXPORT_MVS, 

        SkipManual = AV_CODEC_FLAG2_SKIP_MANUAL, 

        RoFlushNoop = AV_CODEC_FLAG2_RO_FLUSH_NOOP, 
    }
}
