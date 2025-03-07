using Business.Interfaces;
using Data.Entities;
using Data.Interfaces;
using System.Linq.Expressions;

namespace Business.Services
{
    public class EmployeeService : BaseService<EmployeeEntity>, IEmployeeService
    {
        public EmployeeService(IBaseRepository<EmployeeEntity> repository) : base(repository)
        {
        }
        
    }
}
