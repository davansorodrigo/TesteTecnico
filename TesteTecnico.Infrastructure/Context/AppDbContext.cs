using Microsoft.EntityFrameworkCore;
using TesteTecnico.Domain.Entities;
using TesteTecnico.Infrastructure.EntityConfiguration;

namespace TesteTecnico.Infrastructure.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }
        public DbSet<Usuario> Usuarios { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new EscolaridadeConfiguration());
            builder.ApplyConfiguration(new UsuarioConfiguration());
            
            //builder.ApplyConfiguration(new UsuarioConfiguration());
        }
    }
}
