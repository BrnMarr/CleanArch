using CleanArch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Interfaces
{
    public interface IUsuarioRepository
    {
        Task<Usuario> GetUsuarioPorId(int id);

        Usuario GetUsuarioLogin(string Email, string Senha);

        Task<IEnumerable<Usuario>> GetUsuariosPorEmpresa(int id);

    }
}
