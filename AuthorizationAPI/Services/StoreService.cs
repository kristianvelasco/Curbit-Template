using AuthorizationAPI.Services.Interfaces;

namespace AuthorizationAPI.Services
{
    public class StoreService : IStoreService
    {
        public Task<object> AddStore(object StoreDto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteStore(Guid StoreUId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<object>> GetAllStores()
        {
            throw new NotImplementedException();
        }

        public Task<object> GetStoreByStoreName(string StoreName)
        {
            throw new NotImplementedException();
        }

        public Task<object> GetStoreByUId(Guid StoreUId)
        {
            throw new NotImplementedException();
        }

        public Task<object> UpdateStore(Guid StoreUId, object StoreDto)
        {
            throw new NotImplementedException();
        }
    }
}
