using AutoMapper;
using MediatR;
using Teleperformance.Final.Project.Application.Contracts.UnitOfWork;
using Teleperformance.Final.Project.Application.Exceptions;
using Teleperformance.Final.Project.Application.Feautures.Base;

namespace Teleperformance.Final.Project.Application.Feautures.Category.Commands.Delete
{
    #region COMMAND
    public class DeleteCategoryCommand : IRequest
    {
        public int Id { get; set; }
    }

    #endregion

    #region HANDLER
    public class DeleteCategoryCommandHandler : BaseHandler, IRequestHandler<DeleteCategoryCommand>
    {
        #region CTOR
        public DeleteCategoryCommandHandler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }
        #endregion

        #region METHODS
        public async Task<Unit> Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
        {
            var categoryRequest = await _unitOfWork.CategoryRepository.GetById(request.Id);
            if (categoryRequest == null)
                throw new NotFoundException(nameof(categoryRequest), request.Id);

            await _unitOfWork.CategoryRepository.Delete(categoryRequest);
            await _unitOfWork.Save();
            return Unit.Value;
        }

        #endregion

    }

    #endregion
}
