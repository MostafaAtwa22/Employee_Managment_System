using EMS.API.Dtos;
using Microsoft.AspNetCore.Components.Web;
using MudBlazor;
using static MudBlazor.CategoryTypes;


namespace EMS.WASM.Components.Pages
{
    public partial class Home
    {
        MudDataGrid<EmployeeDto> dataGrid;
        string searchString = null;
        private List<EmployeeDto> Employees = new List<EmployeeDto>();
        /// <summary>
        /// Here we simulate getting the paged, filtered and ordered data from the server
        /// </summary>
        private async Task<GridData<EmployeeDto>> ServerReload(GridState<EmployeeDto> state)
        {
            IEnumerable<EmployeeDto> data = Employees;
            await Task.Delay(300);
            data = data.Where(element =>
            {
                if (string.IsNullOrWhiteSpace(searchString))
                    return true;
                if (element.Department.Contains(searchString, StringComparison.OrdinalIgnoreCase))
                    return true;
                if (element.Name.Contains(searchString, StringComparison.OrdinalIgnoreCase))
                    return true;
                if (element.EmployeeIdField.Contains(searchString, StringComparison.OrdinalIgnoreCase))
                    return true;
                return false;
            }).ToArray();
            var totalItems = data.Count();

            var sortDefinition = state.SortDefinitions.FirstOrDefault();
            if (sortDefinition != null)
            {
                switch (sortDefinition.SortBy)
                {
                    case nameof(EmployeeDto.EmployeeIdField):
                        data = data.OrderByDirection(
                            sortDefinition.Descending ? SortDirection.Descending : SortDirection.Ascending,
                            o => o.EmployeeIdField
                        );
                        break;
                    case nameof(EmployeeDto.Name):
                        data = data.OrderByDirection(
                            sortDefinition.Descending ? SortDirection.Descending : SortDirection.Ascending,
                            o => o.Name
                        );
                        break;
                    case nameof(EmployeeDto.Age):
                        data = data.OrderByDirection(
                            sortDefinition.Descending ? SortDirection.Descending : SortDirection.Ascending,
                            o => o.Age
                        );
                        break;
                    case nameof(EmployeeDto.DateOfBirth):
                        data = data.OrderByDirection(
                            sortDefinition.Descending ? SortDirection.Descending : SortDirection.Ascending,
                            o => o.DateOfBirth
                        );
                        break;
                    case nameof(EmployeeDto.Department):
                        data = data.OrderByDirection(
                            sortDefinition.Descending ? SortDirection.Descending : SortDirection.Ascending,
                            o => o.Department
                        );
                        break;
                    case nameof(EmployeeDto.PhoneNumber):
                        data = data.OrderByDirection(
                            sortDefinition.Descending ? SortDirection.Descending : SortDirection.Ascending,
                            o => o.PhoneNumber
                        );
                        break;
                    default:
                        var sortByColumn = dataGrid.RenderedColumns.First(c => c.PropertyName == sortDefinition.SortBy);
                        switch (sortByColumn.Title)
                        {
                            case nameof(EmployeeDto.Name):
                                data = data.OrderByDirection(
                                    sortDefinition.Descending ? SortDirection.Descending : SortDirection.Ascending,
                                    o => o.Name
                                );
                                break;
                        }
                        break;
                }
            }

            var pagedData = data.Skip(state.Page * state.PageSize).Take(state.PageSize).ToArray();
            return new GridData<EmployeeDto>
            {
                TotalItems = totalItems,
                Items = pagedData
            };
        }

        private Task OnSearch(string text)
        {
            searchString = text;
            return dataGrid.ReloadServerData();
        }

        protected override async Task OnInitializedAsync()
        {
            Employees = await EmployeeService.GetEmployeesAsync();
        }

        private async Task CreateNewEmployee()
        {
            var options = new DialogOptions
            {
                MaxWidth = MaxWidth.Large
            };

            var dialog = await DialogService.ShowAsync<CreateOrUpdateEmployee>("Create New Employee", options);
            var result = await dialog.Result;

            if (result is not null && !result.Canceled)
            {
               await dataGrid.ReloadServerData();
            }
        }
    }
}
