using Cart.Repository;
using Cart.service;
using Microsoft.EntityFrameworkCore;

namespace Cart
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
            builder.Services.AddDbContext<CartContext>(Options => Options.UseSqlServer(builder.Configuration.GetConnectionString("Userstring")));
            builder.Services.AddScoped<ICartRepository,CartRepository>();
            builder.Services.AddScoped<ICartService,CartService>();
            builder.Services.AddConsulConfig(configuration);
            builder.Services.AddControllers();

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseAuthorization();
            app.UseConsul(configuration);

            app.MapControllers();

            app.Run();
        }
    }
}