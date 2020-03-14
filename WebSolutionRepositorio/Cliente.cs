using System;
using System.Collections.Generic;
using System.Text;
using WebSCGADominio.Entidades;
using WebSCGARepositorio.Repositories;

namespace WebSCGARepositorio
{
    public class Cliente
    {
        public Cliente()
        {
            var usuarioRepository = new UsuarioRepository();

            var produto = new Produto();
            var usuario = new Usuario();

            usuarioRepository.Adicionar(usuario);
        }
    }
 }
    
