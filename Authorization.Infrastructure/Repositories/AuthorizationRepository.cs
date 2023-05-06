using Authorization.Infrastructure.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authorization.Infrastructure.Repositories;

public class AuthorizationRepository : IAuthorizationRepository
{
    public object Add(object order)
    {
        throw new NotImplementedException();
    }

    public Task<object> GetAsync(int orderId)
    {
        throw new NotImplementedException();
    }

    public void Update(object order)
    {
        throw new NotImplementedException();
    }
}

