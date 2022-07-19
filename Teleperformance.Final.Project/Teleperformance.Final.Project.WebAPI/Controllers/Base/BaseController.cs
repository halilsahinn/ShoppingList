using Microsoft.AspNetCore.Mvc;

namespace Teleperformance.Final.Project.WebAPI.Controllers.Base
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]


    public class BaseController : ControllerBase
    {

        #region CTOR
        public BaseController()
        {

        }
        #endregion

    }
}
