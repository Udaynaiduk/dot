using Items.Repository;
using Items.service;
using Microsoft.EntityFrameworkCore;

namespace Items
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

            
            builder.Services.AddDbContext<ItemsContext>(Options => Options.UseSqlServer(builder.Configuration.GetConnectionString("Item")));

            builder.Services.AddScoped<IItemrepository, Itemrepository>();
            builder.Services.AddCors();
            builder.Services.AddScoped<IItemservice,Itemservice>();

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
            app.UseAuthentication();
            app.UseConsul(configuration);

            app.MapControllers();

            app.Run();
        }
    }
}