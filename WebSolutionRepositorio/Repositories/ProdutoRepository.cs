using System;
using System.Collections.Generic;
using System.Text;
using WebSCGADominio.Contratos;
using WebSCGADominio.Entidades;

namespace WebSCGARepositorio.Repositories
{
    public class ProdutoRepository:BaseRepository<Produto>,IProdutoRepository
    {
        public ProdutoRepository()
        {

        }
    }
}
