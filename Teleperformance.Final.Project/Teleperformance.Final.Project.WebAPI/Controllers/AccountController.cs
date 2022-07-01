using Microsoft.AspNetCore.Mvc;
using Teleperformance.Final.Project.WebAPI.Controllers.Base;

namespace Teleperformance.Final.Project.WebAPI.Controllers
{
    public class AccountController : BaseController
    {
        /// <summary>
        /// Sisteme giriş kontrollerinin yapıldığı controller.
        /// </summary>

        #region CTOR
        public AccountController()
        {

        }

        #endregion

        #region IACTION RESULTS
        public IActionResult Login()
        {
            return View();
        }
        #endregion

        #region METHODS

        #endregion

    }
}
