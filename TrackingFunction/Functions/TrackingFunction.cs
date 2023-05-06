using System;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using TrackingFunction.Services.Interfaces;

namespace TrackingFunction.Functions
{
    public class TrackingFunction
    {
        private readonly ILogger _logger;
        private readonly ITrackingService _trackingService;

        public TrackingFunction(ILoggerFactory loggerFactory , ITrackingService trackingService)
        {
            _logger = loggerFactory.CreateLogger<TrackingFunction>();
            _trackingService = trackingService ?? throw new ArgumentNullException(nameof(trackingService));
        }

        [Function("TrackingFunction")]
        public void Run([ServiceBusTrigger("mytopic", "mysubscription", Connection = "")] string mySbMsg)
        {
            _logger.LogInformation($"C# ServiceBus topic trigger function processed message: {mySbMsg}");
        }
    }
}
