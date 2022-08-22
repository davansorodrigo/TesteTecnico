using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TesteTecnico.Infrastructure.Context;
using TesteTecnico.Domain.Interfaces;
using TesteTecnico.Infrastructure.Repositories;

namespace TesteTecnico.CrossCutting
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services,
           IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnection"),
                    b => b.MigrationsAssembly(typeof(AppDbContext)
                            .Assembly.FullName)));
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            return services;
        }
    }
}
