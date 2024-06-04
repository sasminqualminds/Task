namespace EmployeeManagementSystem.DTOs
{
    public class LeaveBalanceDTO
    {
        public int LeaveBalnceId { get; set; }
        public int? EmployeeId { get; set; }
        public int? LeaveTypeId { get; set; }
        public int Balance { get; set; }
    }
}
