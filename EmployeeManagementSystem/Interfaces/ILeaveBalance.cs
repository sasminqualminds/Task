using EmployeeManagementSystem.DTOs;
using EmployeeManagementSystem.Models;

namespace EmployeeManagementSystem.Interfaces
{
    public interface ILeaveBalance
    {
        public Task<IEnumerable<LeaveBalanceDTO>> GetAllAsync();
        public Task<LeaveBalanceDTO?> GetByIdAsync(int id);
        Task<LeaveBalance> CreateAsync(LeaveBalanceDTO dto);
        public Task<LeaveBalanceDTO?> UpdateAsync(int id, LeaveBalanceDTO dto);
        Task<bool> DeleteAsync(int id);
    }
}
