using Microsoft.AspNetCore.Mvc;

namespace FirstWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() => Ok(new[] { "value1", "value2" });

        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            return Ok($"Received: {value}");
        }
    }
}
