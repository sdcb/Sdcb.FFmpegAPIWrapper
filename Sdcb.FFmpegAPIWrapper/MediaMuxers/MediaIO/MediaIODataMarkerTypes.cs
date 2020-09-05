using FFmpeg.AutoGen;

namespace Sdcb.FFmpegAPIWrapper.MediaMuxers
{
    /// <summary>
    /// <para>
    /// Different data types that can be returned via the AVIO write_data_type callback.
    /// </para>
    /// <see cref="AVIODataMarkerType"/>
    /// </summary>
    public enum MediaIODataMarkerTypes
    {
        /// <summary>
        /// Header data; this needs to be present for the stream to be decodeable.
        /// <see cref="AVIODataMarkerType.AVIO_DATA_MARKER_HEADER"/>
        /// </summary>
        Header = AVIODataMarkerType.AVIO_DATA_MARKER_HEADER,

        /// <summary>
        /// <para>
        /// A point in the output bytestream where a decoder can start decoding
        /// (i.e. a keyframe). A demuxer/decoder given the data flagged with
        /// <see cref="Header"/>, followed by any <see cref="SyncPoint"/>,
        /// should give decodeable results.
        /// </para>
        /// <see cref="AVIODataMarkerType.AVIO_DATA_MARKER_SYNC_POINT"/>
        /// </summary>
        SyncPoint = AVIODataMarkerType.AVIO_DATA_MARKER_SYNC_POINT, 

        /// <summary>
        /// A point in the output bytestream where a demuxer can start parsing
        /// (for non self synchronizing bytestream formats). That is, any
        /// non-keyframe packet start point.
        /// <see cref="AVIODataMarkerType.AVIO_DATA_MARKER_BOUNDARY_POINT"/>
        /// </summary>
        BoundaryPoint = AVIODataMarkerType.AVIO_DATA_MARKER_BOUNDARY_POINT,

        /// <summary>
        /// <para>
        /// This is any, unlabelled data. It can either be a muxer not marking
        /// any positions at all, it can be an actual boundary/sync point
        /// that the muxer chooses not to mark, or a later part of a packet/fragment
        /// that is cut into multiple write callbacks due to limited IO buffer size.
        /// </para>
        /// <see cref="AVIODataMarkerType.AVIO_DATA_MARKER_UNKNOWN"/>
        /// </summary>
        Unknown = AVIODataMarkerType.AVIO_DATA_MARKER_UNKNOWN,

        /// <summary>
        /// <para>
        /// Trailer data, which doesn't contain actual content, but only for
        /// finalizing the output file.
        /// </para>
        /// <see cref="AVIODataMarkerType.AVIO_DATA_MARKER_TRAILER"/>
        /// </summary>
        Trailer = AVIODataMarkerType.AVIO_DATA_MARKER_TRAILER, 

        /// <summary>
        /// <para>
        /// A point in the output bytestream where the underlying <see cref="AVIOContext"/> might
        /// flush the buffer depending on latency or buffering requirements. Typically
        /// means the end of a packet.
        /// </para>
        /// <see cref="AVIODataMarkerType.AVIO_DATA_MARKER_FLUSH_POINT"/>
        /// </summary>
        FlushPoint = AVIODataMarkerType.AVIO_DATA_MARKER_FLUSH_POINT, 
    }
}
