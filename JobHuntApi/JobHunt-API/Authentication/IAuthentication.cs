using JobHunt_Models.User;

namespace JonHunt_API.Authentication
{
    public interface IAuthentication
    {
        public string GenerateToken(Login user);
    }
}
