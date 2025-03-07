using Business.Interfaces;
using Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class StatusController : BaseController<StatusEntity>
    {
        private readonly IStatusService _statusService;

        public StatusController(IStatusService statusService) : base(statusService)
        {
            _statusService = statusService;
        }
    }
}
