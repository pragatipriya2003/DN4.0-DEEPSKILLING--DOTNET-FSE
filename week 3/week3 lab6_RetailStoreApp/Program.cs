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

        // 1. Update the price of "Laptop" to ₹70000
        var product = await context.Products.FirstOrDefaultAsync(p => p.Name == "Laptop");
        if (product != null)
        {
            Console.WriteLine($"Updating '{product.Name}' from ₹{product.Price} to ₹70000...");
            product.Price = 70000;
            await context.SaveChangesAsync();
            Console.WriteLine("Update successful.");
        }

        // 2. Delete the product named "Rice Bag"
        var toDelete = await context.Products.FirstOrDefaultAsync(p => p.Name == "Rice Bag");
        if (toDelete != null)
        {
            Console.WriteLine($"Deleting product: {toDelete.Name}");
            context.Products.Remove(toDelete);
            await context.SaveChangesAsync();
            Console.WriteLine("Delete successful.");
        }

        // 3. Show remaining products
        var products = await context.Products.ToListAsync();
        Console.WriteLine("\nRemaining Products:");
        foreach (var p in products)
            Console.WriteLine($"{p.Name} - ₹{p.Price}");
    }
}
