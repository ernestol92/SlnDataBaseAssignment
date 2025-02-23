using Data.Entities;
using Data.Interfaces;
using System.Linq.Expressions;

namespace Business.Services;

public class StatusService : BaseService<StatusEntity>
{
    StatusService(IBaseRepository<StatusEntity> repository) : base(repository)
    {
    }
}