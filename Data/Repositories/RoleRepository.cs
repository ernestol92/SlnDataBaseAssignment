using Data.Contexts;
using Data.Entities

using Data.Interfaces;

namespace Data.Repositories;

public class RoleRepository(MyDBContext context) : BaseRepository<RoleEntity>(context), IRoleRepository
{
    private readonly MyDBContext _context = context;
}
