using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        public MyContext CreateDbContext(string[] args)
        {
           var connectionString = "Server=localhost;Port=5432;Database=AuthDB;Uid=admin;Pwd=123456";
           
           var optionsBuilder = new DbContextOptionsBuilder<MyContext>();
           optionsBuilder.UseNpgsql(connectionString);
           return new MyContext (optionsBuilder.Options);
        }
    }
}