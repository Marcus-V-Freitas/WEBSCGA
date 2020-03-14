using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebSCGADominio.ObjetoDeValor;

namespace WebSCGADominio.Entidades
{
   public class Pedido:Entidade
    {
        public string Id { get; set; }

        public DateTime DataPedido { get; set; }

        public int UsuarioID { get; set; }

        public virtual Usuario Usuario { get; set; }

        public DateTime DataPrevisaoEntrega { get; set; }

        public string CEP { get; set; }

        public string Estado { get; set; }

        public string Cidade { get; set; }

        public string EnderecoCompleto { get; set; }

        public int NumeroEndereco { get; set; }

        public int FormaPagamentoId { get; set; }
        public virtual FormaPagamento FormaPagamento { get; set; }

        /// <summary>
        /// Pedido deve ter pelo menos um item de pedido ou muitos itens de pedidos
        /// </summary>
        public virtual ICollection<ItemPedido> itensPedido { get; set; }

        public override void Validate()
        {
            if (!itensPedido.Any())
            
                AdicionarErro("Erro - Item de pedido não pode ficar vazio");
            if (string.IsNullOrEmpty(CEP))
                AdicionarErro("Erro - CEP deve estar preenchido");
            if (FormaPagamentoId ==10)
                AdicionarErro("Erro - Não foi informada a forma de pagamento");
        }
    }
}
