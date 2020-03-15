using System;
using System.Collections.Generic;
using System.Text;
using WebSCGADominio.Entidades;

namespace WebSCGADominio.Contratos
{
    public interface IUsuarioRepository:IBaseRepository<Usuario>
    {
        Usuario Obter(string email, string senha);
        Usuario Obter(string email);
    }
}
