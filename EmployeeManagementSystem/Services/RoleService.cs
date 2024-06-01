using EmployeeManagementSystem.DTOs;
using EmployeeManagementSystem.Interfaces;
using EmployeeManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementSystem.Services
{
    public class RoleService:IRole
    {
        private readonly EmployeeManagementDbContext _context;

        public RoleService(EmployeeManagementDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<RoleDTO>> GetAllAsync()
        {
            return await _context.Roles
                .Select(r => new RoleDTO
                {
                    RoleId = r.RoleId,
                    RoleName = r.RoleName,
                    CreatedBy = r.CreatedBy,
                    CreatedDate = r.CreatedDate,
                    UpdatedBy = r.UpdatedBy
                })
            .ToListAsync();
        }

        public async Task<RoleDTO?> GetByIdAsync(int roleId)
        {
            return await _context.Roles
            .Where(r => r.RoleId == roleId)
                .Select(r => new RoleDTO
                {
                    RoleId = r.RoleId,
                    RoleName = r.RoleName,
                    CreatedBy = r.CreatedBy,
                    CreatedDate = r.CreatedDate,
                    UpdatedBy = r.UpdatedBy
                })
                .FirstOrDefaultAsync();
        }

        public async Task<Role> CreateAsync(RoleDTO roleDto)
        {
            var role = new Role
            {
                RoleName = roleDto.RoleName,
                CreatedBy = roleDto.CreatedBy,
                UpdatedBy=roleDto.UpdatedBy,
                CreatedDate = DateTime.UtcNow
            };

            _context.Roles.Add(role);
            await _context.SaveChangesAsync();
            return role;
        }

        public async Task<RoleDTO?> UpdateAsync(int roleId, RoleDTO roleDto)
        {
            var existingRole = await _context.Roles.FindAsync(roleId);
            if (existingRole == null)
            {
                return null;
            }

            existingRole.RoleName = roleDto.RoleName;
            existingRole.UpdatedBy = roleDto.UpdatedBy;
            existingRole.CreatedDate = DateTime.UtcNow;
            existingRole.CreatedBy = roleDto.CreatedBy;

            await _context.SaveChangesAsync();
            return new RoleDTO
            {
                RoleId = existingRole.RoleId,
                RoleName = existingRole.RoleName,
                CreatedBy = existingRole.CreatedBy,
                CreatedDate = existingRole.CreatedDate,
                UpdatedBy = existingRole.UpdatedBy
            };
        }

        public async Task<bool> DeleteAsync(int roleId)
        {
            var role = await _context.Roles.FindAsync(roleId);
            if (role == null)
            {
                return false;
            }

            _context.Roles.Remove(role);
            await _context.SaveChangesAsync();
            return true;
        }

        
    }
}
