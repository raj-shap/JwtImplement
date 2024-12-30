using JWTImplement.Interfaces;
using JWTImplement.Models;
using JWTImplement.RequestModels;
using JWTImplement.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JWTImplement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        private readonly IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        // POST api/<AuthController>
        [HttpPost]
        public string Login([FromBody] LoginRequest loginModel)
        {
            var result = _authService.Login(loginModel);
            return result;
        }

        // PUT api/<AuthController>/5
        [HttpPost("AddUser")]
        public User AddUser([FromBody] User usr)
        {
            var user = _authService.AddUser(usr);
            return user;
        }

    }
}
