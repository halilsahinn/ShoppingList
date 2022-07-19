using FluentValidation;
using Teleperformance.Final.Project.Application.DTOs.ShopList;

namespace Teleperformance.Final.Project.Application.ValidationRules.ShopList
{
    public class CompleteShopListDtoValidator:AbstractValidator<CompleteShopListDto>
    {
        public CompleteShopListDtoValidator()
        {
            RuleFor(x => x.Id).NotNull().WithMessage("Shoplist Id Boş Geçilemez");
        }
    }
}
