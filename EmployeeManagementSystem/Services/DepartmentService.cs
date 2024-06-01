using EmployeeManagementSystem.DTOs;
using EmployeeManagementSystem.Interfaces;
using EmployeeManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementSystem.Services
{
    public class DepartmentService:IDepartment
    {
        private readonly EmployeeManagementDbContext _context;

        public DepartmentService(EmployeeManagementDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<DepartmentDTO>> GetAllAsync()
        {
            return await _context.Departments
                .Select(d => new DepartmentDTO
                {
                    DepartmentId = d.DepartmentId,
                    DepartmentName = d.DepartmentName,
                    Description = d.Description,
                    CreatedBy = d.CreatedBy,
                    CreatedDate = d.CreatedDate,
                    UpdatedBy = d.UpdatedBy
                })
            .ToListAsync();
        }

        public async Task<DepartmentDTO?> GetByIdAsync(int departmentId)
        {
            return await _context.Departments
            .Where(d => d.DepartmentId == departmentId)
                .Select(d => new DepartmentDTO
                {
                    DepartmentId = d.DepartmentId,
                    DepartmentName = d.DepartmentName,
                    Description = d.Description,
                    CreatedBy = d.CreatedBy,
                    CreatedDate = d.CreatedDate,
                    UpdatedBy = d.UpdatedBy
                })
                .FirstOrDefaultAsync();
        }

        public async Task<Department> CreateAsync(DepartmentDTO departmentDTO)
        {
            var department = new Department
            {
                DepartmentName = departmentDTO.DepartmentName,
                Description = departmentDTO.Description,
                CreatedBy = departmentDTO.CreatedBy,
                UpdatedBy = departmentDTO.UpdatedBy,
                CreatedDate = DateTime.UtcNow
            };

            _context.Departments.Add(department);
            await _context.SaveChangesAsync();
            return department;
        }

        public async Task<DepartmentDTO?> UpdateAsync(int departmentId, DepartmentDTO departmentDTO)
        {
            var existingDepartment = await _context.Departments.FindAsync(departmentId);
            if (existingDepartment == null)
            {
                return null;
            }

            existingDepartment.DepartmentName = departmentDTO.DepartmentName;
            existingDepartment.UpdatedBy = departmentDTO.UpdatedBy;
            existingDepartment.CreatedDate = DateTime.UtcNow;
            existingDepartment.CreatedBy = departmentDTO.CreatedBy;
            existingDepartment.Description= departmentDTO.Description;

            await _context.SaveChangesAsync();
            return new DepartmentDTO
            {
                DepartmentId = existingDepartment.DepartmentId,
                DepartmentName = existingDepartment.DepartmentName,
                CreatedBy = existingDepartment.CreatedBy,
                CreatedDate = existingDepartment.CreatedDate,
                UpdatedBy = existingDepartment.UpdatedBy
            };
        }

        public async Task<bool> DeleteAsync(int departmentId)
        {
            var department = await _context.Departments.FindAsync(departmentId);
            if (department == null)
            {
                return false;
            }

            _context.Departments.Remove(department);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
