using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

namespace InfraDataExamples.Infra.Data.Helper
{
    public class NHibernateHelper
    {
        private ISessionFactory _sessionFactory;
        
        private ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                {
                    var connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["InfraDataExamplesContext"].ConnectionString;

                    _sessionFactory = Fluently.Configure()
                        .Database(MsSqlConfiguration.MsSql2012.ConnectionString(connectionString).ShowSql())
                        .Mappings(m => m.FluentMappings.AddFromAssemblyOf<NHibernateHelper>())
                        .ExposeConfiguration(cfg => new SchemaExport(cfg)
                        .Create(false, false))
                        .BuildSessionFactory();
                }
                return _sessionFactory;
            }
        }
        
        public ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
    }
}
