namespace SharedSettings.WorkerService2;

public class Worker : BackgroundService
{
    private readonly ILogger<Worker> _logger;
    private readonly IConfiguration _configuration;

    public Worker(ILogger<Worker> logger, IConfiguration configuration)
    {
        _logger = logger;
        _configuration = configuration;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            _logger.LogInformation("Worker running at: {time} - {Key1}", DateTimeOffset.Now, _configuration.GetValue<string>("Key1"));
            await Task.Delay(1000, stoppingToken);
        }
    }
}
