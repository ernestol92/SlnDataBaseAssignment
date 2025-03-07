using Business.Interfaces;
using Data.Entities;
using Data.Interfaces;


namespace Business.Services;

public class CustomerService : BaseService<CustomerEntity>, ICustomerService
{
    public CustomerService(IBaseRepository<CustomerEntity> repository) : base(repository)
    {
    }


    // Add CustomerService specific methods here by using override. write business logic first then call the basic crud operations.

    public override async Task<CustomerEntity> CreateAsync(CustomerEntity entity)
    {
        var customer = await GetAsync(x => x.Email == entity.Email);
        if (customer != null)
        {
            throw new Exception("Customer already exists");
        }

        return await base.CreateAsync(entity);
    }
}
