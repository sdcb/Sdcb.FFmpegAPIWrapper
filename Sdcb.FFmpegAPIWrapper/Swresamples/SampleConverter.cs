using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;
using Sdcb.FFmpegAPIWrapper.Common;
using System;
using Sdcb.FFmpegAPIWrapper.MediaCodecs;

namespace Sdcb.FFmpegAPIWrapper.Swresamples
{
    /// <summary>
    /// <see cref="SwrContext"/>
    /// </summary>
    public unsafe class SampleConverter : FFmpegSafeObject
    {
        /// <summary>
        /// <see cref="swr_get_class"/>
        /// </summary>
        public static FFmpegClass TypeClass = FFmpegClass.FromNative(swr_get_class());

        /// <summary>
        /// <see cref="swr_alloc"/>
        /// </summary>
        public SampleConverter()
        {
            _nativePointer = NativeUtils.NotNull((IntPtr)swr_alloc());
            _isOwner = true;
        }

        public static implicit operator SwrContext*(SampleConverter data) => (SwrContext*)data._nativePointer;

        public FFmpegOptions Options => new FFmpegOptions((void*)_nativePointer);

        /// <summary>
        /// <see cref="swr_alloc_set_opts(SwrContext*, long, AVSampleFormat, int, long, AVSampleFormat, int, int, void*)"/>
        /// </summary>
        public void Reset(
            ChannelLayout outputChannelLayout, SampleFormat outputSampleFormat, int outputSampleRate, 
            ChannelLayout inputChannelLayout, SampleFormat inputSampleFormat, int inputSampleRate)
        {
            _nativePointer = NativeUtils.NotNull((IntPtr)swr_alloc_set_opts(this,
                (long)outputChannelLayout, (AVSampleFormat)outputSampleFormat, outputSampleRate,
                (long)inputChannelLayout, (AVSampleFormat)inputSampleFormat, inputSampleRate,
                log_offset: 0, log_ctx: null));
        }

        /// <summary>
        /// <see cref="swr_is_initialized(SwrContext*)"/>
        /// </summary>
        public bool Initialized => swr_is_initialized(this) != 0 ? true : false;

        /// <summary>
        /// <see cref="swr_init(SwrContext*)"/>
        /// </summary>
        public void Initialize() => swr_init(this);

        /// <summary>
        /// <see cref="swr_convert(SwrContext*, byte**, int, byte**, int)"/>
        /// </summary>
        public int Convert(Ptr8 outData, int outCount, Ptr8 inData, int inCount)
        {
            return swr_convert(this, (byte**)&outData, outCount, (byte**)&inData, inCount).ThrowIfError();
        }

        /// <summary>
        /// <see cref="swr_convert_frame(SwrContext*, AVFrame*, AVFrame*)"/>
        /// </summary>
        public int ConvertFrame(Frame outFrame, Frame inFrame)
        {
            return swr_convert_frame(this, outFrame, inFrame).ThrowIfError();
        }

        /// <summary>
        /// <see cref="swr_next_pts(SwrContext*, long)"/>
        /// </summary>
        public long NextPts(long pts) => swr_next_pts(this, pts);

        /// <summary>
        /// <see cref="swr_free(SwrContext**)"/>
        /// </summary>
        public void Free()
        {
            SwrContext* ptr = this;
            swr_free(&ptr);
            _nativePointer = (IntPtr)ptr;
        }

        /// <summary>
        /// <see cref="swr_close(SwrContext*)"/>
        /// </summary>
        public void Close() => swr_close(this);

        protected override void DisposeNative() => Free();
    }
}
