using AutoMapper;
using MediatR;
using Teleperformance.Final.Project.Application.Contracts.RabbitMq;
using Teleperformance.Final.Project.Application.Contracts.UnitOfWork;
using Teleperformance.Final.Project.Application.DTOs.ShopList;
using Teleperformance.Final.Project.Application.Exceptions;
using Teleperformance.Final.Project.Application.Feautures.Base;

namespace Teleperformance.Final.Project.Application.Feautures.ShopList.Command.Complete
{

    #region COMMAND
    public class CompleteShopListCommand : IRequest<Unit>
    {
        public CompleteShopListDto completeShopListDto { get; set; }


    }
    #endregion

    #region HANDLER
    public class CompleteShopListCommandHandler : BaseHandler, IRequestHandler<CompleteShopListCommand, Unit>
    {
        #region CTOR
          
        public CompleteShopListCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, IRabbitMqService rabbitmqService) : base(unitOfWork, mapper, rabbitmqService)
        {
        }
        #endregion

        #region METHODS
        public async Task<Unit> Handle(CompleteShopListCommand request, CancellationToken cancellationToken)
        {
            var shopListRequest = await _unitOfWork.ShopListRepository.CompleteShopList(request.completeShopListDto.Id);
            if (shopListRequest == null)
                throw new NotFoundException(nameof(shopListRequest), request.completeShopListDto.Id);

            await _unitOfWork.Save();

            _rabbitmqService.Publish(
                new{
                    request.completeShopListDto.Id

                },

                "amq.direct", "direct.test", "direct.queuName", "direct.test.key");


            return Unit.Value;
        }

        #endregion
    }
    #endregion
}
