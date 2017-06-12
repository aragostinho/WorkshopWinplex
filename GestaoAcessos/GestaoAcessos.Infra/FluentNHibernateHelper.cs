using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAcessos.Infra
{
    public static class FluentNHibernateHelper
    {
        private static ISessionFactory _ISessionFactory;
        private static ISession _ISession;
        private static ISessionFactory InitializeSessionFactory(System.Reflection.Assembly assembly)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ConnectionString;

            _ISessionFactory = Fluently.Configure()
                .Database(MySQLConfiguration.Standard.ConnectionString(connectionString))
                .Mappings(x => x.FluentMappings.AddFromAssembly(assembly))
                .ExposeConfiguration(cfg => new SchemaUpdate(cfg).Execute(true, true)) 
                .BuildSessionFactory();

            return _ISessionFactory;
        }
        public static ISessionFactory SessionFactory(System.Reflection.Assembly pAssembly)
        {
            if (_ISessionFactory == null)
            {
                _ISessionFactory = InitializeSessionFactory(pAssembly);
            }

            return _ISessionFactory;
        }
        public static ISession GetSession
        {
            get
            {
                _ISession = _ISession ?? SessionFactory(ConfigurationManager.AppSettings["AssemblyMappings"].ToString().GetAssembly()).OpenSession();
                return _ISession;
            }
        }
        public static void CloseSession()
        {
            if (_ISession != null)
            {
                _ISession.Disconnect();
                _ISession.Close();
                _ISession.Dispose();
                _ISession = null;
            }
        }

         
    }
}
