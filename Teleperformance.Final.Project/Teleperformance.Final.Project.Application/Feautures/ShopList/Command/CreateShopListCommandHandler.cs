using AutoMapper;
using MediatR;
using Teleperformance.Final.Project.Application.Contracts.UnitOfWork;
using Teleperformance.Final.Project.Application.DTOs.ShopList;
using Teleperformance.Final.Project.Application.Feautures.Base;
using Teleperformance.Final.Project.Application.Responses;
using Teleperformance.Final.Project.Application.ValidationRules.ShopList;
using Teleperformance.Final.Project.Domain.ShopList;

namespace Teleperformance.Final.Project.Application.Feautures.ShopList.Command
{
    #region COMMAND
    public class CreateShopListCommand : IRequest<BaseCommandResponse>
    {
        public AddShopListDto shopListDto { get; set; }


    }
    #endregion

    #region HANDLER
    public class CreateShopListCommandHandler : BaseHandler, IRequestHandler<CreateShopListCommand, BaseCommandResponse>
    { 
        #region CTOR
        public CreateShopListCommandHandler(IUnitOfWork unitOfWork, IMapper mapper):base(unitOfWork, mapper)
        {
           
        }
        #endregion

        #region METHODS
        public async Task<BaseCommandResponse> Handle(CreateShopListCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseCommandResponse();
            var validator = new AddShopListDtoValidator();
            var validationResult = await validator.ValidateAsync(request.shopListDto);

            if (validationResult.IsValid == false)
            {
                response.Success = false;
                response.Message = "Alış Veriş Listesine Ürün Ekleme Hatalı";
                response.Errors = validationResult.Errors.Select(q => q.ErrorMessage).ToList();
            }
            else
            {
                var result = _mapper.Map<ShopListEntity>(request.shopListDto);

               // result = await _unitOfWork.ShopListRepository.Add(result);
                await _unitOfWork.Save();

                response.Success = true;
                response.Message = "Alış Veriş Listesine Ürün Ekleme Başarılı";
                response.Id = result.Id;
            }
            return response;
        }

        #endregion
    }
    #endregion

}
