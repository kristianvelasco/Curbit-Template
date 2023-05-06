using AuthorizationAPI.Services.Interfaces;

namespace AuthorizationAPI.Services;

public class RoleService : IRoleService
{
    public Task<object> AddRole(object roleDto)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteRole(Guid roleUId)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<object>> GetAllRoles()
    {
        throw new NotImplementedException();
    }

    public Task<object> GetRoleByUId(Guid roleUId)
    {
        throw new NotImplementedException();
    }

    public Task<object> UpdateRole(Guid roleUId, object roleDto)
    {
        throw new NotImplementedException();
    }
}

