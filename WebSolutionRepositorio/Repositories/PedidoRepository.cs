using System;
using System.Collections.Generic;
using System.Text;
using WebSCGADominio.Contratos;
using WebSCGADominio.Entidades;

namespace WebSCGARepositorio.Repositories
{
    public class PedidoRepository:BaseRepository<Pedido>,IPedidoRepository
    {
        public PedidoRepository()
        {

        }
    }
}
