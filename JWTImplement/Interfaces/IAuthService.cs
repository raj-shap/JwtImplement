using JWTImplement.Models;
using JWTImplement.RequestModels;

namespace JWTImplement.Interfaces
{
    public interface IAuthService
    {
        User AddUser(User user);
        string Login(LoginRequest loginRequest);
    }
}
