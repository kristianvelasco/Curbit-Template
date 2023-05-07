using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingFunction.Services.Interfaces
{
    public interface ITrackingService
    {
        void AddTracking(ILogger log, string eventData);
    }
}
