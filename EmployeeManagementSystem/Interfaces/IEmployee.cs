using EmployeeManagementSystem.Models;
using EmployeeManagementSystem.DTOs;

namespace EmployeeManagementSystem.Interfaces
{
    public interface IEmployee
    {
        public Task<IEnumerable<EmployeeDTO>> GetAllAsync();
        public Task<EmployeeDTO?> GetByIdAsync(int employeeId);
        Task<Employee> CreateAsync(EmployeeDTO employeeDto);
        public Task<EmployeeDTO?> UpdateAsync(int employeeId, EmployeeDTO employeeDto);
        Task<bool> DeleteAsync(int employeeId);
    }
}
