using employe_project.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace employe_project.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options)
        { 
        }

        public DbSet<Employees> Employeesdetails { get; set; }
    }
}
