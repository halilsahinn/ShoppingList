using AutoMapper;
using Teleperformance.Final.Project.Application.DTOs.Product;
using Teleperformance.Final.Project.Domain.Product;

namespace Teleperformance.Final.Project.Application.Profiles
{
    public class ProductProfile : Profile
    {

        public ProductProfile()
        {
            CreateMap<ProductEntity, ProductDto>().ReverseMap();
        }

    }
}
