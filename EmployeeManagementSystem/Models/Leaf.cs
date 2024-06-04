using System;
using System.Collections.Generic;

namespace EmployeeManagementSystem.Models
{
    public partial class Leaf
    {
        public Leaf()
        {
            Attendances = new HashSet<Attendance>();
            LeaveApplications = new HashSet<LeaveApplication>();
            LeaveBalances = new HashSet<LeaveBalance>();
        }

        public int LeaveTypeId { get; set; }
        public string LeaveTypeName { get; set; } = null!;
        public string? Description { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual ICollection<Attendance> Attendances { get; set; }
        public virtual ICollection<LeaveApplication> LeaveApplications { get; set; }
        public virtual ICollection<LeaveBalance> LeaveBalances { get; set; }
    }
}
