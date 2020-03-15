using System;
using System.Collections.Generic;
using System.Text;
using WebSCGADominio.Contratos;
using WebSCGADominio.Entidades;
using WebSCGARepositorio.Context;

namespace WebSCGARepositorio.Repositories
{
    public class PedidoRepository:BaseRepository<Pedido>,IPedidoRepository
    {
        public PedidoRepository(WebSCGAContext webSCGA) : base(webSCGA)
        {

        }
    }
}
