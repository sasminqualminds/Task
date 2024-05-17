
// Create employee API, Create Controller, create employee table in SQL,
// Perform CRUD operations using swagger
// employee-table(employeeID(pk),first name, second name, salary, department name, phone number)  

using System.ComponentModel.DataAnnotations;

namespace EmployeeApi.Model
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Salary { get; set; }
        public string DepartmentName { get; set; }
        public string PhoneNumber { get; set; }
    }
}
