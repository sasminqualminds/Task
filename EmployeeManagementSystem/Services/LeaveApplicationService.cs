using EmployeeManagementSystem.DTOs;
using EmployeeManagementSystem.Interfaces;
using EmployeeManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementSystem.Services
{
    public class LeaveApplicationService:ILeaveApplication
    {

        private EmployeeManagementDbContext _context;

        public LeaveApplicationService(EmployeeManagementDbContext context)
        {
            _context = context;
        }
        public async Task<LeaveApplication> CreateAsync(LeaveApplicationDTO dto)
        {
            var leaveApplication = new LeaveApplication()
            {
                EmployeeId = dto.EmployeeId,
                LeaveTypeId=dto.LeaveTypeId,
                DateOfApplication = dto.DateOfApplication,
                DateOfApproval = dto.DateOfApproval,
                StatusId = dto.StatusId,
                EndDate=dto.EndDate,
                StartDate=dto.StartDate,
                Purpose=dto.Purpose,
                NoOfDays=dto.NoOfDays,


            };
            _context.Add(leaveApplication);
            await _context.SaveChangesAsync();
            return leaveApplication;


        }

        public async Task<bool> DeleteAsync(int id)
        {

            var leaveApplication = await _context.LeaveApplications.FindAsync(id);
            if (leaveApplication == null)
            {
                return false;
            }
            _context.Remove(leaveApplication);
            return true;
        }

        public async Task<IEnumerable<LeaveApplicationDTO>> GetAllAsync()
        {
            var leaveApplicationDto = _context.LeaveApplications.Select(l => new LeaveApplicationDTO
            {
                LeaveApplicationId=l.LeaveApplicationId,
                EmployeeId = l.EmployeeId,
                LeaveTypeId = l.LeaveTypeId,
                DateOfApplication = l.DateOfApplication,
                DateOfApproval = l.DateOfApproval,
                StatusId = l.StatusId,
                EndDate = l.EndDate,
                StartDate = l.StartDate,
                Purpose = l.Purpose,
                NoOfDays = l.NoOfDays,

            });
            return await leaveApplicationDto.ToListAsync();
        }

        public async Task<LeaveApplicationDTO?> GetByIdAsync(int id)
        {
            return await _context.LeaveApplications
            .Where(a => a.LeaveApplicationId == id)
                .Select(d => new LeaveApplicationDTO
                {
                    EmployeeId = d.EmployeeId,
                    LeaveTypeId = d.LeaveTypeId,
                    DateOfApplication = d.DateOfApplication,
                    DateOfApproval = d.DateOfApproval,
                    StatusId = d.StatusId,
                    EndDate = d.EndDate,
                    StartDate = d.StartDate,
                    Purpose = d.Purpose,
                    NoOfDays = d.NoOfDays,


                })
                .FirstOrDefaultAsync();
        }

        public async Task<LeaveApplicationDTO?> UpdateAsync(int id, LeaveApplicationDTO dto)
        {

            var existingLeaveApplication = await _context.LeaveApplications.FindAsync(id);
            if (existingLeaveApplication == null)
            {
                return null;
            }

            existingLeaveApplication.StartDate = dto.StartDate;
            existingLeaveApplication.EndDate = dto.EndDate;
            existingLeaveApplication.DateOfApplication = dto.DateOfApplication;
            existingLeaveApplication.DateOfApproval = dto.DateOfApproval;
            existingLeaveApplication.StatusId = dto.StatusId;
            existingLeaveApplication.EmployeeId = dto.EmployeeId;
            existingLeaveApplication.LeaveTypeId = dto.LeaveTypeId;
            existingLeaveApplication.NoOfDays = dto.NoOfDays;
            existingLeaveApplication.Purpose = dto.Purpose;

            await _context.SaveChangesAsync();
            return new LeaveApplicationDTO
            {
                EmployeeId = existingLeaveApplication.EmployeeId,
                LeaveTypeId = existingLeaveApplication.LeaveTypeId,
                StartDate = existingLeaveApplication.StartDate,
                EndDate = existingLeaveApplication.EndDate,
                DateOfApproval = existingLeaveApplication.DateOfApproval,
                DateOfApplication = existingLeaveApplication.DateOfApplication,
                NoOfDays = existingLeaveApplication.NoOfDays,
                Purpose = existingLeaveApplication.Purpose,
                StatusId = existingLeaveApplication.StatusId,
            };
        }

        
    }
}
