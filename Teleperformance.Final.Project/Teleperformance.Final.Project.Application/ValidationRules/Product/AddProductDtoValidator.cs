using FluentValidation;
using Teleperformance.Final.Project.Application.DTOs.Product;
using Teleperformance.Final.Project.Application.Messages.Validation;

namespace Teleperformance.Final.Project.Application.ValidationRules.Product
{
    public class AddProductDtoValidator : AbstractValidator<AddProductDto>
    {

        public AddProductDtoValidator()
        {
            RuleFor(x => x.ProductName)
                .NotEmpty().WithMessage(ProductResource.ProductNameNotNull)
                .Length(3,100).WithMessage(String.Format(ProductResource.ProductNameLengthMustBe, 3,100));
           
            RuleFor(x => x.Unit).NotEmpty().WithMessage(ProductResource.ProductUnitNotNull);
        }
    }
}
