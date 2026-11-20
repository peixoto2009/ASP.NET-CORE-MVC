using Microsoft.EntityFrameworkCore;
using EmployeesManagement.Models;
namespace EmployeesManagement.Data
{
public class ApplicationDbContext : DbContext
{
public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
: base(options)
{
    }
        public DbSet<Employee> Employees { get; set; }
    }
}