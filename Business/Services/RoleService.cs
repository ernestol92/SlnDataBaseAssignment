using Data.Entities;
using Data.Interfaces;
using System.Linq.Expressions;

namespace Business.Services;

public class RoleService : BaseService<RoleEntity>
{
    RoleService(IBaseRepository<RoleEntity> repository) : base(repository)
    {
    }
}
