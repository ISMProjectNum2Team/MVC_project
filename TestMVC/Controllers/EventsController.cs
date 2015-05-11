using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestMVC.Models;
using NHibernateDataProvider;
using Business;
using AutoMapper;

namespace TestMVC.Controllers
{
    public class EventsController : Controller
    {
        //
        // GET: /Main/
        private DataProvider Data = new DataProvider();      

        public ActionResult Index()
        {
            var result = Data.GetAllEvents();
            AutoMapper.Mapper.CreateMap<Event, EventViewModel>();
            var model = result.Select(x => Mapper.Map<EventViewModel>(x));
            return View(model);
        }
        [HttpGet]
        public ActionResult Details(string id)
        {
            var result = Data.GetByID(id);
            if (result == null) {
                return RedirectToRoute("Error.NotFound");
            }
            var model = Mapper.Map<Event, EventViewModel>(result);
            return View(model);
        }

        public ActionResult AddEvent()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddEvent(Event ev)
        {
            Data.AddEvent(ev);
            return RedirectToAction("Index", "Events");
        }
    }
}
