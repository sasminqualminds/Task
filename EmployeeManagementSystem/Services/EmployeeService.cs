using EmployeeManagementSystem.Interfaces;
using EmployeeManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using EmployeeManagementSystem.DTOs;

namespace EmployeeManagementSystem.Services
{
    public class EmployeeService:IEmployee
    {
        private readonly EmployeeManagementDbContext _context;

        public EmployeeService(EmployeeManagementDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<EmployeeDTO>> GetAllAsync()
        {
            return await _context.Employees
                .Select(e => new EmployeeDTO
                {
                    EmployeeId = e.EmployeeId,
                    FirstName = e.FirstName,
                    LastName = e.LastName,
                    EmailId = e.EmailId,
                    Contact = e.Contact,
                    Address = e.Address,
                    Salary = e.Salary,
                    DepartmentId = e.DepartmentId,
                    RoleId = e.RoleId
                })
                .ToListAsync();
        }

        public async Task<EmployeeDTO?> GetByIdAsync(int employeeId)
        {
            return await _context.Employees
                .Where(e => e.EmployeeId == employeeId)
                .Select(e => new EmployeeDTO
                {
                    EmployeeId = e.EmployeeId,
                    FirstName = e.FirstName,
                    LastName = e.LastName,
                    EmailId = e.EmailId,
                    Contact = e.Contact,
                    Address = e.Address,
                    Salary = e.Salary,
                    DepartmentId = e.DepartmentId,
                    RoleId = e.RoleId
                })
                .FirstOrDefaultAsync();
        }

        public async Task<Employee> CreateAsync(EmployeeDTO employeeDto)
        {
            var employee = new Employee
            {
                FirstName = employeeDto.FirstName,
                LastName = employeeDto.LastName,
                EmailId = employeeDto.EmailId,
                Contact = employeeDto.Contact,
                Address = employeeDto.Address,
                Salary = employeeDto.Salary,
                DepartmentId = employeeDto.DepartmentId,
                RoleId = employeeDto.RoleId
            };

            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();
            return employee;
        }

        public async Task<EmployeeDTO?> UpdateAsync(int employeeId, EmployeeDTO employeeDto)
        {
            var existingEmployee = await _context.Employees.FindAsync(employeeId);
            if (existingEmployee == null)
            {
                return null;
            }

            existingEmployee.FirstName = employeeDto.FirstName;
            existingEmployee.LastName = employeeDto.LastName;
            existingEmployee.EmailId = employeeDto.EmailId;
            existingEmployee.Contact = employeeDto.Contact;
            existingEmployee.Address = employeeDto.Address;
            existingEmployee.Salary = employeeDto.Salary;
            existingEmployee.DepartmentId = employeeDto.DepartmentId;
            existingEmployee.RoleId = employeeDto.RoleId;

            await _context.SaveChangesAsync();
            return new EmployeeDTO
            {
                EmployeeId = existingEmployee.EmployeeId,
                FirstName = existingEmployee.FirstName,
                LastName = existingEmployee.LastName,
                EmailId = existingEmployee.EmailId,
                Contact = existingEmployee.Contact,
                Address = existingEmployee.Address,
                Salary = existingEmployee.Salary,
                DepartmentId = existingEmployee.DepartmentId,
                RoleId = existingEmployee.RoleId
            };
        }

        public async Task<bool> DeleteAsync(int employeeId)
        {
            var employee = await _context.Employees.FindAsync(employeeId);
            if (employee == null)
            {
                return false;
            }

            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();
            return true;
        }

       
    }
}


