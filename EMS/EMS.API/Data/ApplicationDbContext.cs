using EMS.Shared;
using Microsoft.EntityFrameworkCore;

namespace EMS.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
            
        }
        public ApplicationDbContext(DbContextOptions options)
            : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.GenerateSeed();
        }
        public virtual DbSet<Employee> Employees { get; set; } 
    }
}
