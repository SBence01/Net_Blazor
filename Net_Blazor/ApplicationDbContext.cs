using Microsoft.EntityFrameworkCore;
using Net_Blazor.Shared;

namespace Net_Blazor
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public virtual DbSet<Employee> Employee { get; set; }

        public virtual DbSet<Department> Department { get; set; }
    }
}
