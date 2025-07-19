using EMS.API.Dtos;

namespace EMS.API.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<EmployeeDto>> GetAllEmployeesAsync();
        Task<EmployeeDto?> GetEmployeeByIdAsync(int id);
        Task<EmployeeDto> CreateEmployeeAsync(EmployeeDto employee);
        Task<EmployeeDto> UpdateEmployeeAsync(EmployeeDto employee);
        Task<bool> DeleteEmployeeAsync(int id);
    }
}
