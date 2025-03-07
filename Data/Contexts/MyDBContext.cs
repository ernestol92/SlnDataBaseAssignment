using Microsoft.EntityFrameworkCore;
using Data.Entities;

namespace Data.Contexts
{
    public class MyDBContext(DbContextOptions<MyDBContext> options) : DbContext(options)
    {

        public DbSet<ProjectEntity> Projects { get; } = null!;
        public DbSet<StatusEntity> Status { get; set; } = null!;
        public DbSet<CustomerEntity> Customers { get; set; } = null!;

        public DbSet<EmployeeEntity> Employees { get; set; } = null!;

        public DbSet<ServiceEntity> Services { get; set; } = null!;
        public DbSet<PaymentEntity> Payments { get; set; } = null!; 
        public DbSet<PaymentStatusEntity> PaymentStatus { get; set; } = null!;
        public DbSet<RoleEntity> Role { get; set; } = null!;




    }
}
