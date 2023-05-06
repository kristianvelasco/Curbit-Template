using AuthorizationAPI.Services.Interfaces;

namespace AuthorizationAPI.Services
{
    public class CustomerService : ICustomerService
    {
        public Task<object> AddCustomer(object CustomerDto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteCustomer(Guid CustomerUId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<object>> GetAllCustomers()
        {
            throw new NotImplementedException();
        }

        public Task<object> GetCustomerByCustomerName(string CustomerName)
        {
            throw new NotImplementedException();
        }

        public Task<object> GetCustomerByUId(Guid CustomerUId)
        {
            throw new NotImplementedException();
        }

        public Task<object> UpdateCustomer(Guid CustomerUId, object CustomerDto)
        {
            throw new NotImplementedException();
        }
    }
}
