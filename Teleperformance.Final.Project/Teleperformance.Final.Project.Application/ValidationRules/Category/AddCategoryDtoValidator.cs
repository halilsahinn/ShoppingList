using FluentValidation;
using Teleperformance.Final.Project.Application.DTOs.Category;
using Teleperformance.Final.Project.Application.Messages.Validation;

namespace Teleperformance.Final.Project.Application.ValidationRules.Category
{
    public class AddCategoryDtoValidator : AbstractValidator<AddCategoryDto>
    {

        public AddCategoryDtoValidator()
        {
            RuleFor(x => x.CategoryName)
              .NotEmpty().WithMessage(CategoryResource.CategoryNameNotNull)
              .Length(3, 100).WithMessage(String.Format(CategoryResource.ProductNameLengthMustBe, 3, 100));

          
        }

    }
}
