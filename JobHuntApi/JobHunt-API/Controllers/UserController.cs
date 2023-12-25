using JobHunt_Interface.Interface;
using JobHunt_Models.User;
using JonHunt_API.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JonHunt_API.Controllers
{
    [Route("jobhunt/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IAuthentication _auth;
        private readonly IUser _user;
        public UserController(IUser user,IAuthentication auth)
        {
            _user = user;
            _auth = auth;   
        }
        #region Post
        //For the New User 
        [HttpPost("registration")]
        public OkObjectResult NewRegistration([FromBody]NewUser newUser)
        {
            var response = _user.StoreInfoInDb(newUser);
            return Ok(response);
        }

        [HttpPost("login")]
        public async Task<OkObjectResult> Login([FromBody] Login user)
        {   IActionResult response = Unauthorized();
            dynamic a = await _user.UserExist(user);
            if (a[0] == true)
            {
                var token = _auth.GenerateToken(user);
                return Ok(new {token =token});
            }
            else return Ok(a);
        }

        #endregion
    }
}
