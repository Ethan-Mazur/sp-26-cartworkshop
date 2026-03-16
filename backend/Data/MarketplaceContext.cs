using backend.Models;
using Microsoft.EntityFrameworkCore;

namespace backend.Data;

public class MarketplaceContext : DbContext
{
    public MarketplaceContext(DbContextOptions<MarketplaceContext> options)
        : base(options) { }

    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Cart> Carts { get; set; }
    public DbSet<CartItem> CartItems { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().HasData(
            new Category { Id = 1, Name = "Electronics" },
            new Category { Id = 2, Name = "Books" },
            new Category { Id = 3, Name = "Clothing" }
        );

        modelBuilder.Entity<Product>().HasData(
            new Product
            {
                Id = 1,
                Name = "Wireless Headphones",
                Description = "Noise-cancelling over-ear headphones with 30-hour battery life.",
                Price = 149.99m,
                CategoryId = 1,
                ImageUrl = "https://placehold.co/400x300?text=Headphones",
                CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
            },
            new Product
            {
                Id = 2,
                Name = "Mechanical Keyboard",
                Description = "Compact TKL mechanical keyboard with RGB backlighting.",
                Price = 89.99m,
                CategoryId = 1,
                ImageUrl = "https://placehold.co/400x300?text=Keyboard",
                CreatedAt = new DateTime(2026, 1, 2, 0, 0, 0, DateTimeKind.Utc)
            },
            new Product
            {
                Id = 3,
                Name = "Clean Code",
                Description = "A handbook of agile software craftsmanship by Robert C. Martin.",
                Price = 34.99m,
                CategoryId = 2,
                ImageUrl = "https://placehold.co/400x300?text=Clean+Code",
                CreatedAt = new DateTime(2026, 1, 3, 0, 0, 0, DateTimeKind.Utc)
            },
            new Product
            {
                Id = 4,
                Name = "The Pragmatic Programmer",
                Description = "Your journey to mastery, 20th anniversary edition.",
                Price = 39.99m,
                CategoryId = 2,
                ImageUrl = "https://placehold.co/400x300?text=Pragmatic+Programmer",
                CreatedAt = new DateTime(2026, 1, 4, 0, 0, 0, DateTimeKind.Utc)
            },
            new Product
            {
                Id = 5,
                Name = "Classic Hoodie",
                Description = "Comfortable cotton-blend pullover hoodie in multiple colors.",
                Price = 49.99m,
                CategoryId = 3,
                ImageUrl = "https://placehold.co/400x300?text=Hoodie",
                CreatedAt = new DateTime(2026, 1, 5, 0, 0, 0, DateTimeKind.Utc)
            }
        );
    }
}
