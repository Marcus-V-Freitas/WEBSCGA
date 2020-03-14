using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WebSCGADominio.Entidades;

namespace WebSCGARepositorio.Config
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            //Builder utiliza o padrão fluent
            builder.HasKey(usuario => usuario.Id);

            builder.Property(usuario => usuario.Email)
                    .IsRequired().
                    HasMaxLength(50);

            builder.Property(usuario => usuario.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnType("varchar");

            builder.Property(usuario => usuario.Senha
                    ).IsRequired()
                    .HasMaxLength(10);

            builder.Property(usuario => usuario.SobreNome
                    ).IsRequired()
                    .HasMaxLength(50);

            builder.HasMany(usuario => usuario.Pedidos)
                    .WithOne(pedido=>pedido.Usuario);

        }
    }
}
