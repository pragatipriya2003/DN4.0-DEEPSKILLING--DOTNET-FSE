using Microsoft.AspNetCore.Mvc;

namespace SwaggerDemo.Controllers

{
    [ApiController]
    [Route("api/emp")]
  // ← sets the route to: /api/employee
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new[] { "Alice", "Bob", "Charlie" });
        }
    }
}
