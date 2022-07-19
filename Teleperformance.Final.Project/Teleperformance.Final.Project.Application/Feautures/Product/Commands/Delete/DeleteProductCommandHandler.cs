using AutoMapper;
using MediatR;
using Teleperformance.Final.Project.Application.Contracts.UnitOfWork;
using Teleperformance.Final.Project.Application.Exceptions;
using Teleperformance.Final.Project.Application.Feautures.Base;

namespace Teleperformance.Final.Project.Application.Feautures.Product.Commands.Delete
{
    #region COMMAND
    public class DeleteProductCommand : IRequest
    {
        public int Id { get; set; }
    }
    #endregion

    #region HANDLER
    public class DeleteProductCommandHandler : BaseHandler, IRequestHandler<DeleteProductCommand>
    {
        #region CTOR
        public DeleteProductCommandHandler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }
        #endregion

        #region METHODS
        public async Task<Unit> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            var productRequest = await _unitOfWork.ProductRepository.GetById(request.Id);
            if (productRequest == null)
                throw new NotFoundException(nameof(productRequest), request.Id);

            await _unitOfWork.ProductRepository.Delete(productRequest);
            await _unitOfWork.Save();
            return Unit.Value;

        }
        #endregion

    }
    #endregion

}
