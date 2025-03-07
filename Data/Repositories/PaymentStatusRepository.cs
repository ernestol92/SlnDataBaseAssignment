using Data.Contexts;
using Data.Entities;
using Data.Interfaces;
namespace Data.Repositories
{
    public class PaymentStatusRepository(MyDBContext context) : BaseRepository<PaymentStatusEntity>(context), IPaymentStatusRepository
    {
    }
}
