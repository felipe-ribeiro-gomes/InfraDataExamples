using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using InfraDataExamples.Domain.Core.Interfaces.Entities;

namespace InfraDataExamples.Domain.Core.Interfaces.Repositories
{
    public interface IRepositoryBase<TEntity, TKey> where TEntity : class, IEntityBase<TKey>
    {
        TEntity GetById(TKey id);
        IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate);
        void Create(TEntity obj);
        void Edit(TEntity obj);
        void Delete(TEntity obj);
    }
}
