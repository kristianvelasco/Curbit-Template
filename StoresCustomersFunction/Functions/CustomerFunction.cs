using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using StoresCustomersFunction.Services.Interfaces;

namespace StoresCustomersFunction.Functions;

public class CustomerFunction
{
    private readonly ILogger _logger;
    private readonly ICustomerService _customerService;
    public CustomerFunction(ILoggerFactory loggerFactory, ICustomerService customerService)
    {
        _logger = loggerFactory.CreateLogger<CustomerFunction>();
        _customerService = customerService;
    }

    [Function("CustomerFunction")]
    public void Run([ServiceBusTrigger("mytopic", "mysubscription", Connection = "")] string mySbMsg)
    {
        _logger.LogInformation($"C# ServiceBus topic trigger function processed message: {mySbMsg}");
    }
}

