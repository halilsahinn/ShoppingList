using AutoMapper;
using MediatR;
using Teleperformance.Final.Project.Application.Contracts.Repositories;
using Teleperformance.Final.Project.Application.DTOs.Product;

namespace Teleperformance.Final.Project.Application.Feautures.Product.Queries
{

    public class GetByIdQuery : IRequest<ProductDto>
    {
        public int Id { get; set; }


    }

    public class GetByIdQueryHandler : IRequestHandler<GetByIdQuery, ProductDto>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public GetByIdQueryHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<ProductDto> Handle(GetByIdQuery request, CancellationToken cancellationToken)
        {
            var product = await _productRepository.Get(request.Id);

            return _mapper.Map<ProductDto>(product);
        }
    }
}
