using EmployeeManagementSystem.DTOs;
using EmployeeManagementSystem.Models;

namespace EmployeeManagementSystem.Interfaces
{
    public interface IRole
    {
        public Task<IEnumerable<RoleDTO>> GetAllAsync();
        public Task<RoleDTO?> GetByIdAsync(int roleId);
        public Task<Role> CreateAsync(RoleDTO roleDto);
        public Task<RoleDTO?> UpdateAsync(int roleId, RoleDTO roleDto);

        public Task<bool> DeleteAsync(int roleId);
    }
}
