using Data.Contexts;
using Data.Entities;

namespace Data.Repositories;

public class EmployeeRepository(MyDBContext context) : BaseRepository<EmployeeEntity>(context), IEmployeeRepository
{
    private readonly MyDBContext _context = context;
}

