using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace Data.Contexts;

public class DataContextFactory : IDesignTimeDbContextFactory<MyDBContext>
{
    public MyDBContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<MyDBContext>();
        optionsBuilder.UseMySql("server=localhost;database=projectdata;user=root;password=4elements4;", new MySqlServerVersion(new Version(8,0,41)));

        return new MyDBContext(optionsBuilder.Options);
    }

}
