using Civil.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace Civil.API.Data
{
    public class DataContext:DbContext
    {
        public DbSet<Patient> Patient { get; set; }
        
        public DataContext(DbContextOptions<DataContext> options):base(options) 
        { 

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Patient>().HasIndex(x => x.Register).IsUnique();
        }



    }
}
