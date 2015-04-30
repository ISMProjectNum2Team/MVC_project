using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace TestMVC.Models
{
    public class Event
    {
        string _title;
        string _description;
        string _location;
        string _details;
        DateTime _dateFrom;
        DateTime _dateTo;
        public string title { 
            get
            {
                return _title;
            }
        }
        public string description { 
            get
            {
                return _description;
            } 
        }
        public string details
        {
            get
            {
                return _details;
            }
        }
        public string location {
            get
            {
                return _location;
            }
        }
        public DateTime dateFrom { 
            get
            {
                return _dateFrom;
            }
        }
        public DateTime dateTo { 
            get 
            {
                return _dateTo;
            }
        }
        
        public Event(string title, string description, string details , string location,
                    DateTime dateFrom, DateTime dateTo) {
            _title = title;
            _description = description;
            _location = location;
            _dateFrom = dateFrom;
            _dateTo = dateTo;
            _details = details;
        }
        public Event(string title, string description, string details, string location)
        {
            _title = title;
            _description = description;
            _location = location;
            _dateFrom = DateTime.Now;
            _dateTo = new DateTime(3000, 1, 1);
            _details = details;
        }
        
    }
    public class ListModel
    {
        static List<Event> tmp = new List<Event>();
        
        public static List<Event> getEventList(){
            return tmp;
        }
        public static Event getByID(int id)
        {
            return tmp.ElementAt(id-1);
        }
    }
}