namespace EmployeeManagementSystem.DTOs
{
    public class LeaveApplicationDTO
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
    }
}
