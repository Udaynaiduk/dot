using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using Ocelot.Provider.Consul;

namespace ConsulGateway
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IConfiguration configuration = new ConfigurationBuilder()
                .AddJsonFile("ConsulOcelot.json")
                .Build();
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddOcelot(configuration).AddConsul();
            builder.Services.AddCors();
            var app = builder.Build();
            app.UseCors(o =>
            {
                o.AllowAnyHeader();
                o.AllowAnyOrigin();
                o.AllowAnyMethod();
            });

            app.MapGet("/", () => "Hello World!");
            app.UseOcelot();

            app.Run();
        }
    }
}