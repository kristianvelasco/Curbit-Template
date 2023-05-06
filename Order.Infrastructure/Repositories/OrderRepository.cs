using Common.Data.Models;
using Order.Infrastructure.Repositories.Interfaces;
using Order.Domain;
using System.Linq.Expressions;
using Common.Data.Data;

namespace Order.Infrastructure.Repositories
{
    public class OrderRepository : IOrderRepository
    {

        private readonly OrderDbContext _context;

        public IUnitOfWork UnitOfWork => _context;

        public OrderRepository(OrderDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public Task<Domain.Models.Order> Add(Domain.Models.Order entity)
        {
            throw new NotImplementedException();
        }

        public Task<Domain.Models.Order> AddIfNotExists(Domain.Models.Order entity, Expression<Func<Domain.Models.Order, bool>>? predicate = null)
        {
            throw new NotImplementedException();
        }

        public void Delete(Domain.Models.Order entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists<T>(Guid? uId) where T : BaseModel
        {
            throw new NotImplementedException();
        }

        public void Update(Domain.Models.Order entity)
        {
            throw new NotImplementedException();
        }
    }
}
