using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TesteTecnico.Domain.Entities;
using TesteTecnico.Domain.Interfaces;
using TesteTecnico.Infrastructure.Context;

namespace TesteTecnico.Infrastructure.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        protected readonly AppDbContext db;
        public UsuarioRepository(AppDbContext context)
        {
            db = context;
        }
        public async Task<Usuario> GetById(int id)
        {
            return await db.Usuarios.Include(x => x.Escolaridade).FirstOrDefaultAsync(i => i.Id == id);
        }
        public async Task<IEnumerable<Usuario>> GetAll()
        {
            return await db.Usuarios.Include(x => x.Escolaridade).ToListAsync();
        }
        public void Add(Usuario usuario)
        {
            db.Usuarios.Add(usuario);
            db.SaveChanges();
        }
        public void Update(Usuario usuario)
        {
            db.Usuarios.Update(usuario);
            db.SaveChanges();
        }
        public void Remove(Usuario usuario)
        {
            db.Usuarios.Remove(usuario);
            db.SaveChanges();
        }
        public void Dispose()
        {
            db.Dispose();
        }
    }
}
