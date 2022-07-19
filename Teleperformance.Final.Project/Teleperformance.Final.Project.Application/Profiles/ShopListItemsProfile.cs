using AutoMapper;
using Teleperformance.Final.Project.Application.DTOs.ShopListItems;
using Teleperformance.Final.Project.Domain.ShopListItems;

namespace Teleperformance.Final.Project.Application.Profiles
{
    public class ShopListItemsProfile : Profile
    {

        public ShopListItemsProfile()
        {

            CreateMap<ShopListItemsEntity, AddShopListItemsDto>().ReverseMap();
        }

    }
}
