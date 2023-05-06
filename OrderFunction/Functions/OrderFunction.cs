using System;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace OrderFunction.Functions
{
    public class OrderFunction
    {
        private readonly ILogger _logger;

        public OrderFunction(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<OrderFunction>();
        }

        [Function("OrderFunction")]
        public void Run([ServiceBusTrigger("mytopic", "mysubscription", Connection = "")] string mySbMsg)
        {
            _logger.LogInformation($"C# ServiceBus topic trigger function processed message: {mySbMsg}");
        }
    }
}
