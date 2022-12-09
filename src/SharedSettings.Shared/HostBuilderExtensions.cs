using Microsoft.Extensions.Hosting;

namespace SharedSettings.Shared;
public static class HostBuilderExtensions
{
    public static IHostBuilder AddSharedSettings(this IHostBuilder hostBuilder)
    {
        return hostBuilder.ConfigureAppConfiguration((hostBuilderContext, configurationBuilder) =>
        {
            configurationBuilder.addj

        });
    }
}
