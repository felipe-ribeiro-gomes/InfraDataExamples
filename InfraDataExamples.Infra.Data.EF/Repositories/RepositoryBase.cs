using System;
using System.Collections.Generic;
using System.Linq;
using InfraDataExamples.Domain.Core.Interfaces.Entities;
using InfraDataExamples.Domain.Core.Interfaces.Repositories;

namespace InfraDataExamples.Infra.Data
{
    public class RepositoryBase<TEntity, TKey> : IRepositoryBase<TEntity, TKey> where TEntity : class, IEntityBase<TKey>
    {
        private readonly InfraDataExamplesContext context;

        public RepositoryBase()
        {
            context = new InfraDataExamplesContext();
        }

        public virtual TEntity GetById(TKey id)
        {
            return context.Set<TEntity>().Find(id);
        }

        public virtual IEnumerable<TEntity> GetAll(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate)
        {
            return context.Set<TEntity>().Where(predicate).ToList();
        }

        public virtual void Create(TEntity obj)
        {
            context.Set<TEntity>().Add(obj);
            context.SaveChanges();
        }

        public virtual void Edit(TEntity obj)
        {
            context.Entry<TEntity>(obj).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }

        public virtual void Delete(TEntity obj)
        {
            context.Set<TEntity>().Remove(obj);
            context.SaveChanges();
        }
    }
}
