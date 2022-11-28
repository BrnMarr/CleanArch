using AutoMapper;
using CleanArch.Application.DTOs;
using CleanArch.Application.Interfaces;
using CleanArch.Domain.Entities;
using CleanArch.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Services
{
    public class UsuarioService : IUsuarioService
    {
        private IUsuarioRepository _usuarioRepository;
        private readonly IMapper _mapper;

        public UsuarioService(IUsuarioRepository usuarioRepository, IMapper mapper)
        {
            _usuarioRepository = usuarioRepository;
            _mapper = mapper;
        }

        public async Task<Usuario> GetUsuarioPorId(int id)
        {
            var usuario = await _usuarioRepository.GetUsuarioPorId(id);

            return usuario;
        }

        public Usuario GetUsuarioLogin(string Email, string Senha)
        {
            var usuario = _usuarioRepository.GetUsuarioLogin(Email, Senha);

            return usuario;
        }

        public Task<IEnumerable<Usuario>> GetUsuariosPorEmpresa(int id)
        {
            throw new NotImplementedException();
        }
    }
}
