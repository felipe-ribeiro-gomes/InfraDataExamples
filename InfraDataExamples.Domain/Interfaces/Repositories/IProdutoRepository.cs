using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfraDataExamples.Domain;

namespace InfraDataExamples.Domain.Interfaces.Repositories
{
    public interface IProdutoRepository : IRepositoryBase<Produto, Guid>
    {
    }
}
