using Data.Entities;
using Data.Interfaces;
using System.Linq.Expressions;

namespace Business.Services
{
    public class EmployeeService : BaseService<EmployeeEntity>
    {
        EmployeeService(IBaseRepository<EmployeeEntity> repository) : base(repository)
        {
        }
        
    }
}
