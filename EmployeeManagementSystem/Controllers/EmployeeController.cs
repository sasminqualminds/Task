using EmployeeManagementSystem.DTOs;
using EmployeeManagementSystem.Interfaces;
using EmployeeManagementSystem.Models;
using EmployeeManagementSystem.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployee _employeeService;

        public EmployeeController(IEmployee employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet("GetEmployees")]
        public async Task<ActionResult<IEnumerable<EmployeeDTO>>> GetEmployees()
        {
            var employees = await _employeeService.GetAllAsync();
            return Ok(employees);
        }

        [HttpGet("GetEmployees/{id}")]
        public async Task<ActionResult<EmployeeDTO>> GetEmployee(int id)
        {
            var employee = await _employeeService.GetByIdAsync(id);
            if (employee == null)
            {
                return NotFound();
            }
            return Ok(employee);
        }

        [HttpPost("AddEmployees")]
        public async Task<ActionResult<EmployeeDTO>> CreateEmployee(EmployeeDTO employeeDto)
        {
            var createdEmployee = await _employeeService.CreateAsync(employeeDto);
            var employeeOutputDto = new EmployeeDTO
            {
                EmployeeId = createdEmployee.EmployeeId,
                FirstName = createdEmployee.FirstName,
                LastName = createdEmployee.LastName,
                EmailId = createdEmployee.EmailId,
                Contact = createdEmployee.Contact,
                Address = createdEmployee.Address,
                Salary = createdEmployee.Salary,
                DepartmentId = createdEmployee.DepartmentId,
                RoleId = createdEmployee.RoleId
            };
            return CreatedAtAction(nameof(GetEmployee), new { id = createdEmployee.EmployeeId }, employeeOutputDto);
        }

        [HttpPut("UpdateEmployees/{id}")]
        public async Task<IActionResult> UpdateEmployee(int id, EmployeeDTO employeeDto)
        {
            var updatedEmployee = await _employeeService.UpdateAsync(id, employeeDto);
            if (updatedEmployee == null)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("DeleteEmployees/{id}")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            var success = await _employeeService.DeleteAsync(id);
            if (!success)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
    }




