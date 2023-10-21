using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace InfraDataExamples.Domain.Interfaces.Services
{
    public interface IProdutoService
    {
        Produto GetById(Guid id);
        IEnumerable<Produto> GetAll(Expression<Func<Produto, bool>> predicate);
        void Create(Produto obj);
        void Edit(Produto obj);
        void Delete(Produto obj);
    }
}
