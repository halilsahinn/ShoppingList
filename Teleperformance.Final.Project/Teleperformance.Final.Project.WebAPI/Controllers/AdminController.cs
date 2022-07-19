using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using Teleperformance.Final.Project.Application.Contracts.MongoDb;
using Teleperformance.Final.Project.Application.DTOs.ShopList;
using Teleperformance.Final.Project.Application.Feautures.ShopList.Queries;
using Teleperformance.Final.Project.MongoDb.Model;
using Teleperformance.Final.Project.WebAPI.Controllers.Base;

namespace Teleperformance.Final.Project.WebAPI.Controllers
{
    #region ATTRIBUTES
    [Authorize(Roles = "Administrator")]
    [ApiVersion("1.0")]
    #endregion
    public class AdminController : BaseController
    {
        #region SUMMARY
        /// <summary>
        /// Bu Controllerda Tamamlanan Listeler Görüntülenebilir. Bu görüntüleme işlemini ancak admin yetkisine
        /// sahip olan kullanıcı yapabilir
        /// </summary>
        #endregion

        #region FIELDS
        private readonly IMediator _mediator;
        private readonly IMongoDbService _mongoDbService;
        private const string ShoppingListCollection="CompletedShoppingList";

        #endregion

        #region CTOR
        public AdminController(IMediator mediator)
        {
            _mediator = mediator;
        }

        #endregion

        #region ACTION RESULTS

        #region READ

        // GET: api/<AdminController>
        [HttpGet]
        public async Task<ActionResult<List<ShopListDto>>> Get()
        {
            var shopListComplete = await _mediator.Send(new ShopListCompleteQuery());
            return Ok(shopListComplete);
        }

        [HttpGet("CompletedShoppingList")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetAllComletedShoppingList()
        {
            var collection = _mongoDbService.ConnectTo<ShoppingListBson>(ShoppingListCollection);
            var result = await collection.Find(_ => true).ToListAsync();
            return Ok(result);
        }

        #endregion


        #endregion

    }
}
