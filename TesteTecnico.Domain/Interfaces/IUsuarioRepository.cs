using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteTecnico.Domain.Entities;

namespace TesteTecnico.Domain.Interfaces
{
    public interface IUsuarioRepository
    {
        Task<Usuario> GetById(int id);
        Task<IEnumerable<Usuario>> GetAll();
        void Add(Usuario usuarios);
        void Update(Usuario usuarios);
        void Remove(Usuario usuarios);

    }
}
