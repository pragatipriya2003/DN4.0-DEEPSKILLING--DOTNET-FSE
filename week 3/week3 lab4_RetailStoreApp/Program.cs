using System;
using System.Threading.Tasks;
using RetailStoreApp.Data;
using RetailStoreApp.Models;
using Microsoft.EntityFrameworkCore;

class Program
{
    static async Task Main()
    {
        using var context = new AppDbContext();

        // Create categories
        var electronics = new Category { Name = "Electronics" };
        var groceries = new Category { Name = "Groceries" };

        await context.Categories.AddRangeAsync(electronics, groceries);

        // Create products
        var product1 = new Product { Name = "Laptop", Price = 75000, Category = electronics };
        var product2 = new Product { Name = "Rice Bag", Price = 1200, Category = groceries };

        await context.Products.AddRangeAsync(product1, product2);

        // Save to database
        await context.SaveChangesAsync();

        Console.WriteLine("Initial data inserted successfully.");
    }
}
