using EmployeeApi.Data;
using EmployeeApi.Model;

namespace EmployeeApi.Services
{
    public class EmployeeService
    {
        EmployeeContext _context;
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

        public Employee AddEmployee(Employee employee)
        {
            if (int.TryParse(employee.PhoneNumber, out int phoneNumber) && employee.PhoneNumber.Length == 10)
            {
                employee.FirstName = char.ToUpper(employee.FirstName[0]) + employee.FirstName.Substring(1);
                employee.LastName = char.ToUpper(employee.LastName[0]) + employee.LastName.Substring(1);
                _context.Employees.Add(employee);
                _context.SaveChanges();
                return employee;
            }
            else
            {
                return null;
            }
        }

        public string UpdateEmployeeById(int id, Employee employee)
        {
            var currentEmployee = _context.Employees.Find(id);
            if (currentEmployee != null)
            {
                if (int.TryParse(employee.PhoneNumber, out int phoneNumber) && employee.PhoneNumber.Length == 10)
                {
                    currentEmployee.FirstName = char.ToUpper(employee.FirstName[0]) + employee.FirstName.Substring(1);
                    currentEmployee.LastName = char.ToUpper(employee.LastName[0]) + employee.LastName.Substring(1);
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
                return null;
            }

        }

        public string DeleteEmployeeById(int id)
        {
            var currentEmployee = _context.Employees.Find(id);
            if (currentEmployee != null)
            {
                _context.Remove(currentEmployee);
                _context.SaveChanges();
                return $"Employee with {id} deleted sucessfully";
            }
            else
            {
                return null;
            }

        }
    }
}
