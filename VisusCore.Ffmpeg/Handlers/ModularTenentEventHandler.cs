using FFmpeg.AutoGen;
using Microsoft.Extensions.Options;
using OrchardCore.Modules;
using System.Threading.Tasks;
using VisusCore.Ffmpeg.Models;

namespace VisusCore.Ffmpeg.Handlers;

public class ModularTenentEventHandler : ModularTenantEvents
{
    private readonly IOptions<FfmpegOptions> _options;

    public ModularTenentEventHandler(IOptions<FfmpegOptions> options) =>
        _options = options;

    public override Task ActivatingAsync()
    {
        ffmpeg.RootPath = _options.Value.Path;
        ffmpeg.av_log_set_level(_options.Value.LogLevel);

        return Task.CompletedTask;
    }
}
