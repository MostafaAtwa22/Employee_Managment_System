using EMS.API.Dtos;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using MudBlazor;

namespace EMS.WASM.Components.Pages
{
    public partial class CreateOrUpdateEmployee
    {
        [CascadingParameter]
        private IMudDialogInstance MudDialog { get; set; } = default!;

        public EmployeeDto model { get; set; } = new();
        public DateTime? _date { get; set; } = DateTime.Today;

        private async Task OnValidSubmit(EditContext editContext)
        {
            if (_date != null)
            {
                model.DateOfBirth = _date.Value;
            }

            try
            {
                if (model.Id == 0)
                {
                    await EmployeeService.AddEmployeeAsync(model);
                    Snackbar.Add("Employee added successfully!", Severity.Success);
                }
                else
                {
                    await EmployeeService.UpdateEmployeeAsync(model);
                    Snackbar.Add("Employee updated successfully!", Severity.Success);
                }

                MudDialog.Close(DialogResult.Ok(model));
            }
            catch (Exception ex)
            {
                Snackbar.Add($"Operation failed: {ex.Message}", Severity.Error);
            }
        }

        private void Cancel() => MudDialog.Cancel();
    }
}
