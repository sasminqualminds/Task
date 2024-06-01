using EmployeeApi.Contracts;
using EmployeeApi.Data;
using EmployeeApi.Model;
using System.Globalization;

namespace EmployeeApi.Services
{
    public class EmployeeService:IEmployeeService
    {
        EmployeeContext _context;
        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
        public EmployeeService(EmployeeContext context)
        {
            _context = context;
        }

        public List<Employee> GetEmployees()
        {
            return _context.Employees.ToList();
        }

        public Employee GetById(int id)
        {
            var employee = _context.Employees.Find(id);
            return employee;
        }

        public string AddEmployee(Employee employee)
        {
            
            if (employee.PhoneNumber.All(char.IsDigit) && employee.PhoneNumber.Length == 10)
            {                
                employee.FirstName = textInfo.ToTitleCase(employee.FirstName);
                employee.LastName = textInfo.ToTitleCase(employee.LastName);                
                _context.Employees.Add(employee);
                _context.SaveChanges();
                return "Employee added successfully";
            }
            else
            {
                return "Enter details in correct format. Phone number must be a 10-digit numeric value";
            }
        }

        public string UpdateEmployeeById(int id, Employee employee)
        {
            var currentEmployee = _context.Employees.Find(id);
            if (currentEmployee != null)
            {
                if (employee.PhoneNumber.All(char.IsDigit) && employee.PhoneNumber.Length == 10)
                {
                    currentEmployee.FirstName = textInfo.ToTitleCase(employee.FirstName);
                    currentEmployee.LastName = textInfo.ToTitleCase(employee.LastName);
                    currentEmployee.Salary = employee.Salary;
                    currentEmployee.DepartmentName = employee.DepartmentName;
                    currentEmployee.PhoneNumber = employee.PhoneNumber;

                    _context.Employees.Update(currentEmployee);
                    _context.SaveChanges();
                    return $"Employee with ID {id} updated successfully";
                }
                else
                {
                    return "enter details in correct format";
                }
            }
            else
            {
                return $"Employee with ID {id} not found";
            }
        }

        public string DeleteEmployeeById(int id)
        {
            var currentEmployee = _context.Employees.Find(id);
            if (currentEmployee != null)
            {
                _context.Remove(currentEmployee);
                _context.SaveChanges();
                return $"Employee with id {id} deleted sucessfully";
            }
            else
            {
                return $"Employee with id {id} not found";
            }
        }       
    }
}
