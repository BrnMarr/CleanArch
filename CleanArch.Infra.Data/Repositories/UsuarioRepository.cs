using CleanArch.Domain.Entities;
using CleanArch.Domain.Interfaces;
using CleanArch.Infra.Data.Context;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CleanArch.Infra.Data.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        ApplicationDbContext _usuarioRepository;
        public UsuarioRepository(ApplicationDbContext context)
        {
            _usuarioRepository = context;
        }

        public async Task<Usuario> GetUsuarioPorId(int id)
        {
            return await _usuarioRepository.Usuario.FindAsync(id);
        }


        public Usuario GetUsuarioLogin(string Email, string Senha)
        {           
            var usuario =  _usuarioRepository.Usuario
                .Include(x => x.Empresa)
                .Where(x => x.Email == Email && x.Senha == Senha).FirstOrDefault();
           
            return usuario;
        }

        public Task<IEnumerable<Usuario>> GetUsuariosPorEmpresa(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
