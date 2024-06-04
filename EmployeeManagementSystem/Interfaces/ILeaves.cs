using EmployeeManagementSystem.DTOs;
using EmployeeManagementSystem.Models;

namespace EmployeeManagementSystem.Interfaces
{
    public interface ILeaves
    {
        public Task<IEnumerable<LeavesDTO>> GetAllAsync();
        public Task<LeavesDTO?> GetByIdAsync(int id);
        Task<Leaf> CreateAsync(LeavesDTO dto);
        public Task<LeavesDTO?> UpdateAsync(int id, LeavesDTO dto);
        Task<bool> DeleteAsync(int id);
        Task CreateAsync(AttendanceDTO attendanceDto);
    }
}
