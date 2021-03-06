using Teleperformance.Final.Project.Domain.Base;
using Teleperformance.Final.Project.Domain.Category;
using Teleperformance.Final.Project.Domain.Product;

namespace Teleperformance.Final.Project.Domain.ShopList
{
    public class ShopListEntity : BaseEntity
    {
        #region PROPERTIES

        public string Title { get; set; }

        public int CategoryId { get; set; }

        public string UserId { get; set; }

        public bool IsCompleted { get; set; }

        public DateTime? CompletedDate { get; set; }

        #endregion

        #region NAVIGATION PROPERTIES
        public CategoryEntity Category { get; set; }
         
        public IList<ProductEntity> Products { get; set; }

        #endregion
    }
}
