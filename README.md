Sdcb.FFmpegAPIWrapper ![NuGet Version](https://img.shields.io/nuget/v/Sdcb.FFmpegAPIWrapper) [![QQ](https://img.shields.io/badge/QQ_Group-579060605-52B6EF?style=social&logo=tencent-qq&logoColor=000&logoWidth=20)](https://jq.qq.com/?_wv=1027&k=K4fBqpyQ)
=====================

.NET FFmpeg API Warpper Library, currently based on [FFmpeg.AutoGen](https://github.com/Ruslan-B/FFmpeg.AutoGen). 

> Note: **this project has deprecated** because it's very hard to make it flexiable and powerful by reference to FFmpeg.AutoGen, please use **Sdcb.FFmpeg https://github.com/sdcb/sdcb.ffmpeg**
> 
> 注意：**这个项目已停止维护**，因为用上了FFmpeg.AutoGen之后项目变得很僵硬，请使用我写的新的更好的**Sdcb.FFmpeg：https://github.com/sdcb/sdcb.ffmpeg**

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
