using InfraDataExamples.Domain.Core.Interfaces.Entities;
using InfraDataExamples.Domain.Core.Interfaces.Repositories;
using InfraDataExamples.Infra.Data.Helper;
using NHibernate;
using System;
using System.Collections.Generic;

namespace InfraDataExamples.Infra.Data
{
    public class RepositoryBase<TEntity, TKey> : IDisposable, IRepositoryBase<TEntity, TKey> where TEntity : class, IEntityBase<TKey>
    {
        private readonly ISession session;

        public RepositoryBase()
        {
            session = new NHibernateHelper().OpenSession();
        }

        public virtual TEntity GetById(TKey id)
        {
            return session.Get<TEntity>(id);
        }

        public virtual IEnumerable<TEntity> GetAll(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate)
        {
            return session.QueryOver<TEntity>().Where(predicate).List();
        }

        public virtual void Create(TEntity obj)
        {
            session.SaveOrUpdate(obj);
            session.Flush();
        }

        public virtual void Edit(TEntity obj)
        {
            session.SaveOrUpdate(obj);
            session.Flush();
        }

        public virtual void Delete(TEntity obj)
        {
            session.Delete(obj);
            session.Flush();
        }

        public void Dispose()
        {
            if (session.IsOpen)
                session.Close();

            if (session != null)
                session.Dispose();
        }
    }
}
