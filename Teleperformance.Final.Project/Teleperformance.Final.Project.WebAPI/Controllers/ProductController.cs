using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Teleperformance.Final.Project.Application.DTOs.Product;
using Teleperformance.Final.Project.Application.Feautures.Product.Commands;
using Teleperformance.Final.Project.Application.Feautures.Product.Queries;
using Teleperformance.Final.Project.Application.Responses;
using Teleperformance.Final.Project.WebAPI.Controllers.Base;

namespace Teleperformance.Final.Project.WebAPI.Controllers
{
    [Authorize]
     
    public class ProductController : BaseController
    {

        #region FIELDS

        private readonly IMediator _mediator;


        #endregion

        #region CTOR

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;

        }

        #endregion

        #region METHODS

        #region GET
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductDto>> Get(int id)
        {

            var product = await _mediator.Send(new GetByIdQuery { Id = id });
            return Ok(product);
        }
        #endregion

        #region CREATE
        [HttpPost]
        public async Task<ActionResult<BaseCommandResponse>> Post([FromBody] AddProductDto productDto)
        {
            var command = new CreateProductCommand { productDto = productDto };
            var repsonse = await _mediator.Send(command);
            return Ok(repsonse);
        }
        #endregion

        #region UPDATE

        #endregion

        #region DELETE

        #endregion


        #endregion


    }
}
