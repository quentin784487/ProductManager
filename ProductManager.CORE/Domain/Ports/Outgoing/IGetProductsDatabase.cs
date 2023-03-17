using Shared.Models;

namespace ProductManager.CORE.Domain.Ports.Outgoing
{
    public interface IGetProductsDatabase
    {
        Task<IEnumerable<ProductViewModel>> GetProducts();
    }
}
