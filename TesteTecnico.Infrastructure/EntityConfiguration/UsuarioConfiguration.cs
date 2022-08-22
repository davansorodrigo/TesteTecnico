using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using TesteTecnico.Domain.Entities;

namespace TesteTecnico.Infrastructure.EntityConfiguration
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.Property(b => b.Nome).HasMaxLength(100);
            builder.Property(b => b.Sobrenome).HasMaxLength(100);
            builder.Property(b => b.Email).HasMaxLength(150);
            builder.HasData(
                new Usuario
                {
                    Id = 1,
                    Nome = "Rodrigo",
                    Sobrenome = "Davanso",
                    Email = "rodrigo.davanso@gmail.com",
                    DataNascimento = DateTime.Parse("13/08/1989"),
                    EscolaridadeId = 1,
                    HistoricoEscolarId = 1
                }
           );
        }
    }
}
