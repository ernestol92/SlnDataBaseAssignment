using Microsoft.EntityFrameworkCore;
using Data.Entities;

namespace Data.Contexts
{
    public class MyDBContext(DbContextOptions<MyDBContext> options) : DbContext(options)
    {

        public DbSet<ProjectEntity> Projects { get; set; }
        public DbSet<StatusEntity> Status { get; set; }
        public DbSet<CustomerEntity> Customers { get; set; }


    }
}
