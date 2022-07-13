using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Teleperformance.Final.Project.Application.Contracts.Identity;
using Teleperformance.Final.Project.Application.Models.Identity;
using Teleperformance.Final.Project.WebAPI.Controllers.Base;

namespace Teleperformance.Final.Project.WebAPI.Controllers
{
    [AllowAnonymous]
    public class AccountController : BaseController
    {

        #region SUMMARY
        /// <summary>
        /// Sisteme giriş kontrollerinin yapıldığı controller.
        /// </summary>
        #endregion
         
        #region FIELDS

        private readonly IAuthService _authenticationService;


        #endregion

        #region CTOR

        public AccountController(IAuthService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        #endregion

        #region ACTION RESULTS
        /// <summary>
        /// Varsayılan Admin Kullanıcı Adı: admin@localhost.com Şifre: P@ssword1
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        // GET: api/<AccountController>
        [HttpPost("login")]
        public async Task<ActionResult<AuthResponse>> Login(AuthRequest request)
        {
            return Ok(await _authenticationService.Login(request));
        }


        [HttpPost("register")]
        public async Task<ActionResult<RegistrationResponse>> Register(RegistrationRequest request)
        {
            return Ok(await _authenticationService.Register(request));
        }

        #endregion



    }
}
