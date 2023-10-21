using System;
using InfraDataExamples.Domain.Core.Interfaces.Entities;

namespace InfraDataExamples.Domain.Core
{
    public class EntityBase<TKey> : IEntityBase<TKey>
    {
        public virtual TKey Id { get; set; }

        public virtual string CriadoPor { get; set; }
        public virtual DateTime CriadoEm { get; set; }
        public virtual string EditadoPor { get; set; }
        public virtual DateTime? EditadoEm { get; set; }
    }
}
