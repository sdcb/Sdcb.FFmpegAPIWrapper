// This file was genereated from LINQPad scripts, DO NOT CHANGE DIRECTLY.

using System;
using Sdcb.FFmpegAPIWrapper.Common;
using FFmpeg.AutoGen;
using static FFmpeg.AutoGen.ffmpeg;

namespace Sdcb.FFmpegAPIWrapper.MediaCodecs
{
    /// <summary>
    /// <para>Types and functions for working with AVPacket.</para>
    /// <para> @{.</para>
    /// <see cref="AVPacketSideDataType" />
    /// </summary>
    public enum PacketSideDataType
    {
        /// <summary>
        /// <para>An AV_PKT_DATA_PALETTE side data packet contains exactly AVPALETTE_SIZE bytes worth of palette.</para>
        /// <para> This side data signals that a new palette is present.</para>
        /// <see cref="AVPacketSideDataType.AV_PKT_DATA_PALETTE" />
        /// </summary>
        Palette = 0,
        
        /// <summary>
        /// <para>The AV_PKT_DATA_NEW_EXTRADATA is used to notify the codec or the format that the extradata buffer was changed and the receiving side should act upon it appropriately.</para>
        /// <para> The new extradata is embedded in the side data buffer and should be immediately used for processing the current frame or packet.</para>
        /// <see cref="AVPacketSideDataType.AV_PKT_DATA_NEW_EXTRADATA" />
        /// </summary>
        NewExtradata = 1,
        
        /// <summary>
        /// <para>An AV_PKT_DATA_PARAM_CHANGE side data packet is laid out as follows:.</para>
        /// <see cref="AVPacketSideDataType.AV_PKT_DATA_PARAM_CHANGE" />
        /// </summary>
        ParamChange = 2,
        
        /// <summary>
        /// <para>An AV_PKT_DATA_H263_MB_INFO side data packet contains a number of structures with info about macroblocks relevant to splitting the packet into smaller packets on macroblock edges (e.</para>
        /// <para>g.</para>
        /// <para> as for RFC 2190).</para>
        /// <para> That is, it does not necessarily contain info about all macroblocks, as long as the distance between macroblocks in the info is smaller than the target payload size.</para>
        /// <para> Each MB info structure is 12 bytes, and is laid out as follows:.</para>
        /// <see cref="AVPacketSideDataType.AV_PKT_DATA_H263_MB_INFO" />
        /// </summary>
        H263MbInfo = 3,
        
        /// <summary>
        /// <para>This side data should be associated with an audio stream and contains ReplayGain information in form of the AVReplayGain struct.</para>
        /// <see cref="AVPacketSideDataType.AV_PKT_DATA_REPLAYGAIN" />
        /// </summary>
        Replaygain = 4,
        
        /// <summary>
        /// <para>This side data contains a 3x3 transformation matrix describing an affine transformation that needs to be applied to the decoded video frames for correct presentation.</para>
        /// <see cref="AVPacketSideDataType.AV_PKT_DATA_DISPLAYMATRIX" />
        /// </summary>
        Displaymatrix = 5,
        
        /// <summary>
        /// <para>This side data should be associated with a video stream and contains Stereoscopic 3D information in form of the AVStereo3D struct.</para>
        /// <see cref="AVPacketSideDataType.AV_PKT_DATA_STEREO3D" />
        /// </summary>
        Stereo3d = 6,
        
        /// <summary>
        /// <para>This side data should be associated with an audio stream and corresponds to enum AVAudioServiceType.</para>
        /// <see cref="AVPacketSideDataType.AV_PKT_DATA_AUDIO_SERVICE_TYPE" />
        /// </summary>
        AudioServiceType = 7,
        
        /// <summary>
        /// <para>This side data contains quality related information from the encoder.</para>
        /// <see cref="AVPacketSideDataType.AV_PKT_DATA_QUALITY_STATS" />
        /// </summary>
        QualityStats = 8,
        
        /// <summary>
        /// <para>This side data contains an integer value representing the stream index of a &quot;fallback&quot; track.</para>
        /// <para> A fallback track indicates an alternate track to use when the current track can not be decoded for some reason.</para>
        /// <para> e.</para>
        /// <para>g.</para>
        /// <para> no decoder available for codec.</para>
        /// <see cref="AVPacketSideDataType.AV_PKT_DATA_FALLBACK_TRACK" />
        /// </summary>
        FallbackTrack = 9,
        
        /// <summary>
        /// <para>This side data corresponds to the AVCPBProperties struct.</para>
        /// <see cref="AVPacketSideDataType.AV_PKT_DATA_CPB_PROPERTIES" />
        /// </summary>
        CpbProperties = 10,
        
        /// <summary>
        /// <para>Recommmends skipping the specified number of samples.</para>
        /// <see cref="AVPacketSideDataType.AV_PKT_DATA_SKIP_SAMPLES" />
        /// </summary>
        SkipSamples = 11,
        
        /// <summary>
        /// <para>An AV_PKT_DATA_JP_DUALMONO side data packet indicates that the packet may contain &quot;dual mono&quot; audio specific to Japanese DTV and if it is true, recommends only the selected channel to be used.</para>
        /// <see cref="AVPacketSideDataType.AV_PKT_DATA_JP_DUALMONO" />
        /// </summary>
        JpDualmono = 12,
        
        /// <summary>
        /// <para>A list of zero terminated key/value strings.</para>
        /// <para> There is no end marker for the list, so it is required to rely on the side data size to stop.</para>
        /// <see cref="AVPacketSideDataType.AV_PKT_DATA_STRINGS_METADATA" />
        /// </summary>
        StringsMetadata = 13,
        
        /// <summary>
        /// <para>Subtitle event position.</para>
        /// <see cref="AVPacketSideDataType.AV_PKT_DATA_SUBTITLE_POSITION" />
        /// </summary>
        SubtitlePosition = 14,
        
        /// <summary>
        /// <para>Data found in BlockAdditional element of matroska container.</para>
        /// <para> There is no end marker for the data, so it is required to rely on the side data size to recognize the end.</para>
        /// <para> 8 byte id (as found in BlockAddId) followed by data.</para>
        /// <see cref="AVPacketSideDataType.AV_PKT_DATA_MATROSKA_BLOCKADDITIONAL" />
        /// </summary>
        MatroskaBlockadditional = 15,
        
        /// <summary>
        /// <para>The optional first identifier line of a WebVTT cue.</para>
        /// <see cref="AVPacketSideDataType.AV_PKT_DATA_WEBVTT_IDENTIFIER" />
        /// </summary>
        WebvttIdentifier = 16,
        
        /// <summary>
        /// <para>The optional settings (rendering instructions) that immediately follow the timestamp specifier of a WebVTT cue.</para>
        /// <see cref="AVPacketSideDataType.AV_PKT_DATA_WEBVTT_SETTINGS" />
        /// </summary>
        WebvttSettings = 17,
        
        /// <summary>
        /// <para>A list of zero terminated key/value strings.</para>
        /// <para> There is no end marker for the list, so it is required to rely on the side data size to stop.</para>
        /// <para> This side data includes updated metadata which appeared in the stream.</para>
        /// <see cref="AVPacketSideDataType.AV_PKT_DATA_METADATA_UPDATE" />
        /// </summary>
        MetadataUpdate = 18,
        
        /// <summary>
        /// <para>MPEGTS stream ID as uint8_t, this is required to pass the stream ID information from the demuxer to the corresponding muxer.</para>
        /// <see cref="AVPacketSideDataType.AV_PKT_DATA_MPEGTS_STREAM_ID" />
        /// </summary>
        MpegtsStreamId = 19,
        
        /// <summary>
        /// <para>Mastering display metadata (based on SMPTE-2086:2014).</para>
        /// <para> This metadata should be associated with a video stream and contains data in the form of the AVMasteringDisplayMetadata struct.</para>
        /// <see cref="AVPacketSideDataType.AV_PKT_DATA_MASTERING_DISPLAY_METADATA" />
        /// </summary>
        MasteringDisplayMetadata = 20,
        
        /// <summary>
        /// <para>This side data should be associated with a video stream and corresponds to the AVSphericalMapping structure.</para>
        /// <see cref="AVPacketSideDataType.AV_PKT_DATA_SPHERICAL" />
        /// </summary>
        Spherical = 21,
        
        /// <summary>
        /// <para>Content light level (based on CTA-861.</para>
        /// <para>3).</para>
        /// <para> This metadata should be associated with a video stream and contains data in the form of the AVContentLightMetadata struct.</para>
        /// <see cref="AVPacketSideDataType.AV_PKT_DATA_CONTENT_LIGHT_LEVEL" />
        /// </summary>
        ContentLightLevel = 22,
        
        /// <summary>
        /// <para>ATSC A53 Part 4 Closed Captions.</para>
        /// <para> This metadata should be associated with a video stream.</para>
        /// <para> A53 CC bitstream is stored as uint8_t in AVPacketSideData.</para>
        /// <para>data.</para>
        /// <para> The number of bytes of CC data is AVPacketSideData.</para>
        /// <para>size.</para>
        /// <see cref="AVPacketSideDataType.AV_PKT_DATA_A53_CC" />
        /// </summary>
        A53Cc = 23,
        
        /// <summary>
        /// <para>This side data is encryption initialization data.</para>
        /// <para> The format is not part of ABI, use av_encryption_init_info_* methods to access.</para>
        /// <see cref="AVPacketSideDataType.AV_PKT_DATA_ENCRYPTION_INIT_INFO" />
        /// </summary>
        EncryptionInitInfo = 24,
        
        /// <summary>
        /// <para>This side data contains encryption info for how to decrypt the packet.</para>
        /// <para> The format is not part of ABI, use av_encryption_info_* methods to access.</para>
        /// <see cref="AVPacketSideDataType.AV_PKT_DATA_ENCRYPTION_INFO" />
        /// </summary>
        EncryptionInfo = 25,
        
        /// <summary>
        /// <para>Active Format Description data consisting of a single byte as specified in ETSI TS 101 154 using AVActiveFormatDescription enum.</para>
        /// <see cref="AVPacketSideDataType.AV_PKT_DATA_AFD" />
        /// </summary>
        Afd = 26,
        
        /// <summary>
        /// <para>Producer Reference Time data corresponding to the AVProducerReferenceTime struct, usually exported by some encoders (on demand through the prft flag set in the AVCodecContext export_side_data field).</para>
        /// <see cref="AVPacketSideDataType.AV_PKT_DATA_PRFT" />
        /// </summary>
        Prft = 27,
        
        /// <summary>
        /// <para>ICC profile data consisting of an opaque octet buffer following the format described by ISO 15076-1.</para>
        /// <see cref="AVPacketSideDataType.AV_PKT_DATA_ICC_PROFILE" />
        /// </summary>
        IccProfile = 28,
        
        /// <summary>
        /// <para>DOVI configuration ref: dolby-vision-bitstreams-within-the-iso-base-media-file-format-v2.</para>
        /// <para>1.</para>
        /// <para>2, section 2.</para>
        /// <para>2 dolby-vision-bitstreams-in-mpeg-2-transport-stream-multiplex-v1.</para>
        /// <para>2, section 3.</para>
        /// <para>3 Tags are stored in struct AVDOVIDecoderConfigurationRecord.</para>
        /// <see cref="AVPacketSideDataType.AV_PKT_DATA_DOVI_CONF" />
        /// </summary>
        DoviConf = 29,
        
        /// <summary>
        /// <para>Timecode which conforms to SMPTE ST 12-1:2014.</para>
        /// <para> The data is an array of 4 uint32_t where the first uint32_t describes how many (1-3) of the other timecodes are used.</para>
        /// <para> The timecode format is described in the documentation of av_timecode_get_smpte_from_framenum() function in libavutil/timecode.</para>
        /// <para>h.</para>
        /// <see cref="AVPacketSideDataType.AV_PKT_DATA_S12M_TIMECODE" />
        /// </summary>
        S12mTimecode = 30,
        
        /// <summary>
        /// <para>The number of side data types.</para>
        /// <para> This is not part of the public API/ABI in the sense that it may change when new side data types are added.</para>
        /// <para> This must stay the last enum value.</para>
        /// <para> If its value becomes huge, some code using it needs to be updated as it assumes it to be smaller than other limits.</para>
        /// <see cref="AVPacketSideDataType.AV_PKT_DATA_NB" />
        /// </summary>
        Nb = 31,
    }
}
