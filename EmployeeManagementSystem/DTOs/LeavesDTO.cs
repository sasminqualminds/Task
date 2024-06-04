namespace EmployeeManagementSystem.DTOs
{
    public class LeavesDTO
    {
        public int LeaveTypeId { get; set; }
        public string LeaveTypeName { get; set; } = null!;
        public string? Description { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
