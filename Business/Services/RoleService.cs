using Business.Interfaces;
using Data.Entities;
using Data.Interfaces;
using System.Linq.Expressions;

namespace Business.Services;

public class RoleService : BaseService<RoleEntity>, IRoleService
{
    public RoleService(IBaseRepository<RoleEntity> repository) : base(repository)
    {
    }
}
