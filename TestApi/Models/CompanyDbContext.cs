using Microsoft.EntityFrameworkCore;

namespace TestApi.Models
{
    public class CompanyDbContext:DbContext
    {
        public CompanyDbContext(DbContextOptions<CompanyDbContext> options):base(options)
        {

        }
        public DbSet<Employee> employees { get; set; }
    }
}
