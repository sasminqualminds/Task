using EmployeeManagementSystem.DTOs;
using EmployeeManagementSystem.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttendanceController : ControllerBase
    {
        private readonly IAttendance _attendanceService;

        public AttendanceController(IAttendance attendanceService)
        {
            _attendanceService = attendanceService;
        }

        [HttpGet("GetAttandancesList")]
        public async Task<ActionResult<IEnumerable<AttendanceDTO>>> GetAttendances()
        {
            var attendances = await _attendanceService.GetAllAsync();
            return Ok(attendances);
        }

        [HttpGet("GetAttendances/{id}")]
        public async Task<ActionResult<AttendanceDTO>> GetAttendance(int id)
        {
            var attendance = await _attendanceService.GetByIdAsync(id);
            if (attendance == null)
            {
                return NotFound();
            }
            return Ok(attendance);
        }

        [HttpPost("AddAttendance")]
        public async Task<ActionResult<AttendanceDTO>> CreateAttendance(AttendanceDTO attendanceDto)
        {
            var createdattendance = await _attendanceService.CreateAsync(attendanceDto);
            var AttendanceOutputDto = new AttendanceDTO
            {
               LeaveTypeId=createdattendance.LeaveTypeId,
               EmployeeId=createdattendance.EmployeeId,
               TimeIn=createdattendance.TimeIn,
               TimeOut=createdattendance.TimeOut,
               DateOfLog=createdattendance.DateOfLog,
               LateTime=createdattendance.LateTime,
               

            };
            return CreatedAtAction(nameof(GetAttendance), new { id = createdattendance.AttendanceId }, AttendanceOutputDto);
        }

        [HttpPut("UpdateAttendances/{id}")]
        public async Task<IActionResult> UpdateAttendance(int id, AttendanceDTO attendanceDto)
        {
            var updatedAttendance = await _attendanceService.UpdateAsync(id, attendanceDto);
            if (updatedAttendance == null)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("DeleteAttandances/{id}")]
        public async Task<IActionResult> DeleteAttendance(int id)
        {
            var success = await _attendanceService.DeleteAsync(id);
            if (!success)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
