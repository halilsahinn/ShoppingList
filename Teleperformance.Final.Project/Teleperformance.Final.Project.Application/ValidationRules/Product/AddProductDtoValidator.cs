using FluentValidation;
using Teleperformance.Final.Project.Application.DTOs.Product;
using Teleperformance.Final.Project.Application.Messages.TR.Validation;

namespace Teleperformance.Final.Project.Application.ValidationRules.Product
{
    public class AddProductDtoValidator : AbstractValidator<AddProductDto>
    {

        public AddProductDtoValidator()
        {
            RuleFor(x => x.ProductName)
                .NotEmpty().WithMessage(ProductValidationMessage.ProductNameNotNull)
                .Length(3, 100).WithMessage(String.Format(ProductValidationMessage.ProductNameLengthMustBe, 3, 100));

            RuleFor(x => x.Unit).NotEmpty().WithMessage(ProductValidationMessage.ProductUnitNotNull);
        }
    }
}
