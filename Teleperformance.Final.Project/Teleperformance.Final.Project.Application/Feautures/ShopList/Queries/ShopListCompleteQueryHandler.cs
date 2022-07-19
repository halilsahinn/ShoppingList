using AutoMapper;
using MediatR;
using Teleperformance.Final.Project.Application.Contracts.Cache;
using Teleperformance.Final.Project.Application.Contracts.Repositories;
using Teleperformance.Final.Project.Application.Contracts.UnitOfWork;
using Teleperformance.Final.Project.Application.DTOs.ShopList;
using Teleperformance.Final.Project.Application.Feautures.Base;
using Teleperformance.Final.Project.Domain.ShopList;

namespace Teleperformance.Final.Project.Application.Feautures.ShopList.Queries
{ 

    #region QUERY
    public class ShopListCompleteQuery : IRequest<List<ShopListDto>>
    {

    }
    #endregion

    #region HANDLER
    public class ShopListCompleteQueryHandler : BaseHandler, IRequestHandler<ShopListCompleteQuery, List<ShopListDto>>
    {
        private IShopListRepository _shopListRepository;

        public ShopListCompleteQueryHandler(IShopListRepository shopListRepository, IUnitOfWork _unitOfWork, IMapper mapper, IMemoryCacheService memoryCacheService) : base(_unitOfWork, mapper, memoryCacheService)
        {
            _shopListRepository = shopListRepository;
        }

        public async Task<List<ShopListDto>> Handle(ShopListCompleteQuery request, CancellationToken cancellationToken)
        {
            var shopList = new List<ShopListEntity>();
            var shopListDtoList = new List<ShopListDto>();
            shopList = await _shopListRepository.CompletedList();

            shopListDtoList = _mapper.Map<List<ShopListDto>>(shopList);

            return shopListDtoList;

        }
    }
    #endregion
     
}
