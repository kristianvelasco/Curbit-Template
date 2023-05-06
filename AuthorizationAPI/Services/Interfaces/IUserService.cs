namespace AuthorizationAPI.Services.Interfaces;

public interface IUserService
{
    Task<object> AddUser(object userDto);

    Task<bool> DeleteUser(Guid userUId);

    Task<IEnumerable<object>> GetAllUsers();

    Task<object> GetUserByUId(Guid userUId);

    Task<object> GetUserByUserName(string userName);

    Task<object> UpdateUser(Guid userUId, object userDto);

}

