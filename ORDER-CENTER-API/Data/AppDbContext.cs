using Microsoft.EntityFrameworkCore;
using ORDER_CENTER_API.Models;

namespace ORDER_CENTER_API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions opt) : base(opt)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Orders_Itens>()
                .HasOne(f => f.Food)
                .WithMany(o => o.Orders_Itens)
                .HasForeignKey(f => f.FoodId);

            builder.Entity<Orders_Itens>()
              .HasOne(f => f.Orders)
              .WithMany(o => o.Orders_Itens)
              .HasForeignKey(f => f.OrderId);

            builder.Entity<TempOrders>()
                .HasOne(o => o.Orders_Itens)
                .WithMany(i => i.TempOrders)
                .HasForeignKey(o => o.Orders_ItensId);
        }

        public DbSet<Foods> Foods { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Orders_Itens> Orders_Itens { get; set; }
        public DbSet<TempOrders> TempOrders { get; set; }
    }
}
