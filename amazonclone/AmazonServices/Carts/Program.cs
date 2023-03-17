using Carts.Repository;
using Carts.service;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Serilog;
using System.Text;

namespace Carts
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
            var log = new LoggerConfiguration().WriteTo.File(@"C:\Users\VMUser\Desktop\Amazon.log",rollingInterval:RollingInterval.Day).CreateLogger();
            builder.Logging.AddSerilog(log);

            // Add services to the container.
            builder.Services.AddDbContext<CartContext>(Options => Options.UseSqlServer(builder.Configuration.GetConnectionString("Userstring")));
            builder.Services.AddScoped<ICartRepository, CartRepository>();
            builder.Services.AddScoped<ICartService, CartService>();
            builder.Services.AddCors();
            builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                            .AddJwtBearer(options =>
                            {
                                options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters()
                                {
                                    ValidateIssuer = true,
                                    ValidateAudience = true,
                                    ValidateLifetime = true,
                                    ValidateIssuerSigningKey = true,
                                    ValidIssuer = configuration["Jwt:Issuer"],
                                    ValidAudience = configuration["Jwt:Audience"],
                                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"]))
                                };
                            });


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

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseConsul(configuration);

            app.MapControllers();

            app.Run();
        }
    }
}