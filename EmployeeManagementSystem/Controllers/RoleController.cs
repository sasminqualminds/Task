using EmployeeManagementSystem.DTOs;
using EmployeeManagementSystem.Interfaces;
using EmployeeManagementSystem.Models;
using EmployeeManagementSystem.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRole _roleService;

        public RoleController(IRole roleService)
        {
            _roleService = roleService;
        }

        [HttpGet("GetRoles")]
        public async Task<ActionResult<IEnumerable<RoleDTO>>> GetRoles()
        {
            var roles = await _roleService.GetAllAsync();
            return Ok(roles);
        }

        [HttpGet("GetRoles/{id}")]
        public async Task<ActionResult<RoleDTO>> GetRole(int id)
        {
            var role = await _roleService.GetByIdAsync(id);
            if (role == null)
            {
                return NotFound();
            }
            return Ok(role);
        }

        [HttpPost("AddRoles")]
        public async Task<ActionResult<RoleDTO>> CreateRole(RoleDTO roleDto)
        {
            var createdRole = await _roleService.CreateAsync(roleDto);
            var roleOutputDto = new RoleDTO
            {
                RoleId = createdRole.RoleId,
                RoleName = createdRole.RoleName,
                CreatedBy = createdRole.CreatedBy,
                CreatedDate = createdRole.CreatedDate,
                UpdatedBy = createdRole.UpdatedBy
            };
            return CreatedAtAction(nameof(GetRole), new { id = createdRole.RoleId }, roleOutputDto);
        }

        [HttpPut("UpdateRoles/{id}")]
        public async Task<IActionResult> UpdateRole(int id, RoleDTO roleDto)
        {
            var updatedRole = await _roleService.UpdateAsync(id, roleDto);
            if (updatedRole == null)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("DeleteRoles/{id}")]
        public async Task<IActionResult> DeleteRole(int id)
        {
            var success = await _roleService.DeleteAsync(id);
            if (!success)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}



