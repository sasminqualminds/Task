using EmployeeApi.Model;
using Microsoft.EntityFrameworkCore;

namespace EmployeeApi.Data
{
    // Represents the database context for the Employee entity
    public class EmployeeContext:DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> contextOptions) : base(contextOptions)
        { }

        // DbSet representing the collection of Employee entities in the database
        public DbSet<Employee> Employees { get; set; }
    }
}
