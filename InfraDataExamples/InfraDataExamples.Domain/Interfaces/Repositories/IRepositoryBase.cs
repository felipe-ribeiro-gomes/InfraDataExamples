using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace InfraDataExamples.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<TEntity, TKey>
    {
        TEntity GetById(Guid id);
        IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate);
        void Create(TEntity obj);
        void Edit(TEntity obj);
        void Delete(TEntity obj);
    }
}
