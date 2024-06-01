using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EmployeeManagementSystem.Models
{
    public partial class EmployeeManagementDbContext : DbContext
    {
        public EmployeeManagementDbContext()
        {
        }

        public EmployeeManagementDbContext(DbContextOptions<EmployeeManagementDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Attendance> Attendances { get; set; } = null!;
        public virtual DbSet<Department> Departments { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<Leaf> Leaves { get; set; } = null!;
        public virtual DbSet<LeaveApplication> LeaveApplications { get; set; } = null!;
        public virtual DbSet<LeaveBalance> LeaveBalances { get; set; } = null!;
        public virtual DbSet<LeaveStatus> LeaveStatuses { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<Shift> Shifts { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Attendance>(entity =>
            {
                entity.ToTable("Attendance");

                entity.Property(e => e.DateOfLog).HasColumnType("datetime");

                entity.Property(e => e.LateTime).HasColumnType("datetime");

                entity.Property(e => e.TimeIn).HasColumnType("datetime");

                entity.Property(e => e.TimeOut)
                    .HasColumnType("datetime")
                    .HasColumnName("Time_Out");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Attendances)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK__Attendanc__Emplo__300424B4");

                entity.HasOne(d => d.LeaveType)
                    .WithMany(p => p.Attendances)
                    .HasForeignKey(d => d.LeaveTypeId)
                    .HasConstraintName("FK__Attendanc__Leave__30F848ED");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DepartmentName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Contact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmailId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Salary).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK__Employees__Depar__2C3393D0");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK__Employees__RoleI__2D27B809");
            });

            modelBuilder.Entity<Leaf>(entity =>
            {
                entity.HasKey(e => e.LeaveTypeId)
                    .HasName("PK__Leaves__43BE8F147904346C");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LeaveTypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<LeaveApplication>(entity =>
            {
                entity.ToTable("LeaveApplication");

                entity.Property(e => e.DateOfApplication).HasColumnType("datetime");

                entity.Property(e => e.DateOfApproval).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Purpose)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.LeaveApplications)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK__LeaveAppl__Emplo__37A5467C");

                entity.HasOne(d => d.LeaveType)
                    .WithMany(p => p.LeaveApplications)
                    .HasForeignKey(d => d.LeaveTypeId)
                    .HasConstraintName("FK__LeaveAppl__Leave__38996AB5");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.LeaveApplications)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK__LeaveAppl__Statu__398D8EEE");
            });

            modelBuilder.Entity<LeaveBalance>(entity =>
            {
                entity.HasKey(e => e.LeaveBalnceId)
                    .HasName("PK__LeaveBal__680DA4C3A127C682");

                entity.ToTable("LeaveBalance");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.LeaveBalances)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK__LeaveBala__Emplo__33D4B598");

                entity.HasOne(d => d.LeaveType)
                    .WithMany(p => p.LeaveBalances)
                    .HasForeignKey(d => d.LeaveTypeId)
                    .HasConstraintName("FK__LeaveBala__Leave__34C8D9D1");
            });

            modelBuilder.Entity<LeaveStatus>(entity =>
            {
                entity.HasKey(e => e.StatusId)
                    .HasName("PK__LeaveSta__C8EE20632EB40FB4");

                entity.ToTable("LeaveStatus");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.RoleName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Shift>(entity =>
            {
                entity.ToTable("Shift");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.ShiftName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StartTime).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
