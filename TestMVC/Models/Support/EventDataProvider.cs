using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using NHibernateDataProvider;
using NHibernate;
using NHibernate.Cfg;
using Business;

namespace TestMVC.Models
{ 
    public class EventDataProvider
    {
        /*public static List<EventViewModel> Data = new List<EventViewModel>() 
        {
                new EventViewModel("first", "simple event", "details and other stuff", "location of event"),
                new EventViewModel("митинг", "показать проект", "встречаемся и показываем какой у нас шикарный проект", "ИСМ"),
                new EventViewModel("курсач", "сдать курсач", "рили надо сдать", "универ"),
                new EventViewModel("тест", "тесттест", "тесттесттест", "место"),
                new EventViewModel("International 2015 qual's", "Largest DOTA 2 event starts", "Valve announced that the TI5 qualifiers will be take place during the last week of May, two weeks before the original date they released last week. The change creates a large time window until June 13th, allowing any participants of the qualifiers to join DreamHack Summer as well.", "Seatle", new DateTime(2015, 8, 3), new DateTime(2015, 8, 8))
        };

        public EventDataProvider() { }
        public List<EventViewModel> GetEventList()
        { 
            return Data; 
        }
        public EventViewModel GetByID(string id)
        {
            return Data.Find(e => e.ID == id);
        }*/
    }
}