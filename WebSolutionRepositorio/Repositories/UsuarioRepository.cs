using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebSCGADominio.Contratos;
using WebSCGADominio.Entidades;
using WebSCGARepositorio.Context;

namespace WebSCGARepositorio.Repositories
{
    public class UsuarioRepository:BaseRepository<Usuario>,IUsuarioRepository
    {
        public UsuarioRepository(WebSCGAContext webSCGA) : base(webSCGA)
        {

        }

        public Usuario Obter(string email, string senha)
        {
            return _webSCGA.Usuarios.FirstOrDefault(usuario => usuario.Email == email && usuario.Senha == senha);
        }

        public Usuario Obter(string email)
        {
            return _webSCGA.Usuarios.FirstOrDefault(usuario => usuario.Email == email);
        }
    }
}
