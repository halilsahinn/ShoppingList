using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Teleperformance.Final.Project.Application.DTOs.ShopList;
using Teleperformance.Final.Project.Application.Feautures.ShopList.Command;
using Teleperformance.Final.Project.Application.Responses;
using Teleperformance.Final.Project.WebAPI.Controllers.Base;

namespace Teleperformance.Final.Project.WebAPI.Controllers
{
    [Authorize]
    [ApiVersion("1.0")]

    public class ShopListController : BaseController
    { 
        #region FIELDS
        private readonly IMediator _mediator;
         
        #endregion

        #region CTOR
        public ShopListController(IMediator mediator)
        {
            _mediator = mediator;
        }
        #endregion

        #region METHODS
        #region CREATE
        // POST api/<ShopListController>
        [HttpPost("CreateShoppingList")]
        public async Task<ActionResult<BaseCommandResponse>> Post([FromBody] AddShopListDto shopListDto)
        {
            var command = new CreateShopListCommand { shopListDto = shopListDto };
            var repsonse = await _mediator.Send(command);
            return Ok(repsonse);
        }

        #endregion


        #endregion
    }
}
