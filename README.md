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
- [x] `AVCodecContext` - `MediaCodecContext` (in progress)

### Muxers
- [x] `AVIOContext` - `MediaIO`
- [x] `AVFormatContext` (not started)

### Others(filters, ...)
- [x] `swscale` - `PixelConverter`
- other not supported.

Known other famous FFmpeg API wrapper in Github
===============================================

* [EmguFFmpeg](https://github.com/IOL0ol1/EmguFFmpeg)
* [FFMediaToolkit](https://github.com/radek-k/FFMediaToolkit)
