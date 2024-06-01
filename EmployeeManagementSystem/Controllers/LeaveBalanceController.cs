using EmployeeManagementSystem.DTOs;
using EmployeeManagementSystem.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaveBalanceController : ControllerBase
    {
        private readonly ILeaveBalance _leaveBalance;

        public LeaveBalanceController(ILeaveBalance leaveBalance)
        {
            _leaveBalance = leaveBalance;
        }

        [HttpGet("GetLeaveBalances")]
        public async Task<ActionResult<IEnumerable<LeaveBalanceDTO>>> GetLeaveBalance()
        {
            var leaveBalance = await _leaveBalance.GetAllAsync();
            return Ok(leaveBalance);
        }

        [HttpGet("GetLeaveBalances/{id}")]
        public async Task<ActionResult<LeaveBalanceDTO>> GetLeaveBalance(int id)
        {
            var leaveBalance = await _leaveBalance.GetByIdAsync(id);
            if (leaveBalance == null)
            {
                return NotFound();
            }
            return Ok(leaveBalance);
        }

        [HttpPost("AddLeaveBalances")]
        public async Task<ActionResult<LeaveBalanceDTO>> CreateLeaveBalance(LeaveBalanceDTO leaveBalanceDto)
        {
            var createdLeaveBalance = await _leaveBalance.CreateAsync(leaveBalanceDto);
            var LeaveBalanceOutputDto = new LeaveBalanceDTO
            {
                EmployeeId = createdLeaveBalance.EmployeeId,
                LeaveTypeId = createdLeaveBalance.LeaveTypeId,
                Balance = createdLeaveBalance.Balance,


            };
            return CreatedAtAction(nameof(GetLeaveBalance), new { id = createdLeaveBalance.LeaveBalnceId }, LeaveBalanceOutputDto);
        }

        [HttpPut("UpdateLeaveBalances/{id}")]
        public async Task<IActionResult> UpdateLeave(int id, LeaveBalanceDTO leaveBalanceDto)
        {
            var updatedLeaveBalance = await _leaveBalance.UpdateAsync(id, leaveBalanceDto);
            if (updatedLeaveBalance == null)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("DeleteLeaveBalances/{id}")]
        public async Task<IActionResult> DeleteLeaveBalance(int id)
        {
            var success = await _leaveBalance.DeleteAsync(id);
            if (!success)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
