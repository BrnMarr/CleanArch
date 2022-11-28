using CleanArch.Application.DTOs;
using CleanArch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Interfaces
{
    public interface IUsuarioService
    {
        Task<Usuario> GetUsuarioPorId(int id);

        Usuario GetUsuarioLogin(string Email, string Senha);

        Task<IEnumerable<Usuario>> GetUsuariosPorEmpresa(int id);



    }
}
