using EmployeeManagementSystem.DTOs;
using EmployeeManagementSystem.Models;

namespace EmployeeManagementSystem.Interfaces
{
    public interface IDepartment
    {
        public Task<IEnumerable<DepartmentDTO>> GetAllAsync();
        public Task<DepartmentDTO?> GetByIdAsync(int id);
        Task<Department> CreateAsync(DepartmentDTO dto);
        public Task<DepartmentDTO?> UpdateAsync(int Id, DepartmentDTO dto);
        Task<bool> DeleteAsync(int id);
    }
}
