// This file was genereated from LINQPad scripts, DO NOT CHANGE DIRECTLY.

using System;
using Sdcb.FFmpegAPIWrapper.Common;
using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;

namespace Sdcb.FFmpegAPIWrapper.MediaCodecs
{
    /// <summary>
    /// <para>@} @}.</para>
    /// <see cref="AVPictureType" />
    /// </summary>
    public enum PictureType
    {
        /// <summary>
        /// <para>Undefined.</para>
        /// <see cref="AVPictureType.AV_PICTURE_TYPE_NONE" />
        /// </summary>
        None = 0,
        
        /// <summary>
        /// <para>Intra.</para>
        /// <see cref="AVPictureType.AV_PICTURE_TYPE_I" />
        /// </summary>
        I = 1,
        
        /// <summary>
        /// <para>Predicted.</para>
        /// <see cref="AVPictureType.AV_PICTURE_TYPE_P" />
        /// </summary>
        P = 2,
        
        /// <summary>
        /// <para>Bi-dir predicted.</para>
        /// <see cref="AVPictureType.AV_PICTURE_TYPE_B" />
        /// </summary>
        B = 3,
        
        /// <summary>
        /// <para>S(GMC)-VOP MPEG-4.</para>
        /// <see cref="AVPictureType.AV_PICTURE_TYPE_S" />
        /// </summary>
        S = 4,
        
        /// <summary>
        /// <para>Switching Intra.</para>
        /// <see cref="AVPictureType.AV_PICTURE_TYPE_SI" />
        /// </summary>
        Si = 5,
        
        /// <summary>
        /// <para>Switching Predicted.</para>
        /// <see cref="AVPictureType.AV_PICTURE_TYPE_SP" />
        /// </summary>
        Sp = 6,
        
        /// <summary>
        /// <para>BI type.</para>
        /// <see cref="AVPictureType.AV_PICTURE_TYPE_BI" />
        /// </summary>
        Bi = 7,
    }
}
