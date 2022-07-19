namespace Teleperformance.Final.Project.Application.DTOs.ShopList
{
    public class AddShopListDto
    {
        public string Title { get; set; }
        public int CategoryId { get; set; }
        public string UserId { get; set; }

        public bool IsCompleted { get; set; } = false;

        public bool IsActive { get; set; } = true;

        public string? Description { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
