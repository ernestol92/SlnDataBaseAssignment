using Business.Interfaces;
using Data.Entities;
using Data.Interfaces;

namespace Business.Services;

public class ServiceService : BaseService<ServiceEntity> , IServiceService
{
    public ServiceService(IBaseRepository<ServiceEntity> repository) : base(repository)
    {
    }
}
