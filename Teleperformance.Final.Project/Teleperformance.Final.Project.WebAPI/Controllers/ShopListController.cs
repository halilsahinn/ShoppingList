using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Teleperformance.Final.Project.Application.DTOs.ShopList;
using Teleperformance.Final.Project.Application.Feautures.ShopList.Command.Complete;
using Teleperformance.Final.Project.Application.Feautures.ShopList.Command.Create;
using Teleperformance.Final.Project.Application.Responses;
using Teleperformance.Final.Project.WebAPI.Controllers.Base;

namespace Teleperformance.Final.Project.WebAPI.Controllers
{
    #region ATTRIBUTES

    [Authorize(Roles = "User,Administrator")]
    [ApiVersion("1.0")]
    #endregion


    public class ShopListController : BaseController
    {
        #region SUMMARY
        /// <summary>
        /// Alışveriş Listesi İle ilgili işlemlerin yapıldığı controller
        /// </summary>

        #endregion

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
        [HttpPost]
        public async Task<ActionResult<BaseCommandResponse>> Post([FromBody] AddShopListDto shopListDto)
        {
            var command = new CreateShopListCommand { shopListDto = shopListDto };
            var repsonse = await _mediator.Send(command);
            return Ok(repsonse);
        }

        #endregion

        #region UPDATE
        // PUT api/<ShopListController>/1
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]

        public async Task<ActionResult> Put([FromBody] CompleteShopListDto completeShopListDto)
        {
            var command = new CompleteShopListCommand { completeShopListDto = completeShopListDto };
            await _mediator.Send(command);
            return Ok();
        }


        #endregion

        #endregion
    }
}
