using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;

namespace NHibernateDataProvider
{
    public class NHibernateEventDataProvider : IEventDataProvider
    {
        public Event GetById(string id)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                Event ev = session.Get<Event>(id);
                return ev;
            }
        }
        public IList<Event> GetAll()
        {
            IList<Event> events;
            using (ISession session = NHibernateHelper.OpenSession())
            {
                IQuery query = session.CreateQuery("from Event");
                events = query.List<Event>();
            }
            return events;
        }

        public void AddT(Event element)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Save(element);
                    transaction.Commit();
                }
            }
        }

        public void DeleteT(string id)
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
