using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RetailStoreApp.Data;
using RetailStoreApp.Models;

class Program
{
    static async Task Main()
    {
        using var context = new AppDbContext();

        // 1. Retrieve all products
        var products = await context.Products.ToListAsync();
        Console.WriteLine("All Products:");
        foreach (var p in products)
            Console.WriteLine($"{p.Name} - ₹{p.Price}");

        // 2. Find by ID
        var product = await context.Products.FindAsync(1);
        Console.WriteLine($"\nProduct with ID 1: {product?.Name}");

        // 3. First product with price > ₹50000
        var expensive = await context.Products.FirstOrDefaultAsync(p => p.Price > 50000);
        Console.WriteLine($"\nFirst expensive product: {expensive?.Name}");
    }
}
