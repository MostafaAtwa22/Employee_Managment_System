using EMS.WASM.Components;
using EMS.WASM.Services;
using Microsoft.AspNetCore.Components.Server;
using MudBlazor.Services;

namespace EMS.WASM
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();

            builder.Services.Configure<CircuitOptions>(options =>
            {
                options.DetailedErrors = true;
            });

            builder.Services.AddMudServices();
            builder.Services.AddHttpClient<IEmployeeDataService, EmployeeDataService>((sp, client) =>
            {
                client.BaseAddress = new Uri(sp.GetRequiredService<IConfiguration>()["Ip"]!);
            });
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();
            app.UseAntiforgery();

            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode();

            app.Run();
        }
    }
}
