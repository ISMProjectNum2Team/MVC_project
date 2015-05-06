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
                new Event("1", "2", "3", "4")
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