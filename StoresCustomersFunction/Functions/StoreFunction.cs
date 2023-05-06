using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace StoresCustomersFunction.Functions;

public class StoreFunction
{
    private readonly ILogger _logger;

    public StoreFunction(ILoggerFactory loggerFactory)
    {
        _logger = loggerFactory.CreateLogger<StoreFunction>();
    }
    [Function("CustomerFunction")]
    public void Run([ServiceBusTrigger("mytopic", "mysubscription", Connection = "")] string mySbMsg)
    {
        _logger.LogInformation($"C# ServiceBus topic trigger function processed message: {mySbMsg}");
    }
}

