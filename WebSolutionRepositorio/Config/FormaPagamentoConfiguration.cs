using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WebSCGADominio.ObjetoDeValor;

namespace WebSCGARepositorio.Config
{
    public class FormaPagamentoConfiguration : IEntityTypeConfiguration<FormaPagamento>
    {
        public void Configure(EntityTypeBuilder<FormaPagamento> builder)
        {
            builder.HasKey(pagamento => pagamento.Id);

            builder.Property(pagamento => pagamento.Nome)
                   .IsRequired();

            builder.Property(pagamento => pagamento.Descricao)
                     .IsRequired();
        }
    }
}
