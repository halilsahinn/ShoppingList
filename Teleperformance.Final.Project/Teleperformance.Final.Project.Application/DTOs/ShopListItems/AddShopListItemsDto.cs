using Teleperformance.Final.Project.Application.DTOs.Base;

namespace Teleperformance.Final.Project.Application.DTOs.ShopListItems
{
    public class AddShopListItemsDto
    {
        public int ProductId { get; set; }

        public int ShopListId { get; set; }

        public bool IsTaken { get; set; }

    }
}
