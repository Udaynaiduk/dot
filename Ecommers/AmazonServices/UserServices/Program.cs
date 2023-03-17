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

            // Add services to the container.

            builder.Services.AddControllers();


            builder.Services.AddDbContext<UserContext>(Options => Options.UseSqlServer(builder.Configuration.GetConnectionString("Userstring")));

            builder.Services.AddScoped<IUserrepository,Userrepository >();
            builder.Services.AddScoped<IUserS,UserS>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}