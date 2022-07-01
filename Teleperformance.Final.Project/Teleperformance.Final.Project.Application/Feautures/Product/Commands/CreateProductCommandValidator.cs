using FluentValidation;
using Teleperformance.Final.Project.Application.DTOs.Product;

namespace Teleperformance.Final.Project.Application.Feautures.Product.Commands
{
    public class CreateProductCommandValidator : AbstractValidator<ProductDto>
    {
        public CreateProductCommandValidator()
        {
            RuleFor(x=>x.ProductName).NotEmpty();
        }


    }
}
