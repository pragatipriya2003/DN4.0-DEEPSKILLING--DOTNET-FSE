using Microsoft.EntityFrameworkCore;

public class InventoryContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=RetailInventoryDb;Trusted_Connection=True;TrustServerCertificate=True;");

}
    