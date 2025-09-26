using Microsoft.EntityFrameworkCore;
using Task2.Models
    ;
namespace Task2.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        
        public DbSet<Employee> Employees { get; set; }

        public async Task<List<Employee>> GetEmployeesWithSalaryAboveAsync(decimal minSalary)
        {
            return await Employees
                .FromSqlRaw("EXEC GetEmployeesWithSalaryAbove @MinSalary={0}", minSalary)
                .ToListAsync();
        }

    }

}
