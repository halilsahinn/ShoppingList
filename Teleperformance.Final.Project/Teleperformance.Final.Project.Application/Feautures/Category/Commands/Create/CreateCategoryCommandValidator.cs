using FluentValidation;
using Teleperformance.Final.Project.Application.DTOs.Category;

namespace Teleperformance.Final.Project.Application.Feautures.Category.Commands.Create
{
    public class CreateCategoryCommandValidator : AbstractValidator<CategoryDto>
    {
        public CreateCategoryCommandValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty();
        }

    }
}
