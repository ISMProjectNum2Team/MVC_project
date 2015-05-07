using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TestMVC.Models
{ 
    public class EventDataProvider
    {
        public static List<Event> Data = new List<Event>() 
        {
                new Event("first", "simple event", "details and other stuff", "location of event"),
                new Event("митинг", "показать проект", "встречаемся и показываем какой у нас шикарный проект", "ИСМ"),
                new Event("курсач", "сдать курсач", "рили надо сдать", "универ"),
                new Event("тест", "тесттест", "тесттесттест", "место"),
                new Event("International 2015 qual's", "Largest DOTA 2 event starts", "Valve announced that the TI5 qualifiers will be take place during the last week of May, two weeks before the original date they released last week. The change creates a large time window until June 13th, allowing any participants of the qualifiers to join DreamHack Summer as well.", "Seatle", new DateTime(2015, 8, 3), new DateTime(2015, 8, 8))
        };

        public EventDataProvider() { }
        public List<Event> GetEventList()
        { 
            return Data; 
        }
        public Event GetByID(string id)
        {
            return Data.Find(e => e.ID == id);
        }
    }
}