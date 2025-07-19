using EMS.API.Dtos;

namespace EMS.WASM.Services
{
    public class EmployeeDataService : IEmployeeDataService
    {
        private readonly HttpClient _http;

        public EmployeeDataService(HttpClient http)
        {
            _http = http;
        }
        public async Task<List<EmployeeDto>> GetEmployeesAsync()
            => await _http.GetFromJsonAsync<List<EmployeeDto>>("api/Employee");

        public async Task<EmployeeDto> GetEmployeeByIdAsync(int id)
            => await _http.GetFromJsonAsync<EmployeeDto>($"api/Employee/{id}");

        public async Task AddEmployeeAsync(EmployeeDto employee)
        {
            var response = await _http.PostAsJsonAsync("api/Employee", employee);
            await response.Content.ReadFromJsonAsync<EmployeeDto>();
        }
        public async Task UpdateEmployeeAsync(EmployeeDto employee)
        {
            await _http.PutAsJsonAsync($"api/Employee/{employee.Id}", employee);
        }

        public async Task DeleteEmployeeAsync(int id)
        {
            await _http.DeleteAsync($"api/Employee/{id}");
        }

    }
}
