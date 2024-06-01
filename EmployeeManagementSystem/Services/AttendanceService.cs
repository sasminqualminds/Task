using EmployeeManagementSystem.DTOs;
using EmployeeManagementSystem.Interfaces;
using EmployeeManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementSystem.Services
{
    public class AttendanceService:IAttendance
    {
        private EmployeeManagementDbContext _context;

        public AttendanceService(EmployeeManagementDbContext context)
        {
            _context = context;
        }
        public async Task<Attendance> CreateAsync(AttendanceDTO dto)
        {
            var attendance = new Attendance()
            {
                EmployeeId = dto.EmployeeId,
                LeaveTypeId = dto.LeaveTypeId,
                DateOfLog = dto.DateOfLog,
                TimeIn = dto.TimeIn,
                TimeOut = dto.TimeOut,
                LateTime = dto.LateTime,
                

            };
            _context.Add(attendance);
            await _context.SaveChangesAsync();
            return attendance;


        }

        public async Task<bool> DeleteAsync(int id)
        {

            var attendance = await _context.Attendances.FindAsync(id);
            if (attendance == null)
            {
                return false;
            }
            _context.Remove(attendance);
            return true;
        }

        public async Task<IEnumerable<AttendanceDTO>> GetAllAsync()
        {
            var attendanceDto = _context.Attendances.Select(l => new AttendanceDTO
            {
                EmployeeId=l.EmployeeId,
                LeaveTypeId=l.LeaveTypeId,
                DateOfLog=l.DateOfLog,
                TimeIn = l.TimeIn,
                TimeOut = l.TimeOut,
                LateTime=l.LateTime,

            });
            return await attendanceDto.ToListAsync();
        }

        public async Task<AttendanceDTO?> GetByIdAsync(int id)
        {
            return await _context.Attendances
            .Where(a => a.LeaveTypeId == id)
                .Select(d => new AttendanceDTO
                {
                    EmployeeId = d.EmployeeId,
                    LeaveTypeId=d.LeaveTypeId,
                    DateOfLog=d.DateOfLog,
                    TimeIn = d.TimeIn,
                    TimeOut = d.TimeOut,
                    LateTime = d.LateTime,
                    

                })
                .FirstOrDefaultAsync();
        }

        public async Task<AttendanceDTO?> UpdateAsync(int id, AttendanceDTO dto)
        {

            var existingAttendance = await _context.Attendances.FindAsync(id);
            if (existingAttendance == null)
            {
                return null;
            }

            existingAttendance.LeaveTypeId = dto.LeaveTypeId;
            existingAttendance.TimeOut = dto.TimeOut;
            existingAttendance.EmployeeId = dto.EmployeeId;
            existingAttendance.TimeIn = dto.TimeIn;
            existingAttendance.LateTime = dto.LateTime;
            existingAttendance.DateOfLog = dto.DateOfLog;

            await _context.SaveChangesAsync();
            return new AttendanceDTO
            {
                EmployeeId= existingAttendance.EmployeeId,
                LeaveTypeId=existingAttendance.LeaveTypeId,
                TimeIn = existingAttendance.TimeIn,
                TimeOut = existingAttendance.TimeOut,
                LateTime = existingAttendance.LateTime,
                DateOfLog = existingAttendance.DateOfLog,
            };
        }
    }
}

