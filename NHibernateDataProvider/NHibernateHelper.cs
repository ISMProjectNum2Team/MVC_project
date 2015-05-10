using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Cfg;
using Business;
//using NHibernate.Tool.hbm2ddl;

namespace NHibernateDataProvider
{
    public class NHibernateHelper
    {
        private static ISessionFactory sessionFactory;

        private static ISessionFactory SessionFactory
        {
            get
            {
                if (sessionFactory == null)
                {                   
                    /*var configuration = new Configuration();
                    var configurationPath = context.Server.MapPath(@"~\Models\Nhibernate\hibernate.cfg.xml");
                    configuration.Configure(configurationPath);
                    var employeeConfigurationFile = HttpContext.Current.Server.MapPath(@"~\Models\Nhibernate\Employee.hbm.xml");
                    configuration.AddFile(employeeConfigurationFile);
                    sessionFactory = configuration.BuildSessionFactory();

                    /*var cfg = new Configuration();
                    var data = cfg.Configure(HttpContext.Current.Server.MapPath(@"~/NHibernate/hibernate.cfg.xml"));
                    cfg.AddDirectory(new System.IO.DirectoryInfo(HttpContext.Current.Server.MapPath(@"~/NHibernate/Mapping/Event.hbm.xml")));
                    sessionFactory = data.BuildSessionFactory();*/
                    var configuration = new Configuration();
                    configuration.Configure();
                    configuration.AddAssembly(typeof(Event).Assembly);
                    //new SchemaExport(configuration).Execute(true, true, false);
                    sessionFactory = configuration.BuildSessionFactory();
                }
                return sessionFactory;
            }
        }

        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
    }
}
