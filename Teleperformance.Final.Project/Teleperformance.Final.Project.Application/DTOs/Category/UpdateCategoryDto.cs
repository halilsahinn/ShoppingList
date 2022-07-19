using Teleperformance.Final.Project.Application.DTOs.Base;

namespace Teleperformance.Final.Project.Application.DTOs.Category
{
    public class UpdateCategoryDto : BaseDto
    {
        public string CategoryName { get; set; }

        public DateTime UpdatedDate { get; set; } = DateTime.Now;

    }
}
