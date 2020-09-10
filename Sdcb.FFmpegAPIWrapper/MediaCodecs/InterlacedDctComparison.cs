namespace Sdcb.FFmpegAPIWrapper.MediaCodecs
{
    public enum InterlacedDctComparison
    {
        SAD        = 0  ,
        SSE        = 1  ,
        SATD       = 2  ,
        DCT        = 3  ,
        PSNR       = 4  ,
        BIT        = 5  ,
        RD         = 6  ,
        ZERO       = 7  ,
        VSAD       = 8  ,
        VSSE       = 9  ,
        NSSE       = 10 ,
        W53        = 11 ,
        W97        = 12 ,
        DCTMAX     = 13 ,
        DCT264     = 14 ,
        MEDIAN_SAD = 15 ,
        CHROMA     = 256,
    }
}