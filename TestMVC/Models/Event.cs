using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestMVC.Models
{
    public class Event
    {
        public string ID
        {
            get;
            private set;
        }

        public string Title
        {
            get;
            private set;
        }

        public string Description
        {
            get;
            private set;
        }

        public string Details
        {
            get;
            private set;
        }

        public string Location
        {
            get;
            private set;
        }

        public DateTime DateFrom
        {
            get;
            private set;
        }

        public DateTime DateTo
        {
            get;
            private set;
        }

        public Event(string title, string description, string details, string location,
                    DateTime dateFrom = new DateTime(), DateTime dateTo = new DateTime())
        {
            ID = Guid.NewGuid().ToString();
            Title = title;
            Description = description;
            Location = location;
            DateFrom = dateFrom;
            DateTo = dateTo;
            Details = details;
        }

    }
}