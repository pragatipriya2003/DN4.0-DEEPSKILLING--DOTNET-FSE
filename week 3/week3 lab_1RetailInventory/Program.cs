using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

class Program
{
    static void Main(string[] args)
    {
        using (var context = new InventoryContext())
        {
            // Add a category
            var category = new Category { Name = "Electronics" };
            context.Categories.Add(category);
            context.SaveChanges();

            // Add a product
            var product = new Product { Name = "Laptop", Stock = 10, CategoryId = category.Id };
            context.Products.Add(product);
            context.SaveChanges();

            // Display products
            var products = context.Products.Include(p => p.Category).ToList();
            foreach (var p in products)
            {
                Console.WriteLine($"{p.Name} - {p.Category.Name} - Stock: {p.Stock}");
            }
        }
    }
}
