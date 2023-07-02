using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.Environment.Shell.Configuration;
using OrchardCore.Modules;
using VisusCore.Ffmpeg.Handlers;
using VisusCore.Ffmpeg.Models;

namespace VisusCore.Storage;

public class Startup : StartupBase
{
    private const string FfmpegSection = "VisusCore_Ffmpeg";
    private readonly IShellConfiguration _shellConfiguration;

    public Startup(IShellConfiguration shellConfiguration) =>
        _shellConfiguration = shellConfiguration;

    public override void ConfigureServices(IServiceCollection services)
    {
        services.Configure<FfmpegOptions>(
            options => _shellConfiguration
                .GetSection($"{FfmpegSection}:{nameof(FfmpegOptions)}")
                .Bind(options));
        services.AddSingleton<IModularTenantEvents, ModularTenentEventHandler>();
    }
}
