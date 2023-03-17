using AutoMapper;
using ProductManager.CORE.Domain;
using ProductManager.CORE.Domain.Entities;
using ProductManager.CORE.Domain.Ports.Outgoing;
using Shared.Models;

namespace ProductManager.Infrastructure
{
    public class GetProductsDatabaseAdapter : IGetProductsDatabase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetProductsDatabaseAdapter(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProductViewModel>> GetProducts()
        {
            IEnumerable<Product> products = await _unitOfWork.ProductRepository.GetAllAsync().ConfigureAwait(false);

            var mappedProducts = _mapper.Map<IEnumerable<ProductViewModel>>(products);

            return mappedProducts;
        }
    }
}
