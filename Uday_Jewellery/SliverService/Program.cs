using Microsoft.EntityFrameworkCore;
using SliverService.Repository;
using SliverService.Service;

namespace SliverService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddDbContext<SliverContext>(Options => Options.UseSqlServer(builder.Configuration.GetConnectionString("goldstring")));
            builder.Services.AddScoped<ISliverRepository, SliverRepository>();
            builder.Services.AddScoped<ISliverService,SliverService1 >();

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}