using JobHunt_Models.User;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace JonHunt_API.Authentication
{
    public class Authentication: IAuthentication
    {
        private IConfiguration _config;
        public Authentication(IConfiguration configuration)
        {
            _config = configuration;
        }


        public string GenerateToken(Login user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["jwt:Key"]));
            var credential = new SigningCredentials(securityKey,SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(
                _config["jwt:Issuer"],
                _config["jwt:Audience"],
                null,
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: credential
               ) ;

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
