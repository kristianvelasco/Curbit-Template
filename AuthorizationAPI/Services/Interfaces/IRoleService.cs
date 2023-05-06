namespace AuthorizationAPI.Services.Interfaces;

public interface IRoleService
{
    Task<object> AddRole(object roleDto);

    Task<bool> DeleteRole(Guid roleUId);

    Task<IEnumerable<object>> GetAllRoles();

    Task<object> GetRoleByUId(Guid roleUId);

    Task<object> UpdateRole(Guid roleUId, object roleDto);
}

