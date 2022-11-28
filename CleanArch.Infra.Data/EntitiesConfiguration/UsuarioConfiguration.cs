using CleanArch.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infra.Data.EntitiesConfiguration
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(t => t.idUsuario);
            builder.Property(p => p.Nome).HasMaxLength(50);            
            builder.Property(p => p.Email).HasMaxLength(30);
            builder.Property(p => p.Senha).HasMaxLength(30);
            builder.Property(p => p.Ativo).HasDefaultValue(true);
            builder.HasOne(e => e.Empresa).WithMany(e => e.Usuarios).HasForeignKey(e => e.idEmpresa);
        }

    }
}
