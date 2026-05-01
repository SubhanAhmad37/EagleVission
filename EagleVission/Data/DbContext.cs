using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace EagleVission.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        // =====================
        // DATABASE TABLES
        // =====================

        public DbSet<Product> Products { get; set; }

        // =====================
        // OPTIONAL CONFIGURATION
        // =====================
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //// User config
            //modelBuilder.Entity<User>()
            //    .Property(u => u.Name)
            //    .IsRequired()
            //    .HasMaxLength(100);

            //modelBuilder.Entity<User>()
            //    .Property(u => u.Email)
            //    .IsRequired()
            //    .HasMaxLength(150);

            //// Product config
            //modelBuilder.Entity<Product>()
            //    .Property(p => p.Name)
            //    .IsRequired()
            //    .HasMaxLength(200);
        }
    }
}