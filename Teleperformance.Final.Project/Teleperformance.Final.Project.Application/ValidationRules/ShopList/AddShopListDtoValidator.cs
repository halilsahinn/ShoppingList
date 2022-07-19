using FluentValidation;
using Teleperformance.Final.Project.Application.DTOs.ShopList;

namespace Teleperformance.Final.Project.Application.ValidationRules.ShopList
{
    public class AddShopListDtoValidator : AbstractValidator<AddShopListDto>
    {
        public AddShopListDtoValidator()
        {
            RuleFor(x=>x.CategoryId).NotNull().WithMessage("Kategori Id Boş Geçilemez");
            RuleFor(x => x.UserId).NotEmpty().WithMessage("User Id Boş Geçilemez");
        }

    }
}
