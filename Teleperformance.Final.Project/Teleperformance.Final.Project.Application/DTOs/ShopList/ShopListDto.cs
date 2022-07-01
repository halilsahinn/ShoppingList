using Teleperformance.Final.Project.Application.DTOs.Product;

namespace Teleperformance.Final.Project.Application.DTOs.ShopList
{
    public class ShopListDto
    {

        public IList<ProductDto> Products { get; set; }

        public bool IsTaken { get; set; }


    }
}
