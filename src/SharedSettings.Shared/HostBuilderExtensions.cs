using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace SharedSettings.Shared;
public static class HostBuilderExtensions
{
    public static IHostBuilder AddSharedSettings(this IHostBuilder hostBuilder)
    {
        // ConfigureAppConfiguration method can be called multiple times and  the results will be additive
        return hostBuilder.ConfigureAppConfiguration((hostingContext, configurationBuilder) =>
        {
            string sharedSettingsFile = $"SharedSettings.{hostingContext.HostingEnvironment.EnvironmentName}.json";
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, sharedSettingsFile);
            configurationBuilder.AddJsonFile(path, optional: true, reloadOnChange: true);
        });
    }
}
