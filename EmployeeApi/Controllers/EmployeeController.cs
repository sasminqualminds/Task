using EmployeeApi.Data;
using EmployeeApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        EmployeeContext _context;
        public EmployeeController(EmployeeContext context) { 
            _context = context;
        }

        // Get request to get all employees
        [HttpGet]
        public List<Employee> GetAllEmployees()
        {
            return _context.Employees.ToList();
        }

        // Get request to get an single employee data by employeeId
        [HttpGet("{id}")]
        public Employee GetEmployeeById(int id)
        {
            var employee = _context.Employees.Find(id);
            if(employee == null)
            {
                return null;
            }
            else
            {
                return employee;
            }
        }


        // Post request to Add an employee record
        [HttpPost]
        public string AddEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return "Employee added";
        }

        // Put request to update an employee record by Id
        [HttpPut]
        public string UpdateEmployee(int id,Employee employee)
        {
            var _employee = _context.Employees.Find(id);
            if (_employee == null)
            {
                return $"EMployee with {id} not found";
            }
            else
            {
                _employee.FirstName = employee.FirstName;
                _employee.LastName = employee.LastName;
                _employee.Salary= employee.Salary;
                _employee.PhoneNumber = employee.PhoneNumber;
                _employee.DepartmentName = employee.DepartmentName;
                _context.SaveChanges();
                return $"EMployee with {id} updated";
            }
        }

        // Delete request to delete an employee record
        [HttpDelete]
        public string DeleteEmployee(int id)
        {

            var employee = _context.Employees.Find(id);
            if (employee == null)
            {
                return $"EMployee with {id} not found";
            }
            else
            {
                _context.Employees.Remove(employee);
                _context.SaveChanges();
                return $"EMployee with {id} deleted";
            }
        }
    }
}
