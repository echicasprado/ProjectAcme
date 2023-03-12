using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using QuizzesAcme.Helpers;
using QuizzesAcme.Models;
using QuizzesAcme.Models.User;
using QuizzesAcme.Services.UserService;

namespace QuizzesAcme.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly JwtAuthenticationManager _JwtAuthenticationManager;

        public UserController(JwtAuthenticationManager jwtAuthenticationManager)
        {
            _JwtAuthenticationManager = jwtAuthenticationManager;
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public IActionResult AuthUser([FromBody] User user)
        {
            var token = _JwtAuthenticationManager.Authenticate(user);

            if (token == null)
                return Unauthorized();

            return Ok(token);
        }
    }
}
