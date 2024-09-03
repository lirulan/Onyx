using Microsoft.EntityFrameworkCore;
using Onyx.Domain.Entities;

namespace Onyx.Infrastructure
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(o => o.Id);
                entity.Property(o => o.CustomerName).IsRequired().HasMaxLength(100);
                entity.Property(o => o.OrderDate).IsRequired();

                entity.HasMany(o => o.Items)
                      .WithOne()
                      .HasForeignKey(oi => oi.Id);
            });

            modelBuilder.Entity<OrderItem>(entity =>
            {
                entity.HasKey(oi => oi.Id);
                entity.Property(oi => oi.ProductName).IsRequired().HasMaxLength(100);
                entity.Property(oi => oi.Quantity).IsRequired();

                entity.HasOne<Order>()
                      .WithMany(o => o.Items)
                      .HasForeignKey(oi => oi.Id);
            });
        }
    }
}
