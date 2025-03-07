using Business.Interfaces;
using Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class PaymentStatusController : BaseController<PaymentStatusEntity>
    {
        private readonly IPaymentStatusService _paymentStatusService;

        public PaymentStatusController(IPaymentStatusService paymentStatusService) : base(paymentStatusService)
        {
            _paymentStatusService = paymentStatusService;
        }
    }
}
