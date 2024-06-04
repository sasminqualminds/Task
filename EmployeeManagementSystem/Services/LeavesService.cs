using EmployeeManagementSystem.DTOs;
using EmployeeManagementSystem.Interfaces;
using EmployeeManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementSystem.Services
{
    public class LeavesService:ILeaves
    {
        private EmployeeManagementDbContext _context;

        public LeavesService(EmployeeManagementDbContext context)
        {
            _context = context;
        }
        public async Task<Leaf> CreateAsync(LeavesDTO dto)
        {
            var leave = new Leaf()
            {
                LeaveTypeName=dto.LeaveTypeName,
                Description=dto.Description,
                CreatedBy=dto.CreatedBy,
                CreatedDate=dto.CreatedDate,
                UpdatedBy=dto.UpdatedBy,
                UpdatedDate=dto.UpdatedDate,

            };
            _context.Add(leave);
            await _context.SaveChangesAsync();
            return leave;


        }

        public Task CreateAsync(AttendanceDTO attendanceDto)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteAsync(int id)
        {

            var leave = await _context.Leaves.FindAsync(id);
            if (leave == null)
            {
                return false;
            }
            _context.Remove(leave);
            return true;
        }

        public async Task<IEnumerable<LeavesDTO>> GetAllAsync()
        {
            var leavesDto = _context.Leaves.Select(l => new LeavesDTO
            {
                Description=l.Description,
                CreatedBy=l.CreatedBy,
                CreatedDate=l.CreatedDate,
                UpdatedBy=l.UpdatedBy,
                UpdatedDate = l.UpdatedDate,
                LeaveTypeName = l.LeaveTypeName,
            });
            return await leavesDto.ToListAsync();
        }

        public async Task<LeavesDTO?> GetByIdAsync(int id)
        {
            return await _context.Leaves
            .Where(l => l.LeaveTypeId == id)
                .Select(d => new LeavesDTO
                {
                    LeaveTypeId=d.LeaveTypeId,
                    CreatedBy=d.CreatedBy,
                    CreatedDate=d.CreatedDate,
                    UpdatedBy=d.UpdatedBy,
                    UpdatedDate=d.UpdatedDate,
                    Description=d.Description,
                    LeaveTypeName=d.LeaveTypeName,
                })
                .FirstOrDefaultAsync();
        }

        public async Task<LeavesDTO?> UpdateAsync(int id, LeavesDTO dto)
        {

            var existingLeave = await _context.Leaves.FindAsync(id);
            if (existingLeave == null)
            {
                return null;
            }

            existingLeave.LeaveTypeName = dto.LeaveTypeName;
            existingLeave.UpdatedDate = dto.UpdatedDate;
            existingLeave.Description = dto.Description;
            existingLeave.UpdatedBy = dto.UpdatedBy;
            existingLeave.CreatedBy = dto.CreatedBy;
            existingLeave.CreatedDate = dto.CreatedDate;

            await _context.SaveChangesAsync();
            return new LeavesDTO
            {
                LeaveTypeId = existingLeave.LeaveTypeId,
                LeaveTypeName = existingLeave.LeaveTypeName,
                UpdatedDate = existingLeave.UpdatedDate,
                Description = existingLeave.Description,
                UpdatedBy = existingLeave.UpdatedBy,
                CreatedDate = existingLeave.CreatedDate,
                CreatedBy = existingLeave.CreatedBy,
            };
        }

        
    }
}

