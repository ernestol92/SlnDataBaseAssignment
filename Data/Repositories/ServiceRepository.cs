using Data.Contexts;
using Data.Entities;
using Data.Interfaces;

namespace Data.Repositories;

public class ServiceRepository(MyDBContext context) : BaseRepository<ServiceEntity>(context), IServiceRepository
{
    private readonly MyDBContext _context = context;
}
