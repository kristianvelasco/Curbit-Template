using Microsoft.Extensions.Logging;
using Tracking.Infrastructure.Repositories.Interfaces;
using TrackingFunction.Services.Interfaces;

namespace TrackingFunction.Services
{
    public class TrackingService : ITrackingService
    {
        private readonly ITrackingRepository _trackingRepository;

        public TrackingService(ITrackingRepository trackingRepository)
        {
            _trackingRepository = trackingRepository;
        }
        public void AddTracking(ILogger log, string eventData)
        {
            _trackingRepository.Add(new Tracking.Domain.Models.TrackingOrder());
            _trackingRepository.UnitOfWork.SaveChangesAsync();
        }
    }
}
