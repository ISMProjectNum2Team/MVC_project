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

        public Event GetById(string id)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                Event ev = session.Get<Event>(id);
                return ev;
            }
        }

        public void AddT(Event element)
        {
            throw new NotImplementedException();
        }

        public void DeleteT(string id)
        {
            throw new NotImplementedException();
        }
    }
}
