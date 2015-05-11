using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using Business;
using NUnit.Framework;

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
                    var cnfg = new Configuration();
                    cnfg.Configure();
                    cnfg.AddAssembly(typeof(Event).Assembly);
                    sessionFactory = cnfg.BuildSessionFactory();
                    //new SchemaExport(cnfg).Execute(true, true, false);
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
