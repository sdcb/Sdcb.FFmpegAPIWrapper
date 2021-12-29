Sdcb.FFmpegAPIWrapper ![NuGet Version](https://img.shields.io/nuget/v/Sdcb.FFmpegAPIWrapper) [![QQ](https://img.shields.io/badge/QQ_Group-579060605-52B6EF?style=social&logo=tencent-qq&logoColor=000&logoWidth=20)](https://jq.qq.com/?_wv=1027&k=K4fBqpyQ)
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
