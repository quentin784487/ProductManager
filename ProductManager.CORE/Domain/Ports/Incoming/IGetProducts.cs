using Shared.Models;

namespace ProductManager.CORE.Domain.Ports.Incoming
{
    public interface IGetProducts
    {
        Task<IEnumerable<ProductViewModel>> GetProducts();
    }
}
