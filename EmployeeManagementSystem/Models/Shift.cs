using System;
using System.Collections.Generic;

namespace EmployeeManagementSystem.Models
{
    public partial class Shift
    {
        public int ShiftId { get; set; }
        public string ShiftName { get; set; } = null!;
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
