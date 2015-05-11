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
            IList<Event> Events;
            using (ISession session = NHibernateHelper.OpenSession())
            {
                IQuery query = session.CreateQuery("from Event");
                Events = query.List<Event>();
            }
            return Events;
        }

        public Event GetByID(string id)
        {
            Event Event = new Event();
            using (ISession session = NHibernateHelper.OpenSession())
            {
                Event = session.Get<Event>(id);
                return Event;
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
            Event ev = GetByID(id);
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
