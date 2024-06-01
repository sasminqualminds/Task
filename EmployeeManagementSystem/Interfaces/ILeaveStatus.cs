using EmployeeManagementSystem.DTOs;
using EmployeeManagementSystem.Models;

namespace EmployeeManagementSystem.Interfaces
{
    public interface ILeaveStatus
    {
        public Task<IEnumerable<LeaveStatusDTO>> GetAllAsync();
        public Task<LeaveStatusDTO?> GetByIdAsync(int id);
        Task<LeaveStatus> CreateAsync(LeaveStatusDTO dto);
        public Task<LeaveStatusDTO?> UpdateAsync(int id, LeaveStatusDTO dto);
        Task<bool> DeleteAsync(int id);
    }
}
