using AutoMapper;
using MediatR;
using Teleperformance.Final.Project.Application.Contracts.Repositories;
using Teleperformance.Final.Project.Application.DTOs.Product;

namespace Teleperformance.Final.Project.Application.Feautures.Product.Queries
{

    public class GetByIdProductQuery : IRequest<ProductDto>
    {
        public int Id { get; set; }


    }

    public class GetByIdProductQueryHandler : IRequestHandler<GetByIdProductQuery, ProductDto>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public GetByIdProductQueryHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<ProductDto> Handle(GetByIdProductQuery request, CancellationToken cancellationToken)
        {
            var product = await _productRepository.GetById(request.Id);

            return _mapper.Map<ProductDto>(product);
        }
    }
}
