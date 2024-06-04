namespace EmployeeManagementSystem.DTOs
{
    public class RoleDTO
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; } = null!;
        public string CreatedBy { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
    }
}
