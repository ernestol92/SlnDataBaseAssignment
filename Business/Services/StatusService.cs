using Business.Interfaces;
using Data.Entities;
using Data.Interfaces;
using System.Linq.Expressions;

namespace Business.Services;

public class StatusService : BaseService<StatusEntity>, IStatusService
{
    public StatusService(IBaseRepository<StatusEntity> repository) : base(repository)
    {
    }
}