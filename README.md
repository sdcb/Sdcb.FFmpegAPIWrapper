Sdcb.FFmpegAPIWrapper ![NuGet Version](https://img.shields.io/nuget/v/Sdcb.FFmpegAPIWrapper)
=====================

.NET FFmpeg API Warpper Library, currently based on [FFmpeg.AutoGen](https://github.com/Ruslan-B/FFmpeg.AutoGen). 

Status
======

### Common
- [x] Basic - `FFmpegException`, `FFmpegLogger`, `FFmpegHandle`
- [x] `AVClass` - `FFmpegClass`
- [x] `AVDictionary` - `MediaDictionary`
- [x] `AVRational` - `MediaRational`
- [x] `mathematics.h` - `MediaMath`

### Codecs
- [x] `AVCodec` - `MediaCodec`
- [x] `AVCodecContext` - `MediaCodecContext`

### Muxers
- [x] `AVIOContext` - `MediaIO`
- [x] `AVFormatContext` - `InputFormat`/`OutputFormat`/`FormatContext`

### Others(filters, ...)
- [x] `swscale` - `PixelConverter`/`FrameConverter`
- [x] `resampler` - `SampleConverter`
- other not supported.

Known other famous FFmpeg API wrapper in Github
===============================================

* [EmguFFmpeg](https://github.com/IOL0ol1/EmguFFmpeg)
* [FFMediaToolkit](https://github.com/radek-k/FFMediaToolkit)
