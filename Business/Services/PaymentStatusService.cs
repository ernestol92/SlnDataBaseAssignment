using Data.Entities;
using Data.Interfaces;
using System.Linq.Expressions;

namespace Business.Services;

public class PaymentStatusService : BaseService<PaymentStatusEntity>
{
    PaymentStatusService(IBaseRepository<PaymentStatusEntity> repository) : base(repository)
    {
    }
}
