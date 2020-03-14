using System;
using System.Collections.Generic;
using System.Text;

namespace WebSCGADominio.Entidades
{
   public class Usuario:Entidade
    {
        public int Id { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public string Nome { get; set; }

        public string SobreNome { get; set; }

        /// <summary>
        /// Usuário pode ter um ou mais pedidos relacionados
        /// </summary>
        public virtual ICollection<Pedido> Pedidos { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Email))
                AdicionarErro("Email não foi informado");
            if (string.IsNullOrEmpty(Senha))
                AdicionarErro("Senha não foi informado");
        }
    }
}
