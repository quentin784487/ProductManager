using ProductManager.CORE.Domain.Ports.Incoming;
using ProductManager.CORE.Domain.Ports.Outgoing;
using Shared.Models;

namespace ProductManager.CORE.Domain.Ports
{
    public class GetProductsAdapter : IGetProducts
    {
        private IGetProductsDatabase database;

        public GetProductsAdapter(IGetProductsDatabase database)
        {
            this.database = database;
        }

        public async Task<IEnumerable<ProductViewModel>> GetProducts()
        {
            return await database.GetProducts();
        }
    }
}
