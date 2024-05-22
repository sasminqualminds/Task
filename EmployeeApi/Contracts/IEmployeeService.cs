using EmployeeApi.Model;

namespace EmployeeApi.Contracts
{
    public interface IEmployeeService
    {
        List<Employee> GetEmployees();
        Employee GetById(int id);
        Employee AddEmployee(Employee employee);
        string UpdateEmployeeById(int id, Employee employee);
        string DeleteEmployeeById(int id);
    }
}
