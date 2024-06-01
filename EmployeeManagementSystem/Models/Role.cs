using System;
using System.Collections.Generic;

namespace EmployeeManagementSystem.Models
{
    public partial class Role
    {
        public Role()
        {
            Employees = new HashSet<Employee>();
        }

        public int RoleId { get; set; }
        public string RoleName { get; set; } = null!;
        public string CreatedBy { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
