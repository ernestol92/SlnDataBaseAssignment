using Business.Interfaces;
using Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : BaseController<PaymentEntity>
    {
        private readonly IPaymentService _paymentService;

        public PaymentController(IPaymentService paymentService) : base(paymentService)
        {
            _paymentService = paymentService;
        }
    }
}
