using System;
using System.Collections.Generic;
using System.Text;

namespace WebSCGADominio.Entidades
{
   public class ItemPedido:Entidade
    {
        public int Id { get; set; }

        public int ProdutoId { get; set; }

        public int Quantidade { get; set; }

        public override void Validate()
        {
            if (ProdutoId == 0)
               AdicionarErro("Não foi identificadada a referência do produto");
            if (Quantidade == 0)
                AdicionarErro("Quantidade não foi informado");
        }
    }
}
