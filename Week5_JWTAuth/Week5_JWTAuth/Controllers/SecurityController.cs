using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Week5_JWTAuth.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class SecurityController : ControllerBase
    {
        [HttpGet("secret")]
        public IActionResult Secret()
        {
            return Ok("🔒 You are authorized to see this secure data!");
        }
    }
}
