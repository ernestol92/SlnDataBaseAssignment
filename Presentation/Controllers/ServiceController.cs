using Business.Interfaces;
using Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : BaseController<ServiceEntity>
    {
        private readonly IServiceService _serviceService;

        public ServiceController(IServiceService serviceService) : base(serviceService)
        {
            _serviceService = serviceService;
        }
    }
}
