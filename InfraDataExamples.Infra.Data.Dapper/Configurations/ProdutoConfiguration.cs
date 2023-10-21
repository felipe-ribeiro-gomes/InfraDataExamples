using Dapper.FluentMap.Dommel.Mapping;
using InfraDataExamples.Domain;

namespace InfraDataExamples.Infra.Data.Configurations
{
    public class ProdutoConfiguration : DommelEntityMap<Produto>
    {
        public ProdutoConfiguration()
        {
            ToTable("Produtos");

            Map(s => s.Id)
                .ToColumn("Id")
                .IsKey();

            Map(p => p.CriadoPor)
                .ToColumn("CriadoPor");

            Map(p => p.CriadoEm)
                .ToColumn("CriadoEm");

            Map(p => p.EditadoPor)
                .ToColumn("EditadoPor");

            Map(p => p.EditadoEm)
                .ToColumn("EditadoEm");

            Map(p => p.Nome)
                .ToColumn("Nome");

            Map(p => p.Marca)
                .ToColumn("Marca");

            Map(p => p.Modelo)
                .ToColumn("Modelo");
        }
    }
}
