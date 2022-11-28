using CleanArch.Domain.Entities;
using CleanArch.Domain.Interfaces;
using CleanArch.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infra.Data.Repositories
{
    public class PerfilRepository : IPerfilRepository
    {
        ApplicationDbContext _perfilRepository;

        public PerfilRepository(ApplicationDbContext perfilRepository)
        {
            _perfilRepository = perfilRepository;
        }
            
        public Perfil GetPerfil(int id)
        {
            var perfil = _perfilRepository.Perfil.Where(x => x.idUsuario == id).FirstOrDefault();

            return perfil;
                
        }
    }
}
