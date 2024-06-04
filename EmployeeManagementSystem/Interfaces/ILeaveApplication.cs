using EmployeeManagementSystem.DTOs;
using EmployeeManagementSystem.Models;

namespace EmployeeManagementSystem.Interfaces
{
    public interface ILeaveApplication
    {
        public Task<IEnumerable<LeaveApplicationDTO>> GetAllAsync();
        public Task<LeaveApplicationDTO?> GetByIdAsync(int id);
        Task<LeaveApplication> CreateAsync(LeaveApplicationDTO dto);
        public Task<LeaveApplicationDTO?> UpdateAsync(int id, LeaveApplicationDTO dto);
        Task<bool> DeleteAsync(int id);
    }
}
