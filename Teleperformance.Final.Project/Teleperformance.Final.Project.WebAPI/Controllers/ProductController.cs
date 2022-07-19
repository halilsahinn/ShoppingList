using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Teleperformance.Final.Project.Application.DTOs.Product;
using Teleperformance.Final.Project.Application.Feautures.Product.Commands.Create;
using Teleperformance.Final.Project.Application.Feautures.Product.Commands.Delete;
using Teleperformance.Final.Project.Application.Feautures.Product.Queries;
using Teleperformance.Final.Project.Application.Responses;
using Teleperformance.Final.Project.WebAPI.Controllers.Base;

namespace Teleperformance.Final.Project.WebAPI.Controllers
{
    #region ATTRIBUTES
    [Authorize(Roles = "User")]
    [ApiVersion("1.0")]
    #endregion

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
         

        #region CREATE
        [HttpPost]
        public async Task<ActionResult<BaseCommandResponse>> Post([FromBody] AddProductDto productDto)
        {
            var command = new CreateProductCommand { productDto = productDto };
            var repsonse = await _mediator.Send(command);
            return Ok(repsonse);
        }
        #endregion

        #region READ
        // GET api/<ProductController>/1
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductDto>> Get(int id)
        {
            var product = await _mediator.Send(new GetByIdProductQuery { Id = id });
            return Ok(product);
        }

        // GET: api/<ProductController>
        [HttpGet]
        public async Task<ActionResult<List<ProductDto>>> Get()
        {
            var product = await _mediator.Send(new GetAllProductQuery() { });
            return Ok(product);
        }
        #endregion

        #region UPDATE

        #endregion

        #region DELETE
        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> Delete(int id)
        {
            var command = new DeleteProductCommand { Id = id };
            await _mediator.Send(command);
            return NoContent();
        }

        #endregion


        #endregion


    }
}
