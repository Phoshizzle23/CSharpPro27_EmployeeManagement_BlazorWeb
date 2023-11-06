using EmployeeMGTBlazor.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeMGTBlazor.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { 
            
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
