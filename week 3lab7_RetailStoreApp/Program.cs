using System;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RetailStoreApp.Data;
using RetailStoreApp.Models;

class Program
{
    static async Task Main()
    {
        using var context = new AppDbContext();

        // 🔁 Optional: Clear old data (to avoid duplicates on re-run)
        context.Products.RemoveRange(context.Products);
        await context.SaveChangesAsync();

        // ✅ Insert more products
        var electronics = await context.Categories.FirstOrDefaultAsync(c => c.Name == "Electronics");
        var groceries = await context.Categories.FirstOrDefaultAsync(c => c.Name == "Groceries");

        // If not found, create the categories
        if (electronics == null || groceries == null)
        {
            electronics = new Category { Name = "Electronics" };
            groceries = new Category { Name = "Groceries" };
            await context.Categories.AddRangeAsync(electronics, groceries);
            await context.SaveChangesAsync();
        }

        await context.Products.AddRangeAsync(
            new Product { Name = "Laptop", Price = 70000, Category = electronics },
            new Product { Name = "Smartphone", Price = 35000, Category = electronics },
            new Product { Name = "Rice Bag", Price = 1200, Category = groceries },
            new Product { Name = "Headphones", Price = 1500, Category = electronics },
            new Product { Name = "Milk", Price = 60, Category = groceries }
        );

        await context.SaveChangesAsync();
        Console.WriteLine("✅ Products inserted.\n");

        // 🧠 1. Filter and sort products where price > 1000, descending
        var filtered = await context.Products
            .Where(p => p.Price > 1000)
            .OrderByDescending(p => p.Price)
            .ToListAsync();

        Console.WriteLine("=== Filtered & Sorted Products (Price > ₹1000) ===");
        foreach (var p in filtered)
            Console.WriteLine($"{p.Name} - ₹{p.Price}");

        // 🧠 2. Project into DTO
        var productDTOs = await context.Products
            .Select(p => new { p.Name, p.Price })
            .ToListAsync();

        Console.WriteLine("\n=== Projected DTOs ===");
        foreach (var dto in productDTOs)
            Console.WriteLine($"Name: {dto.Name}, Price: ₹{dto.Price}");
    }
}
