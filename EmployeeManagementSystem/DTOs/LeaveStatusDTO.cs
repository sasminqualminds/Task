namespace EmployeeManagementSystem.DTOs
{
    public class LeaveStatusDTO
    {
        public int StatusId { get; set; }
        public string Status { get; set; } = null!;
        public string? Description { get; set; }
    }
}
