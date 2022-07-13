using AutoMapper;
using MediatR;
using Teleperformance.Final.Project.Application.Contracts.Cache;
using Teleperformance.Final.Project.Application.Contracts.Repositories;
using Teleperformance.Final.Project.Application.Contracts.UnitOfWork;
using Teleperformance.Final.Project.Application.DTOs.Product;
using Teleperformance.Final.Project.Application.Feautures.Base;
using Teleperformance.Final.Project.Domain.Product;

namespace Teleperformance.Final.Project.Application.Feautures.Product.Queries
{
    #region QUERY
    public class GetAllProductQuery : IRequest<List<ProductDto>>
    {



    }
    #endregion

    #region HANDLER
    public class GetAllProductQueryHandler : BaseHandler,IRequestHandler<GetAllProductQuery, List<ProductDto>>
    {
        private IProductRepository _productRepository;

        public GetAllProductQueryHandler(IProductRepository productRepository, IUnitOfWork _unitOfWork, IMapper mapper,IMemoryCacheService memoryCacheService):base(_unitOfWork,mapper,memoryCacheService)
        {
              _productRepository= productRepository;
        }

        public async Task<List<ProductDto>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
        {
            var productList = new List<ProductEntity>();
            var productDtoList = new List<ProductDto>();
            productList = await  _productRepository.GetAll();

            productDtoList = _mapper.Map<List<ProductDto>>(productList);
             
            return productDtoList;

        }
    }
    #endregion



}
