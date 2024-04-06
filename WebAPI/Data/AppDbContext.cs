using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using WebAPI.Entities;

namespace WebAPI.Data
{
    public class AppDbContext : IdentityDbContext<User>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = Guid.Parse("3958dc9e-742f-4377-85e9-fec4b6a6442a"), Name = "Category 1" },
                new Category { CategoryId = Guid.Parse("3958dc9e-742f-4377-85e9-fec4b6a6442b"), Name = "Category 2" }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = Guid.NewGuid(), Name = "Product 1", Description = "Description of Product 1", Price = 10.99m, StockQuantity = 100, CategoryId = Guid.Parse("3958dc9e-742f-4377-85e9-fec4b6a6442a") },
                new Product { ProductId = Guid.NewGuid(), Name = "Product 2", Description = "Description of Product 2", Price = 20.49m, StockQuantity = 50, CategoryId = Guid.Parse("3958dc9e-742f-4377-85e9-fec4b6a6442b") }
            );

        }

    }
}
