using Microsoft.EntityFrameworkCore;
using P134Lab.Models;

namespace P134Lab.Data
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> options):base(options)
        {

        }
        public DbSet<Student> Student { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
