using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TestMVC.Models
{
    public class Event
    {
        public string ID
        {
            get;
            private set;
        }
        [Display(Name = "Event")]
        public string Title
        {
            get;
            private set;
        }
        [Display(Name = "Description")]
        public string Description
        {
            get;
            private set;
        }
        [Display(Name = "Details")]
        public string Details
        {
            get;
            private set;
        }
        [Display(Name = "Location")]
        public string Location
        {
            get;
            private set;
        }
        [Display(Name = "Start from")]
        public DateTime DateFrom
        {
            get;
            private set;
        }
        [Display(Name = "End event")]
        public DateTime DateTo
        {
            get;
            private set;
        }
        
        public Event(string title, string description, string details , string location,
                    DateTime dateFrom = new DateTime(), DateTime dateTo = new DateTime()) {
            ID = Guid.NewGuid().ToString();
            Title = title;
            Description = description;
            Location = location;
            DateFrom = dateFrom;
            DateTo = dateTo.AddDays(1);
            Details = details;
        }
        
    }
    
    public class EventDataProvider
    {
        public static List<Event> Data = new List<Event>();
        
        public EventDataProvider()
        {
            if (!(Data.Count > 0))
            {
                Data.Add(new Event("first", "simple event", "details and other stuff", "location of event"));
                Data.Add(new Event("митинг", "показать проект", "встречаемся и показываем какой у нас шикарный проект", "ИСМ"));
                Data.Add(new Event("курсач", "сдать курсач", "рили надо сдать", "универ"));
                Data.Add(new Event("тест", "тесттест", "тесттесттест", "место"));
                Data.Add(new Event("1", "2", "3", "4"));
            }
        }
        public List<Event> GetEventList(){
            return Data;
        }
        public Event GetByID(string id)
        {
            return Data.Find(e => e.ID == id);
        }
    }
}