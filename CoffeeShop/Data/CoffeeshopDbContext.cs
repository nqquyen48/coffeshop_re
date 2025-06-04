using CoffeeShop.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace CoffeeShop.Data
{
    public class CoffeeshopDbContext : DbContext
    {
        public CoffeeshopDbContext(DbContextOptions<CoffeeshopDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        // Seed data mẫu (Bước 6 sẽ dùng)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().Property(p => p.Price).HasPrecision(18, 2);
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Americano", Price = 25, Detail = "Cà phê Mỹ", ImageUrl = "https://media.istockphoto.com/id/2153935192/vi/anh/cup-of-coffee-isolated-on-white-background-file-contains-clipping-path.jpg?s=612x612&w=0&k=20&c=2KvztiUrbZCfAhdKM93t2Xkzfo_DHadA8CZqkIm-o6E=", },
                new Product { Id = 2, Name = "Vietnam", Price = 20, Detail = "Cà phê Việt", ImageUrl = "https://cubes-asia.com/storage/blogs/2024-12/5-cach-pha-ca-phe-sua-tuoi-khong-duong-co.jpeg" },
                new Product { Id = 3, Name = "UK", Price = 15, Detail = "Cà phê Anh", ImageUrl = "https://cubes-asia.com/storage/blogs/2024-12/5-cach-pha-ca-phe-sua-tuoi-khong-duong-co.jpeg" },
                new Product { Id = 4, Name = "Americano", Price = 25, Detail = "Cà phê Mỹ", ImageUrl = "https://media.istockphoto.com/id/2153935192/vi/anh/cup-of-coffee-isolated-on-white-background-file-contains-clipping-path.jpg?s=612x612&w=0&k=20&c=2KvztiUrbZCfAhdKM93t2Xkzfo_DHadA8CZqkIm-o6E=", },
                new Product { Id = 5, Name = "Vietnam", Price = 20, Detail = "Cà phê Việt", ImageUrl = "https://cubes-asia.com/storage/blogs/2024-12/5-cach-pha-ca-phe-sua-tuoi-khong-duong-co.jpeg" },
                new Product { Id = 6, Name = "UK", Price = 15, Detail = "Cà phê Anh", ImageUrl = "https://cubes-asia.com/storage/blogs/2024-12/5-cach-pha-ca-phe-sua-tuoi-khong-duong-co.jpeg" }
            );
        }
    }
}
