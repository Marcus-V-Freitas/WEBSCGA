using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WebSCGADominio.Entidades;

namespace WebSCGARepositorio.Config
{
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(pedido => pedido.Id);

            builder.Property(pedido => pedido.DataPedido)
                   .IsRequired();

            builder.Property(pedido => pedido.DataPrevisaoEntrega)
                 .IsRequired();

            builder.Property(pedido => pedido.CEP)
                 .IsRequired()
                 .HasMaxLength(10);

            builder.Property(pedido => pedido.Cidade)
                 .IsRequired();

            builder.Property(pedido => pedido.Estado)
                    .IsRequired();

            builder.Property(pedido => pedido.EnderecoCompleto)
                    .IsRequired()
                    .HasMaxLength(100);

            builder.Property(pedido => pedido.NumeroEndereco)
                    .IsRequired();

            builder.HasOne(pedido => pedido.FormaPagamento);

        }
    }
}
