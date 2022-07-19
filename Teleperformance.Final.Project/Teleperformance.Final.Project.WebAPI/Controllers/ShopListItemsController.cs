using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Teleperformance.Final.Project.Application.DTOs.ShopListItems;
using Teleperformance.Final.Project.Application.Feautures.ShopListItems.Command.Create;
using Teleperformance.Final.Project.Application.Responses;
using Teleperformance.Final.Project.WebAPI.Controllers.Base;

namespace Teleperformance.Final.Project.WebAPI.Controllers
{
    #region ATTRIBUTES
    [Authorize(Roles = "User,Administrator")]
    [ApiVersion("1.0")]
    #endregion

    public class ShopListItemsController : BaseController
    {
        #region SUMMARY
        /// <summary>
        /// Alışveriş Listesine Ürün Ekler.
        /// </summary>

        #endregion

        #region FIELDS
        private readonly IMediator _mediator;

        #endregion

        #region CTOR
        public ShopListItemsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        #endregion

        #region METHODS

        #region CREATE
        [HttpPost]
        public async Task<ActionResult<BaseCommandResponse>> Post([FromBody] AddShopListItemsDto shopListItems)
        {
            var command = new CreateShopListItemsCommand { AddShopListItems = shopListItems };
            var repsonse = await _mediator.Send(command);
            return Ok(repsonse);
        }

        #endregion


        #endregion

    }
}
