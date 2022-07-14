using FluentValidation;
using Teleperformance.Final.Project.Application.DTOs.Category;
using Teleperformance.Final.Project.Application.Messages.TR.Validation;

namespace Teleperformance.Final.Project.Application.ValidationRules.Category
{
    public class AddCategoryDtoValidator : AbstractValidator<AddCategoryDto>
    {

        public AddCategoryDtoValidator()
        {
            RuleFor(x => x.CategoryName)
              .NotEmpty().WithMessage(CategoryValidationMessage.CategoryNameNotNull)
              .Length(3, 100).WithMessage(String.Format(CategoryValidationMessage.ProductNameLengthMustBe, 3, 100));


        }

    }
}
