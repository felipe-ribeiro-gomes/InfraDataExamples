using System;
using InfraDataExamples.Domain.Core;

namespace InfraDataExamples.Domain
{
    public class Produto : EntityBase<Guid>
    {
        public virtual string Nome { get; set; }
        public virtual string Marca { get; set; }
        public virtual string Modelo { get; set; }
    }
}
