using EmployeeAPI.Models;
using EmployeeAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        // GET: api/employee
        [HttpGet]
        public IActionResult Get()
        {
            var employees = _employeeService.GetAll();
            return Ok(employees);
        }

        // GET api/employee/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var employee = _employeeService.Get(id);
            if(employee == null) 
            {
                return BadRequest();
            }
            return CreatedAtAction("Get", new { id = employee.Id }, employee);
        }

        // POST api/employee
        [HttpPost]
        public IActionResult Post(Employee employee)
        {
            _employeeService.AddEntity(employee);
            return NoContent();
        }

        // PUT api/employee/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, Employee employee)
        {
            if (id != employee.Id)
            {
                return BadRequest();
            }
            var emp = _employeeService.Get(id);
            if (emp == null)
                return NotFound();
            return Ok(emp);
        }

        // DELETE api/employee/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var emp = _employeeService.Get(id);
            if (emp == null)
                return NotFound();
            return Ok();
        }
    }
}
