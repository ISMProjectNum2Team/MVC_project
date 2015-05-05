using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestMVC.Models;
namespace TestMVC.Controllers
{
    public class EventsController : Controller
    {
        //
        // GET: /Main/

        public ActionResult Index()
        {
            var model = new EventDataProvider();
            return View(model.GetEventList());
        }
        [HttpGet]
        public ActionResult Details(string id)
        {
            var model = new EventDataProvider();
            //if (id < 1 || id > model.Data.Count) {
            //    return HttpNotFound();
            //}
            return View(model.GetByID(id));
        }
    }
}
