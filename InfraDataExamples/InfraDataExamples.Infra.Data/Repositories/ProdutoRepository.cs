using System;
using InfraDataExamples.Domain;
using InfraDataExamples.Domain.Interfaces.Repositories;

namespace InfraDataExamples.Infra.Data.EF.Repositories
{
    public class ProdutoRepository : RepositoryBase<Produto, Guid>, IProdutoRepository
    {
        
    }
}
