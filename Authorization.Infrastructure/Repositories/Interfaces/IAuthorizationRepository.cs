using Common.Data.Data;

namespace Authorization.Infrastructure.Repositories.Interfaces;

public interface IAuthorizationRepository : IUnitOfWork
{
    object Add(object order);

    void Update(object order);

    Task<object> GetAsync(int orderId);
}

