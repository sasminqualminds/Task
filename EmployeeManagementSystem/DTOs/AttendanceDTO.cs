namespace EmployeeManagementSystem.DTOs
{
    public class AttendanceDTO
    {
        public int AttendanceId { get; set; }
        public int? EmployeeId { get; set; }
        public int? LeaveTypeId { get; set; }
        public DateTime DateOfLog { get; set; }
        public DateTime? TimeIn { get; set; }
        public DateTime? TimeOut { get; set; }
        public DateTime? LateTime { get; set; }
    }
}
