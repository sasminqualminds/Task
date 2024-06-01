using EmployeeManagementSystem.DTOs;
using EmployeeManagementSystem.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaveStatusController : ControllerBase
    {
        private readonly ILeaveStatus _leaveStatusService;

        public LeaveStatusController(ILeaveStatus leaveStatusService)
        {
            _leaveStatusService = leaveStatusService;
        }

        [HttpGet("GetLeaveStatus")]
        public async Task<ActionResult<IEnumerable<LeaveStatusDTO>>> GetLeaveStatuses()
        {
            var leaveStatuses = await _leaveStatusService.GetAllAsync();
            return Ok(leaveStatuses);
        }

        [HttpGet("GetLeaveStatus/{id}")]
        public async Task<ActionResult<LeaveStatusDTO>> GetLeaveStatus(int id)
        {
            var leaveStatus = await _leaveStatusService.GetByIdAsync(id);
            if (leaveStatus == null)
            {
                return NotFound();
            }
            return Ok(leaveStatus);
        }

        [HttpPost("AddLeaveStatus")]
        public async Task<ActionResult<LeaveStatusDTO>> CreateLeaveStatus(LeaveStatusDTO leaveStatusDTO)
        {
            var createdLeaveStatus = await _leaveStatusService.CreateAsync(leaveStatusDTO);
            var LeaveStatusOutputDto = new LeaveStatusDTO
            {
                Status = leaveStatusDTO.Status,
                Description = leaveStatusDTO.Description,
                
            };
            return CreatedAtAction(nameof(GetLeaveStatus), new { id = createdLeaveStatus.StatusId }, LeaveStatusOutputDto);
        }

        [HttpPut("UpdateLeaveStatus/{id}")]
        public async Task<IActionResult> UpdateLeaveStatus(int id, LeaveStatusDTO leaveStatusDTO)
        {
            var updatedLeaveStatus = await _leaveStatusService.UpdateAsync(id, leaveStatusDTO);
            if (updatedLeaveStatus == null)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("DeleteLeaveStatus/{id}")]
        public async Task<IActionResult> DeleteLeaveStatus(int id)
        {
            var success = await _leaveStatusService.DeleteAsync(id);
            if (!success)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}

