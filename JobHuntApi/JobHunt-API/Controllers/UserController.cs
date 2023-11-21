using JobHunt_Interface.Interface;
using JobHunt_Models.User;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JonHunt_API.Controllers
{
    [Route("jobhunt/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUser _user;
        public UserController(IUser user)
        {
            _user = user;
            
        }
        #region Post
        //For the New User 
        [HttpPost("registration")]
        public OkObjectResult NewRegistration([FromBody]NewUser newUser)
        {
            var response = _user.StoreInfoInDb(newUser);
            return Ok(response);
        }

        #endregion
    }
}
