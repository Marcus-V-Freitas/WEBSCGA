using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WebSCGADominio.Entidades;

namespace WebSCGARepositorio.Config
{
    public class ItemPedidoConfiguration : IEntityTypeConfiguration<ItemPedido>
    {
        public void Configure(EntityTypeBuilder<ItemPedido> builder)
        {
            builder.HasKey(item => item.Id);

            builder.Property(item => item.ProdutoId)
                   .IsRequired();

            builder.Property(item => item.Quantidade)
                    .IsRequired();
        }
    }
}
