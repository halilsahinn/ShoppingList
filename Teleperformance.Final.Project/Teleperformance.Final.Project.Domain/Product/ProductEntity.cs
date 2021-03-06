using Teleperformance.Final.Project.Domain.Base;
using Teleperformance.Final.Project.Domain.Category;

namespace Teleperformance.Final.Project.Domain.Product
{
    public class ProductEntity : BaseEntity
    {

        #region PROPERTIES
        public string ProductName { get; set; }

        public byte Unit { get; set; }

        public int CategoryId { get; set; }

        #endregion

        #region NAVIGATION PROPERTIES
        public CategoryEntity Category { get; set; }


        #endregion


    }
}
