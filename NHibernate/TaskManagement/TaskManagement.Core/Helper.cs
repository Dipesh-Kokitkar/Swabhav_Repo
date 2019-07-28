using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using TaskManagement.Core.DatabaseMapping;

namespace TaskManagement.Core
{
    public class Helper
    {
        private static ISessionFactory _sessionfactory;

        private static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionfactory == null)
                {
                    InitializationSessionFactory();
                }
                return _sessionfactory;
            }
        }

        private static void InitializationSessionFactory()
        {
            _sessionfactory = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2008.ConnectionString(@"Data Source=.\sqlexpress;Initial Catalog=TaskManagement;Integrated Security=True").ShowSql())
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<UserMapping>())
                .Mappings(m=>m.FluentMappings.AddFromAssemblyOf<UserTaskMapping>())
                .Mappings(m=>m.FluentMappings.AddFromAssemblyOf<UserSubTaskMapping>())
                .ExposeConfiguration(cfg => new SchemaExport(cfg).Create(true,true))
                .BuildSessionFactory();
        }

        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
    }
}
