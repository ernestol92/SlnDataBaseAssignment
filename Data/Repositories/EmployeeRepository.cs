using Data.Contexts;
using Data.Entities;
using Data.Interfaces;

namespace Data.Repositories;

public class EmployeeRepository(MyDBContext context) : BaseRepository<EmployeeEntity>(context), IEmployeeRepository
{
}

