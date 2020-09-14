using System;
using System.Collections.Generic;
using System.Text;

namespace Sdcb.FFmpegAPIWrapper.MediaCodecs
{
    public enum AudioServiceTypes
    {
        Main = 0,
        Effects = 1,
        VISUALLY_IMPAIRED = 2,
        HEARING_IMPAIRED = 3,
        DIALOGUE = 4,
        COMMENTARY = 5,
        EMERGENCY = 6,
        VoiceOver = 7,
        Karaoke = 8,
        NB, ///< Not part of ABI
    };
}
