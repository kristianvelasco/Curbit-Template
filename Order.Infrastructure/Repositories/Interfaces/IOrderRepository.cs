using Common.Data.Data;
using Common.Data.Models;
using System.Linq.Expressions;

namespace Order.Infrastructure.Repositories.Interfaces;

public interface IOrderRepository : IRepository<Domain.Models.Order>
{
    Task<Domain.Models.Order> Add(Domain.Models.Order entity);

    Task<Domain.Models.Order> AddIfNotExists(Domain.Models.Order entity, Expression<Func<Domain.Models.Order, bool>>? predicate = null);

    void Delete(Domain.Models.Order entity);

    bool Exists<T>(Guid? uId) where T : BaseModel;

    void Update(Domain.Models.Order entity);
}


