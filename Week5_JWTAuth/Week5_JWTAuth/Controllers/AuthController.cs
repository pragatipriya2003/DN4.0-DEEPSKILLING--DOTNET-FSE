using Microsoft.AspNetCore.Mvc;
using Week5_JWTAuth.Models;
using Week5_JWTAuth.Services;

namespace Week5_JWTAuth.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly JWTService _jwtService;

        public AuthController(JWTService jwtService)
        {
            _jwtService = jwtService;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] User user)
        {
            // Fake validation
            if (user.Username == "admin" && user.Password == "password")
            {
                var token = _jwtService.GenerateToken(user.Username);
                return Ok(new { token });
            }

            return Unauthorized("Invalid credentials");
        }
    }
}
