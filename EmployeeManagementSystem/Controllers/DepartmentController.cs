using EmployeeManagementSystem.DTOs;
using EmployeeManagementSystem.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartment _departmentService;

        public DepartmentController(IDepartment departmentService)
        {
            _departmentService = departmentService;
        }

        [HttpGet("GetDepartments")]
        public async Task<ActionResult<IEnumerable<DepartmentDTO>>> GetDepartments()
        {
            var departments = await _departmentService.GetAllAsync();
            return Ok(departments);
        }

        [HttpGet("GetDepartments/{id}")]
        public async Task<ActionResult<DepartmentDTO>> GetRole(int id)
        {
            var department = await _departmentService.GetByIdAsync(id);
            if (department == null)
            {
                return NotFound();
            }
            return Ok(department);
        }

        [HttpPost("AddDepartments")]
        public async Task<ActionResult<DepartmentDTO>> CreateDepartment(DepartmentDTO departmentDTO)
        {
            var createdDepartment = await _departmentService.CreateAsync(departmentDTO);
            var DepartmentOutputDto = new DepartmentDTO
            {
                DepartmentName = departmentDTO.DepartmentName,
                Description = departmentDTO.Description,
                CreatedBy = departmentDTO.CreatedBy,
                UpdatedBy = departmentDTO.UpdatedBy,
                CreatedDate = DateTime.UtcNow
            };
            return CreatedAtAction(nameof(GetRole), new { id = createdDepartment.DepartmentId }, DepartmentOutputDto);
        }

        [HttpPut("UpdateDepartments/{id}")]
        public async Task<IActionResult> UpdateDepartment(int id, DepartmentDTO departmentDTO)
        {
            var updatedDepartment = await _departmentService.UpdateAsync(id, departmentDTO);
            if (updatedDepartment == null)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("DeleteDepartments/{id}")]
        public async Task<IActionResult> DeleteDepartment(int id)
        {
            var success = await _departmentService.DeleteAsync(id);
            if (!success)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}

