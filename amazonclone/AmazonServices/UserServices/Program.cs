using Microsoft.EntityFrameworkCore;
using UserServices.Repository;
using UserServices.Services;

namespace UserServices
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            IConfiguration configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .AddEnvironmentVariables()
                .Build();

            // Add services to the container.

            


            builder.Services.AddDbContext<UserContext>(Options => Options.UseSqlServer(builder.Configuration.GetConnectionString("Userstring")));

            builder.Services.AddScoped<IUserrepository,Userrepository >();
            builder.Services.AddScoped<IUserS,UserS>();
            builder.Services.AddCors();

            builder.Services.AddConsulConfig(configuration);
            builder.Services.AddControllers();
            var app = builder.Build();
            app.UseCors(o =>
            {
                o.AllowAnyHeader();
                o.AllowAnyOrigin();
                o.AllowAnyMethod();
            });
            // Configure the HTTP request pipeline.

            app.UseAuthorization();
            app.UseConsul(configuration);

            app.MapControllers();

            app.Run();
        }
    }
}