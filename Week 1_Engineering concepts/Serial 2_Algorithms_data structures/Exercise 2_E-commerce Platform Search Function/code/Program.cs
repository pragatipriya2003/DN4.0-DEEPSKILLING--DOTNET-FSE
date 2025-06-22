using System;
using System.Collections.Generic;
using System.Linq;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }

    public void Display()
    {
        Console.WriteLine($"ID: {Id}, Name: {Name}, Price: ₹{Price:F2}");
    }
}

public class ECommercePlatform
{
    private List<Product> products;

    public ECommercePlatform()
    {
        // Sample product list
        products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Price = 55000 },
            new Product { Id = 2, Name = "Smartphone", Price = 20000 },
            new Product { Id = 3, Name = "Headphones", Price = 2500 },
            new Product { Id = 4, Name = "Smart Watch", Price = 7000 },
            new Product { Id = 5, Name = "Laptop Stand", Price = 1200 },
        };
    }

    // Search function using keyword
    public void Search(string keyword)
    {
        var results = products
            .Where(p => p.Name.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0)
            .ToList();

        if (results.Count == 0)
        {
            Console.WriteLine("No products found for keyword: " + keyword);
        }
        else
        {
            Console.WriteLine($"\nSearch results for \"{keyword}\":");
            foreach (var product in results)
            {
                product.Display();
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        ECommercePlatform store = new ECommercePlatform();

        Console.Write("Enter product keyword to search: ");
        string keyword = Console.ReadLine();

        store.Search(keyword);
    }
}