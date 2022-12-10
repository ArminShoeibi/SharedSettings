using SharedSettings.Shared;
using SharedSettings.WorkerService3;

IHost host = Host.CreateDefaultBuilder(args)
    .AddSharedSettings()
    .ConfigureServices(services =>
    {
        services.AddHostedService<Worker>();
    })
    .Build();

host.Run();
