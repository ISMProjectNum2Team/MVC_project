using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestMVC.Models;
namespace TestMVC.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Main/

        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult List()
        {
            var events = ListModel.getEventList();
            if (events.Count == 0)
            {
                events.Add(new Event("first", "simple event", "details and other stuff", "location of event"));
                events.Add(new Event("митинг", "показать проект", "встречаемся и показываем какой у нас шикарный проект", "ИСМ"));
                events.Add(new Event("курсач", "сдать курсач", "рили надо сдать", "универ"));
                events.Add(new Event("тест", "тесттест", "тесттесттест", "место"));
                events.Add(new Event("1", "2", "3", "4"));
            }
            ViewBag.Title = "Index";
            return View(events);
        }
        [HttpGet]
        public ActionResult Details(int id)
        {
            Event e = ListModel.getByID(id);
            return View(e);
        }
    }
}
