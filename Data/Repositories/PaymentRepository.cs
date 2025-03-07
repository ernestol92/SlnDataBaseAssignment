using Data.Contexts;
using Data.Entities;
using Data.Interfaces;

namespace Data.Repositories;

public class PaymentRepository(MyDBContext context) : BaseRepository<PaymentEntity>(context), IPaymentRepository
{
}


