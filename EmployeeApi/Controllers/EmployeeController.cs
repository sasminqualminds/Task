using EmployeeApi.Contracts;
using EmployeeApi.Data;
using EmployeeApi.Model;
using EmployeeApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeApi.Controllers
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

        [HttpGet("/allEmployees")]
        public IActionResult GetAllEmployees()
        {
            var employees = _employeeService.GetEmployees();
            return Ok(employees);
        }

        [HttpGet("/employee/{id}")]
        public IActionResult GetEmployeeById(int id)
        {
            var employee = _employeeService.GetById(id);
            if (employee == null)
            {
                return NotFound($"Employee with ID {id} not found");
            }
            return Ok(employee);
        }

        [HttpPost("/addEmployee")]
        public IActionResult AddNewEmployee(Employee employee)
        {
            var result = _employeeService.AddEmployee(employee);                     
             return Ok(result);            
        }

        [HttpPut("/updateEmployee/{id}")]
        public IActionResult UpdateEmployee(int id, Employee employee)
        {
            var result = _employeeService.UpdateEmployeeById(id, employee);           
                return Ok(result);           
        }

        [HttpDelete("/deleteEmployee/{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            var result = _employeeService.DeleteEmployeeById(id);            
            return Ok(result);
        }
    }
}

