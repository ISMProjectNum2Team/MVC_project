using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Event
    {
        public virtual string ID
        {
            get;
            private set;
        }

        public virtual string Title
        {
            get;
            private set;
        }

        public virtual string Description
        {
            get;
            private set;
        }

        public virtual string Details
        {
            get;
            private set;
        }

        public virtual string Location
        {
            get;
            private set;
        }

        public virtual DateTime? DateFrom
        {
            get;
            private set;
        }

        public virtual DateTime? DateTo
        {
            get;
            private set;
        }
    }
}
