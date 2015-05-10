using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestMVC.Models;
using NHibernateDataProvider;
using Business;

namespace TestMVC.Controllers
{
    public class EventsController : Controller
    {
        //
        // GET: /Main/
        private DataProvider Data = new DataProvider();

        public ActionResult Index()
        {
            //var result = Data.GetAllEvents();
            //return View(result);
            return View();
            //var model = new EventDataProvider();
            //return View(model.GetEventList());
        }
        [HttpGet]
        public ActionResult Details(string id)
        {
            //var model = new EventDataProvider();
            var result = Data.GetByID(id);
            if (result == null) {
                return RedirectToRoute("Error.NotFound");
            }
            return View(result);
        }

        public ActionResult AddEvent()
        {
            return View();
        }

        [HttpPost]
        public void AddEvent(Event ev)
        {
            Data.AddEvent(ev);
            RedirectToAction("Index");
        }
    }
}
