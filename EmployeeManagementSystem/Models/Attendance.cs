using System;
using System.Collections.Generic;

namespace EmployeeManagementSystem.Models
{
    public partial class Attendance
    {
        public int AttendanceId { get; set; }
        public int? EmployeeId { get; set; }
        public int? LeaveTypeId { get; set; }
        public DateTime DateOfLog { get; set; }
        public DateTime? TimeIn { get; set; }
        public DateTime? TimeOut { get; set; }
        public DateTime? LateTime { get; set; }

        public virtual Employee? Employee { get; set; }
        public virtual Leaf? LeaveType { get; set; }
    }
}
