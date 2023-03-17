using EntityFramework;
using ProductManager.CORE.Domain.Entities;

namespace ProductManager.CORE.Domain.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
    }
}
