using EMS.API.Dtos;

namespace EMS.WASM.Services
{
    public interface IEmployeeDataService
    {
        Task<List<EmployeeDto>> GetEmployeesAsync();
        Task<EmployeeDto> GetEmployeeByIdAsync(int id);
        Task AddEmployeeAsync(EmployeeDto employee);
        Task UpdateEmployeeAsync(EmployeeDto employee);
        Task DeleteEmployeeAsync(int id);
    }
}
