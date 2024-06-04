using EmployeeManagementSystem.DTOs;
using EmployeeManagementSystem.Interfaces;
using EmployeeManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementSystem.Services
{
    public class LeaveBalanceService:ILeaveBalance
    {
        private EmployeeManagementDbContext _context;

        public LeaveBalanceService(EmployeeManagementDbContext context)
        {
            _context = context;
        }
        public async Task<LeaveBalance> CreateAsync(LeaveBalanceDTO dto)
        {
            var leaveBalance = new LeaveBalance()
            {
                EmployeeId = dto.EmployeeId,
                LeaveTypeId = dto.LeaveTypeId,
                Balance = dto.Balance,
                


            };
            _context.Add(leaveBalance);
            await _context.SaveChangesAsync();
            return leaveBalance;


        }

        public async Task<bool> DeleteAsync(int id)
        {

            var leaveBalance = await _context.LeaveBalances.FindAsync(id);
            if (leaveBalance == null)
            {
                return false;
            }
            _context.Remove(leaveBalance);
            return true;
        }

        public async Task<IEnumerable<LeaveBalanceDTO>> GetAllAsync()
        {
            var leaveBalanceDto = _context.LeaveBalances.Select(l => new LeaveBalanceDTO
            {
                LeaveBalnceId=l.LeaveBalnceId,
                LeaveTypeId=l.LeaveTypeId,
                Balance = l.Balance,
                EmployeeId = l.EmployeeId,

            });
            return await leaveBalanceDto.ToListAsync();
        }

        public async Task<LeaveBalanceDTO?> GetByIdAsync(int id)
        {
            return await _context.LeaveBalances
            .Where(a => a.LeaveBalnceId == id)
                .Select(d => new LeaveBalanceDTO
                {
                   EmployeeId= d.EmployeeId,
                   LeaveTypeId = d.LeaveTypeId,
                   Balance= d.Balance,
 
                })
                .FirstOrDefaultAsync();
        }

        public async Task<LeaveBalanceDTO?> UpdateAsync(int id, LeaveBalanceDTO dto)
        {

            var existingLeaveBalance = await _context.LeaveBalances.FindAsync(id);
            if (existingLeaveBalance == null)
            {
                return null;
            }

            existingLeaveBalance.EmployeeId = dto.EmployeeId;
            existingLeaveBalance.LeaveTypeId = dto.LeaveTypeId;
            existingLeaveBalance.Balance = dto.Balance;

            await _context.SaveChangesAsync();
            return new LeaveBalanceDTO
            {
                EmployeeId = existingLeaveBalance.EmployeeId,
                LeaveTypeId= existingLeaveBalance.LeaveTypeId,
                Balance = existingLeaveBalance.Balance,
            };
        }

    }
}
