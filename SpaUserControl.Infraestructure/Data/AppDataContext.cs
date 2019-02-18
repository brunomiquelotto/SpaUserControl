using Microsoft.EntityFrameworkCore;
using SpaUserControl.Domain.Models;
using SpaUserControl.Infraestructure.Data.Map;

namespace SpaUserControl.Infraestructure.Data
{
    public class AppDataContext : DbContext
    {
        public AppDataContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDataContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\SQLEXPRESS;Database=SpaUserControl; MultipleActiveResultSets=true;Encrypt=YES;TrustServerCertificate=YES");
            
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());
        }

        public DbSet<User> Users { get; set; }
    }
}
