using System;
using System.Collections.Generic;

namespace EmployeeManagementSystem.Models
{
    public partial class LeaveBalance
    {
        public int LeaveBalnceId { get; set; }
        public int? EmployeeId { get; set; }
        public int? LeaveTypeId { get; set; }
        public int Balance { get; set; }

        public virtual Employee? Employee { get; set; }
        public virtual Leaf? LeaveType { get; set; }
    }
}
