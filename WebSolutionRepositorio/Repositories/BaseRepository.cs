using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebSCGADominio.Contratos;
using WebSCGARepositorio.Context;

namespace WebSCGARepositorio.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {

        protected readonly WebSCGAContext _webSCGA;

        public BaseRepository(WebSCGAContext webSCGA)
        {
            _webSCGA = webSCGA; 
        }

        public void Adicionar(TEntity entity)
        {
            _webSCGA.Set<TEntity>().Add(entity);
            _webSCGA.SaveChanges();
        }

        public void Atualizar(TEntity entity)
        {
            _webSCGA.Set<TEntity>().Update(entity);
            _webSCGA.SaveChanges();
        }

        public void Dispose()
        {
            _webSCGA.Dispose();
        }

        public IEnumerable<TEntity> Entities()
        {
            return _webSCGA.Set<TEntity>().ToList();
        }

        public TEntity GetEntityId(int id)
        {
            return _webSCGA.Set<TEntity>().Find(id);
        }

        public void Remover(TEntity entity)
        {
            _webSCGA.Set<TEntity>().Remove(entity);
            _webSCGA.SaveChanges();
        }
    }
}
