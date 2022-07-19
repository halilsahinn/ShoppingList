using AutoMapper;
using Teleperformance.Final.Project.Application.DTOs.ShopList;
using Teleperformance.Final.Project.Domain.ShopList;

namespace Teleperformance.Final.Project.Application.Profiles
{
    public class ShopListProfile : Profile
    {

        public ShopListProfile()
        {
            CreateMap<ShopListEntity, ShopListDto>().ReverseMap();
            CreateMap<ShopListEntity, AddShopListDto>().ReverseMap();

        }


    }
}
