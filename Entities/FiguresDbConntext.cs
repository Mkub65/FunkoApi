using FunkoApi.Models;
using Microsoft.EntityFrameworkCore;

namespace FunkoApi.Entities
{
    public class FiguresDbConntext
    {
        public class RestaurantDbContext : DbContext
        {
            private string _connectionString = "Server=localhost;Database=;Trusted_Connection=True;";
            public DbSet<Figure> Figures { get; set; }
            public DbSet<User> Users { get; set; }
            public DbSet<Role> Roles { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<User>()
                    .Property(u => u.Email)
                    .IsRequired();
                modelBuilder.Entity<Role>()
                    .Property(u => u.Name)
                    .IsRequired();
                modelBuilder.Entity<Figure>();
            }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(_connectionString);
            }
        }
    }
}
