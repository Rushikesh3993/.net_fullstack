using Microsoft.EntityFrameworkCore;

namespace WebApplication2dot_net_corestart.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions options) : base(options) 
        { 
        
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
