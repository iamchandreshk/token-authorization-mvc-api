using System.Web.Http;

namespace Authorization.Controllers
{
    //[Authorize]
    //[CustomAuthorize]
    [Route("secure_data")]
    public class SecureDataController : ApiController
    {
        [Authorize]
        public IHttpActionResult Get()
        {
            return Ok(new { secureData = "Hi!, " + System.Web.HttpContext.Current.User.Identity.Name });
        }
    }
}