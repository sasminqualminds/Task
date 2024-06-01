using EmployeeManagementSystem.DTOs;
using EmployeeManagementSystem.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeavesController : ControllerBase
    {
        private readonly ILeaves _leavesService;

        public LeavesController(ILeaves leaves)
        {
            _leavesService = leaves;
        }

        [HttpGet("GetLeaves")]
        public async Task<ActionResult<IEnumerable<LeavesDTO>>> GetLeaves()
        {
            var leaves = await _leavesService.GetAllAsync();
            return Ok(leaves);
        }

        [HttpGet("GetLeaves/{id}")]
        public async Task<ActionResult<LeavesDTO>> GetLeave(int id)
        {
            var leave = await _leavesService.GetByIdAsync(id);
            if (leave == null)
            {
                return NotFound();
            }
            return Ok(leave);
        }

        [HttpPost("AddeLeave")]
        public async Task<ActionResult<LeavesDTO>> CreateLeave(LeavesDTO leavesDto)
        {
            var createdLeave = await _leavesService.CreateAsync(leavesDto);
            var LeaveOutputDto = new LeavesDTO
            {
                LeaveTypeName=leavesDto.LeaveTypeName,
                CreatedBy=createdLeave.CreatedBy,
                CreatedDate=createdLeave.CreatedDate,
                UpdatedBy=createdLeave.UpdatedBy,   
                UpdatedDate=createdLeave.UpdatedDate,
                Description=leavesDto.Description,
                

            };
            return CreatedAtAction(nameof(GetLeave), new { id = createdLeave.LeaveTypeId }, LeaveOutputDto);
        }

        [HttpPut("UpdateLeaves/{id}")]
        public async Task<IActionResult> UpdateLeave(int id, LeavesDTO leaveDto)
        {
            var updatedLeave = await _leavesService.UpdateAsync(id, leaveDto);
            if (updatedLeave == null)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("DeleteLeaves/{id}")]
        public async Task<IActionResult> DeleteLeaveStatus(int id)
        {
            var success = await _leavesService.DeleteAsync(id);
            if (!success)
            {
                return NotFound();
            }

            return NoContent();
        }
    
}
}
