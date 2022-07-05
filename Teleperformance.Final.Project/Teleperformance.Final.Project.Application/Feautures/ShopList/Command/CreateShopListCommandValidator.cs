using FluentValidation;
using Teleperformance.Final.Project.Application.DTOs.ShopList;

namespace Teleperformance.Final.Project.Application.Feautures.ShopList.Command
{
    public class CreateShopListCommandValidator : AbstractValidator<ShopListDto>
    {
        public CreateShopListCommandValidator()
        {
            RuleFor(x=>x.CategoryName).NotEmpty();
            RuleFor(x=>x.ProductName).NotEmpty ();
           
        }

    }
}
