using Teleperformance.Final.Project.Domain.Base;
using Teleperformance.Final.Project.Domain.Product;
using Teleperformance.Final.Project.Domain.ShopList;

namespace Teleperformance.Final.Project.Domain.Category
{
    public class CategoryEntity : BaseEntity
    {
        #region PROPERTIES
        public string CategoryName { get; set; }
        #endregion

        #region NAVIGATION PROPERTIES

        public IList<ProductEntity> Products { get; set; }
        public IList<ShopListEntity> ShopList { get; set; }

        #endregion

    }
}
