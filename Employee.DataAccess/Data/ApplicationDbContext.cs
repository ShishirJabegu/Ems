using Microsoft.EntityFrameworkCore;

namespace Employee.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options)
        {
            
        }
        public DbSet<Model.Models.Employee> EmployeeTable { get; set; }  
    }
}
