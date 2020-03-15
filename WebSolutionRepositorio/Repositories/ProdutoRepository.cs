using System;
using System.Collections.Generic;
using System.Text;
using WebSCGADominio.Contratos;
using WebSCGADominio.Entidades;
using WebSCGARepositorio.Context;

namespace WebSCGARepositorio.Repositories
{
    public class ProdutoRepository:BaseRepository<Produto>,IProdutoRepository
    {
        public ProdutoRepository(WebSCGAContext webSCGA) : base(webSCGA)
        {

        }
    }
}
