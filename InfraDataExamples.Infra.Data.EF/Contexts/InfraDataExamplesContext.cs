using System;
using System.Data.Entity;
using InfraDataExamples.Domain;
using InfraDataExamples.Infra.Data.Configurations;

namespace InfraDataExamples.Infra.Data
{
    public class InfraDataExamplesContext : DbContext
    {
        public InfraDataExamplesContext() 
        {
            //hack para fazer o Entity Framework funcionar sem pedir pelo EF.SQLServer na camada de apresentação e testes
            var type = typeof(System.Data.Entity.SqlServer.SqlProviderServices);
            if (type == null)
                throw new Exception("Do not remove, ensures static reference to System.Data.Entity.SqlServer");
        }

        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProdutoConfiguration());
        }
    }
}
