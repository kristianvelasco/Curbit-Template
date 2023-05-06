namespace AuthorizationAPI.Services.Interfaces
{
    public interface IStoreService
    {
        Task<object> AddStore(object StoreDto);

        Task<bool> DeleteStore(Guid StoreUId);

        Task<IEnumerable<object>> GetAllStores();

        Task<object> GetStoreByUId(Guid StoreUId);

        Task<object> GetStoreByStoreName(string StoreName);

        Task<object> UpdateStore(Guid StoreUId, object StoreDto);
    }
}
