using GoogleCloudConsole.Application.Interfaces;
using GoogleCloudConsole.Infrastructure.Services;

namespace GoogleCloudConsoleAPI_Tests.Extensions;

public static class ServiceExtensions
{
    public static void ConfigureServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddTransient<IGoogleDriveService, GoogleDriveService>();
    }
}