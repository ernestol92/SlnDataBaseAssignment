
using Business.Factories;
using Business.Interfaces;
using Business.Services;
using Data.Contexts;
using Data.Entities;
using Data.Interfaces;
using Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using Swashbuckle.AspNetCore.SwaggerUI;


namespace Presentation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            // Add my DBContext to the container.
            builder.Services.AddDbContext<MyDBContext>(options => options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"),
                ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("DefaultConnection"))));
            // Add my services to the container.
            builder.Services.AddScoped<IBaseRepository<CustomerEntity>, CustomerRepository>();
            builder.Services.AddScoped<IBaseRepository<EmployeeEntity>, EmployeeRepository>();
            builder.Services.AddScoped<IBaseRepository<PaymentEntity>, PaymentRepository>();
            builder.Services.AddScoped<IBaseRepository<PaymentStatusEntity>, PaymentStatusRepository>();
            builder.Services.AddScoped<IBaseRepository<ProjectEntity>, ProjectRepository>();
            builder.Services.AddScoped<IBaseRepository<RoleEntity>, RoleRepository>();
            builder.Services.AddScoped<IBaseRepository<ServiceEntity>, ServiceRepository>();
            builder.Services.AddScoped<IBaseRepository<StatusEntity>, StatusRepository>();


            builder.Services.AddScoped<ICustomerService, CustomerService>();
            builder.Services.AddScoped<IEmployeeService, EmployeeService>();
            builder.Services.AddScoped<IPaymentService, PaymentService>();
            builder.Services.AddScoped<IPaymentStatusService, PaymentStatusService>();
            builder.Services.AddScoped<IProjectService, ProjectService>();
            builder.Services.AddScoped<IRoleService, RoleService>();
            builder.Services.AddScoped<IServiceService, ServiceService>();
            builder.Services.AddScoped<IStatusService, StatusService>();

            builder.Services.AddScoped<IProjectFactory, ProjectFactory>();

            builder.Services.AddCors(options =>
            {
                var corsPolicy = "_allowFrontend";

                options.AddPolicy(name: corsPolicy,
                    policy =>
                    {
                        policy.WithOrigins("http://localhost:3000") // Replace with your frontend URL
                              .AllowAnyHeader()
                              .AllowAnyMethod();
                    });
            });


            builder.Services.AddControllers();
            builder.Services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
            });
            

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();  // Enable Swagger UI
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
                    c.RoutePrefix = string.Empty;
                });
            }

            app.UseHttpsRedirection();
            

            app.UseCors("_allowFrontend");

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
