using Data.Entities;
using Data.Interfaces;
using Business.Interfaces;

namespace Business.Services;

public class PaymentStatusService : BaseService<PaymentStatusEntity>, IPaymentStatusService

{
    public PaymentStatusService(IBaseRepository<PaymentStatusEntity> repository) : base(repository)
    {
    }
}
