using Dapper.FluentMap;
using Dapper.FluentMap.Dommel;
using InfraDataExamples.Infra.Data.Configurations;

namespace InfraDataExamples.Infra.Data
{
    public static class Initializer
    {
        public static void Initialize()
        {
            FluentMapper.Initialize(config =>
            {
                config.AddMap(new ProdutoConfiguration());
                config.ForDommel();
            });
        }
    }
}
