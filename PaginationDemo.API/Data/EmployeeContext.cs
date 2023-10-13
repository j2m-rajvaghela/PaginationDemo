using Microsoft.EntityFrameworkCore;
using PaginationDemo.API.Configuration;
using PaginationDemo.API.Model;

namespace PaginationDemo.API.Data
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }



        // Model Configuaration
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.ApplyConfiguration(new EmployeeModelConfiguration());
        }
    }
}
