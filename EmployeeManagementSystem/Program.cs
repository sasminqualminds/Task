using EmployeeManagementSystem.Interfaces;
using EmployeeManagementSystem.Models;
using EmployeeManagementSystem.Services;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            var ConnectionStrings = builder.Configuration.GetConnectionString("dbcn");
            builder.Services.AddDbContext<EmployeeManagementDbContext>(options => options.UseSqlServer(ConnectionStrings));
            builder.Services.AddScoped<IRole, RoleService>();
            builder.Services.AddScoped<IDepartment, DepartmentService>();
            builder.Services.AddScoped<IEmployee, EmployeeService>();
            builder.Services.AddScoped<ILeaveBalance,LeaveBalanceService>();
            builder.Services.AddScoped<ILeaveApplication, LeaveApplicationService>();
            builder.Services.AddScoped<ILeaves, LeavesService>();
            builder.Services.AddScoped<ILeaveStatus, LeaveStatusService>();
            builder.Services.AddScoped<IAttendance, AttendanceService>();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
