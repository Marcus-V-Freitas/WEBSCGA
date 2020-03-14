using System;
using System.Collections.Generic;
using System.Text;
using WebSCGADominio.Contratos;
using WebSCGADominio.Entidades;

namespace WebSCGARepositorio.Repositories
{
    public class UsuarioRepository:BaseRepository<Usuario>,IUsuarioRepository
    {
        public UsuarioRepository()
        {

        }
    }
}
