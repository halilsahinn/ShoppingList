using AutoMapper;
using MediatR;
using Teleperformance.Final.Project.Application.Contracts.UnitOfWork;
using Teleperformance.Final.Project.Application.DTOs.Category;
using Teleperformance.Final.Project.Application.Exceptions;
using Teleperformance.Final.Project.Application.Feautures.Base;

namespace Teleperformance.Final.Project.Application.Feautures.Category.Commands.Update
{ 
    #region COMMAND
    public class UpdateCategoryCommand : IRequest<Unit>
    {
        public UpdateCategoryDto UpdateCategory { get; set; }
    }

    #endregion

    #region HANDLER
    public class UpdateCategoryCommandHandler : BaseHandler, IRequestHandler<UpdateCategoryCommand>
    {
        #region CTOR
        public UpdateCategoryCommandHandler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }
        #endregion

        #region METHODS
        public async Task<Unit> Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
        {
            var categoryRequest = await _unitOfWork.CategoryRepository.GetById(request.UpdateCategory.Id);
            if (categoryRequest == null)
                throw new NotFoundException(nameof(categoryRequest), request.UpdateCategory.Id);

            await _unitOfWork.CategoryRepository.Update(categoryRequest);
            await _unitOfWork.Save();
            return Unit.Value;
        }

        #endregion

    }

    #endregion
}
