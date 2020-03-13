using System;
using System.Collections.Generic;
using System.Text;
using WebSCGADominio.ObjetoDeValor;

namespace WebSCGADominio.Entidades
{
   public class Pedido
    {
        public string Id { get; set; }

        public DateTime DataPedido { get; set; }

        public int UsuarioID { get; set; }

        public DateTime DataPrevisaoEntrega { get; set; }

        public string CEP { get; set; }

        public string Estado { get; set; }

        public string Cidade { get; set; }

        public string EnderecoCompleto { get; set; }

        public int NumeroEndereco { get; set; }

        public int FormaPagamentoId { get; set; }
        public FormaPagamento FormaPagamento { get; set; }

        /// <summary>
        /// Pedido deve ter pelo menos um item de pedido ou muitos itens de pedidos
        /// </summary>
        public ICollection<ItemPedido> itensPedido { get; set; }
    }
}
