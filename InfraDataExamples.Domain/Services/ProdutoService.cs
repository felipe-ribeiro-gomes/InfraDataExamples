using System;
using System.Collections.Generic;
using InfraDataExamples.Domain.Interfaces.Repositories;
using InfraDataExamples.Domain.Interfaces.Services;

namespace InfraDataExamples.Domain.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository repository;

        public ProdutoService(IProdutoRepository repository)
        {
            this.repository = repository;
        }

        public Produto GetById(Guid id)
        {
            return repository.GetById(id);
        }

        public IEnumerable<Produto> GetAll(System.Linq.Expressions.Expression<Func<Produto, bool>> predicate)
        {
            return repository.GetAll(predicate);
        }

        public void Create(Produto obj)
        {
            repository.Create(obj);
        }

        public void Edit(Produto obj)
        {
            repository.Edit(obj);
        }

        public void Delete(Produto obj)
        {
            repository.Delete(obj);
        }
    }
}