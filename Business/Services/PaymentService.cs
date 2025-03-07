using Business.Interfaces;
using Data.Entities;
using Data.Interfaces;

namespace Business.Services;

public class PaymentService : BaseService<PaymentEntity>, IPaymentService
{
    public PaymentService(IBaseRepository<PaymentEntity> repository) : base(repository)
    {
    }
}
