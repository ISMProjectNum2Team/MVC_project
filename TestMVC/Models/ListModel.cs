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
        DateTime _dateFrom;
        DateTime _dateTo;
        public string title { get
        {
            return _title;
        }}
        public string description { get {
            return _description;
        } }
        public string location { get {
            return _location;
        } }
        public DateTime dateFrom { get {
            return _dateFrom;
        } }
        public DateTime dateTo { get {
            return _dateTo;
        } }
        public Event(string title, string description, string location,
                    DateTime dateFrom, DateTime dateTo) {
            _title = title;
            _description = description;
            _location = location;
            _dateFrom = dateFrom;
            _dateTo = dateTo;
        }
        public Event(string title, string description, string location)
        {
            _title = title;
            _description = description;
            _location = location;
            _dateFrom = DateTime.Now;
            _dateTo = new DateTime(3000,1,1);
        }

    }
    public class ListModel
    {
        public static List<Event> getEventList(){
            var tmp = new List<Event>();
            tmp.Add(new Event("1", "111", "ism"));
            tmp.Add(new Event("1", "111", "ism"));
            tmp.Add(new Event("1", "111", "ism"));
            tmp.Add(new Event("1", "111", "ism"));
            tmp.Add(new Event("1", "111", "ism"));
            return tmp;
        }
    }
}