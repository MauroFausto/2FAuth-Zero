using _2FA_Zero.Interfaces;
using _2FA_Zero.Repository;
using System.Runtime.CompilerServices;

namespace _2FA_Zero
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }

    public static class ConfigurePersistanceServices
    {
        public static IServiceCollection ConfigureMySQL(this IServiceCollection services)
        {
            services.AddScoped(IAuthentication, AuthenticationRepository);

            return services;
        }

        public static IServiceCollection ConfigurePostGreSQL(this IServiceCollection services)
        {
            return services;
        }
        
        public static IServiceCollection ConfigureOracle(this IServiceCollection services)
        {
            return services;
        }

        public static IServiceCollection ConfigureSQLServer(this IServiceCollection services)
        {
            return services;
        }
    }
}