﻿using System;
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
        private readonly IEventDataProvider data;

        public EventsController(IEventDataProvider _data)
        {
            data = _data;
        }

        public ActionResult Index()
        {
            var result = data.GetAll();
            var model = Mapper.Map<IList<EventViewModel>>(result);
            return View(model);
        }
        [HttpGet]
        public ActionResult Details(string id)
        {
            var result = data.GetById(id);
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
        public ActionResult AddEvent(EventViewModel ev)
        {
            if (ModelState.IsValid)
            {
                var newEvent = Mapper.Map<EventViewModel, Event>(ev);
                data.AddT(newEvent);
            }
            return RedirectToAction("Index", "Events");
        }
    }
}
