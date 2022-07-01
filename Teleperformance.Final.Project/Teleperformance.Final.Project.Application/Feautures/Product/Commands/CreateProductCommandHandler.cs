using MediatR;
using Teleperformance.Final.Project.Application.DTOs.Product;
using Teleperformance.Final.Project.Application.Responses;

namespace Teleperformance.Final.Project.Application.Feautures.Product.Commands
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, WebAPIResponse<AddProductDto>>
    {
        public Task<WebAPIResponse<AddProductDto>> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
