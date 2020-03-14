using System;
using System.Collections.Generic;
using System.Text;

namespace WebSCGADominio.Contratos
{
    public interface IBaseRepository<TEntity>:IDisposable where TEntity:class
    {
        void Adicionar(TEntity entity);

        TEntity GetEntityId(int id);

        IEnumerable<TEntity> Entities();

        void Atualizar(TEntity entity);

        void Remover(TEntity entity);

    }
}
