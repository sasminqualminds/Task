using EmployeeManagementSystem.DTOs;
using EmployeeManagementSystem.Models;

namespace EmployeeManagementSystem.Interfaces
{
    public interface IAttendance
    {
        public Task<IEnumerable<AttendanceDTO>> GetAllAsync();
        public Task<AttendanceDTO?> GetByIdAsync(int id);
        Task<Attendance> CreateAsync(AttendanceDTO dto);
        public Task<AttendanceDTO?> UpdateAsync(int id, AttendanceDTO dto);
        Task<bool> DeleteAsync(int id);
    }
}
