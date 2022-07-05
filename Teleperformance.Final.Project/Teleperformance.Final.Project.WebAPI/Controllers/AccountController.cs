using Microsoft.AspNetCore.Mvc;
using Teleperformance.Final.Project.Application.Contracts.Identity;
using Teleperformance.Final.Project.Application.Models.Identity;
using Teleperformance.Final.Project.WebAPI.Controllers.Base;

namespace Teleperformance.Final.Project.WebAPI.Controllers
{
    public class AccountController : BaseController
    {
        /// <summary>
        /// Sisteme giriş kontrollerinin yapıldığı controller.
        /// </summary>

        #region FIELDS

        private readonly IAuthService _authenticationService;


        #endregion

        #region CTOR

        public AccountController(IAuthService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        #endregion

        #region IACTION RESULTS
        [HttpPost("login")]
        public async Task<ActionResult<AuthResponse>> Login(AuthRequest request)
        {
            return Ok(await _authenticationService.Login(request));
        }
        #endregion

        #region METHODS

        #endregion

    }
}
