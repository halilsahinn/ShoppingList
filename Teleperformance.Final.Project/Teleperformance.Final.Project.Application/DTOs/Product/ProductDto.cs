using Teleperformance.Final.Project.Application.DTOs.Base;

namespace Teleperformance.Final.Project.Application.DTOs.Product
{
    public class ProductDto : BaseDto
    { 
        public string ProductName { get; set; }

        public byte Unit { get; set; }

        public int CategoryId { get; set; }


    }
}
