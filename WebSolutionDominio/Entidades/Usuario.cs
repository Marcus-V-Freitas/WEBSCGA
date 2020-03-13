using System;
using System.Collections.Generic;
using System.Text;

namespace WebSCGADominio.Entidades
{
   public class Usuario
    {
        public int Id { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public string Nome { get; set; }

        public string SobreNome { get; set; }

        /// <summary>
        /// Usuário pode ter um ou mais pedidos relacionados
        /// </summary>
        public ICollection<Pedido> Pedidos { get; set; }



    }
}
