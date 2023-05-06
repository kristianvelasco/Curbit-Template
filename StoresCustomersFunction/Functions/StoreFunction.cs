using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using StoresCustomersFunction.Services.Interfaces;

namespace StoresCustomersFunction.Functions;

public class StoreFunction
{
    private readonly ILogger _logger;
    private readonly IStoreService _storeService;

    public StoreFunction(ILoggerFactory loggerFactory, IStoreService storeService)
    {
        _logger = loggerFactory.CreateLogger<StoreFunction>();
        _storeService = storeService;
    }
    [Function("CustomerFunction")]
    public void Run([ServiceBusTrigger("mytopic", "mysubscription", Connection = "")] string mySbMsg)
    {
        _logger.LogInformation($"C# ServiceBus topic trigger function processed message: {mySbMsg}");
    }
}

