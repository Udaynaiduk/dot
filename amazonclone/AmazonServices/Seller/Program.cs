using Microsoft.EntityFrameworkCore;
using Seller.Repository;
using Seller.Service;

namespace Seller
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            IConfiguration configuration=new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .AddEnvironmentVariables()
                .Build();
            builder.Services.AddDbContext<VendorContext>(Options => Options.UseSqlServer(builder.Configuration.GetConnectionString("Userstring")));

            builder.Services.AddScoped<IVendorrepository, Vendorrepository>();
            builder.Services.AddCors();
            builder.Services.AddScoped<IVendorservice, Vendorservice>();

            // Add services to the container.
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