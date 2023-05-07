using Common.Data.Data;
using Common.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Tracking.Domain.Models;
using Tracking.Infrastructure.Repositories.Interfaces;

namespace Tracking.Infrastructure.Repositories
{
    internal class TrackingRepository : ITrackingRepository
    {
        public IUnitOfWork UnitOfWork => throw new NotImplementedException();

        public Task<TrackingOrder> Add(TrackingOrder entity)
        {
            throw new NotImplementedException();
        }

        public Task<TrackingOrder> AddIfNotExists(TrackingOrder entity, Expression<Func<TrackingOrder, bool>>? predicate = null)
        {
            throw new NotImplementedException();
        }

        public void Delete(TrackingOrder entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists<T>(Guid? uId) where T : BaseModel
        {
            throw new NotImplementedException();
        }

        public void Update(TrackingOrder entity)
        {
            throw new NotImplementedException();
        }
    }
}
