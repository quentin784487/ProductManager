using EntityFramework;
using ProductManager.CORE.Domain.Entities;
using ProductManager.CORE.Domain.Repositories;

namespace ProductManager.CORE.Persistence.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(ProductsManagerDbContext context)
            : base(context)
        {
        }

        public ProductsManagerDbContext? ProductsManagerDbContext
        {
            get { return Context as ProductsManagerDbContext; }
        }

        public override void Add(Product entity)
        {
            // We can override repository virtual methods in order to customize repository behavior, Template Method Pattern Code here
            base.Add(entity);
        }
    }
}
