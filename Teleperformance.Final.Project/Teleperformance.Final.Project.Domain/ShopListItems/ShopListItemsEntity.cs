using Teleperformance.Final.Project.Domain.Base;

namespace Teleperformance.Final.Project.Domain.ShopListItems
{
    public class ShopListItemsEntity : BaseEntity
    {

        public int ProductId { get; set; }

        public int ShopListId { get; set; }

        public bool IsTaken { get; set; }

    }
}
