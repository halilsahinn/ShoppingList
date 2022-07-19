using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Teleperformance.Final.Project.Application.DTOs.Category;
using Teleperformance.Final.Project.Application.Feautures.Category.Commands.Create;
using Teleperformance.Final.Project.Application.Feautures.Category.Commands.Delete;
using Teleperformance.Final.Project.Application.Feautures.Category.Commands.Update;
using Teleperformance.Final.Project.Application.Feautures.Category.Queries;
using Teleperformance.Final.Project.Application.Responses;
using Teleperformance.Final.Project.WebAPI.Controllers.Base;

namespace Teleperformance.Final.Project.WebAPI.Controllers
{
    #region ATTRIBUTES
    [Authorize(Roles = "User")]
    [ApiVersion("1.0")]
    #endregion

    public class CategoryController : BaseController
    {
        #region FIELDS
        private readonly IMediator _mediator;

        #endregion

        #region CTOR
        public CategoryController(IMediator mediator)
        {
            _mediator = mediator;
        }
        #endregion

        #region METHODS

        #region CREATE
        [HttpPost]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<ActionResult<BaseCommandResponse>> Post([FromBody] AddCategoryDto categoryDto)
        {
            var command = new CreateCategoryCommand { categoryDto = categoryDto };
            var repsonse = await _mediator.Send(command);
            return Ok(repsonse);
        }

        #endregion

        #region READ
        // GET api/<CategoryController>/1
        [HttpGet("{id}")]
        public async Task<ActionResult<CategoryDto>> Get(int id)
        {
            var category = await _mediator.Send(new GetByIdCategoryQuery { Id = id });
            return Ok(category);
        }


        // GET: api/<CategoryController>
        [HttpGet]
        public async Task<ActionResult<List<CategoryDto>>> Get()
        {
            var categories = await _mediator.Send(new GetAllCategoryQuery());
            return Ok(categories);
        }

        #endregion

        #region UPDATE
        // PUT api/<CategoryCController>
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
         
        public async Task<ActionResult> Put([FromBody] UpdateCategoryDto updateCategory)
        {
            var command = new UpdateCategoryCommand {  UpdateCategory = updateCategory };
            await _mediator.Send(command);
            return NoContent();
        }

        #endregion

        #region DELETE
        // DELETE api/<CategoryController>/5
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
       
        public async Task<ActionResult> Delete(int id)
        {
            var command = new DeleteCategoryCommand { Id = id };
            await _mediator.Send(command);
            return NoContent();
        }

        #endregion

        #endregion
    }
}
