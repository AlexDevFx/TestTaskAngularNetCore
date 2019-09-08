using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using AngularRestApi.Authorization.Roles;
using AngularRestApi.Authorization.Users;
using AngularRestApi.Goods;
using AngularRestApi.MultiTenancy;
using AngularRestApi.OrderGoods;
using AngularRestApi.Orders;

namespace AngularRestApi.EntityFrameworkCore
{
    public class AngularRestApiDbContext : AbpZeroDbContext<Tenant, Role, User, AngularRestApiDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Good> Goods { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderGood> OrdersGoods { get; set; }
        public AngularRestApiDbContext(DbContextOptions<AngularRestApiDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Good>(b =>
            {
                b.ToTable("Goods");
                b.Property(p => p.Title).HasMaxLength(255).IsUnicode();
            });

            modelBuilder.Entity<Order>(b =>
            {
                b.ToTable("Orders");
                b.Property(p => p.Title).HasMaxLength(512).IsUnicode();
            });
            
            modelBuilder.Entity<OrderGood>(b =>
            {
                b.ToTable("OrdersGoods");
                b.HasOne(e => e.Order).WithMany(e => e.OrderGoods);
                b.HasOne(e => e.Good).WithMany(e => e.OrderGoods);
            });
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
