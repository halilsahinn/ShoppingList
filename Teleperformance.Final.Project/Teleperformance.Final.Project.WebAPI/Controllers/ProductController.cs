using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Teleperformance.Final.Project.Application.DTOs.Product;
using Teleperformance.Final.Project.Application.Feautures.Product.Queries;

namespace Teleperformance.Final.Project.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
 
    public class ProductController : ControllerBase
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
            var product = await _mediator.Send(new GetByIdQuery{Id = id});
            return Ok(product);
        }
        #endregion


        #region CREATE

        #endregion


        #region UPDATE

        #endregion

        #region DELETE

        #endregion


        #endregion


    }
}
