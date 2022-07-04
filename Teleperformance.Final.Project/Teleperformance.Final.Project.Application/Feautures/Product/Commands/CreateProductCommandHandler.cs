using AutoMapper;
using MediatR;
using Teleperformance.Final.Project.Application.Contracts.UnitOfWork;
using Teleperformance.Final.Project.Application.DTOs.Product;
using Teleperformance.Final.Project.Application.Responses;
using Teleperformance.Final.Project.Domain.Product;

namespace Teleperformance.Final.Project.Application.Feautures.Product.Commands
{

    #region COMMAND
    public class CreateProductCommand : IRequest<BaseCommandResponse>
    {
        public ProductDto productDto { get; set; }
    }
    #endregion
     
    #region HANDLER
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, BaseCommandResponse>
    {

        #region FIELDS
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        #endregion
         
        #region CTOR
        public CreateProductCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        #endregion

        #region METHODS
        public async Task<BaseCommandResponse> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseCommandResponse();
            var validator = new CreateProductCommandValidator();
            var validationResult = await validator.ValidateAsync(request.productDto);

            if (validationResult.IsValid == false)
            {
                response.Success = false;
                response.Message = "Ürün Ekleme Hatalı";
                response.Errors = validationResult.Errors.Select(q => q.ErrorMessage).ToList();
            }
            else
            {
                var product = _mapper.Map<ProductEntity>(request.productDto);

                product = await _unitOfWork.ProductRepository.Add(product);
                await _unitOfWork.Save();

                response.Success = true;
                response.Message = "Ürün Ekleme Başarılı";
                response.Id = product.Id;
            }
            return response;
        }

        #endregion
    }
    #endregion

}
