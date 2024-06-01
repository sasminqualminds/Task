using System;
using System.Collections.Generic;

namespace EmployeeManagementSystem.Models
{
    public partial class LeaveApplication
    {
        public int LeaveApplicationId { get; set; }
        public int? EmployeeId { get; set; }
        public int? LeaveTypeId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Purpose { get; set; } = null!;
        public int NoOfDays { get; set; }
        public DateTime DateOfApplication { get; set; }
        public DateTime DateOfApproval { get; set; }
        public int? StatusId { get; set; }

        public virtual Employee? Employee { get; set; }
        public virtual Leaf? LeaveType { get; set; }
        public virtual LeaveStatus? Status { get; set; }
    }
}
