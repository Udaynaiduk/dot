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
            builder.Services.AddDbContext<VendorContext>(Options => Options.UseSqlServer(builder.Configuration.GetConnectionString("Userstring")));

            builder.Services.AddScoped<IVendorrepository, Vendorrepository>();

            builder.Services.AddScoped<IVendorservice, Vendorservice>();
            // Add services to the container.

            builder.Services.AddControllers();

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}