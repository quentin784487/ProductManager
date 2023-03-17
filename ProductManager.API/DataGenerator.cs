using Microsoft.EntityFrameworkCore;
using ProductManager.CORE.Domain.Entities;
using ProductManager.CORE.Persistence;

namespace Web.API
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ProductsManagerDbContext(serviceProvider.GetRequiredService<DbContextOptions<ProductsManagerDbContext>>()))
            {
                if (context.Products.Any())
                {
                    return;   // Data was already seeded
                }

                context.Products.AddRange(
                    new Product
                    { 
                        Id = 1,
                        ProductName = "Test Product #1",
                        ProductCode = Guid.NewGuid()
                    },
                    new Product
                    {
                        Id = 2,
                        ProductName = "Test Product #2",
                        ProductCode = Guid.NewGuid()
                    },
                    new Product
                    {
                        Id = 3,
                        ProductName = "Test Product #3",
                        ProductCode = Guid.NewGuid()
                    },
                    new Product
                    {
                        Id = 4,
                        ProductName = "Test Product #4",
                        ProductCode = Guid.NewGuid()
                    },
                    new Product
                    {
                        Id = 5,
                        ProductName = "Test Product #5",
                        ProductCode = Guid.NewGuid()
                    },
                    new Product
                    {
                        Id = 6,
                        ProductName = "Test Product #6",
                        ProductCode = Guid.NewGuid()
                    },
                    new Product
                    {
                        Id = 7,
                        ProductName = "Test Product #7",
                        ProductCode = Guid.NewGuid()
                    },
                    new Product
                    {
                        Id = 8,
                        ProductName = "Test Product #8",
                        ProductCode = Guid.NewGuid()
                    },
                    new Product
                    {
                        Id = 9,
                        ProductName = "Test Product #9",
                        ProductCode = Guid.NewGuid()
                    },
                    new Product
                    {
                        Id = 10,
                        ProductName = "Test Product #10",
                        ProductCode = Guid.NewGuid()
                    });

                context.SaveChanges();
            }
        }
    }
}
