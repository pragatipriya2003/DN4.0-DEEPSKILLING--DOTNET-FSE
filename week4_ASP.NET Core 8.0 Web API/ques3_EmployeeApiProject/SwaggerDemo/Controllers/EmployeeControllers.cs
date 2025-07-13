using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SwaggerDemo.Models;
using SwaggerDemo.Filters;

namespace SwaggerDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [CustomAuthFilter]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> _employees = new();

        public EmployeeController()
        {
            if (!_employees.Any())
            {
                _employees = GetStandardEmployeeList();
            }
        }

        private List<Employee> GetStandardEmployeeList()
        {
            return new List<Employee>
            {
                new Employee
                {
                    Id = 1,
                    Name = "Alice",
                    Salary = 60000,
                    Permanent = true,
                    Department = new Department { Id = 1, Name = "HR" },
                    Skills = new List<Skill>
                    {
                        new Skill { Id = 1, Name = "Communication" },
                        new Skill { Id = 2, Name = "Recruitment" }
                    },
                    DateOfBirth = new DateTime(1990, 1, 1)
                }
            };
        }

        [AllowAnonymous]
        [HttpGet]
        [ProducesResponseType(typeof(List<Employee>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<List<Employee>> GetStandard()
        {
            return Ok(_employees);
        }

        [HttpPost]
        public IActionResult AddEmployee([FromBody] Employee emp)
        {
            emp.Id = _employees.Max(e => e.Id) + 1;
            _employees.Add(emp);
            return Ok(emp);
        }
    }
}
