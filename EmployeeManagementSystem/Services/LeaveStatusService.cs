using EmployeeManagementSystem.DTOs;
using EmployeeManagementSystem.Interfaces;
using EmployeeManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementSystem.Services
{
    public class LeaveStatusService : ILeaveStatus
    {
        private EmployeeManagementDbContext _context;

        public LeaveStatusService(EmployeeManagementDbContext context)
        {
            _context     = context;
        }
        public async Task<LeaveStatus> CreateAsync(LeaveStatusDTO dto)
        {
            var leaveStatus = new LeaveStatus()
            {
                Status = dto.Status,
                Description = dto.Description,

            };
            _context.Add(leaveStatus);
            await _context.SaveChangesAsync();
            return leaveStatus;
           
            
        }

        public async Task<bool> DeleteAsync(int id)
        {

            var leaveStatus=await _context.LeaveStatuses.FindAsync(id);
            if (leaveStatus==null)
            {
                return false;
            }
            _context.Remove(leaveStatus);
            return true;
        }

        public async Task<IEnumerable<LeaveStatusDTO>> GetAllAsync()
        {
            var leaveStatusDto= _context.LeaveStatuses.Select(l => new LeaveStatusDTO
            {
                Description=l.Description,
                Status = l.Status,
            });
           return await leaveStatusDto.ToListAsync();
        }

        public async Task<LeaveStatusDTO?> GetByIdAsync(int id)
        {
            return await _context.LeaveStatuses
            .Where(l => l.StatusId == id)
                .Select(d => new LeaveStatusDTO
                {
                   StatusId= d.StatusId,
                   Description= d.Description,
                })
                .FirstOrDefaultAsync();
        }

        public async Task<LeaveStatusDTO?> UpdateAsync(int id, LeaveStatusDTO dto)
        {

            var existingLeaveStatus = await _context.LeaveStatuses.FindAsync(id);
            if (existingLeaveStatus == null)
            {
                return null;
            }

            existingLeaveStatus.Status = dto.Status;
            existingLeaveStatus.Description = dto.Description;

            await _context.SaveChangesAsync();
            return new LeaveStatusDTO
            {
                StatusId = dto.StatusId,
                Status = dto.Status,
                Description = dto.Description,
            };
        }
    }
}
