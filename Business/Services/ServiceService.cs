
using Data.Entities;
using Data.Interfaces;
using System.Linq.Expressions;

namespace Business.Services;

public class ServiceService : BaseService<ServiceEntity>
{
    ServiceService(IBaseRepository<ServiceEntity> repository) : base(repository)
    {
    }
}
