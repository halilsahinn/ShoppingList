using AutoMapper;
using Teleperformance.Final.Project.Application.DTOs.Category;
using Teleperformance.Final.Project.Domain.Category;

namespace Teleperformance.Final.Project.Application.Profiles
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {

            CreateMap<CategoryEntity, CategoryDto>().ReverseMap();

        }

    }
}
