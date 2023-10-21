using System;
using FluentNHibernate.Mapping;
using InfraDataExamples.Domain;

namespace InfraDataExamples.Infra.Data.EF.Configurations
{
    public class ProdutoConfiguration : ClassMap<Produto>
    {
        public ProdutoConfiguration()
        {
            Table("Produtos");

            Id(p => p.Id)
                .GeneratedBy.Guid();

            Map(p => p.CriadoPor)
                .Not.Nullable()
                .Length(100);

            Map(p => p.CriadoEm)
                .Not.Nullable()
                .CustomType("datetime");

            Map(p => p.EditadoPor)
                .Length(100);

            Map(p => p.EditadoEm)
                .CustomType("datetime");

            Map(p => p.Nome)
                .Not.Nullable()
                .Length(50);

            Map(p => p.Marca)
                .Not.Nullable()
                .Length(50);

            Map(p => p.Modelo)
                .Not.Nullable()
                .Length(50);
        }
    }
}
