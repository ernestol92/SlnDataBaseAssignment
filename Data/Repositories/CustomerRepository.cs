using Data.Contexts;
using Data.Entities;
using Data.Interfaces;

namespace Data.Repositories
{
    public class CustomerRepository(MyDBContext context) : BaseRepository<CustomerEntity>(context), ICustomerRepository
    {
        private readonly MyDBContext _context = context;
    }
}
