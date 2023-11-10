using JobHunt_Models.User;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JonHunt_API.Controllers
{
    [Route("jobhunt/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        #region Post
        //For the New User 
        [HttpPost("registration")]
        public OkObjectResult NewRegistration([FromBody]NewUser newUser)
        {
            return Ok(newUser);
        }

        #endregion
    }
}
