using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateDataProvider
{
    public class NHibernateEventDataProvider : IEventDataProvider
    {
        public IList<Event> GetAll()
        {
            throw new NotImplementedException();
        }

        public Event GetById(string id)
        {
            throw new NotImplementedException();
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
