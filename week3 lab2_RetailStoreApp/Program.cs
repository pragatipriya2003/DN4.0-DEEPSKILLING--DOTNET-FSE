using System;
using System.Linq;
using RetailStoreApp.Models;
using RetailStoreApp.Data;
using Microsoft.EntityFrameworkCore;

class Program
{
    static void Main()
    {
        using (var context = new AppDbContext())
        {
            // Add a category
            var category = new Category { Name = "Clothing" };
            context.Categories.Add(category);
            context.SaveChanges();

            // Add a product
            var product = new Product
            {
                Name = "T-Shirt",
                Price = 19.99m,
                CategoryId = category.Id
            };
            context.Products.Add(product);
            context.SaveChanges();

            // Display
            var products = context.Products.Include(p => p.Category).ToList();
            foreach (var p in products)
            {
                Console.WriteLine($"{p.Name} - {p.Category.Name} - ₹{p.Price}");
            }
        }
    }
}
