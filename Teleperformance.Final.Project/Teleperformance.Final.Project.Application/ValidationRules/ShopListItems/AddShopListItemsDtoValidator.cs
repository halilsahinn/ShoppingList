using FluentValidation;
using Teleperformance.Final.Project.Application.DTOs.ShopListItems;
using Teleperformance.Final.Project.Application.Messages.TR.Validation;

namespace Teleperformance.Final.Project.Application.ValidationRules.ShopListItems
{
    public class AddShopListItemsDtoValidator : AbstractValidator<AddShopListItemsDto>
    {
        public AddShopListItemsDtoValidator()
        {
            RuleFor(x => x.ProductId).NotNull().WithMessage(ShopListItemsValidationMessage.ProductIdNotNull);
            RuleFor(x => x.ShopListId).NotNull().WithMessage(ShopListItemsValidationMessage.ShopListIdNotNull);

        }

    }
}
