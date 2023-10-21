using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using InfraDataExamples.Domain;

namespace InfraDataExamples.Infra.Data.EF.Configurations
{
    public class ProdutoConfiguration : EntityTypeConfiguration<Produto>
    {
        public ProdutoConfiguration()
        {
            ToTable("Produtos");

            HasKey<Guid>(s => s.Id)
                .Property(s => s.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(p => p.CriadoPor)
                .IsRequired()
                .HasMaxLength(100);

            Property(p => p.CriadoEm)
                .IsRequired()
                .HasColumnType("datetime");

            Property(p => p.EditadoPor)
                .HasMaxLength(100);

            Property(p => p.EditadoEm)
                .HasColumnType("datetime");

            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(50);

            Property(p => p.Marca)
                .IsRequired()
                .HasMaxLength(50);

            Property(p => p.Modelo)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
