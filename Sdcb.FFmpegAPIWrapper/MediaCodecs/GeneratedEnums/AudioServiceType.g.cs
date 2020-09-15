using System;
using Sdcb.FFmpegAPIWrapper.Common;
using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;

namespace Sdcb.FFmpegAPIWrapper.MediaCodecs
{
    /// <summary>
    /// <see cref="AVAudioServiceType" />
    /// </summary>
    public enum AudioServiceType
    {
        /// <summary>
        /// <see cref="AVAudioServiceType.AV_AUDIO_SERVICE_TYPE_MAIN" />
        /// </summary>
        Main = 0x00000000,
        
        /// <summary>
        /// <see cref="AVAudioServiceType.AV_AUDIO_SERVICE_TYPE_EFFECTS" />
        /// </summary>
        Effects = 0x00000001,
        
        /// <summary>
        /// <see cref="AVAudioServiceType.AV_AUDIO_SERVICE_TYPE_VISUALLY_IMPAIRED" />
        /// </summary>
        VisuallyImpaired = 0x00000002,
        
        /// <summary>
        /// <see cref="AVAudioServiceType.AV_AUDIO_SERVICE_TYPE_HEARING_IMPAIRED" />
        /// </summary>
        HearingImpaired = 0x00000003,
        
        /// <summary>
        /// <see cref="AVAudioServiceType.AV_AUDIO_SERVICE_TYPE_DIALOGUE" />
        /// </summary>
        Dialogue = 0x00000004,
        
        /// <summary>
        /// <see cref="AVAudioServiceType.AV_AUDIO_SERVICE_TYPE_COMMENTARY" />
        /// </summary>
        Commentary = 0x00000005,
        
        /// <summary>
        /// <see cref="AVAudioServiceType.AV_AUDIO_SERVICE_TYPE_EMERGENCY" />
        /// </summary>
        Emergency = 0x00000006,
        
        /// <summary>
        /// <see cref="AVAudioServiceType.AV_AUDIO_SERVICE_TYPE_VOICE_OVER" />
        /// </summary>
        VoiceOver = 0x00000007,
        
        /// <summary>
        /// <see cref="AVAudioServiceType.AV_AUDIO_SERVICE_TYPE_KARAOKE" />
        /// </summary>
        Karaoke = 0x00000008,
        
        /// <summary>
        /// <para>Not part of ABI.</para>
        /// <see cref="AVAudioServiceType.AV_AUDIO_SERVICE_TYPE_NB" />
        /// </summary>
        Nb = 0x00000009,
    }
}
