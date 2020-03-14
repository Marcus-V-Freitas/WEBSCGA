using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebSCGADominio.Entidades;
using WebSCGADominio.ObjetoDeValor;
using WebSCGARepositorio.Config;

namespace WebSCGARepositorio.Context
{
    public class WebSCGAContext:DbContext
    {
        public WebSCGAContext(DbContextOptions options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Classes de Mapeamento
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
            modelBuilder.ApplyConfiguration(new ItemPedidoConfiguration());
            modelBuilder.ApplyConfiguration(new FormaPagamentoConfiguration());
            modelBuilder.ApplyConfiguration(new ItemPedidoConfiguration());
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Usuario>  Usuarios { get; set; }

        public DbSet<Produto> Produtos { get; set; }

        public DbSet<Pedido> Pedidos { get; set; }

        public DbSet<FormaPagamento> FormasPagamentos { get; set; }

        public DbSet<ItemPedido> ItensPedidos { get; set; }
    }
}
