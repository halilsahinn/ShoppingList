using AutoMapper;
using MediatR;
using Teleperformance.Final.Project.Application.Contracts.UnitOfWork;
using Teleperformance.Final.Project.Application.DTOs.ShopListItems;
using Teleperformance.Final.Project.Application.Feautures.Base;
using Teleperformance.Final.Project.Application.Messages.TR.Info;
using Teleperformance.Final.Project.Application.Responses;
using Teleperformance.Final.Project.Application.ValidationRules.ShopListItems;
using Teleperformance.Final.Project.Domain.ShopListItems;

namespace Teleperformance.Final.Project.Application.Feautures.ShopListItems.Command.Create
{
    #region COMMAND
    public class CreateShopListItemsCommand : IRequest<BaseCommandResponse>
    {
        public AddShopListItemsDto AddShopListItems { get; set; }


    }
    #endregion

    #region HANDLER
    public class CreateShopListItemsCommandHandler : BaseHandler, IRequestHandler<CreateShopListItemsCommand, BaseCommandResponse>
    {
        #region CTOR
        public CreateShopListItemsCommandHandler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {

        }
        #endregion

        #region METHODS
        public async Task<BaseCommandResponse> Handle(CreateShopListItemsCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseCommandResponse();
            var validator = new AddShopListItemsDtoValidator();
            var validationResult = await validator.ValidateAsync(request.AddShopListItems);

            if (validationResult.IsValid == false)
            {
                response.Success = false;
                response.Message = ShopListItemsInfoMessage.AddedFail;
                response.Errors = validationResult.Errors.Select(q => q.ErrorMessage).ToList();
            }
            else
            {
                var result = _mapper.Map<ShopListItemsEntity>(request.AddShopListItems);

                result = await _unitOfWork.ShopListItemsRepository.Add(result);
                await _unitOfWork.Save();

                response.Success = true;
                response.Message = ShopListItemsInfoMessage.AddedSuccess;
                response.Id = result.Id;
            }
            return response;
        }

        #endregion
    }
    #endregion
}
