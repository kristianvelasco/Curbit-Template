using AuthorizationAPI.Services.Interfaces;

namespace AuthorizationAPI.Services;

public class UserService : IUserService
{
    public Task<object> AddUser(object userDto)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteUser(Guid userUId)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<object>> GetAllUsers()
    {
        throw new NotImplementedException();
    }

    public Task<object> GetUserByUId(Guid userUId)
    {
        throw new NotImplementedException();
    }

    public Task<object> GetUserByUserName(string userName)
    {
        throw new NotImplementedException();
    }

    public Task<object> UpdateUser(Guid userUId, object userDto)
    {
        throw new NotImplementedException();
    }
}

