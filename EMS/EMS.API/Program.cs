
using EMS.API.Data;
using EMS.API.Services;
using Microsoft.EntityFrameworkCore;
namespace EMS.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            
            builder.Services.AddScoped<IEmployeeService, EmployeeService>();

            builder.Services.AddSwaggerGen();
            var constr = builder.Configuration.GetConnectionString("Default")
                ?? throw new InvalidOperationException("No Connection String");

            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(constr)
            );

            builder.Services.AddCors(
                opt => opt.AddPolicy("MyPolicy",
                policyOpt => policyOpt.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod()
            ));
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseCors("MyPolicy");

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
