using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace StoresCustomersFunction.Functions;

public class CustomerFunction
{
    private readonly ILogger _logger;

    public CustomerFunction(ILoggerFactory loggerFactory)
    {
        _logger = loggerFactory.CreateLogger<CustomerFunction>();
    }

    [Function("CustomerFunction")]
    public void Run([ServiceBusTrigger("mytopic", "mysubscription", Connection = "")] string mySbMsg)
    {
        _logger.LogInformation($"C# ServiceBus topic trigger function processed message: {mySbMsg}");
    }
}

