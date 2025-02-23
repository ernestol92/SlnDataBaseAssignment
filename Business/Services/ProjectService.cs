using Data.Entities;
using Data.Interfaces;
using System.Linq.Expressions;

namespace Business.Services;

public class ProjectService : BaseService<ProjectEntity>
{
    ProjectService(IBaseRepository<ProjectEntity> repository) : base(repository)
    {
    }
}
