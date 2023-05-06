namespace AuthorizationAPI.Services.Interfaces
{
    public interface ICustomerService
    {
        Task<object> AddCustomer(object CustomerDto);

        Task<bool> DeleteCustomer(Guid CustomerUId);

        Task<IEnumerable<object>> GetAllCustomers();

        Task<object> GetCustomerByUId(Guid CustomerUId);

        Task<object> GetCustomerByCustomerName(string CustomerName);

        Task<object> UpdateCustomer(Guid CustomerUId, object CustomerDto);
    }
}
