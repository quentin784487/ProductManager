using Microsoft.EntityFrameworkCore;
using ProductManager.CORE.Domain.Entities;
using System.Reflection;

namespace ProductManager.CORE.Persistence
{
    public class ProductsManagerDbContext : DbContext
    {
        public virtual DbSet<Product> Products { get; set; }

        public ProductsManagerDbContext(DbContextOptions<ProductsManagerDbContext> dbContextOptions)
            : base(dbContextOptions)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}
