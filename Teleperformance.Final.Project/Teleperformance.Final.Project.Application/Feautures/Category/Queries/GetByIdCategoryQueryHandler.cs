using AutoMapper;
using MediatR;
using Teleperformance.Final.Project.Application.Contracts.Repositories;
using Teleperformance.Final.Project.Application.Contracts.UnitOfWork;
using Teleperformance.Final.Project.Application.DTOs.Category;
using Teleperformance.Final.Project.Application.Feautures.Base;

namespace Teleperformance.Final.Project.Application.Feautures.Category.Queries
{
    #region QUERY
    public class GetByIdCategoryQuery : IRequest<CategoryDto>
    {
        public int Id   { get; set; }

    }
    #endregion

    #region HANDLER
    public class GetByIdCategoryQueryHandler : BaseHandler, IRequestHandler<GetByIdCategoryQuery, CategoryDto>
    {
        #region FILEDS
        private readonly ICategoryRepository _categoryRepository;
        #endregion

        #region CTOR
        public GetByIdCategoryQueryHandler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }
        #endregion

        #region METHODS
        public async Task<CategoryDto> Handle(GetByIdCategoryQuery request, CancellationToken cancellationToken)
        {
            var categoryRequest = _mapper.Map<CategoryDto>(await _categoryRepository.GetById(request.Id));
           return categoryRequest;  
        }

        #endregion

    }
    #endregion

}
