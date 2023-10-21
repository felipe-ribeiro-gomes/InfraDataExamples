using InfraDataExamples.Domain;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Dialect;
using NHibernate.Driver;

namespace InfraDataExamples.Infra.Data.NH.Helper
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
                    var configuration = new Configuration();

                    configuration.DataBaseIntegration(x => 
                    {
                        x.ConnectionStringName = "InfraDataExamplesContext";
                        x.Driver<SqlClientDriver>();
                        x.Dialect<MsSql2012Dialect>();
                    });

                    configuration.AddAssembly(typeof(Produto).Assembly);

                    _sessionFactory = configuration.BuildSessionFactory();
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
