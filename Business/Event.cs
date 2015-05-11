using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Event
    {
        public virtual string Id { get;set; }
        public virtual string Title { get;set; }
        public virtual string Description { get;set; }
        public virtual string Details { get;set; }
        public virtual string Location { get;set; }
        public virtual DateTime? DateFrom { get;set; }
        public virtual DateTime? DateTo { get; set; }

        public Event()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
