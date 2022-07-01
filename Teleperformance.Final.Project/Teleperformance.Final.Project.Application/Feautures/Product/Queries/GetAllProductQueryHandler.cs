using AutoMapper;
using MediatR;
using Teleperformance.Final.Project.Application.Contracts.Repositories;
using Teleperformance.Final.Project.Application.DTOs.Product;

namespace Teleperformance.Final.Project.Application.Feautures.Product.Queries
{
    public class GetAllProductQuery : IRequest<List<ProductDto>>
    {



    }

    public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQuery, List<ProductDto>>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public GetAllProductQueryHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<List<ProductDto>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
        {
            var productList = _productRepository.GetAll();
            return _mapper.Map<List<ProductDto>>(productList);

        }
    }


}
