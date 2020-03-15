using System;
using System.Collections.Generic;
using System.Text;

namespace WebSCGADominio.Entidades
{
    public class Produto:Entidade
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public double Preco { get; set; }

        public string NomeArquivo { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Nome))
                AdicionarErro("Nome do produto não foi informado");

            if (string.IsNullOrEmpty(Descricao))
                AdicionarErro("Descrição não foi informado");

        }
    }
}
