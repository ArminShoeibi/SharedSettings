using SharedSettings.WorkerService3;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureAppConfiguration(configurationBuilder => 
    {
        configurationBuilder.AddJsonFile();
    })
    .ConfigureServices(services =>
    {
        services.AddHostedService<Worker>();
    })
    .Build();

host.Run();
