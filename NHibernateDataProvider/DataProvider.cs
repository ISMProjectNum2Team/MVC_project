using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business;
using NHibernate;

namespace NHibernateDataProvider
{
    public class DataProvider
    {
        public IList<Event> GetAllEvents()
        {
            IList<Event> events;
            using (ISession session = NHibernateHelper.OpenSession())
            {
                IQuery query = session.CreateQuery("from Event");
                events = query.List<Event>();
            }
            return events;
        }

        public Event GetById(string id)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                Event ev = session.Get<Event>(id);
                return ev;
            }
        }

        public void AddEvent(Event ev)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Save(ev);
                    transaction.Commit();
                }
            }        
        }

        public void DeleteEvent(string id)
        {
            Event ev = GetById(id);
            if (ev != null) 
            {
                using (ISession session = NHibernateHelper.OpenSession())
                {
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        session.Delete(ev);
                        transaction.Commit();
                    }
                }
            }      
        }
    }
}
