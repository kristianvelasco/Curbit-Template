using Common.Data.Data;
using Common.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Tracking.Infrastructure.Repositories.Interfaces;

    public interface ITrackingRepository : IRepository<Domain.Models.TrackingOrder>
{
    Task<Domain.Models.TrackingOrder> Add(Domain.Models.TrackingOrder entity);

    Task<Domain.Models.TrackingOrder> AddIfNotExists(Domain.Models.TrackingOrder entity, Expression<Func<Domain.Models.TrackingOrder, bool>>? predicate = null);

    void Delete(Domain.Models.TrackingOrder entity);

    bool Exists<T>(Guid? uId) where T : BaseModel;

    void Update(Domain.Models.TrackingOrder entity);
}


