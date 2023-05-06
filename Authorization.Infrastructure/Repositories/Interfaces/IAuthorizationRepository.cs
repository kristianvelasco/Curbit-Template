namespace Authorization.Infrastructure.Repositories.Interfaces;

public interface IAuthorizationRepository
{
    object Add(object order);

    void Update(object order);

    Task<object> GetAsync(int orderId);
}

