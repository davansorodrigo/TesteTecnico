using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using TesteTecnico.Domain.Entities;

namespace TesteTecnico.Infrastructure.EntityConfiguration
{
    public class EscolaridadeConfiguration : IEntityTypeConfiguration<Escolaridade>
    {
        public void Configure(EntityTypeBuilder<Escolaridade> builder)
        {
            builder.HasData(
                new Escolaridade
                {
                    Id = 1,
                    Descricao = "Infantil"
                    
                },
                new Escolaridade
                {
                    Id = 2,
                    Descricao = "Fundamental"

                },
                new Escolaridade
                {
                    Id = 3,
                    Descricao = "Médio"

                },
                new Escolaridade
                {
                    Id = 4,
                    Descricao = "Superior"

                }
           );
        }
    }
}
