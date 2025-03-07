using Business.Interfaces;
using Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : BaseController<RoleEntity>
    {
        private readonly IRoleService _roleService;

        public RoleController(IRoleService roleService) : base(roleService)
        {
            _roleService = roleService;
        }
    }
}
