using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Mapping.ByCode;
using DealsMo.DataAccess.Models;

namespace DealsMo.DataAccess
{
    public static class Database
    {
        private const string SessionKey = "ssoconcur.DataBase.SessionKey";
        private static ISessionFactory _sessionFactory;

        //expose our Database to public for use
        public static ISession Session
        {
            get { return (ISession)HttpContext.Current.Items[SessionKey]; }
        }
        public static void Configure()
        {
            var config = new Configuration();

            config.DataBaseIntegration(x =>
            {
                x.ConnectionString = "DataSource = DBNAME; userID = USERNAME; Password = PASSWORD;";
                x.Driver<NHibernate.Driver.DB2400Driver>();
                x.Dialect<NHibernate.Dialect.DB2400Dialect>();
                x.LogFormattedSql = true;
            }
            );
            //confiure the connection stirng 
            //config.Configure();

            //add out mappings 
            var mapper = new ModelMapper();
            mapper.AddMapping<UserMap>();
            config.AddMapping(mapper.CompileMappingForAllExplicitlyAddedEntities());

            //create our sesisonFactory
            _sessionFactory = config.BuildSessionFactory();

        }
        public static void OpenSession()
        {
            HttpContext.Current.Items[SessionKey] = _sessionFactory.OpenSession();
        }
        public static void CloseSesison()
        {
            var session = HttpContext.Current.Items[SessionKey] as ISession;
            if (session != null)
                session.Close();

            HttpContext.Current.Items.Remove(SessionKey);
        }

    }
}
