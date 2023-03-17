using Ocelot.DependencyInjection;
using Ocelot.Middleware;

namespace Gateway
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("ocelot.json").Build();


            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddOcelot(configuration);
            builder.Services.AddCors();
            var app = builder.Build();

            app.UseCors(o =>
            {
                o.AllowAnyHeader();
                o.AllowAnyOrigin();
                o.AllowAnyMethod();
            });
            app.MapGet("/", () => "Hello World!");
            //app.MapGet("api/User/Validate",()=> { });
            app.UseOcelot();
            app.Run();
        }
    }
}