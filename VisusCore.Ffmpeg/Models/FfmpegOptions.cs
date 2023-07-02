using FFmpeg.AutoGen;

namespace VisusCore.Ffmpeg.Models;

public class FfmpegOptions
{
    public string Path { get; set; }
    // See possible values: https://ffmpeg.org/doxygen/2.5/group__lavu__log__constants.html#ga11e329935b59b83ca722b66674f37fd4
    public int LogLevel { get; set; } = ffmpeg.AV_LOG_QUIET;
}
