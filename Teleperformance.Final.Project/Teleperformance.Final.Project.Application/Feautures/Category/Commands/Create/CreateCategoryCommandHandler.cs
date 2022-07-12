using AutoMapper;
using MediatR;
using Teleperformance.Final.Project.Application.Contracts.UnitOfWork;
using Teleperformance.Final.Project.Application.DTOs.Category;
using Teleperformance.Final.Project.Application.Feautures.Base;
using Teleperformance.Final.Project.Application.Responses;
using Teleperformance.Final.Project.Application.ValidationRules.Category;
using Teleperformance.Final.Project.Domain.Category;

namespace Teleperformance.Final.Project.Application.Feautures.Category.Commands.Create
{
    #region COMMAND
    public class CreateCategoryCommand : IRequest<BaseCommandResponse>
    {
        public AddCategoryDto categoryDto { get; set; }
    }
    #endregion

    #region HANDLER
    public class CreateCategoryCommandHandler : BaseHandler, IRequestHandler<CreateCategoryCommand, BaseCommandResponse>
    {
        #region CTOR
        public CreateCategoryCommandHandler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {

        }
        #endregion

        #region METHODS
        public async Task<BaseCommandResponse> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseCommandResponse();
            var validator = new AddCategoryDtoValidator();
            var validationResult = await validator.ValidateAsync(request.categoryDto);

            if (validationResult.IsValid == false)
            {
                response.Success = false;
                response.Message = "Kategori Ekleme Hatalı";
                response.Errors = validationResult.Errors.Select(q => q.ErrorMessage).ToList();
            }
            else
            {
                var result = _mapper.Map<CategoryEntity>(request.categoryDto);

                // result = await _unitOfWork.ProductRepository.Add(result);
                await _unitOfWork.Save();



                response.Success = true;
                response.Message = "Kategori Ekleme Başarılı";
                response.Id = result.Id;
            }
            return response;
        }

        #endregion
    }

    #endregion
}
