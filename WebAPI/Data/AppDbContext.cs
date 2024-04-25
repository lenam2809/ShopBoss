using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebAPI.Entities;

namespace WebAPI.Data
{
    public class AppDbContext : IdentityDbContext<User>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Variant> Variants { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Shipping> Shippings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    CategoryId = Guid.Parse("3958dc9e-742f-4377-85e9-fec4b6a6442a"),
                    Name = "Category 1"
                },
                new Category
                {
                    CategoryId = Guid.Parse("3958dc9e-742f-4377-85e9-fec4b6a6442b"),
                    Name = "Category 2"
                }
            );


            modelBuilder.Entity<Customer>().HasData(
                new Customer { CustomerId = Guid.Parse("1958dc9e-742f-4377-85e9-fec4b6a6442a"), Name = "John Doe", Email = "john@example.com", Address = "Paris" },
                new Customer { CustomerId = Guid.Parse("2958dc9e-742f-4377-85e9-fec4b6a6442a"), Name = "Jane Smith", Email = "jane@example.com", Address = "New York" }
            );

        }

    }
}
