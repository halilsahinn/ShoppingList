using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Teleperformance.Final.Project.Application.DTOs.Category;
using Teleperformance.Final.Project.Application.Feautures.Category.Commands.Create;
using Teleperformance.Final.Project.Application.Responses;
using Teleperformance.Final.Project.WebAPI.Controllers.Base;

namespace Teleperformance.Final.Project.WebAPI.Controllers
{
    [Authorize]
    [ApiVersion("2.0")]
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
        public async Task<ActionResult<BaseCommandResponse>> Post([FromBody] AddCategoryDto categoryDto)
        {
            var command = new CreateCategoryCommand { categoryDto = categoryDto };
            var repsonse = await _mediator.Send(command);
            return Ok(repsonse);
        }

        #endregion


        #endregion
    }
}
