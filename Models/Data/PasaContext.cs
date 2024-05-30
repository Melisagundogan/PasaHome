using Microsoft.AspNetCore.Antiforgery;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
namespace PasaHome.Models.Data;

public class PasaContext : DbContext
{

    public DbSet<Category> Categories { get; set; } = null!;
    public DbSet<Product> Products { get; set; } = null!;

    public ILoggerFactory MyLoggerFactory { get; private set; }
    = LoggerFactory.Create(builder => { builder.AddConsole(); });
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=MELISA\\SQLEXPRESS;Database=ShopApp;Trusted_Connection=True;Integrated Security=true;TrustServerCertificate=True;");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Product>(entity =>
        {
            entity.Property(e => e.Price)
            .HasColumnType("decimal(18,2)");

            entity.HasOne(p => p.Category)
             .WithMany(c => c.Products)
             .HasForeignKey(p => p.CategoryId);
        });
    }
}
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public string img { get; set; }=null!;
        public decimal Price { get; set; }
        public string CategoryName {  get; set; } = null!;
        public string color {  get; set; } =null!;
        public int CategoryId { get; set; }

    
        [ForeignKey("CategoryId")]
        public Category Category { get; set; } = null!;

    }

    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; } = null!;

        public ICollection<Product> Products { get; set; } = new List<Product>();
    }



