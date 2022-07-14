namespace Teleperformance.Final.Project.Application.DTOs.ShopList
{
    public class AddShopListDto
    {

        public int CategoryId { get; set; }
        public int UserId { get; set; }
 
        public string Title { get; set; }

        public string? Description { get; set; }

        public DateTime CreateDate { get; set; } = DateTime.Now;
    }
}
