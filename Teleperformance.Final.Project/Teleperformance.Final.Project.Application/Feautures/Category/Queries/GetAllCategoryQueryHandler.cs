using AutoMapper;
using MediatR;
using Teleperformance.Final.Project.Application.Contracts.Repositories;
using Teleperformance.Final.Project.Application.Contracts.UnitOfWork;
using Teleperformance.Final.Project.Application.DTOs.Category;
using Teleperformance.Final.Project.Application.Feautures.Base;
using Teleperformance.Final.Project.Domain.Category;

namespace Teleperformance.Final.Project.Application.Feautures.Category.Queries
{

    #region QUERY
    public class GetAllCategoryQuery : IRequest<List<CategoryDto>>
    {


    }
    #endregion

    #region HANDLER
    public class GetAllCategoryQueryHandler : BaseHandler, IRequestHandler<GetAllCategoryQuery, List<CategoryDto>>
    {
        #region FILEDS
        private readonly ICategoryRepository _categoryRepository;
        #endregion

        #region CTOR
        public GetAllCategoryQueryHandler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }
        #endregion

        #region METHODS
        public async Task<List<CategoryDto>> Handle(GetAllCategoryQuery request, CancellationToken cancellationToken)
        {
            var categoryList = new List<CategoryEntity>();
            var categoryDtoList = new List<CategoryDto>();
            categoryList = await _categoryRepository.GetAll();

            categoryDtoList = _mapper.Map<List<CategoryDto>>(categoryList);

            return categoryDtoList;
        }

        #endregion

    }
    #endregion
}
