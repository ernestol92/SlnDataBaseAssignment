
using Data.Entities;
using Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;


[Route("api/[controller]")]
[ApiController]
public class CustomerController : BaseController<CustomerEntity>
{
    private readonly ICustomerService _customerService;
    public CustomerController(ICustomerService customerService) : base(customerService)
    {
        _customerService = customerService;
    }
}