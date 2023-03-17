using AutoMapper;
using ProductManager.CORE.Domain.Entities;
using Shared.Models;

namespace Web.API.DtoMappingConfigs
{
    public class ProductMappingProfile : Profile
    {
        public ProductMappingProfile()
        {
            CreateMap<Product, ProductViewModel>();
        }
    }
}
