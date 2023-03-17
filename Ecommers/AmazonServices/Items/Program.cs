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

           

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddDbContext<ItemsContext>(Options => Options.UseSqlServer(builder.Configuration.GetConnectionString("Item")));

            builder.Services.AddScoped<IItemrepository, Itemrepository>();

            builder.Services.AddScoped<IItemservice,Itemservice>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}