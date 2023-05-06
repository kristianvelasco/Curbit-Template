using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace NotificationFunction.Functions;

public class NotificationFunction
{
    private readonly ILogger _logger;

    public NotificationFunction(ILoggerFactory loggerFactory)
    {
        _logger = loggerFactory.CreateLogger<NotificationFunction>();
    }


    [Function("NotificationFunction")]
    public void Run([ServiceBusTrigger("mytopic", "mysubscription", Connection = "")] string mySbMsg)
    {
        _logger.LogInformation($"C# ServiceBus topic trigger function processed message: {mySbMsg}");
    }
}

