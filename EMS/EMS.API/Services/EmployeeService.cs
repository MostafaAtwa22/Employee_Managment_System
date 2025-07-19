using EMS.API.Data;
using EMS.API.Dtos;
using EMS.Shared;
using Microsoft.EntityFrameworkCore;

namespace EMS.API.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly ApplicationDbContext _context;

        public EmployeeService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<EmployeeDto>> GetAllEmployeesAsync()
        {
            var employees = await _context.Employees.ToListAsync();
            return employees
                .OrderBy(e => e.Name)
                .Select(MapToDto);
        }

        public async Task<EmployeeDto?> GetEmployeeByIdAsync(int id)
        {
            var employee = await _context.Employees.FindAsync(id);
            return employee != null! ? MapToDto(employee) : null!;
        }

        public async Task<EmployeeDto> CreateEmployeeAsync(EmployeeDto employeeDto)
        {
            var employee = MapToEntity(employeeDto);
            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();
            return MapToDto(employee);
        }

        public async Task<EmployeeDto> UpdateEmployeeAsync(EmployeeDto employeeDto)
        {
            var existingEmployee = await _context.Employees.FindAsync(employeeDto.Id);
            if (existingEmployee == null)
                return null!;

            // Update properties
            existingEmployee.Name = employeeDto.Name;
            existingEmployee.Department = employeeDto.Department;
            existingEmployee.DateOfBirth = employeeDto.DateOfBirth;
            existingEmployee.Age = employeeDto.Age;
            existingEmployee.PhoneNumber = employeeDto.PhoneNumber;

            await _context.SaveChangesAsync();
            return MapToDto(existingEmployee);
        }

        public async Task<bool> DeleteEmployeeAsync(int id)
        {
            var employee = await _context.Employees.FindAsync(id);
            if (employee == null)
                return false;

            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();
            return true;
        }

        private static EmployeeDto MapToDto(Employee employee)
        {
            return new EmployeeDto
            {
                Id = employee.Id,
                Name = employee.Name,
                Department = employee.Department,
                DateOfBirth = employee.DateOfBirth,
                Age = employee.Age,
                PhoneNumber = employee.PhoneNumber
            };
        }

        private static Employee MapToEntity(EmployeeDto employeeDto)
        {
            return new Employee
            {
                Id = employeeDto.Id,
                Name = employeeDto.Name,
                Department = employeeDto.Department,
                DateOfBirth = employeeDto.DateOfBirth,
                Age = employeeDto.Age,
                PhoneNumber = employeeDto.PhoneNumber
            };
        }
    }
} 