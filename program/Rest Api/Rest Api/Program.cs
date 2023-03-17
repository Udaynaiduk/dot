using Microsoft.EntityFrameworkCore;
using Rest_Api.Controllers.GoldRepositroy;
using Rest_Api.Repositroy;

namespace Rest_Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<JewelleryContext>(Options => Options.UseSqlServer(@"server=WIN-RAAV6KLNV17\SQLEXPRESS ;Initial Catalog =Jewellery;User Id =sa;Password=pass@123"));
            // Add services to the container.
            builder.Services.AddScoped<IGoldRepository,GoldRepository>();
            builder.Services.AddCors();
            builder.Services.AddControllers();

            var app = builder.Build();
            app.UseCors(option =>
            {
                option.AllowAnyOrigin();
                option.AllowAnyHeader();
                option.AllowAnyMethod();
            }
            );
            // Configure the HTTP request pipeline.

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}