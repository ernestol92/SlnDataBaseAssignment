using Data.Entities;
using Data.Interfaces;
using System.Linq.Expressions;

namespace Business.Services;

public class PaymentService : BaseService<PaymentEntity>
{
    PaymentService(IBaseRepository<PaymentEntity> repository) : base(repository)
    {
    }
}
