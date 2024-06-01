using System;
using System.Collections.Generic;

namespace EmployeeManagementSystem.Models
{
    public partial class Department
    {
        public Department()
        {
            Employees = new HashSet<Employee>();
        }

        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; } = null!;
        public string? Description { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
